using Anandashram.Core.Enums;
using Anandashram.Core.Models;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.BAL.Interface
{
    public interface IDevoteeBO
    {
        List<DevoteeCategory> GetDevoteeCategoryList(SortModel sortModel);
    }
}
