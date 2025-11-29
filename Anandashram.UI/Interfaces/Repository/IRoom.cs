namespace Anandashram.Interfaces.Repository;
public interface IRoom
{
    Task<PaginatedList<Room>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
    Task<Room> GetRoom(int id); // read particular item
    Task<Room> Create(Room room);
    Task<Room> Edit(Room room);
    Task<Room> Delete(Room room);
    bool IsRoomNameExists(string name);
    bool IsRoomNameExists(string name, int Id);
    Task<List<Room>> GetFilteredRooms();
    Task<Room> GetSelectedRoom(int id);
    Task<List<Room>> GeRoomReservations(string SortProperty, SortOrder sortOrder, string SearchText = "");
    Task<List<Room>> GetAllRoomReservations(string SearchText = "");
    Task<List<RoomReportDTO>> GetRoomsUpToDateAsync(DateTime dateValue);
    Task<List<RoomReportDTO>> GetRoomsWithReservationsUpToDateAsync(DateTime dateValue);
    Task<List<RoomDTO>> GetRooms();
    Task<List<ReservationReportDTO>> GetCheckInDetailsReportAsync(DateTime dateValue);
    Task<List<Room>> GetRoomsList(string SearchText);
}
