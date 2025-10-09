using System.Security.Policy;

namespace Anandashram.Interfaces
{
    public interface IReservation
    {
        Task<List<Reservation>> ReservationList(int DevoteeId);
    }
}
