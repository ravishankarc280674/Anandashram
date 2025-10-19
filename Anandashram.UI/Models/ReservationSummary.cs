namespace Anandashram.Models
{
    public class ReservationSummary
    {
        public ReservationSummary()
        {
            Reservations=new List<Reservation>();
        }
        public Room Room { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}
