namespace Anandashram.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuilding _repo;

        public BuildingService(IBuilding repo)
        {
            _repo = repo;
        }

        public Task<PaginatedList<Building>> GetItems(string sortProperty, SortOrder sortOrder,
            string searchText, int pageIndex, int pageSize)
            => _repo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize);

        public Task<Building?> GetBuilding(int id)
            => _repo.GetBuilding(id);

        public IEnumerable<Building> GetBuildings()
            => _repo.GetBuildings();

        public async Task<(bool Success, string Message, Building? Entity)> Create(Building building)
        {
            // Example validation
            if (await _repo.IsExists(building.Name))
                return (false, "Building name already exists!", null);

            var created = await _repo.Create(building);
            return (true, "Building created", created);
        }

        public async Task<(bool Success, string Message, Building? Entity)> Edit(Building building)
        {
            var edited = await _repo.Edit(building);
            return (true, "Successfully updated", edited);
        }

        public async Task<(bool Success, string Message)> Delete(Building building)
        {
            await _repo.Delete(building);
            return (true, "Deleted successfully");
        }
    }
}
