using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.BAL.Interface
{
    public interface IInfraStructureBO
    {
        Task<PaginatedList<Building>> GetBuildingList(string sortOrder, string currentFilter, string searchString, int? pageNumber,int pageSize);
        Task<PaginatedList<Block>> GetBlockList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);
        Task<PaginatedList<Floor>> GetFloorList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);
        Task<PaginatedList<Room>> GetRoomList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);

    }
}
