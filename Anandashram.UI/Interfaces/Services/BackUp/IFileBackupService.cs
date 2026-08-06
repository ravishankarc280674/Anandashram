namespace Anandashram.Interfaces.Services.Backup
{
    public interface IFileBackupService
    {
        Task<FileBackupResult> BackupFilesAsync(
            string filesBackupPath);
    }
}
