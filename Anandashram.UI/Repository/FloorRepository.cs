namespace Anandashram.Repository;
public class FloorRepository : IFloor
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public FloorRepository(ApplicationDbContext context) // will be passed by dependency injection.
    {
        _context = context;
    }
    public async Task<Floor> Create(Floor floors)
    {
        _context.Floors.Add(floors);
        await _context.SaveChangesAsync();
        return floors;
    }

    public async Task<Floor> Delete(Floor floors)
    {
        _context.Floors.Attach(floors);
        _context.Entry(floors).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
        return floors;
    }

    public async Task<Floor> Edit(Floor floors)
    {
        _context.Floors.Attach(floors);
        _context.Entry(floors).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return floors;
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
    public async Task<bool> IsExists(string floorsName, int excludeId = 0)
    {
        return await _context.Floors
            .AnyAsync(b => b.Name.ToLower().Trim() == floorsName.ToLower().Trim()
                           && b.Id != excludeId);
    }
    public async Task<PaginatedList<Floor>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5)
    {
        List<Floor> floors;

        if (!string.IsNullOrEmpty(SearchText))
        {
            floors = await _context.Floors.Where(n => n.Name.Contains(SearchText) || n.Description.Contains(SearchText))
                .ToListAsync();
        }
        else
            floors = await _context.Floors.ToListAsync();

        floors = DoSort(floors, SortProperty, sortOrder);

        PaginatedList<Floor> retFloors = new PaginatedList<Floor>(floors, pg, pageSize);
        return retFloors;
    }

    public async Task<Floor> GetFloor(int id)
    {
        Floor floors = await _context.Floors.Where(u => u.Id == id).FirstOrDefaultAsync();
        return floors;
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

    public async Task<IEnumerable<Floor>> GetFloors()
    {
        return await _context.Floors.ToListAsync();
    }
}
