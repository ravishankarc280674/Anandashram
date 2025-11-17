
namespace Anandashram.Interfaces
{
    public interface IFloor
    {
        Task<PaginatedList<Floor>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        Task<Floor> GetFloor(int id); // read particular item

        Task<Floor> Create(Floor floor);

        Task<Floor> Edit(Floor floor);

        Task<Floor> Delete(Floor floor);

        public bool IsFloorNameExists(string name);
        public bool IsFloorNameExists(string name, int Id);
        IEnumerable<Floor> GetFloors();
    }
}
