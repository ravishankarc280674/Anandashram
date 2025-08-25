using Anandashram.BAL.Interface;
using Anandashram.DAL.Interface;
using Anandashram.Core.Enums;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;
using Anandashram.Core.Models;

namespace Anandashram.BAL
{
    public class DevoteeBO : IDevoteeBO
    {
        private readonly IDevoteeDAO _Devotee;

        public DevoteeBO(IDevoteeDAO Devotee)
        {
            _Devotee = Devotee;
        }
        public List<DevoteeCategory> GetDevoteeCategoryList(SortModel sortModel)
        {

            return _Devotee.GetDevoteeCategoryList(sortModel);
        }

        //public async Task<List<DevoteeCategory>> UpdateDevoteeCategory(int Id, string Name)
        //{
        //    return await _Devotee.UpdateDevoteeCategory(Id, Name);
        //}
    }
}
