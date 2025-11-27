namespace Anandashram.Interfaces.Services
{
    public interface ICompanyService
    {
        Company CompanyDetails();
        Company SaveCompany(Company company);
    }
}
