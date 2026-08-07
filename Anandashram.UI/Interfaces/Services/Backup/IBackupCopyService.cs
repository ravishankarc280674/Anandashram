namespace Anandashram.Interfaces.Services.Backup;

public interface IBackupCopyService
{
    Task<BackupCopyResult> CopyBackupAsync(
        string sourceBackupFolder,
        CancellationToken cancellationToken);
}
