using Anandashram.Interfaces.Repository;
using Anandashram.UI.Tools.Core.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;

public class RoomService : IRoomService
{
    private readonly IRoom _repo;

    public RoomService(IRoom repo)
    {
        _repo = repo;
    }

    public async Task<PaginatedList<Room>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize)
    {
        return await _repo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize);
    }

    public async Task<Room> GetRoom(int id)
    {
        return await _repo.GetRoom(id);
    }

    public async Task Create(Room room)
    {
        await _repo.Create(room);
    }

    public async Task<Room> Edit(Room room)
    {
        return await _repo.Edit(room);
    }

    public async Task<Room> Delete(Room room)
    {
        return await _repo.Delete(room);
    }

    public bool IsRoomNameExists(string name, int id)
    {
        return _repo.IsRoomNameExists(name, id);
    }

    public Task<List<Room>> GeRoomReservations(string SortProperty, SortOrder sortOrder, string SearchText = "")
    {
        return _repo.GeRoomReservations(SortProperty, sortOrder, SearchText);
    }

    public Room GetSelectedRoom(int id)
    {
        return _repo.GetSelectedRoom(id);
    }

    public List<Room> GetFilteredRooms()
    {
        return _repo.GetFilteredRooms();    
    }
}
