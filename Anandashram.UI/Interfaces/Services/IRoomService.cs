using Anandashram.UI.Tools.Core.Models;

public interface IRoomService
{
    Task<PaginatedList<Room>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize);
    Task<Room> GetRoom(int id);
    Task Create(Room room);
    Task<Room> Edit(Room room);
    Task<Room> Delete(Room room);
    Task<Room> GetSelectedRoom(int id);
    bool IsRoomNameExists(string name, int id);
    Task<List<Room>> GetFilteredRooms();

    Task<List<Room>> GeRoomReservations(string SortProperty, SortOrder sortOrder, string SearchText = "");
    Task<List<Room>> GetAllRooms();
}
