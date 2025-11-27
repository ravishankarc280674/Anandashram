using Anandashram.Interfaces.Repository;


public class BuildingRepository : IBuilding
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public BuildingRepository(ApplicationDbContext context) // will be passed by dependency injection.
    {
        _context = context;
    }
    public async Task<Building> Create(Building building)
    {
        _context.Buildings.Add(building);
       await _context.SaveChangesAsync();
        return building;
    }

    public async Task<Building> Delete(Building building)
    {
        _context.Buildings.Attach(building);
        _context.Entry(building).State = EntityState.Deleted;
       await _context.SaveChangesAsync();
        return building;
    }

    public async Task<Building> Edit(Building building)
    {
        _context.Buildings.Attach(building);
        _context.Entry(building).State = EntityState.Modified;
       await _context.SaveChangesAsync();
        return building;
    }


    private List<Building> DoSort(List<Building> buildings, string SortProperty, SortOrder sortOrder)
    {

        if (SortProperty.ToLower() == "name")
        {
            if (sortOrder == SortOrder.Ascending)
                buildings = buildings.OrderBy(n => n.Name).ToList();
            else
                buildings = buildings.OrderByDescending(n => n.Name).ToList();
        }
        else
        {
            if (sortOrder == SortOrder.Ascending)
                buildings = buildings.OrderBy(d => d.Description).ToList();
            else
                buildings = buildings.OrderByDescending(d => d.Description).ToList();
        }

        return buildings;
    }
    public async Task<bool> IsExists(string buildingName, int excludeId = 0)
    {
        return await _context.Buildings
            .AnyAsync(b => b.Name.ToLower().Trim() == buildingName.ToLower().Trim()
                           && b.Id != excludeId);
    }
    public async Task<PaginatedList<Building>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5)
    {
        List<Building> buildings;

        if (!string.IsNullOrEmpty(SearchText))
        {
            buildings =await _context.Buildings.Where(n => n.Name.Contains(SearchText) || n.Description.Contains(SearchText))
                .ToListAsync();
        }
        else
            buildings =await _context.Buildings.ToListAsync();

        buildings = DoSort(buildings, SortProperty, sortOrder);

        PaginatedList<Building> retBuildings = new PaginatedList<Building>(buildings, pg, pageSize);
        return retBuildings;
    }

    public async Task<Building> GetBuilding(int id)
    {
        Building building =await _context.Buildings.Where(u => u.Id == id).FirstOrDefaultAsync();
        return building;
    }
    public bool IsBuildingNameExists(string name)
    {
        int ct = _context.Buildings.Where(n => n.Name.ToLower() == name.ToLower()).Count();
        if (ct > 0)
            return true;
        else
            return false;
    }

    public bool IsBuildingNameExists(string name, int Id)
    {
        int ct = _context.Buildings.Where(n => n.Name.ToLower() == name.ToLower() && n.Id != Id).Count();
        if (ct > 0)
            return true;
        else
            return false;
    }

    public IEnumerable<Building> GetBuildings()
    {
        return _context.Buildings.ToList();
    }
}
