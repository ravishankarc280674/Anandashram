namespace Anandashram.Services;
public class RoomService : IRoomService
{
    private readonly IRoom _repo;

    public RoomService(IRoom repo)
    {
        _repo = repo;
    }

    public async Task<PaginatedList<Room>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize)
    => await _repo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize);

    public async Task<Room> GetRoom(int id)
    {
        return await _repo.GetRoom(id);
    }

    public async Task Create(Room room)
    =>   await _repo.Create(room);

    public async Task<Room> Edit(Room room)
    =>  await _repo.Edit(room);

    public async Task<Room> Delete(Room room)
    => await _repo.Delete(room);

    public bool IsRoomNameExists(string name, int id)
    => _repo.IsRoomNameExists(name, id);

    public async Task<List<Room>> GeRoomReservations(string SortProperty, SortOrder sortOrder, string SearchText = "")
    => await _repo.GeRoomReservations(SortProperty, sortOrder, SearchText);

    public async Task<Room> GetSelectedRoom(int id)
    =>await _repo.GetSelectedRoom(id);

    public async Task<List<Room>> GetFilteredRooms()
    =>await _repo.GetFilteredRooms();    

public async Task<List<Room>> GetAllRooms()
    => await _repo.GetAllRooms();
}
