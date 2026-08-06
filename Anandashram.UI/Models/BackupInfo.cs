namespace Anandashram.Models;

public class BackupInfo
{
    public DateTime BackupDateTime { get; set; }

    public string DatabaseBackupFile { get; set; }

    public string ZipBackupFile { get; set; }

    public long DatabaseBackupSize { get; set; }

    public long ZipBackupSize { get; set; }

    public long TotalBackupSize { get; set; }

    public string ComputerName { get; set; }

    public TimeSpan Duration { get; set; }

    public string Status { get; set; }
}
