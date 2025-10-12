using System.Security.Policy;

namespace Anandashram.Interfaces
{
    public interface IReservation
    {
        Task<List<Reservation>> AddReservation(List<Reservation> reservationList);
        Task CloseReservation(int id, int devoteeId);
        Task<List<Reservation>> ReservationList(int DevoteeId);
    }
}
