namespace Anandashram.Interfaces.Services;
public interface IDevoteeCategory
{
    Task<PaginatedList<DevoteeCategory>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
    Task<DevoteeCategory> GetDevoteeCategory(int id); // read particular item
    Task<DevoteeCategory> Create(DevoteeCategory devoteeCategory);
    Task<DevoteeCategory> Edit(DevoteeCategory devoteeCategory);
    Task<DevoteeCategory> Delete(DevoteeCategory devoteeCategory);
    bool IsDevoteeCategoryNameExists(string name);
    bool IsDevoteeCategoryNameExists(string name, int Id);
    Task<IEnumerable<DevoteeCategory>> GetDevoteeCategories();
    Task<bool> IsExists(string devoteeCategoryName, int excludeId = 0);
    Task<IEnumerable<DevoteeCategory>> GetAllAsync();
}
