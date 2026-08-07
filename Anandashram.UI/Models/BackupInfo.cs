namespace Anandashram.Models;

public class BackupInfo
{
    public DateTime BackupDate { get; set; }
    public DateTime DatabaseBackupStartTime { get; set; }
    public DateTime DatabaseBackupEndTime { get; set; }
    public string DatabaseBackupFile { get; set; } = string.Empty;
    public long DatabaseBackupSize { get; set; }
    public DateTime FileBackupStartTime { get; set; }
    public DateTime FileBackupEndTime { get; set; }
    public string ZipBackupFile { get; set; } = string.Empty;
    public long ZipBackupSize { get; set; }
    public long TotalBackupSize { get; set; }
    public string ComputerName { get; set; } = string.Empty;
    public TimeSpan Duration { get; set; }
    public string Status { get; set; } = string.Empty;
}
