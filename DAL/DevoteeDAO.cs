using Anandashram.DAL.Interface;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Anandashram.DAL
{
    public class DevoteeDAO: IDevoteeDAO
    {
        private readonly AnandashramContext _context;

        public DevoteeDAO(AnandashramContext dbcontext)
        {
            _context = dbcontext;
        } 
        public async Task<PaginatedList<DevoteeCategory>> GetDevoteeCategoryList(string sortOrder, string currentFilter, string searchText, int? pageNumber, int pageSize)
        {
            if (searchText != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchText = currentFilter;
            }
            var devoteeCategoryList = from m in _context.AshramDevoteeCategories select m;
            if (!String.IsNullOrEmpty(searchText))
            {
                devoteeCategoryList = devoteeCategoryList.Where(s => s.Name.ToLower().Contains(searchText.ToLower()));
            }
            devoteeCategoryList = sortOrder switch
            {
                "name_desc" => devoteeCategoryList.OrderByDescending(s => s.Name),
                                _ => devoteeCategoryList.OrderBy(s => s.Name),
            };
            return await PaginatedList<DevoteeCategory>.CreateAsync(devoteeCategoryList, pageNumber ?? 1, pageSize);
        }
    }
}
