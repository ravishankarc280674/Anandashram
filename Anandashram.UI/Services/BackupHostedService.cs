namespace Anandashram.Services;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.IO.Compression;

public class BackupHostedService : IHostedService
{
    private readonly IConfiguration _configuration;
    private readonly BackupSettings _settings;
    private readonly ILogger<BackupHostedService> _logger;
    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;

    public BackupHostedService(
        IConfiguration configuration,
        IOptions<BackupSettings> settings,
        ILogger<BackupHostedService> logger)
    {
        _configuration = configuration;
        _settings = settings.Value;
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        // Run ONLY on Sunday
        //if (DateTime.Today.DayOfWeek != DayOfWeek.Sunday)
        //    return;

        _ = Task.Run(async () =>
        {
            string dateFolder = DateTime.Today.ToString("dd-MMM-yyyy");

            if (Directory.Exists(Path.Combine(_settings.BackupRootPath, dateFolder)))
            {
                _logger.LogInformation("Sunday backup already completed");
                return;
            }

            if (!await WaitForSqlServerAsync())
            {
                _logger.LogWarning("SQL Server not available");
                return;
            }

            await RunSundayBackupAsync();
        });
    }

    private async Task RunSundayBackupAsync()
    {
        try
        {
            string dateFolder = DateTime.Today.ToString("dd-MMM-yyyy");
            string baseBackupPath = Path.Combine(_settings.BackupRootPath, dateFolder);

            string dbBackupPath = Path.Combine(baseBackupPath, "db");
            string filesBackupPath = Path.Combine(baseBackupPath, "files");

            Directory.CreateDirectory(dbBackupPath);
            Directory.CreateDirectory(filesBackupPath);

            await BackupDatabaseAsync(dbBackupPath);
            BackupFiles(filesBackupPath);

            _logger.LogInformation("Sunday backup completed successfully.");
        }
        catch (Exception ex)
        {
            File.AppendAllText(
                Path.Combine(_settings.BackupRootPath, "backup-errors.log"),
                $"{DateTime.Now}: {ex}{Environment.NewLine}");

            _logger.LogError(ex, "Sunday backup failed");
        }
    }
    private async Task<bool> WaitForSqlServerAsync()
    {
        for (int i = 0; i < 10; i++)
        {
            try
            {
                using var connection =
                    new SqlConnection(_configuration.GetConnectionString("AnandashramDBConnection"));

                await connection.OpenAsync();

                return true;
            }
            catch
            {
                await Task.Delay(30000); // wait 30 sec
            }
        }

        return false;
    }
    private async Task BackupDatabaseAsync(string dbBackupPath)
    {
        var connectionString = _configuration.GetConnectionString("AnandashramDBConnection");

        var builder = new SqlConnectionStringBuilder(connectionString);
        string databaseName = builder.InitialCatalog;

        string backupFile = Path.Combine(
            dbBackupPath,
            $"{databaseName}.bak");

        string sql = $@"
                BACKUP DATABASE [{databaseName}]
                TO DISK = @backupPath
                WITH INIT, FORMAT";

        using var connection = new SqlConnection(connectionString);
        await connection.OpenAsync();

        using var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@backupPath", backupFile);

        await command.ExecuteNonQueryAsync();
    }

    private void BackupFiles(string filesBackupPath)
    {
        string sourceFolder = _configuration.GetValue<string>("DocumentStoragePath").ToString();
        string zipFile = Path.Combine(
            filesBackupPath,
            "FilesBackup.zip");

        if (File.Exists(zipFile))
            File.Delete(zipFile);

        ZipFile.CreateFromDirectory(
            sourceFolder,
            zipFile,
            CompressionLevel.Optimal,
            includeBaseDirectory: false);
    }
}
