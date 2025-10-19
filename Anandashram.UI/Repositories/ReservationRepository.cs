using Anandashram.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.CodeDom;

namespace Anandashram.Repositories
{
    public class ReservationRepository:IReservation
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
                        Remaining =result.r.Room.Capacity - result.rss.Where(rs => rs.Closed == false).Sum(rs => rs.Allocated)
                    }).ToListAsync();
            return reservations;
        }
        public async Task  AddReservation([FromBody] List<Reservation> reservationList)
        {
            _context.Reservations.AddRange(reservationList);
            await _context.SaveChangesAsync();
            //return reservationList;
        }

        public async Task CloseReservation(int id, int devoteeId)
        {
            Reservation reservation = _context.Reservations.Where(n => n.Id == id).FirstOrDefault();
            if (reservation != null)
            {
                reservation.Closed = true;
                reservation.ToDate = DateTime.Now;
                _context.Reservations.Update(reservation);
                _context.Entry(reservation).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
       
    }
}
