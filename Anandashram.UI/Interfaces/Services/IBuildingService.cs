namespace Anandashram.Interfaces.Services;
public interface IBuildingService
{
    Task<PaginatedList<Building>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize);
    Task<Building> GetBuilding(int id);
    Task<(bool Success, string Message, Building Entity)> Create(Building building);
    Task<(bool Success, string Message, Building Entity)> Edit(Building building);
    Task<(bool Success, string Message)> Delete(Building building);
    IEnumerable<Building> GetBuildings();
}
