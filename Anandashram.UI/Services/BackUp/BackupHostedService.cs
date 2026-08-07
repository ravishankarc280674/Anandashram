using Anandashram.Interfaces.Services.Backup;
using Anandashram.Services.Backup;

public class BackupHostedService : BackgroundService
{
    private readonly IBackupService _backupService;
    private readonly ILogger<BackupHostedService> _logger;
    
    public BackupHostedService(
        IBackupService backupService,
        ILogger<BackupHostedService> logger)
    {
        _backupService = backupService;
        _logger = logger;
    }


    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
       
        try
        {
            await _backupService.RunBackupAsync(
                stoppingToken);
            

        }
        catch (OperationCanceledException)
        {
            _logger.LogInformation(
                "Backup service cancellation requested.");
        }
        catch (Exception ex)
        {
            _logger.LogError(
                ex,
                "Backup service failed.");
        }

    }
}