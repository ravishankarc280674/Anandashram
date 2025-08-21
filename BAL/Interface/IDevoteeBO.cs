using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.BAL.Interface
{
    public interface IDevoteeBO
    {
        Task<PaginatedList<DevoteeCategory>> GetDevoteeCategoryList(string sortOrder, string currentFilter, string searchString, int? pageNumber,int pageSize);
    }
}
