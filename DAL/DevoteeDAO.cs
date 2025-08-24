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
        public async Task<List<DevoteeCategory>> GetDevoteeCategoryList()
        {
            return (await _context.AshramDevoteeCategories.ToListAsync());
        }


        public async Task<List<DevoteeCategory>> UpdateDevoteeCategory(int Id, string Name)
        {
            var devoteeCategory = _context.AshramDevoteeCategories.FirstOrDefault(p => p.Id == Id);
            if (devoteeCategory != null)
            {
                devoteeCategory.Name = Name;
                _context.AshramDevoteeCategories.Update(devoteeCategory);
                _context.SaveChanges();
            }
           
            return (await GetDevoteeCategoryList());


        }
    }
}
