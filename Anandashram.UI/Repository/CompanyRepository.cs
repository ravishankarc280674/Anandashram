namespace Anandashram.Repository;
public class CompanyRepository:ICompany
{

    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public CompanyRepository(ApplicationDbContext context, IConfiguration configuration) // will be passed by dependency injection.
    {
        _context = context;
    }

    public Company CompanyDetails()
    {
        Company company = _context.Company.FirstOrDefault();
        if(company != null) 
            return company;
        else
            return new Company();
    }

    public Company SaveCompany(Company company)
    {
        if (company.Id == 0)
        {
            _context.Company.Add(company);
            _context.SaveChanges();
        }
        else
        {
            _context.Company.Attach(company);
            _context.Entry(company).State = EntityState.Modified;
            _context.SaveChanges();
        }
        return company;
    }
}
