namespace Anandashram.Repository;

public class CFormRepository : ICForm
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public CFormRepository(ApplicationDbContext context) // will be passed by dependency injection.
    {
        _context = context;
    }
    public async Task<Devotee?> GetDevoteeAsync(int devoteeId)
        => await _context.Devotees.FirstOrDefaultAsync(x => x.Id == devoteeId);
    public async Task<CForm?> GetByDevoteeIdAsync(int devoteeId)
        => await _context.CForms.FirstOrDefaultAsync(x => x.DevoteeId == devoteeId);
    public async Task InsertAsync(CForm model)
    {
        _context.CForms.Add(model);
        await _context.SaveChangesAsync();
    }

    public Task UpdateAsync(CForm model)
    {
        throw new NotImplementedException();
    }
}
