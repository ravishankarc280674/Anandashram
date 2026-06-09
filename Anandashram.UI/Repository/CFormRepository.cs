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
    
    public async Task<CForm> SaveAsync(CForm model)
    {
        var existing = await _context.CForms
            .FirstOrDefaultAsync(x => x.DevoteeId == model.DevoteeId);

        if (existing == null)
        {
            await _context.CForms.AddAsync(model);
        }
        else
        {
            // Preserve existing record identity
            model.Id = existing.Id;

            _context.Entry(existing).CurrentValues.SetValues(model);
        }

        await _context.SaveChangesAsync();

        return model;
    }
}
