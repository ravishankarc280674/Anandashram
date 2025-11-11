
using Anandashram.Models;
using Anandashram.UI.Tools.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
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
            else if (SortProperty.ToLower() == "code")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.Code).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.Code).ToList();
            }
            else if (SortProperty.ToLower() == "devoteecategoryname")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.DevoteeCategoryName).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.DevoteeCategoryName).ToList();
            }
            else if (SortProperty.ToLower() == "mobile")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.Mobile).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.Mobile).ToList();
            }
            else if (SortProperty.ToLower() == "email")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.Email).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.Email).ToList();
            }
            else if (SortProperty.ToLower() == "startdate")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.StartDate).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.StartDate).ToList();
            }
            else if (SortProperty.ToLower() == "document")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.Document).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.Document).ToList();
            }
            else if (SortProperty.ToLower() == "enddate")
            {
                if (sortOrder == SortOrder.Ascending)
                    devotees = devotees.OrderBy(n => n.EndDate).ToList();
                else
                    devotees = devotees.OrderByDescending(n => n.EndDate).ToList();
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
            devotees = await GetAllDevotees(Checked);
            if (!string.IsNullOrEmpty(SearchText))
            {
                devotees = devotees.Where(n => n.Code.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                            || n.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                            || (n.Description ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                            || (n.Document ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                            || (n.Email ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                            || (n.Mobile ?? "").Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                                            || n.DevoteeCategory.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            devotees = DoSort(devotees, SortProperty, sortOrder);
            PaginatedList<Devotee> retDevotees = new PaginatedList<Devotee>(devotees, pg, pageSize);
            return retDevotees;
        }

        public async Task<List<Devotee>> GetAllDevotees(bool Checked)
        {
            if (!Checked)
            {
                return await _context.Devotees.Include(d => d.DevoteeCategory).Where(n => n.Closed == false).ToListAsync();
            }
            else
            {
                return await _context.Devotees.Include(d => d.DevoteeCategory).ToListAsync();
            }

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

        public async Task<Devotee> GetDevoteeWithReservations(int devoteeId)
        {
            Devotee devotee = await _context.Devotees.Where(t1 => t1.Id == devoteeId).Include(t1 => t1.DevoteeCategory)
                          .Include(t1 => t1.Reservations).ThenInclude(t2 => t2.Room).ThenInclude(t3 => t3.Building)
                          .Include(t1 => t1.Reservations).ThenInclude(t2 => t2.Room).ThenInclude(t3 => t3.Block)
                          .Include(t1 => t1.Reservations).ThenInclude(t2 => t2.Room).ThenInclude(t3 => t3.Floor)
                          .FirstOrDefaultAsync();
            return devotee;

        }
        public async Task<List<DevoteeReportDTO>> GetDevoteeSummaryByDateAsync(DateTime dateValue)
        {
            DateTime nextDate = dateValue.Date.AddDays(1);

            var result = await _context.Reservations
                .Where(r => !r.Closed
                            && r.ToDate >= dateValue.Date
                            && r.ToDate < nextDate) // ✅ filter by date only
                .GroupBy(r => new
                {
                    r.DevoteeId,
                    r.Devotee.Name,
                    r.Devotee.Code,
                    CategoryName = r.Devotee.DevoteeCategory.Name
                })
                .Select(g => new DevoteeReportDTO
                {
                    Name = g.Key.Name,
                    Code = g.Key.Code,
                    DevoteeCategoryName = g.Key.CategoryName,
                    TotalAllocated = g.Sum(x => x.Allocated)
                })
                .ToListAsync();

            return result;
        }

    }
}
