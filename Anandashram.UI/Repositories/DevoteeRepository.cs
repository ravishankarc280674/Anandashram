
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using SQLitePCL;

namespace Anandashram.Repositories
{
    public class DevoteeRepository : IDevotee
    {
        private readonly ApplicationDbContext _context; // for connecting to efcore.
        public DevoteeRepository(ApplicationDbContext context, IConfiguration configuration) // will be passed by dependency injection.
        {
            _context = context;
        }
        public async Task<Devotee> Create(Devotee devotee)
        {
            _context.Devotees.Add(devotee);
            await _context.SaveChangesAsync();
            return devotee;
        }

        public async Task<Devotee> Delete(Devotee devotee)
        {
            _context.Devotees.Attach(devotee);
            _context.Entry(devotee).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return devotee;
        }

        public async Task<Devotee> Edit(Devotee devotee)
        {
            _context.Devotees.Attach(devotee);
            _context.Entry(devotee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return devotee;
        }


        private List<Devotee> DoSort(List<Devotee> devotees, string SortProperty, SortOrder sortOrder)
        {

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.Name).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.Name).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(d => d.Description).ToList();
                else
                    devotees = devotees.OrderByDescending(d => d.Description).ToList();
            }

            return devotees;
        }

        public async Task<PaginatedList<Devotee>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5, bool Checked = false)
        {
            List<Devotee> devotees = new List<Devotee>();

            if (!Checked)
            {
                devotees = await _context.Devotees.Include(d => d.DevoteeCategory).Where(n => n.Closed == false).ToListAsync();
            }
            else
            {
                devotees = await _context.Devotees.Include(d => d.DevoteeCategory).ToListAsync();
            }
                if (!string.IsNullOrEmpty(SearchText))
                {
                    devotees = devotees.Where(n => n.Code.Contains(SearchText, StringComparison.OrdinalIgnoreCase) 
                                                || n.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase) 
                                                || (n.Description ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                                || (n.Document ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                                || (n.Email ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                                || (n.Mobile ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                                || n.DevoteeCategory.Name.Contains(SearchText,StringComparison.OrdinalIgnoreCase)).ToList();
                }
            devotees = DoSort(devotees, SortProperty, sortOrder);
            PaginatedList<Devotee> retDevotees = new PaginatedList<Devotee>(devotees, pg, pageSize);
            return retDevotees;
        }

        public async Task<Devotee> GetDevotee(int id)
        {
            Devotee devotee = await _context.Devotees.Where(u => u.Id == id).FirstOrDefaultAsync();
            return devotee == null ? new Devotee() : devotee;
        }
       
    public bool IsDevoteeNameExists(string name)
        {
            int ct = _context.Devotees.Where(n => n.Name.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public bool IsDevoteeNameExists(string name, int Id)
        {
            int ct = _context.Devotees.Where(n => n.Name.ToLower() == name.ToLower() && n.Id != Id).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }

        public IEnumerable<Devotee> GetDevotees()
        {
            return _context.Devotees.ToList();
        }
        
       
    }
}
