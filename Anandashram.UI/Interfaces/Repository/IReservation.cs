namespace Anandashram.Interfaces.Repository;
public interface IReservation
{
    Task<int> AddReservation(List<Reservation> reservationList);
    Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy);
    Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy);
    Task<List<Reservation>> ReservationList(int DevoteeId);
    Task<ReservationExtendDTO> GetReservationDataAsync(int id);
    Task<ApiResponse> ExtendReservationAsync(int reservationId, int newRoomId, DateTime newToDate);
    Task<ApiResponse> PartialReservationAsync(int reservationId, int newRoomId, DateTime newToDate, int newAllocated);
    Task<List<Reservation>> GetReservationsForChart(DateTime startDate, DateTime endDate);
    Task AutoCloseReservation(DateTime dateValue);
    Task<List<ReservationReportDTO>> GetReservationReportAsync(DateTime fromDate, DateTime toDate, List<int> roomIds);
}
