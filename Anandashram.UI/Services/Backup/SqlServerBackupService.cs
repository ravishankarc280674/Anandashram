using Anandashram.Interfaces.Services.Backup;
using Microsoft.Data.SqlClient;
using System.IO.Compression;

namespace Anandashram.Services.Backup;

/// <summary>
/// Creates SQL Server database backup files.
///
/// Responsibility:
///     Execute the SQL Server BACKUP DATABASE command
///     and return the generated backup file information.
///
/// Not Responsible:
///     - Checking SQL Server availability.
///     - Creating backup folders.
///     - Verifying backup files.
///     - Compressing files.
///     - Cleaning old backups.
///     - Coordinating the complete backup workflow.
/// </summary>
public class SqlServerBackupService : IDatabaseBackupService
{
    #region << Constants >>

    private const string ConnectionStringName = "AnandashramDBConnection";

    #endregion


    #region << Private Members >>

    private readonly IConfiguration _configuration;
    private readonly ILogger<SqlServerBackupService> _logger;
    private readonly IBackupMetadataService _backupMetaDataService;
    #endregion


    #region << Constructor >>

    public SqlServerBackupService(IConfiguration configuration,
        ILogger<SqlServerBackupService> logger,
        IBackupMetadataService backupMetaDataService)
    {
        _configuration = configuration;
        _logger = logger;
        _backupMetaDataService = backupMetaDataService;
    }

    #endregion


    #region << Public Methods >>

    /// <summary>
    /// Creates a SQL Server database backup file.
    /// </summary>
    public async Task<DatabaseBackupResult> BackupDatabaseAsync(
        string backupFolderPath,
        CancellationToken cancellationToken = default)
    {
       
        string connectionString = GetConnectionString();

        string databaseName =
            GetDatabaseName(connectionString);

        string backupFilePath =
            CreateBackupFilePath(
                backupFolderPath,
                databaseName);

        DatabaseBackupResult result = new()
        {
            BackupFilePath = backupFilePath,
            StartTime = DateTime.Now
        };
        try
        {
            await ExecuteBackupAsync(
            connectionString,
            databaseName,
            backupFilePath,
            cancellationToken);
            result.EndTime = DateTime.Now;
            result.IsSuccessful = true;
            result.ErrorMessage = null;

            if (File.Exists(backupFilePath))
            {
                result.BackupFileSize =
                    new FileInfo(backupFilePath).Length;
            }

            return result;
        }
        catch(Exception ex)
        {
            result.EndTime = DateTime.Now;
            result.IsSuccessful = false;
            result.ErrorMessage = ex.Message;

            throw;
        }
    }

    #endregion


    #region << Private Methods >>

    /// <summary>
    /// Reads the configured database connection string.
    ///
    /// Missing configuration indicates an application
    /// configuration problem, not a database availability problem.
    /// </summary>
    private string GetConnectionString()
    {
        return _configuration
            .GetConnectionString(ConnectionStringName)
            ?? throw new InvalidOperationException(
                $"Connection string '{ConnectionStringName}' was not found.");
    }


    /// <summary>
    /// Extracts the database name from the connection string.
    /// </summary>
    private string GetDatabaseName(
        string connectionString)
    {
        SqlConnectionStringBuilder builder =
            new(connectionString);

        return builder.InitialCatalog;
    }


    /// <summary>
    /// Creates the full path where the backup file will be stored.
    /// </summary>
    private string CreateBackupFilePath(
        string backupFolderPath,
        string databaseName)
    {
        return Path.Combine(
            backupFolderPath,
            $"{databaseName}.bak");
    }


    /// <summary>
    /// Executes the SQL Server database backup command.
    ///
    /// SQL Server is responsible for creating the backup file.
    /// </summary>
    private async Task ExecuteBackupAsync(
        string connectionString,
        string databaseName,
        string backupFilePath,
        CancellationToken cancellationToken)
    {

        const string sql = """
            BACKUP DATABASE [{0}]
            TO DISK = @backupPath
            WITH INIT, CHECKSUM, STATS = 10;
            """;


        using SqlConnection connection =
            new(connectionString);

        await connection.OpenAsync(cancellationToken);

        using SqlCommand command =
            new(
                string.Format(sql, databaseName),
                connection);

        command.Parameters.AddWithValue(
            "@backupPath",
            backupFilePath);

        await command.ExecuteNonQueryAsync(
            cancellationToken);
    }
    #endregion
  
}