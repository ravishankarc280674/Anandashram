namespace Anandashram.Interfaces;
public interface IBlockService
{
    Task<PaginatedList<Block>> GetItems(string sortProperty, SortOrder sortOrder, string searchText, int pageIndex, int pageSize);
    Task<Block> GetBlock(int id);
    Task<(bool Success, string Message, Block Entity)> Create(Block block);
    Task<(bool Success, string Message, Block Entity)> Edit(Block block);
    Task<(bool Success, string Message)> Delete(Block block);
    IEnumerable<Block> GetBlocks();
}
