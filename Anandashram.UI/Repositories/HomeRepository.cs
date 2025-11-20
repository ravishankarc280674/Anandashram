namespace Anandashram.Repositories;
public class HomeRepository:IHome
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public HomeRepository(ApplicationDbContext context) // will be passed by dependency injection.
    {
        _context = context;
    }
    public HomeDTO GetHomeData()
    {
        var today = DateTime.Today;
        var tomorrow = today.AddDays(1);
        var vm = new HomeDTO
        {
            // Include all devotees except reopened
            TotalDevoteesCount = _context.Devotees
                .Where(d => d.ReopenedCode == null)
                .Sum(d => (int?)d.NoOfPeople) ?? 0,

            // Active devotees: Closed == false OR null
            TotalActiveDevotees = _context.Devotees
                .Where(d => d.ReopenedCode == null && (d.Closed == false))
                .Sum(d => (int?)d.NoOfPeople) ?? 0,

            // Total room capacity
            TotalRoomCapacity = _context.Rooms.Sum(r => r.Capacity),

            // Total reserved (active only)
            TotalRoomCapacityAvailable = (
                _context.Rooms.Sum(r => (int?)r.Capacity) ?? 0
            ) - (
                _context.Reservations
                    .Where(r => r.Closed == false)
                    .Sum(r => (int?)r.Allocated) ?? 0
            ),

            // Today Check-ins (FromDate)
            TodaysCheckIns = _context.Reservations
                .Where(r => r.FromDate.Date == today &&
                r.FromDate < tomorrow)
                .Sum(r => (int?)r.Allocated) ?? 0,

            // Today Check-outs (ToDate + Closed = true)
            TodaysCheckOuts = _context.Reservations
                .Where(r => r.ToDate >= today &&
                r.ToDate < tomorrow && r.Closed)
                .Sum(r => (int?)r.Allocated) ?? 0,
        };

        return vm;
    }

    public DashboardChartDTO GetDashBoardChartForCheckInCheckOut()
    {

        var today = DateTime.Today;
        var monthStart = new DateTime(today.Year, today.Month, 1);

        // Database-friendly date range (avoid time issues in SQL)
        var monthStartDate = monthStart.Date;
        var tomorrowDate = today.AddDays(1).Date;

        // Get Check-ins grouped by day
        var checkins = _context.Reservations
            .Where(r => r.FromDate >= monthStartDate && r.FromDate < tomorrowDate)
            .GroupBy(r => r.FromDate.Date)
            .Select(g => new { Date = g.Key, Count = g.Sum(x => x.Allocated) })
            .ToList();

        // Get Check-outs grouped by day (closed == true)
        var checkouts = _context.Reservations
            .Where(r => r.Closed == true &&
                        r.ToDate >= monthStartDate && r.ToDate < tomorrowDate)
            .GroupBy(r => r.ToDate.Date)
            .Select(g => new { Date = g.Key, Count = g.Sum(x => x.Allocated) })
            .ToList();

        // Build full date range for the month
        var daysInMonth = Enumerable.Range(0, (today - monthStart).Days + 1)
            .Select(i => monthStartDate.AddDays(i))
            .ToList();

        // Map values to ViewModel
        var vm = new DashboardChartDTO
        {
            Dates = daysInMonth
                .Select(d => d.ToString("dd-MMM"))
                .ToList(),

            DailyCheckIns = daysInMonth
                .Select(d => checkins.FirstOrDefault(x => x.Date == d)?.Count ?? 0)
                .ToList(),

            DailyCheckOuts = daysInMonth
                .Select(d => checkouts.FirstOrDefault(x => x.Date == d)?.Count ?? 0)
                .ToList()
        };

        return vm;
    }
}
