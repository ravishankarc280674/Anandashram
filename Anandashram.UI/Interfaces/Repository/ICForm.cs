namespace Anandashram.Interfaces.Repository;
public interface ICForm
{
    Task<Devotee?> GetDevoteeAsync(int devoteeId);
    Task<CForm?> GetByDevoteeIdAsync(int devoteeId);
    Task<CForm> SaveAsync(CForm model);
    Task<CFormDTO> GetCFormForPrint(int devoteeId, string devoteeCode);
}
