using System.Threading.Tasks;

namespace Anandashram.Services;
public class CFormService : ICFormService
{
    private readonly ICForm _repo;
    private readonly IDevotee _devoteeRepo;
    public CFormService(ICForm repo, IDevotee devoteeRepo)
    {
        _repo = repo;
        _devoteeRepo = devoteeRepo;
    }
    public async Task SaveAsync(CForm model)
    =>   await _repo.SaveAsync(model);
    

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

    public async Task<CFormDTO> GetCFormForPrint(int devoteeId)
    {
        string? devoteeCode = null;
        var devotee =await _devoteeRepo.GetDevotee(devoteeId);
        if(devotee != null)
            devoteeCode = devotee.Code;
       return await _repo.GetCFormForPrint(devoteeId,devoteeCode);
    }
}
