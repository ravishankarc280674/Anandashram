using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Anandashram.DAL.Interface
{
    public interface IDevoteeDAO
    {
        Task<List<DevoteeCategory>> GetDevoteeCategoryList();
        Task<List<DevoteeCategory>> UpdateDevoteeCategory(int Id, string Name);
    }
}
