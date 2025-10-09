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
                               .ToListAsync();
            return reservations;
        }

    }
}
