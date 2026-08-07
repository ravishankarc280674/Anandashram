namespace Anandashram.Models;

public class FileBackupResult
{
    public string BackupFilePath { get; set; } = string.Empty;

    public long BackupFileSize { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public TimeSpan Duration => EndTime - StartTime;

    public bool IsSuccessful { get; set; }
    public string? ErrorMessage { get; set; }
}
