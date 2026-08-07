namespace Anandashram.Models;

public class BackupCopyResult
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string SourcePath { get; set; } = string.Empty;
    public string DestinationPath { get; set; } = string.Empty;
    public long BackupSize { get; set; }
    public bool IsSuccessful { get; set; }
    public string? ErrorMessage { get; set; }
}
