using Anandashram.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.CodeDom;

namespace Anandashram.Repositories
{
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
                    }).ToListAsync();
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
    }
}
