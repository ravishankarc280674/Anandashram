namespace Anandashram.Models;

public class BackupLogEntry
{
    public DateTime Time { get; set; }
    public string Step { get; set; }
    public string Status { get; set; }
    public string? Message { get; set; }
}
