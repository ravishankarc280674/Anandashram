using Anandashram.BAL.Interface;
using Anandashram.DAL.Interface;
using Anandashram.Models;
using Anandashram.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;

namespace Anandashram.BAL
{
    public class InfraStructureBO : IInfraStructureBO
    {
        private readonly IInfraStructureDAO _InfraStructure;

        public InfraStructureBO(IInfraStructureDAO InfraStructure)
        {
            _InfraStructure = InfraStructure;
        }
        public async Task<PaginatedList<Building>> GetBuildingList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize)
        {

            return await _InfraStructure.GetBuildingList(sortOrder, currentFilter, searchString, pageNumber,pageSize);
        }

        public async Task<PaginatedList<Block>> GetBlockList(string sortOrder, string currentFilter, string searchString, int? pageNumber, int pageSize)
        {

            return await _InfraStructure.GetBlockList(sortOrder, currentFilter, searchString, pageNumber, pageSize);
        }
    }
}
