namespace Anandashram.Repositories
{
    public class HomeRepository
    {
        private readonly ApplicationDbContext _context; // for connecting to efcore.
        public HomeRepository(ApplicationDbContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public async Task<HomeDTO> GetHomeDataAsync()
{
    var today = DateTime.Today;

    var vm = new HomeDTO
    {
        // Include all devotees except reopened
        TotalDevoteesCount = await _context.Devotees
            .Where(d => d.ReopenedCode == null)
            .SumAsync(d => (int?)d.NoOfPeople) ?? 0,

        // Active devotees: Closed == false OR null
        TotalActiveDevotees = await _context.Devotees
            .Where(d => d.ReopenedCode == null && (d.Closed == false))
            .SumAsync(d => (int?)d.NoOfPeople) ?? 0,

        // Total room capacity
        TotalRoomCapacity = await _context.Rooms.SumAsync(r => r.Capacity),

        // Total reserved (active only)
        TotalRoomCapacityAvailable = (
            await _context.Rooms.SumAsync(r => (int?)r.Capacity) ?? 0
        ) - (
            await _context.Reservations
                .Where(r => r.Closed == false)
                .SumAsync(r => (int?)r.Allocated) ?? 0
        ),

        // Today Check-ins (FromDate)
        TodaysCheckIns = await _context.Reservations
            .Where(r => r.FromDate.Date == today)
            .SumAsync(r => (int?)r.Allocated) ?? 0,

        // Today Check-outs (ToDate + Closed = true)
        TodaysCheckOuts = await _context.Reservations
            .Where(r => r.ToDate.Date == today && r.Closed == true)
            .SumAsync(r => (int?)r.Allocated) ?? 0
    };

    return vm;
}


    }
}
