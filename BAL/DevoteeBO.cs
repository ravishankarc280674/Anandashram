using Anandashram.BAL.Interface;
using Anandashram.DAL.Interface;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace Anandashram.BAL
{
    public class DevoteeBO : IDevoteeBO
    {
        private readonly IDevoteeDAO _Devotee;

        public DevoteeBO(IDevoteeDAO Devotee)
        {
            _Devotee = Devotee;
        }
        public async Task<PaginatedList<DevoteeCategory>> GetDevoteeCategoryList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize)
        {

            return await _Devotee.GetDevoteeCategoryList(sortOrder, currentFilter, searchString, pageNumber,pageSize);
        }
    }
}
