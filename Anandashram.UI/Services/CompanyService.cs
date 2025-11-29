namespace Anandashram.Services;

public class CompanyService : ICompanyService
{
    private readonly ICompany _repo;

    public CompanyService(ICompany repo)
    {
        _repo = repo;
    }

    public Company CompanyDetails()
    {
        return _repo.CompanyDetails();
    }

    public Company SaveCompany(Company company)
    {
        return _repo.SaveCompany(company);
    }
}
