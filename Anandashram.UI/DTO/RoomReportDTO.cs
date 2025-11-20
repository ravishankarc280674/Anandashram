namespace Anandashram.DTO;
public class RoomReportDTO
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string RoomName { get; set; } = string.Empty;
    public string BuildingName { get; set; } = string.Empty;
    public string BlockName { get; set; } = string.Empty;
    public string FloorName { get; set; } = string.Empty;
    public int Occupied { get; set; }
    public int Capacity { get; set; }
    public int RemainingCount { get; set; }

    public int TotalAllocated { get; set; }
    public int TotalRemaining { get; set; }

    public List<ReservationReportDTO> Reservations { get; set; } = new();
}
