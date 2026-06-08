using System.Threading.Tasks;

namespace Anandashram.Services;
public class CFormService : ICFormService
{
    private readonly ICForm _repo;

    public CFormService(ICForm repo)
    {
        _repo = repo;
    }
    public async Task SaveAsync(CForm model)
    {
        var existing = await _repo.GetByDevoteeIdAsync(model.DevoteeId);

        if (existing == null)
            await _repo.InsertAsync(model);
        else
        {
            model.Id = existing.Id;
            await _repo.UpdateAsync(model);
        }

    }
    public async Task<CForm?> GetAsync(int devoteeId)
    {
        var cform = await _repo.GetByDevoteeIdAsync(devoteeId);

        if (cform != null)
            return cform;


        // If CForm not exists create new

        var devotee = await _repo.GetDevoteeAsync(devoteeId);

        cform = new CForm
        {
            DevoteeId = devoteeId,

            FirstName = devotee?.Name,
            Nationality = devotee?.Country,

            Address = devotee?.AddressLine1,
            City = devotee?.State,
            Country = devotee?.Country,
            PassportNo = devotee?.Document
        };

        return cform;
    }

}
