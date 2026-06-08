namespace Anandashram.DTO;

public class PartialCheckoutResultcs
{
    public int ReservationId { get; set; }
    public int OriginalAllocated { get; set; }
    public int LeavingPeople { get; set; }
    public int RemainingPeople { get; set; }
    public int DevoteeId { get; set; }
    public int RoomId { get; set; }
    public DateTime OriginalFromDate { get; set; }
    public DateTime OriginalToDate { get; set; }
}
