using System.Threading.Tasks;

namespace Anandashram.Repositories
{
    public class DevoteeCategoryRepository : IDevoteeCategory
    {
        private readonly ApplicationDbContext _context; // for connecting to efcore.
        public DevoteeCategoryRepository(ApplicationDbContext context) // will be passed by dependency injection.
        {
            _context = context;
        }
        public async Task<DevoteeCategory> Create(DevoteeCategory devoteeCategory)
        {
            _context.DevoteeCategories.Add(devoteeCategory);
           await _context.SaveChangesAsync();
            return devoteeCategory;
        }

        public async Task<DevoteeCategory> Delete(DevoteeCategory devoteeCategory)
        {
            _context.DevoteeCategories.Attach(devoteeCategory);
            _context.Entry(devoteeCategory).State = EntityState.Deleted;
           await _context.SaveChangesAsync();
            return devoteeCategory;
        }

        public async Task<DevoteeCategory> Edit(DevoteeCategory devoteeCategory)
        {
            _context.DevoteeCategories.Attach(devoteeCategory);
            _context.Entry(devoteeCategory).State = EntityState.Modified;
           await _context.SaveChangesAsync();
            return devoteeCategory;
        }


        private List<DevoteeCategory> DoSort(List<DevoteeCategory> devoteeCategories, string SortProperty, SortOrder sortOrder)
        {           

            if (SortProperty.ToLower() == "name")
            {
                if (sortOrder == SortOrder.Ascending)
                    devoteeCategories = devoteeCategories.OrderBy(n => n.Name).ToList();
                else
                    devoteeCategories = devoteeCategories.OrderByDescending(n => n.Name).ToList();
            }
            else
            {
                if (sortOrder == SortOrder.Ascending)
                    devoteeCategories = devoteeCategories.OrderBy(d => d.Description).ToList();
                else
                    devoteeCategories = devoteeCategories.OrderByDescending(d => d.Description).ToList();
            }

            return devoteeCategories;
        }

        public async Task<PaginatedList<DevoteeCategory>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5)
        {
            List<DevoteeCategory> devoteeCategories;

            if (!string.IsNullOrEmpty(SearchText))
            {
                devoteeCategories =await _context.DevoteeCategories.Where(n => n.Name.Contains(SearchText) || n.Description.Contains(SearchText))
                    .ToListAsync();
            }
            else
                devoteeCategories =await _context.DevoteeCategories.ToListAsync();

            devoteeCategories = DoSort(devoteeCategories, SortProperty, sortOrder);

            PaginatedList<DevoteeCategory> retDevoteeCategorys = new PaginatedList<DevoteeCategory>(devoteeCategories,pg,pageSize);
            return retDevoteeCategorys;
        }

        public async Task<DevoteeCategory> GetDevoteeCategory(int id)
        {
            DevoteeCategory devoteeCategory =await _context.DevoteeCategories.Where(u => u.Id == id).FirstOrDefaultAsync();
            return devoteeCategory;
        }
        public bool IsDevoteeCategoryNameExists(string name)
        {
            int ct = _context.DevoteeCategories.Where(n => n.Name.ToLower() == name.ToLower()).Count();
            if (ct > 0)
                return true;
            else
                return false;      
        }

        public bool IsDevoteeCategoryNameExists(string name,int Id)
        {
            int ct = _context.DevoteeCategories.Where(n => n.Name.ToLower() == name.ToLower() && n.Id!=Id).Count();
            if (ct > 0)
                return true;
            else
                return false;
        }
        public IEnumerable<DevoteeCategory> GetDevoteeCategories()
        {
            return _context.DevoteeCategories.ToList();
        }
    }
}
