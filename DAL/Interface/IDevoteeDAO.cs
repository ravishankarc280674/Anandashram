using Anandashram.Core.Enums;
using Anandashram.Core.Models;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.DAL.Interface
{
    public interface IDevoteeDAO
    {
        List<DevoteeCategory> GetDevoteeCategoryList(SortModel sortModel);
       // Task<List<DevoteeCategory>> UpdateDevoteeCategory(int Id, string Name);
    }
}
