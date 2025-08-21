using Anandashram.Models;
using Anandashram.Shared;

namespace Anandashram.DAL.Interface
{
    public interface IInfraStructureDAO
    {
        Task<PaginatedList<Building>> GetBuildingList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);
        Task<PaginatedList<Block>> GetBlockList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);
    }
}
