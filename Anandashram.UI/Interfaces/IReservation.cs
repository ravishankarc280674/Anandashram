using System.Security.Policy;

namespace Anandashram.Interfaces
{
    public interface IReservation
    {
        Task<List<Reservation>> AddReservation(List<Reservation> reservationList);
        Task<List<Reservation>> ReservationList(int DevoteeId);
    }
}
