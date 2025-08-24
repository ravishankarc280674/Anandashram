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
        public async Task<List<DevoteeCategory>> GetDevoteeCategoryList()
        {

            return await _Devotee.GetDevoteeCategoryList();
        }

        public async Task<List<DevoteeCategory>> UpdateDevoteeCategory(int Id, string Name)
        {
            return await _Devotee.UpdateDevoteeCategory(Id, Name);
        }
    }
}
