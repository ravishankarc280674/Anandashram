namespace Anandashram.DTO;

public class TimelineDTO
{
    public string RoomName { get; set; }
    public int Capacity { get; set; }
    public string DevoteeName { get; set; }
    public string DevoteeCode { get; set; }
    public int Allocated { get; set; }
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
}
