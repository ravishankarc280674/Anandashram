using Anandashram.Models;
using Anandashram.Shared;

namespace Anandashram.DAL.Interface
{
    public interface IDevoteeDAO
    {
        Task<PaginatedList<DevoteeCategory>> GetDevoteeCategoryList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize);
    }
}
