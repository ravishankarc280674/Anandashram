namespace Anandashram.Interfaces.Services
{
    public interface IReservationService
    {
        Task<int> AddReservation(List<Reservation> reservationList);
        Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy);
        Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy);
        Task<List<Reservation>> ReservationList(int DevoteeId);
    }
}
