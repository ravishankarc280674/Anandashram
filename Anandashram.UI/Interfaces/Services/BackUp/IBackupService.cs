namespace Anandashram.Interfaces.Services.Backup
{
    public interface IBackupService
    {
        Task RunBackupAsync(CancellationToken cancellationToken);
    }
}
