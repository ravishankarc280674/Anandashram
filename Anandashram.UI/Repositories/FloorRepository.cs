using System.Threading.Tasks;

namespace Anandashram.Repositories
{
    public class FloorRepository : IFloor
    {
        private readonly ApplicationDbContext _context; // for connecting to efcore.
        public FloorRepository(ApplicationDbContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public async Task<Floor> Create(Floor floor)
        {
            _context.Floors.Add(floor);
            await _context.SaveChangesAsync();
            return floor;
        }

        public async Task<Floor> Delete(Floor floor)
        {
            _context.Floors.Attach(floor);
            _context.Entry(floor).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return floor;
        }

        public async Task<Floor> Edit(Floor floor)
        {
            _context.Floors.Attach(floor);
            _context.Entry(floor).State = EntityState.Modified;
           await _context.SaveChangesAsync();
            return floor;
        }


        private List<Floor> DoSort(List<Floor> floors, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    floors = floors.OrderBy(n => n.Name).ToList();
                else
                    floors = floors.OrderByDescending(n => n.Name).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    floors = floors.OrderBy(d => d.Description).ToList();
                else
                    floors = floors.OrderByDescending(d => d.Description).ToList();
            }

            return floors;
        }

        public async Task<PaginatedList<Floor>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5)
        {
            List<Floor> floors;

            if (!string.IsNullOrEmpty(SearchText))
            {
                floors =await _context.Floors.Where(n => n.Name.Contains(SearchText) || n.Description.Contains(SearchText))
                    .ToListAsync();
            }
            else
                floors =await _context.Floors.ToListAsync();

            floors = DoSort(floors, SortProperty, sortOrder);

            PaginatedList<Floor> retFloors = new PaginatedList<Floor>(floors, pg, pageSize);
            return retFloors;
        }

        public async Task<Floor> GetFloor(int id)
        {
            Floor floor =await _context.Floors.Where(u => u.Id == id).FirstOrDefaultAsync();
            return floor;
        }
        public bool IsFloorNameExists(string name)
        {
            int ct = _context.Floors.Where(n => n.Name.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsFloorNameExists(string name, int Id)
        {
            int ct = _context.Floors.Where(n => n.Name.ToLower() == name.ToLower() && n.Id != Id).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public IEnumerable<Floor> GetFloors()
        {
            return _context.Floors.ToList();
        }
    }
}
