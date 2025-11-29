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
}
