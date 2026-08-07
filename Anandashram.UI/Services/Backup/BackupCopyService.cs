using Anandashram.Interfaces.Services.Backup;
using Microsoft.Extensions.Options;

namespace Anandashram.Services.Backup;

public class BackupCopyService: IBackupCopyService
{
    #region Private Members

    private readonly BackupSettings _settings;
    private readonly ILogger<BackupCopyService> _logger;

    #endregion

    #region Constructor

    public BackupCopyService(
        IOptions<BackupSettings> settings,
        ILogger<BackupCopyService> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    #endregion

    #region Public Methods

    public async Task<BackupCopyResult> CopyBackupAsync(
        string sourceBackupFolder,
        CancellationToken cancellationToken)
    {
        BackupCopyResult result = new()
        {
            StartTime = DateTime.Now,
            SourcePath = sourceBackupFolder
        };

        try
        {
            string destinationRootPath =
                _settings.ExternalBackupFilesCopingPath
                ?? throw new InvalidOperationException(
                    "ExternalBackupFilesCopingPath was not found.");

            string folderName =
                Path.GetFileName(
                    sourceBackupFolder.TrimEnd(
                        Path.DirectorySeparatorChar));

            string destinationFolder =
                Path.Combine(
                    destinationRootPath,
                    folderName);

            Directory.CreateDirectory(destinationFolder);

            await CopyDirectoryAsync(
                sourceBackupFolder,
                destinationFolder,
                cancellationToken);

            result.DestinationPath = destinationFolder;
            result.BackupSize =
                CalculateDirectorySize(destinationFolder);

            result.IsSuccessful = true;
        }
        catch (Exception exception)
        {
            result.IsSuccessful = false;
            result.ErrorMessage = exception.Message;

            _logger.LogError(
                exception,
                "Error while copying backup from '{SourcePath}'.",
                sourceBackupFolder);
        }
        finally
        {
            result.EndTime = DateTime.Now;
        }

        return result;
    }

    #endregion

    #region Private Methods

    private static async Task CopyDirectoryAsync(
        string sourceDirectory,
        string destinationDirectory,
        CancellationToken cancellationToken)
    {
        Directory.CreateDirectory(destinationDirectory);

        foreach (string filePath in
            Directory.EnumerateFiles(sourceDirectory))
        {
            cancellationToken.ThrowIfCancellationRequested();

            string fileName =
                Path.GetFileName(filePath);

            string destinationFile =
                Path.Combine(
                    destinationDirectory,
                    fileName);

            await using FileStream sourceStream =
                new(
                    filePath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.Read,
                    bufferSize: 81920,
                    useAsync: true);

            await using FileStream destinationStream =
                new(
                    destinationFile,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None,
                    bufferSize: 81920,
                    useAsync: true);

            await sourceStream.CopyToAsync(
                destinationStream,
                cancellationToken);
        }

        foreach (string directoryPath in
            Directory.EnumerateDirectories(sourceDirectory))
        {
            string directoryName =
                Path.GetFileName(directoryPath);

            string destinationSubDirectory =
                Path.Combine(
                    destinationDirectory,
                    directoryName);

            await CopyDirectoryAsync(
                directoryPath,
                destinationSubDirectory,
                cancellationToken);
        }
    }

    private static long CalculateDirectorySize(
        string directoryPath)
    {
        return Directory
            .EnumerateFiles(
                directoryPath,
                "*",
                SearchOption.AllDirectories)
            .Sum(file => new FileInfo(file).Length);
    }

    #endregion
}