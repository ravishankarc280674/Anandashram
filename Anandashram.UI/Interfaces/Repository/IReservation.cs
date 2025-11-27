namespace Anandashram.Interfaces.Repository;
public interface IReservation
{
    Task<int> AddReservation(List<Reservation> reservationList);
    Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy);
    Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy);
    Task<List<Reservation>> ReservationList(int DevoteeId);

}
