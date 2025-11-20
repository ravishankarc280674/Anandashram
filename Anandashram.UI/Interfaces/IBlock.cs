namespace Anandashram.Interfaces;
public interface IBlock
{
    Task<PaginatedList<Block>> GetItems(string SortProperty,SortOrder sortOrder, string SearchText="", int pageIndex = 1, int pageSize = 5); //read all
    Task<Block> GetBlock(int id); // read particular item

    Task<Block> Create(Block block);

    Task<Block> Edit(Block block);

    Task<Block> Delete(Block block);

    bool IsBlockNameExists(string name);
    bool IsBlockNameExists(string name, int Id);
    IEnumerable<Block> GetBlocks();
}
