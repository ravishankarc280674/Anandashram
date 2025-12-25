namespace Anandashram.Interfaces.Services
{
    public interface IReservationService
    {
        Task<int> AddReservation(List<Reservation> reservationList);
        Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy);
        Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy);
        Task<List<Reservation>> ReservationList(int DevoteeId);
        Task<ReservationExtendDTO> GetReservationDataAsync(int id);
        Task<ApiResponse> ExtendReservationAsync(int reservationId, int newRoomId, DateTime newToDate);
        Task<ApiResponse> PartialReservationAsync(int reservationId, int newRoomId, DateTime newToDate, int newAllocated);
        Task<List<TimelineDTO>> GetReservationsForChart(DateTime startDate, DateTime endDate, List<int> buildings);
        Task AutoCloseReservation(DateTime dateValue);
       
    }
}
