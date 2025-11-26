namespace Anandashram.Interfaces;
public interface IDevoteeCategoryService
{
    Task<PaginatedList<DevoteeCategory>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize);
    Task<DevoteeCategory> GetDevoteeCategory(int id);
    Task<(bool Success, string Message, DevoteeCategory Entity)> Create(DevoteeCategory devoteeCategory);
    Task<(bool Success, string Message, DevoteeCategory Entity)> Edit(DevoteeCategory devoteeCategory);
    Task<(bool Success, string Message)> Delete(DevoteeCategory devoteeCategory);
    IEnumerable<DevoteeCategory> GetDevoteeCategories();
}
