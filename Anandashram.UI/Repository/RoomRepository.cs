using Anandashram.Interfaces.Repository;


public class RoomRepository : IRoom
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public RoomRepository(ApplicationDbContext context) // will be passed by dependency injection.
    {
        _context = context;
    }
    public async Task<Room> Create(Room room)
    {
        _context.Rooms.Add(room);
        await _context.SaveChangesAsync();
        return room;
    }

    public async Task<Room> Delete(Room room)
    {
        _context.Rooms.Attach(room);
        _context.Entry(room).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
        return room;
    }

    public async Task<Room> Edit(Room room)
    {
        _context.Rooms.Attach(room);
        _context.Entry(room).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return room;
    }


    private List<Room> DoSort(List<Room> rooms, string SortProperty, SortOrder sortOrder)
    {

        if (SortProperty.ToLower() == "name")
        {
            if (sortOrder == SortOrder.Ascending)
                rooms = rooms.OrderBy(n => n.Name).ToList();
            else
                rooms = rooms.OrderByDescending(n => n.Name).ToList();
        }
        else
        {
            if (sortOrder == SortOrder.Ascending)
                rooms = rooms.OrderBy(d => d.Description).ToList();
            else
                rooms = rooms.OrderByDescending(d => d.Description).ToList();
        }

        return rooms;
    }

    public async Task<PaginatedList<Room>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5)
    {
        List<Room> rooms = await GetRoomsList(SearchText);

        rooms = DoSort(rooms, SortProperty, sortOrder);

        PaginatedList<Room> retRooms = new PaginatedList<Room>(rooms, pg, pageSize);
        return retRooms;
    }

    public async Task<List<Room>> GetRoomsList(string SearchText)
    {
        List<Room> rooms;

        if (!string.IsNullOrEmpty(SearchText))
        {
            rooms = await _context.Rooms.Include(e => e.Building)
                .Include(e => e.Block)
                .Include(e => e.Floor)
            .Where(n => n.Name.Contains(SearchText)
                    || n.Building.Name.Contains(SearchText)
                    || n.Block.Name.Contains(SearchText)
                    || n.Floor.Name.Contains(SearchText))
                .ToListAsync();
        }
        else
            rooms = await _context.Rooms.Include(e => e.Building)
                .Include(e => e.Block)
                .Include(e => e.Floor).ToListAsync();
        return rooms;
    }

    public async Task<Room> GetRoom(int id)
    {
        Room room = await _context.Rooms.Where(u => u.Id == id).FirstOrDefaultAsync();
        return room == null ? new Room() : room;
    }
    public bool IsRoomNameExists(string name)
    {
        int ct = _context.Rooms.Where(n => n.Name.ToLower() == name.ToLower()).Count();
        if (ct > 0)
            return true;
        else
            return false;
    }

    public bool IsRoomNameExists(string name, int Id)
    {
        int ct = _context.Rooms.Where(n => n.Name.ToLower() == name.ToLower() && n.Id != Id).Count();
        if (ct > 0)
            return true;
        else
            return false;
    }

    public List<Room> GetFilteredRooms()
    {

        return _context.Rooms.Include(e => e.Building)
                .Include(e => e.Block)
                .Include(e => e.Floor).ToList();
    }
    public Room GetSelectedRoom(int Id) // to be changed future
    {
        Room room = _context.Rooms.Where(u => u.Id == Id).Include(e => e.Building)
                .Include(e => e.Block)
                .Include(e => e.Floor)
                .GroupJoin(_context.Reservations, r => r.Id, rs => rs.RoomId, (r, rss) => new { r, rss })
                .Select(result => new Room
                {
                    Building = result.r.Building,
                    Floor = result.r.Floor,
                    Block = result.r.Block,
                    Id = result.r.Id,
                    Name = result.r.Name,
                    BuildingId = result.r.BuildingId,
                    FloorId = result.r.FloorId,
                    BlockId = result.r.BlockId,
                    Capacity = result.r.Capacity,
                    CreatedBy = result.r.CreatedBy,
                    CreatedDate = result.r.CreatedDate,
                    Description = result.r.Description,
                    ModifiedBy = result.r.ModifiedBy,
                    ModifiedDate = result.r.ModifiedDate,
                    Remaining = result.r.Capacity - (result.rss.Where(rs => !rs.Closed).Sum(rs => rs.Allocated))
                }).FirstOrDefault();

        return room == null ? new Room() : room;
    }
    public async Task<List<Room>> GeRoomReservations(string SortProperty, SortOrder sortOrder, string SearchText = "")
    {
        List<Room> roomList = await GetAllRoomReservations(SearchText);

        return roomList;
    }

    public async Task<List<Room>> GetAllRoomReservations(string SearchText)
    {
        List<Room> roomList;
        if (!string.IsNullOrEmpty(SearchText))
        {
            roomList = await _context.Rooms.Include(e => e.Building)
                        .Include(e => e.Block)
                        .Include(e => e.Floor)
                        .Include(e => e.Reservations.Where(e => e.Closed == false)).ThenInclude(e => e.Devotee)
                        .Where(n => n.Name.Contains(SearchText)
                        || n.Block.Name.Contains(SearchText)
                        || n.Building.Name.Contains(SearchText)
                        || n.Floor.Name.Contains(SearchText)).ToListAsync();
        }
        else
        {
            roomList = await _context.Rooms.Include(e => e.Building)
                        .Include(e => e.Block)
                        .Include(e => e.Floor)
                        .Include(e => e.Reservations.Where(e => e.Closed == false)).ThenInclude(e => e.Devotee).ToListAsync();
        }

        return roomList;
    }
    public async Task<List<RoomReportDTO>> GetRoomsUpToDateAsync(DateTime dateValue)
    {
        List<RoomReportDTO> rooms;
        if (dateValue == DateTime.MinValue)
        {
            rooms = await _context.Rooms
            .Include(r => r.Building)
            .Include(r => r.Block)
            .Include(r => r.Floor)
            .GroupJoin(
                _context.Reservations
                    .Include(rv => rv.Devotee)
                    .Where(rv =>
                        !rv.Closed
                    ),
                room => room.Id,
                rv => rv.RoomId,
                (room, reservations) => new
                {
                    room,
                    reservations,
                    allocated = reservations.Sum(v => (int?)v.Allocated) ?? 0
                }
            )
            .Select(x => new RoomReportDTO
            {
                Id = x.room.Id,
                RoomName = x.room.Name,

                BuildingName = x.room.Building != null ? x.room.Building.Name : "",
                BlockName = x.room.Block != null ? x.room.Block.Name : "",
                FloorName = x.room.Floor != null ? x.room.Floor.Name : "",
                Capacity = x.room.Capacity,

                TotalAllocated = x.allocated,
                TotalRemaining = x.room.Capacity - x.allocated,
                RemainingCount = x.room.Capacity - x.allocated,

                Reservations = x.reservations.Select(rv => new ReservationReportDTO
                {
                    Id = rv.Id,
                    RoomId = rv.RoomId,
                    DevoteeId = rv.DevoteeId,
                    DevoteeCode = rv.Devotee != null ? rv.Devotee.Code : "",
                    DevoteeName = rv.Devotee != null ? rv.Devotee.Name : "",

                    FromDate = rv.FromDate,
                    ToDate = rv.ToDate,
                    Allocated = rv.Allocated,
                    Closed = rv.Closed
                }).ToList()
            })
            .OrderBy(x => x.BuildingName)
            .ThenBy(x => x.BlockName)
            .ThenBy(x => x.FloorName)
            .ThenBy(x => x.RoomName)
            .ToListAsync();
        }
        else
        {
            var targetDate = dateValue.Date.AddDays(1); // include full selected date

             rooms = await _context.Rooms
                .Include(r => r.Building)
                .Include(r => r.Block)
                .Include(r => r.Floor)
                .GroupJoin(
                    _context.Reservations
                        .Include(rv => rv.Devotee)
                        .Where(rv =>
                            !rv.Closed && // 🔥 ensures reservation is active
                            rv.FromDate < targetDate
                        ),
                    room => room.Id,
                    rv => rv.RoomId,
                    (room, reservations) => new
                    {
                        room,
                        reservations,
                        allocated = reservations.Sum(v => (int?)v.Allocated) ?? 0
                    }
                )
                .Select(x => new RoomReportDTO
                {
                    Id = x.room.Id,
                    RoomName = x.room.Name,

                    BuildingName = x.room.Building != null ? x.room.Building.Name : "",
                    BlockName = x.room.Block != null ? x.room.Block.Name : "",
                    FloorName = x.room.Floor != null ? x.room.Floor.Name : "",
                    Capacity = x.room.Capacity,

                    TotalAllocated = x.allocated,
                    TotalRemaining = x.room.Capacity - x.allocated,
                    RemainingCount = x.room.Capacity - x.allocated,

                    Reservations = x.reservations.Select(rv => new ReservationReportDTO
                    {
                        Id = rv.Id,
                        RoomId = rv.RoomId,
                        DevoteeId = rv.DevoteeId,
                        DevoteeCode = rv.Devotee != null ? rv.Devotee.Code : "",
                        DevoteeName = rv.Devotee != null ? rv.Devotee.Name : "",

                        FromDate = rv.FromDate,
                        ToDate = rv.ToDate,
                        Allocated = rv.Allocated,
                        Closed = rv.Closed
                    }).ToList()
                })
                .OrderBy(x => x.BuildingName)
                .ThenBy(x => x.BlockName)
                .ThenBy(x => x.FloorName)
                .ThenBy(x => x.RoomName)
                .ToListAsync();
        }
        return rooms;
    }

    public async Task<List<RoomReportDTO>> GetRoomsWithReservationsUpToDateAsync(DateTime dateValue)
    {
        var endOfDay = dateValue.Date.AddDays(1);
        var rooms = await _context.Rooms
    .Include(r => r.Building)
    .Include(r => r.Block)
    .Include(r => r.Floor)
    .GroupJoin(
        _context.Reservations
            .Include(e => e.Devotee)
            .Where(res => !res.Closed && res.FromDate < endOfDay),
        room => room.Id,
        res => res.RoomId,
        (room, reservations) => new { room, reservations }
    )
    .Select(x => new RoomReportDTO
    {
        Id = x.room.Id,
        RoomName = x.room.Name,

        BuildingName = x.room.Building != null ? x.room.Building.Name : "",
        BlockName = x.room.Block != null ? x.room.Block.Name : "",
        FloorName = x.room.Floor != null ? x.room.Floor.Name : "",
        Capacity = x.room.Capacity,

        TotalAllocated = x.reservations.Sum(rv => (int?)rv.Allocated) ?? 0,
        TotalRemaining = x.room.Capacity - (x.reservations.Sum(rv => (int?)rv.Allocated) ?? 0),
        RemainingCount = x.room.Capacity - (x.reservations.Sum(rv => (int?)rv.Allocated) ?? 0),

        Reservations = x.reservations
            .Select(rv => new ReservationReportDTO
            {
                RoomId = rv.RoomId,
                DevoteeCode = rv.Devotee.Code,
                DevoteeName = rv.Devotee.Name,
                FromDate = rv.FromDate,
                Allocated = rv.Allocated,
                Closed = rv.Closed
            })
            .ToList()
    })
    .ToListAsync();
        return rooms;
    }

    public List<RoomDTO> GetRooms()
    {
        var rooms = _context.Rooms
            .Include(r => r.Building)
            .Include(r => r.Block)
            .Include(r => r.Floor)
            .OrderBy(r => r.Building.Name)
            .ThenBy(r => r.Block.Name)
            .ThenBy(r => r.Floor.Name)
            .ThenBy(r => r.Name)
            .Select(r => new RoomDTO
            {
                RoomId = r.Id,
                RoomName = r.Name,
                BuildingName = r.Building != null ? r.Building.Name : string.Empty,
                BlockName = r.Block != null ? r.Block.Name : string.Empty,
                FloorName = r.Floor != null ? r.Floor.Name : string.Empty,
                Capacity = r.Capacity,
                BuildingId = r.BuildingId,
                BlockId = r.BlockId,
                FloorId = r.FloorId
            })
            .ToList();

        return rooms;
    }

    public async Task<List<ReservationReportDTO>> GetCheckInDetailsReportAsync(DateTime dateValue)
    {
        var endOfDay = dateValue.Date.AddDays(1);
        var startOfDate = dateValue.Date;

        return await _context.Reservations.Include(rv => rv.Devotee)
            .Where(r => r.FromDate.Date >= startOfDate && r.FromDate.Date < endOfDay) // ignore time!
            .Select(r => new ReservationReportDTO
            {
                DevoteeCode = r.Devotee.Code,
                DevoteeName = r.Devotee.Name,
                FromDate = r.FromDate,
                ToDate = r.ToDate,
                RoomName = r.Room.Name,
                Allocated = r.Allocated
            }).ToListAsync();
    }
}
