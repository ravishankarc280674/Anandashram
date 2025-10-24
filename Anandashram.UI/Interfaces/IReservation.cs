using System.Security.Policy;

namespace Anandashram.Interfaces
{
    public interface IReservation
    {
        Task AddReservation(List<Reservation> reservationList);
        Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy);
        Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy);
        Task<List<Reservation>> ReservationList(int DevoteeId);

    }
}
