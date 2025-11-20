namespace Anandashram.DTO;
public class ReservationReportDTO
{
    public int Id { get; set; }
    public int DevoteeId { get; set; }
    public int RoomId { get; set; }
    public string RoomName { get; set; } = string.Empty;
    public string DevoteeCode { get; set; } = string.Empty;
    public string DevoteeName { get; set; } = string.Empty;
    public string DevoteeCategoryName { get; set; } = string.Empty;
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public int Allocated { get; set; }
    public bool Closed { get; set; }
}
