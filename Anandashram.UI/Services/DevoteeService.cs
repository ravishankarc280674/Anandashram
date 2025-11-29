namespace Anandashram.Services;
public class DevoteeService : IDevoteeService
{
    private readonly IDevotee _devoteeRepo;

    public DevoteeService(IDevotee devoteeRepo)
    {
        _devoteeRepo = devoteeRepo;
    }

    public async Task<PaginatedList<Devotee>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize, bool closed = false)
    {
        // pass-through for now — add caching/validation/business rules here later
        return await _devoteeRepo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize, closed);
    }

    public async Task<Devotee> GetDevoteeWithReservations(int devoteeId)
    {
        return await _devoteeRepo.GetDevoteeWithReservations(devoteeId);
    }

    public async Task<Devotee> GetDevotee(int id)
    {
        return await _devoteeRepo.GetDevotee(id);
    }

    public async Task<Devotee> Create(Devotee devotee)
    {
        // place to add validation or pre-processing (e.g., trim strings, apply defaults)
        return await _devoteeRepo.Create(devotee);
    }

    public async Task<Devotee> Edit(Devotee devotee)
    {
        return await _devoteeRepo.Edit(devotee);
    }
    public async Task<Devotee> Delete(Devotee devotee)
    {
        return await _devoteeRepo.Delete(devotee);
    }

}
