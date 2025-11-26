using Anandashram.Models;
using Anandashram.Repositories;
using System.Threading.Tasks;

namespace Anandashram.Services
{
    public class FloorService : IFloorService
    {
        private readonly IFloor _repo;

        public FloorService(IFloor repo)
        {
            _repo = repo;
        }

        public Task<PaginatedList<Floor>> GetItems(string sortProperty, SortOrder sortOrder,
            string searchText, int pageIndex, int pageSize)
            => _repo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize);

        public Task<Floor?> GetFloor(int id)
            => _repo.GetFloor(id);

        public IEnumerable<Floor> GetFloors()
            => _repo.GetFloors();

        public async Task<(bool Success, string Message, Floor? Entity)> Create(Floor floor)
        {
            // Example validation
            if (await _repo.IsExists(floor.Name))
                return (false, "Floor name already exists!", null);

            var created = await _repo.Create(floor);
            return (true, "Floor created", created);
        }

        public async Task<(bool Success, string Message, Floor? Entity)> Edit(Floor floor)
        {
            var edited = await _repo.Edit(floor);
            return (true, "Successfully updated", edited);
        }

        public async Task<(bool Success, string Message)> Delete(Floor floor)
        {
            await _repo.Delete(floor);
            return (true, "Deleted successfully");
        }
    }
}
