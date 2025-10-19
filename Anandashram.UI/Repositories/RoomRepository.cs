using AspNetCoreGeneratedDocument;
using Microsoft.EntityFrameworkCore.Internal;
using System.Net;
using System.Security.Cryptography.Xml;

namespace Anandashram.Repositories
{
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
            List<Room> rooms;

            if (!string.IsNullOrEmpty(SearchText))
            {
                rooms =await _context.Rooms.Include(e =>e.Building)
                    .Include(e => e.Block)
                    .Include(e => e.Floor)
                .Where(n => n.Name.Contains(SearchText) || n.Description.Contains(SearchText))
                    .ToListAsync();
            }
            else
                rooms =await _context.Rooms.Include(e => e.Building)
                    .Include(e => e.Block)
                    .Include(e => e.Floor).ToListAsync();

            rooms = DoSort(rooms, SortProperty, sortOrder);

            PaginatedList<Room> retRooms = new PaginatedList<Room>(rooms,pg,pageSize);
            return retRooms;
        }

        public async Task<Room> GetRoom(int id)
        {
            Room room =await _context.Rooms.Where(u => u.Id == id).FirstOrDefaultAsync();
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

        public bool IsRoomNameExists(string name,int Id)
        {
            int ct = _context.Rooms.Where(n => n.Name.ToLower() == name.ToLower() && n.Id!=Id).Count();
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
            Room room =_context.Rooms.Where(u => u.Id == Id).Include(e => e.Building)
                    .Include(e => e.Block)
                    .Include(e => e.Floor)
                    .GroupJoin(_context.Reservations, r => r.Id, rs => rs.RoomId, (r, rss) => new { r, rss })
                    .Select(result => new Room
                    {
                       Building = result.r.Building,
                       Floor= result.r.Floor,
                       Block= result.r.Block,
                       Id= result.r.Id,
                       Name= result.r.Name,
                       BuildingId= result.r.BuildingId,
                       FloorId = result.r.FloorId,
                       BlockId = result.r.BlockId,
                       Capacity = result.r.Capacity,
                       CreatedBy = result.r.CreatedBy,
                       CreatedDate = result.r.CreatedDate,
                       Description = result.r.Description,
                       ModifiedBy = result.r.ModifiedBy,
                       ModifiedDate = result.r.ModifiedDate,
                        Remaining = result.r.Capacity - (result.rss.Where(rs => rs.Closed == false).Sum(rs => rs.Allocated))
                    }).FirstOrDefault();
            
            
            return room == null ? new Room() : room;
        }
        public async Task<List<Room>> GeRoomReservations(string SortProperty, SortOrder sortOrder, string SearchText = "")
        {
            List<Room> roomList = await _context.Rooms.Include(e => e.Building)
                            .Include(e => e.Block)
                            .Include(e => e.Floor)
                            .Include(e => e.Reservations.Where(e => e.Closed == false)).ThenInclude(e => e.Devotee).ToListAsync();

            //}
            //else
            //{
            //    roomList= _context.Rooms.Include(e => e.Building)
            //           .Include(e => e.Block)
            //           .Include(e => e.Floor).GroupJoin(_context.Reservations, ro => ro.Id, res => res.RoomId,
            //           (ro, resGroup) => new { ro, resGroup }
            //           )
            //           .SelectMany(
            //               x => x.resGroup.DefaultIfEmpty(),
            //               (x, ro) => new
            //               {
            //                   Room = x.ro,
            //                   reservations = x.resGroup
            //               }
            //           );
            //}

            return roomList;
        }
    }
}
