namespace Anandashram.DTO;

//copilot
public class PartialCheckoutConfirmModel
{
    public int ReservationId { get; set; }
    public int LeavingPeople { get; set; }
    public DateTime CheckoutDate { get; set; }
    public DateTime NewFromDate { get; set; }
    public DateTime NewToDate { get; set; }
}
