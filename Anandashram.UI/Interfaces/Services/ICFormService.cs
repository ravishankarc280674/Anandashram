namespace Anandashram.Interfaces.Services;
public interface ICFormService
{
    Task<CForm?> GetAsync(int devoteeId);
    Task SaveAsync(CForm model);
    Task<CFormDTO> GetCFormForPrint(int devoteeId);
}
