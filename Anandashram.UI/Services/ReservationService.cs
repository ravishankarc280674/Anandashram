namespace Anandashram.Services;
public class ReservationService : IReservationService
{
    private readonly IReservation _reservationRepo;
    public ReservationService(IReservation reservationRepo) { _reservationRepo = reservationRepo; }
    public async Task<int> AddReservation(List<Reservation> reservationList)
    {
        return await _reservationRepo.AddReservation(reservationList);
    }

    public Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy)
    {
        return _reservationRepo.CloseReservation(id, devoteeId, ToDate, ModifiedBy);
    }

    public async Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy)
    {
        await _reservationRepo.CloseReservations(devoteeId, ToDate, ModifiedBy);
    }

    public async Task<List<Reservation>> ReservationList(int DevoteeId)
    {
        return await _reservationRepo.ReservationList(DevoteeId);
    }

    public async Task<ReservationExtendDTO> GetReservationDataAsync(int id)
   => await _reservationRepo.GetReservationDataAsync(id);
    public async Task<ApiResponse> ExtendReservationAsync(int reservationId, int newRoomId, DateTime newToDate)
=> await _reservationRepo.ExtendReservationAsync(reservationId, newRoomId, newToDate);

    public async Task<List<TimelineDTO>> GetReservationsForChart(DateTime startDate, DateTime endDate)
    {
        var list = await _reservationRepo.GetReservationsForChart(startDate, endDate);

        return list.Select(r =>
        {
            var f = r.FromDate < startDate ? startDate : r.FromDate;
            var t = r.ToDate > endDate ? endDate : r.ToDate;

            return new TimelineDTO
            {
                RoomName = r.RoomName,
                DevoteeName = r.DevoteeName,
                DevoteeCode = r.DevoteeCode,
                Allocated = r.Allocated,
                FromDate = f,
                ToDate = t
            };
        }).ToList();
    }

}
