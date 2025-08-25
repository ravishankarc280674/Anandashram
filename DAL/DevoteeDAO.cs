using Anandashram.Core.Enums;
using Anandashram.Core.Models;
using Anandashram.DAL.Interface;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Anandashram.DAL
{
    public class DevoteeDAO: IDevoteeDAO
    {
        private readonly AnandashramContext _context;

        public DevoteeDAO(AnandashramContext dbcontext)
        {
            _context = dbcontext;
        } 
        public List<DevoteeCategory> GetDevoteeCategoryList(SortModel sortModel)
        {
            List<DevoteeCategory> devoteeCategoryList = _context.AshramDevoteeCategories.ToList();
            if (sortModel.SortedProperty.ToLower() == "name")
            {
                if (sortModel.SortedOrder == SortOrder.Ascending)
                    devoteeCategoryList.OrderBy(m => m.Name);
                else
                    devoteeCategoryList.OrderByDescending(m => m.Name);
            }
            return (devoteeCategoryList);
        }


        //public async Task<List<DevoteeCategory>> UpdateDevoteeCategory(int Id, string Name)
        //{
        //    var devoteeCategory = _context.AshramDevoteeCategories.FirstOrDefault(p => p.Id == Id);
        //    if (devoteeCategory != null)
        //    {
        //        devoteeCategory.Name = Name;
        //        _context.AshramDevoteeCategories.Update(devoteeCategory);
        //        _context.SaveChanges();
        //    }
           
        //    return (await GetDevoteeCategoryList());


        //}
    }
}
