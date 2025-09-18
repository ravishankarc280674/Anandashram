namespace Anandashram.Interfaces
{
    public interface IRoom
    {
        Task<PaginatedList<Room>> GetItems(string SortProperty,SortOrder sortOrder, string SearchText="", int pageIndex = 1, int pageSize = 5); //read all
        Task<Room> GetRoom(int id); // read particular item

        Task<Room> Create(Room room);

        Task<Room> Edit(Room room);

        Task<Room> Delete(Room room);

        bool IsRoomNameExists(string name);
        bool IsRoomNameExists(string name, int Id);


    }
}
