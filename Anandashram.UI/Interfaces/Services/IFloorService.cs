namespace Anandashram.Interfaces.Services;
public interface IFloorService
{
    Task<PaginatedList<Floor>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize);
    Task<Floor> GetFloor(int id);
    Task<(bool Success, string Message, Floor Entity)> Create(Floor floor);
    Task<(bool Success, string Message, Floor Entity)> Edit(Floor floor);
    Task<(bool Success, string Message)> Delete(Floor floor);
    Task<IEnumerable<Floor>> GetFloors();
}
