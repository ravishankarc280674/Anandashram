using Anandashram.Interfaces.Services.Backup;
using Humanizer.Configuration;
using System.Configuration;
using System.IO.Compression;

namespace Anandashram.Services.Backup;
public class ZipFileBackupService : IFileBackupService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<ZipFileBackupService> _logger;
    public ZipFileBackupService(IConfiguration configuration,
        ILogger<ZipFileBackupService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }
    public async Task<FileBackupResult> BackupFilesAsync(
    string filesBackupPath)
    {
      
        string sourceFolder =
            _configuration.GetValue<string>("DocumentStoragePath")
            ?? throw new InvalidOperationException(
                "DocumentStoragePath was not found.");

        string zipFile = Path.Combine(
            filesBackupPath,
            "FilesBackup.zip");

        if (File.Exists(zipFile))
        {
            File.Delete(zipFile);
        }
        FileBackupResult result = new()
        {
            BackupFilePath = filesBackupPath,
            StartTime = DateTime.Now,
            ErrorMessage = null
        };

        try
        {
            ZipFile.CreateFromDirectory(
                sourceFolder,
                zipFile,
                CompressionLevel.Optimal,
                includeBaseDirectory: false);
            result.IsSuccessful = true;

            result.BackupFileSize =
                new FileInfo(zipFile).Length;
        }
        finally
        {
            result.EndTime = DateTime.Now;
        }

        return result;
    }
}
