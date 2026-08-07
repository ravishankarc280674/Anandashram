namespace Anandashram.Interfaces.Services.Backup;

public interface IBackupMetadataService
{
    Task SaveBackupInfoAsync(BackupInfo backupInfo, string backupInfoFilePath);
    Task SaveBackupLogAsync(IEnumerable<BackupLogEntry> backupLogEntries, string backupLogFilePath);
}