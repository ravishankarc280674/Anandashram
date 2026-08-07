namespace Anandashram.Models;

public class DatabaseBackupResult
{
    /// <summary>
    /// Represents the result of a completed database backup operation.
    ///
    /// Purpose:
    ///     Encapsulate information produced during the backup process.
    ///
    /// Why not return a string?
    ///     Although the current implementation only requires the backup
    ///     file path, additional information such as backup duration,
    ///     file size, database name, verification status, or backup
    ///     completion time may be required in the future.
    ///
    ///     Returning a dedicated result object allows the backup process
    ///     to evolve without changing the service interface.
    /// </summary>
    public string BackupFilePath { get; set; } = string.Empty;

    public long BackupFileSize { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public TimeSpan Duration => EndTime - StartTime;

    public bool IsSuccessful { get; set; }
    public string? ErrorMessage { get; set; }
}
