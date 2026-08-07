using Anandashram.Interfaces.Services.Backup;
using Microsoft.Extensions.Options;

namespace Anandashram.Services.Backup;
/// <summary>
/// Coordinates the complete backup workflow.
///
/// This class acts as an orchestrator.
/// It does not perform database or file operations directly.
/// Those responsibilities are delegated to specialized services.
///
/// Workflow:
/// 1. Prepare backup folders.
/// 2. Ensure SQL Server availability.
/// 3. Create database backup.
/// 4. Verify database backup.
/// 5. Backup application files.
/// 6. Apply backup cleanup rules.
/// </summary>
public class BackupService : IBackupService
{
    private readonly IDatabaseAvailabilityService _databaseAvailabilityService;
    private readonly IDatabaseBackupService _databaseBackupService;
    // private readonly IDatabaseBackupVerificationService _databaseBackupVerificationService;
    private readonly IFileBackupService _fileBackupService;
    private readonly IBackupCleanupService _backupCleanupService;
    private readonly IBackupMetadataService _backupMetadataService;
    private readonly IBackupCopyService _backupCopyService;
    private readonly ILogger<BackupService> _logger;

    private readonly BackupSettings _settings;

    // Dependencies are injected as interfaces so that workflow
    // orchestration remains independent of specific implementations.
    // This allows individual backup operations to be replaced
    // without changing the workflow.
    public BackupService(
    IOptions<BackupSettings> settings,
    IDatabaseAvailabilityService databaseAvailabilityService,
    IDatabaseBackupService databaseBackupService,
    // IDatabaseBackupVerificationService databaseBackupVerificationService,
    IFileBackupService fileBackupService,
    IBackupCleanupService backupCleanupService,
    IBackupMetadataService backupMetadataService,
    IBackupCopyService backupCopyService,
    ILogger<BackupService> logger)
    {
        _settings = settings.Value;

        _databaseAvailabilityService = databaseAvailabilityService;
        _databaseBackupService = databaseBackupService;
        // _databaseBackupVerificationService = databaseBackupVerificationService;
        _fileBackupService = fileBackupService;
        _backupCleanupService = backupCleanupService;
        _backupMetadataService = backupMetadataService;
        _backupCopyService = backupCopyService;
        _logger = logger;
    }

    public async Task RunBackupAsync(
CancellationToken cancellationToken)
    {
        List<BackupLogEntry> backupLogEntries = new();
        backupLogEntries.Add(new BackupLogEntry
        {
            Time = DateTime.Now,
            Step = "Backup Process",
            Status = "Started"
        });
        // 1. Prepare folders

        BackupFolderInfo folders = PrepareBackupFolder();

        // 2. Check SQL Server availability

        bool available =
            await _databaseAvailabilityService
                .EnsureSqlServerIsAvailableAsync(
                    cancellationToken);

        if (!available)
        {
            _logger.LogWarning(
                "Backup stopped because SQL Server is unavailable.");

            return;
        }

        // 3. Execute database backup


        DatabaseBackupResult databaseBackupResult =
            await _databaseBackupService
                .BackupDatabaseAsync(folders.DatabaseFolder,
                    cancellationToken);
        backupLogEntries.Add(new BackupLogEntry
        {
            Time = databaseBackupResult.EndTime,
            Step = "Database Backup",
            Status = databaseBackupResult.IsSuccessful
            ? "Success"
            : "Failed",
            Message = databaseBackupResult.ErrorMessage

        });


        // 4. Verify database backup

        //await _databaseBackupVerificationService
        //    .VerifyBackupAsync(
        //        result.DatabaseFolder,
        //        cancellationToken);

        // 5. Backup documents
        FileBackupResult fileBackupResult = await _fileBackupService
         .BackupFilesAsync(
             folders.FilesFolder);
        backupLogEntries.Add(new BackupLogEntry
        {
            Time = fileBackupResult.EndTime,
            Step = "Files Backup",
            Status = fileBackupResult.IsSuccessful
            ? "Success"
            :"Failed",
            Message = fileBackupResult.ErrorMessage
        });
        backupLogEntries.Add(new BackupLogEntry
        {
            Time = DateTime.Now,
            Step = "Backup Process",
            Status = "Ended"
        });
        //6. create BackupInfo details
        BackupInfo backupInfo = new()
        {
            BackupDate = DateTime.Today,

            DatabaseBackupStartTime = databaseBackupResult.StartTime,
            DatabaseBackupEndTime = databaseBackupResult.EndTime,
            DatabaseBackupFile = databaseBackupResult.BackupFilePath,
            DatabaseBackupSize = databaseBackupResult.BackupFileSize,

            FileBackupStartTime = fileBackupResult.StartTime,
            FileBackupEndTime = fileBackupResult.EndTime,
            ZipBackupFile = fileBackupResult.BackupFilePath,
            ZipBackupSize = fileBackupResult.BackupFileSize,

            TotalBackupSize = databaseBackupResult.BackupFileSize + fileBackupResult.BackupFileSize,
            Duration = fileBackupResult.EndTime - databaseBackupResult.StartTime,
            ComputerName = Environment.MachineName,

            Status = "Success"
        };

        
            string backupInfoFilePath = Path.Combine(
        folders.RootFolder,
        "BackupInfo.json");
        string backupLogFilePath = Path.Combine(
        folders.RootFolder,
        "BackupLog.json");
        //write backupinfo file
        await _backupMetadataService.SaveBackupInfoAsync(backupInfo, backupInfoFilePath);
       await _backupMetadataService.SaveBackupLogAsync(backupLogEntries, backupLogFilePath);

        // Copy backup
        BackupCopyResult backupCopyResult =await _backupCopyService.CopyBackupAsync(folders.RootFolder, cancellationToken);
        // 6. Cleanup old backups

        //await _backupCleanupService
        //    .CleanupAsync(
        //        cancellationToken);
    }
    #region << Private Methods >>

    /// <summary>
    /// Creates the folder structure required for the current backup.
    ///
    /// Example:
    /// BackupRoot
    ///     └── 04-Aug-2026
    ///          ├── db
    ///          └── files
    ///
    /// This method only prepares storage locations.
    /// It does not perform any backup operation.
    /// </summary>
    private BackupFolderInfo PrepareBackupFolder()
    {
        string backupRootPath =
            _settings.BackupRootPath
            ?? throw new InvalidOperationException(
                "BackupRootPath was not found.");

        string dateFolder =
            DateTime.Now.ToString("dd-MMM-yyyy");

        string backupFolderPath =
            Path.Combine(
                backupRootPath,
                dateFolder);

        string databaseFolder =
            Path.Combine(
                backupFolderPath,
                "db");

        string filesFolder =
            Path.Combine(
                backupFolderPath,
                "files");
        
        Directory.CreateDirectory(backupFolderPath);
        Directory.CreateDirectory(databaseFolder);
        Directory.CreateDirectory(filesFolder);

        return new BackupFolderInfo()
        {
            DatabaseFolder = databaseFolder,
            FilesFolder = filesFolder,
            RootFolder = backupFolderPath
        };
    }

    #endregion
}
