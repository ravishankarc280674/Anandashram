namespace Anandashram.Interfaces.Repository;
public interface IReservation
{
    Task<int> AddReservation(List<Reservation> reservationList);
    Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy);
    Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy);
    Task<List<Reservation>> ReservationList(int DevoteeId);
    Task<ReservationExtendDTO> GetReservationDataAsync(int id);
    Task<ApiResponse> ExtendReservationAsync(int reservationId, int newRoomId, DateTime newToDate);
    Task<List<Reservation>> GetReservationsForChart(DateTime startDate, DateTime endDate);

}
