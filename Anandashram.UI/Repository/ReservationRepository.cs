namespace Anandashram.Repository;
public class ReservationRepository : IReservation
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.

    public ReservationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Reservation>> ReservationList(int DevoteeId)
    {
        List<Reservation> reservations;

        reservations = await _context.Reservations.Where(r => r.DevoteeId == DevoteeId)
                                       .Include(r => r.Room).ThenInclude(b => b.Building)
                                       .Include(r => r.Room).ThenInclude(b => b.Block)
                                       .Include(r => r.Room).ThenInclude(b => b.Floor)
                                       .GroupJoin(_context.Reservations, r => r.RoomId, rs => rs.RoomId, (r, rss) => new { r, rss })
                .Select(result => new Reservation
                {

                    Id = result.r.Id,
                    RoomId = result.r.RoomId,
                    DevoteeId = result.r.DevoteeId,
                    Allocated = result.r.Allocated,
                    Closed = result.r.Closed,
                    FromDate = result.r.FromDate,
                    ToDate = result.r.ToDate,
                    CreatedBy = result.r.CreatedBy,
                    CreatedDate = result.r.CreatedDate,
                    Room = result.r.Room,
                    Remaining = result.r.Room.Capacity - result.rss.Where(rs => rs.Closed == false).Sum(rs => rs.Allocated)
                }).OrderByDescending(x => x.ToDate).ToListAsync();
        return reservations;
    }
    public Task<int> AddReservation([FromBody] List<Reservation> reservationList)
    {
        _context.Reservations.AddRange(reservationList);
        return _context.SaveChangesAsync();
    }

    public async Task CloseReservation(int id, int devoteeId, DateTime ToDate, string ModifiedBy)
    {
        Reservation reservation = _context.Reservations.Where(n => n.Id == id).FirstOrDefault();
        if (reservation != null)
        {
            reservation.Closed = true;
            reservation.ToDate = ToDate;
            reservation.ModifiedBy = ModifiedBy;
            reservation.ModifiedDate = ToDate;
            _context.Reservations.Update(reservation);
            _context.Entry(reservation).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
    public async Task CloseReservations(int devoteeId, DateTime ToDate, string ModifiedBy)
    {
        int i = await _context.Reservations.Where(d => d.DevoteeId == devoteeId && d.Closed == false)
                                               .ExecuteUpdateAsync(s => s.SetProperty(p => p.Closed, p => true)
                                                                  .SetProperty(p => p.ToDate, p => ToDate)
                                                                  .SetProperty(p => p.ModifiedDate, p => ToDate)
                                                                  .SetProperty(p => p.ModifiedBy, p => ModifiedBy));
    }
    public async Task<ReservationExtendDTO> GetReservationDataAsync(int reservationId)
    {
        var r = await _context.Reservations
                    .FirstOrDefaultAsync(x => x.Id == reservationId);

        var rooms = await _context.Rooms
                .OrderBy(x => x.Name)
                .Select(x => new RoomDTO   // << FLAT DTO
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();

        return new ReservationExtendDTO
        {
            CurrentRoomId = r?.RoomId ?? 0,
            ToDate = r?.ToDate.ToString("yyyy-MM-dd") ?? "",
            Allocated = r?.Allocated ?? 0,
            Rooms = rooms
        };
    }
    public async Task<ApiResponse> ExtendReservationAsync(int reservationId, int newRoomId, DateTime newToDate)
    {
        var reservation = await _context.Reservations
            .FirstOrDefaultAsync(r => r.Id == reservationId);

        if (reservation == null)
            return ApiResponse.Fail("Reservation not found");

        DateTime today = DateTime.Today;
        // RULE 1 — Prevent past dates
        if (newToDate < today)
            return ApiResponse.Fail("ToDate cannot be less than today's date.");

        bool roomChanged = reservation.RoomId != newRoomId;
        bool dateChanged = reservation.ToDate.Date != newToDate.Date;
        if (!roomChanged && !dateChanged)
        {
            return ApiResponse.Ok("No Changes Found");
        }
        // ---- ONLY DATE CHANGED ----
        if (!roomChanged && dateChanged)
        {
            reservation.ToDate = newToDate;
            await _context.SaveChangesAsync();
            return ApiResponse.Ok("Reservation extended.");
        }

        // ---- ONLY ROOM CHANGED ----
        if (roomChanged && !dateChanged)
        {
            if (reservation.FromDate.Date >= today)
            {
                // CASE 3A — Modify same reservation
                reservation.RoomId = newRoomId;
                await _context.SaveChangesAsync();
                return ApiResponse.Ok("Room updated for today's reservation.");
            }
            else
            {
                // CASE 3B — Split reservation
                reservation.ToDate = today;
                reservation.Closed = true;

                var newRes = new Reservation
                {
                    DevoteeId = reservation.DevoteeId,
                    RoomId = newRoomId,
                    FromDate = today,
                    ToDate = reservation.ToDate, // same date since only room changed
                    Allocated = reservation.Allocated,
                    CreatedDate = DateTime.Now
                };

                _context.Reservations.Add(newRes);
                await _context.SaveChangesAsync();

                return ApiResponse.Ok("Room changed by splitting reservation.");
            }
        }

        // ---- BOTH ROOM + DATE CHANGED ----
        if (reservation.FromDate.Date >= today)
        {
            // Update in place
            reservation.RoomId = newRoomId;
            reservation.ToDate = newToDate;
            await _context.SaveChangesAsync();
            return ApiResponse.Ok("Reservation updated with new room + date.");
        }
        else
        {
            // Split reservation
            reservation.ToDate = today;
            reservation.Closed = true;

            var newRes = new Reservation
            {
                DevoteeId = reservation.DevoteeId,
                RoomId = newRoomId,
                FromDate = today,
                ToDate = newToDate,
                Allocated = reservation.Allocated,
                CreatedDate = DateTime.Now
            };

            _context.Reservations.Add(newRes);
            await _context.SaveChangesAsync();

            return ApiResponse.Ok("Reservation split with new room + date.");
        }
    }

    public async Task<List<Reservation>> GetReservationsForChart(DateTime startDate, DateTime endDate)
    {
        return await _context.Reservations
            .Include(r => r.Devotee)
            .Include(r => r.Room).ThenInclude(b => b.Building)
            .Include(r => r.Room).ThenInclude(b => b.Block)
            .Include(r => r.Room).ThenInclude(b => b.Floor)
            .Where(r => r.Closed == false &&
                   r.FromDate <= endDate &&
                   r.ToDate >= startDate)
            .ToListAsync();
    }

}
