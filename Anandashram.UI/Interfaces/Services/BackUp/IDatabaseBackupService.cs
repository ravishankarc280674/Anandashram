namespace Anandashram.Interfaces.Services.Backup;

/// <summary>
/// Creates a backup of the application's database.
///
/// Responsibility:
///     Create the database backup file.
///
/// Not Responsible:
///     - Waiting for database availability.
///     - Verifying the backup.
///     - Creating backup folders.
///     - Cleaning old backups.
/// </summary>
public interface IDatabaseBackupService
{
    Task<DatabaseBackupResult> BackupDatabaseAsync(
        string backupFolderPath,
        CancellationToken cancellationToken = default);

}