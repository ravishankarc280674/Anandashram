using Anandashram.Interfaces.Services.Backup;
using System.Text.Json;

namespace Anandashram.Services.Backup;

public class BackupMetadataService : IBackupMetadataService
{
        #region Private Members

        private readonly ILogger<BackupMetadataService> _logger;

        private readonly JsonSerializerOptions _jsonSerializerOptions;

        #endregion

        #region Constructor

        public BackupMetadataService(
            ILogger<BackupMetadataService> logger)
        {
            _logger = logger;

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = null
            };
        }

    #endregion

    #region Public Methods

    public async Task SaveBackupInfoAsync(BackupInfo backupInfo, string backupInfoFilePath)
        => await SaveJsonAsync(backupInfo, backupInfoFilePath);

    public async Task SaveBackupLogAsync(IEnumerable<BackupLogEntry> backupLogEntries, string backupLogFilePath)
        => await SaveJsonAsync(backupLogEntries, backupLogFilePath);

    #endregion

    #region Private Methods

    private async Task SaveJsonAsync<T>(T data, string filePath)
        {
            ArgumentNullException.ThrowIfNull(data);
            ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

            try
            {
            await using FileStream fileStream = File.Create(filePath);

            await System.Text.Json.JsonSerializer.SerializeAsync(
                fileStream,
                data,
                _jsonSerializerOptions);
        }
            catch (Exception exception)
            {
                _logger.LogError(
                    exception,
                    "Error while writing metadata file '{FilePath}'.",
                    filePath);

                throw;
            }
        }

        #endregion
    }
