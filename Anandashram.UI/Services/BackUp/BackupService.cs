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
    ILogger<BackupService> logger)
    {
        _settings = settings.Value;

        _databaseAvailabilityService = databaseAvailabilityService;
        _databaseBackupService = databaseBackupService;
        // _databaseBackupVerificationService = databaseBackupVerificationService;
        _fileBackupService = fileBackupService;
        _backupCleanupService = backupCleanupService;
        _backupMetadataService = backupMetadataService;
        _logger = logger;
    }

    public async Task RunBackupAsync(
CancellationToken cancellationToken)
    {
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
                .BackupDatabaseAsync(
                    folders.DatabaseFolder,
                    cancellationToken);

        BackupInfo backupInfo = new();

        // 4. Verify database backup

        //await _databaseBackupVerificationService
        //    .VerifyBackupAsync(
        //        result.DatabaseFolder,
        //        cancellationToken);


        // 5. Backup documents

        await _fileBackupService
            .BackupFilesAsync(
                folders.FilesFolder);


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
            RootFolder = backupRootPath
        };
    }

    #endregion
}
