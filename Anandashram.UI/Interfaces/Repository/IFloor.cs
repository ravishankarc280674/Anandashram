namespace Anandashram.Interfaces.Repository;
public interface IFloor
{
    Task<PaginatedList<Floor>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
    Task<Floor> GetFloor(int id); // read particular item
    Task<Floor> Create(Floor floor);
    Task<Floor> Edit(Floor floor);
    Task<Floor> Delete(Floor floor);
    bool IsFloorNameExists(string name);
    bool IsFloorNameExists(string name, int Id);
    IEnumerable<Floor> GetFloors();
    Task<bool> IsExists(string floorName, int excludeId = 0);
}
