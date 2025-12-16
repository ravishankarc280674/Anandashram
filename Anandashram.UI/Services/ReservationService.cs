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

    public async Task<List<TimelineDTO>> GetReservationsForChart(DateTime startDate, DateTime endDate,List<int> buildingIds)
    {
        var list = await _reservationRepo.GetReservationsForChart(startDate, endDate);
        if (buildingIds != null && buildingIds.Any())
        {
            list = list.Where(r =>
                buildingIds.Contains(
                    r.Room.BuildingId)).ToList();
        }
        return list
            .Where(r => r.Closed == false)          // Only active
            .Select(r =>
            {
                DateTime f;
                DateTime t;

                // LEFT TRIM — only when reservation starts BEFORE selected range
                if (r.FromDate < startDate)
                    f = startDate;
                else
                    f = r.FromDate;  // No trimming (Case-2)

                // RIGHT TRIM — only when reservation ends AFTER selected range
                if (r.ToDate > endDate)
                    t = endDate;
                else
                    t = r.ToDate;

                return new TimelineDTO
                {
                    RoomName = r.RoomName,
                    DevoteeName = r.DevoteeName,
                    DevoteeCode = r.DevoteeCode,
                    Allocated = r.Allocated,
                    Capacity = r.Room.Capacity,
                    FromDate = f,
                    ToDate = t
                };
            })
            .Where(r => r.FromDate <= r.ToDate)      // Filter situations where trimmed result is invalid
            .ToList();
    }
    public async Task AutoCloseReservation(DateTime dateValue)
    => await _reservationRepo.AutoCloseReservation(dateValue);
}
