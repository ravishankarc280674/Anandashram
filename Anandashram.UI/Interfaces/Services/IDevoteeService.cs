namespace Anandashram.Interfaces.Services;
public interface IDevoteeService
{
    Task<PaginatedList<Devotee>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize, bool closed = false);
    Task<Devotee> GetDevoteeWithReservations(int devoteeId);
    Task<Devotee> GetDevotee(int id);
    Task<Devotee> Create(Devotee devotee);
    Task<Devotee> Edit(Devotee devotee);
    Task<Devotee> Delete(Devotee devotee);
}