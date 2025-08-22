using Anandashram.DAL.Interface;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Anandashram.DAL
{
    public class InfraStructureDAO: IInfraStructureDAO
    {
        private readonly AnandashramContext _context;

        public InfraStructureDAO(AnandashramContext dbcontext)
        {
            _context = dbcontext;
        } 
        public async Task<PaginatedList<Building>> GetBuildingList(string sortOrder, string currentFilter, string searchText, int? pageNumber, int pageSize)
        {
            if (searchText != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchText = currentFilter;
            }
            var buildingList = from m in _context.HotelBuildings select m;
            if (!String.IsNullOrEmpty(searchText))
            {
                buildingList = buildingList.Where(s => s.Name.ToLower().Contains(searchText.ToLower()));
            }
            buildingList = sortOrder switch
            {
                "name_desc" => buildingList.OrderByDescending(s => s.Name),
                                _ => buildingList.OrderBy(s => s.Name),
            };
            return await PaginatedList<Building>.CreateAsync(buildingList, pageNumber ?? 1, pageSize);
        }

        public async Task<PaginatedList<Block>> GetBlockList(string sortOrder, string currentFilter, string searchText, int? pageNumber, int pageSize)
        {
            if (searchText != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchText = currentFilter;
            }
            var blockList = from m in _context.HotelBlocks select m;
            if (!String.IsNullOrEmpty(searchText))
            {
                blockList = blockList.Where(s => s.Name.ToLower().Contains(searchText.ToLower()));
            }
            blockList = sortOrder switch
            {
                "name_desc" => blockList.OrderByDescending(s => s.Name),
                _ => blockList.OrderBy(s => s.Name),
            };
            return await PaginatedList<Block>.CreateAsync(blockList, pageNumber ?? 1, pageSize);
        }

        public async Task<PaginatedList<Floor>> GetFloorList(string sortOrder, string currentFilter, string searchText, int? pageNumber, int pageSize)
        {
            if (searchText != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchText = currentFilter;
            }
            var floorList = from m in _context.HotelFloors select m;
            if (!String.IsNullOrEmpty(searchText))
            {
                floorList = floorList.Where(s => s.Name.ToLower().Contains(searchText.ToLower()));
            }
            floorList = sortOrder switch
            {
                "name_desc" => floorList.OrderByDescending(s => s.Name),
                _ => floorList.OrderBy(s => s.Name),
            };
            return await PaginatedList<Floor>.CreateAsync(floorList, pageNumber ?? 1, pageSize);
        }

        public async Task<PaginatedList<Room>> GetRoomList(string sortOrder, string currentFilter, string searchText, int? pageNumber, int pageSize)
        {
            if (searchText != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchText = currentFilter;
            }
            var roomList = from m in _context.HotelRooms select m;
            //if (!String.IsNullOrEmpty(searchText))
            //{
            //    roomList = roomList.Where(s => s.r.ToLower().Contains(searchText.ToLower()));
            //}
            //roomList = sortOrder switch
            //{
            //    "name_desc" => roomList.OrderByDescending(s => s.Name),
            //    _ => roomList.OrderBy(s => s.Name),
            //};
            return await PaginatedList<Room>.CreateAsync(roomList, pageNumber ?? 1, pageSize);
        }
    }
}
