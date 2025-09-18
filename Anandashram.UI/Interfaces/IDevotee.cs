namespace Anandashram.Interfaces
{
    public interface IDevotee
    {
        Task<PaginatedList<Devotee>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        Task<Devotee> GetDevotee(int id); // read particular item

        Task<Devotee> Create(Devotee devotee);

        Task<Devotee> Edit(Devotee devotee);

        Task<Devotee> Delete(Devotee devotee);

        bool IsDevoteeNameExists(string name);
        bool IsDevoteeNameExists(string name, int Id);
    }
}
