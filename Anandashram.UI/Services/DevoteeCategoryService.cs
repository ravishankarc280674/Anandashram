using System.Threading.Tasks;

namespace Anandashram.Services;

public class DevoteeCategoryService : IDevoteeCategoryService
{
    private readonly IDevoteeCategory _repo;

    public DevoteeCategoryService(IDevoteeCategory repo)
    {
        _repo = repo;
    }

    public async Task<PaginatedList<DevoteeCategory>> GetItems(string sortProperty, SortOrder sortOrder,
        string searchText, int pageIndex, int pageSize)
        =>await _repo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize);

    public async Task<DevoteeCategory?> GetDevoteeCategory(int id)
        =>await _repo.GetDevoteeCategory(id);

    public async Task<IEnumerable<DevoteeCategory>> GetDevoteeCategories()
        =>await _repo.GetDevoteeCategories();

    public async Task<(bool Success, string Message, DevoteeCategory? Entity)> Create(DevoteeCategory building)
    {
        // Example validation
        if (await _repo.IsExists(building.Name))
            return (false, "DevoteeCategory name already exists!", null);

        var created = await _repo.Create(building);
        return (true, "DevoteeCategory created", created);
    }

    public async Task<(bool Success, string Message, DevoteeCategory? Entity)> Edit(DevoteeCategory building)
    {
        var edited = await _repo.Edit(building);
        return (true, "Successfully updated", edited);
    }

    public async Task<(bool Success, string Message)> Delete(DevoteeCategory building)
    {
        await _repo.Delete(building);
        return (true, "Deleted successfully");
    }

    public async Task<IEnumerable<DevoteeCategory>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }
}
