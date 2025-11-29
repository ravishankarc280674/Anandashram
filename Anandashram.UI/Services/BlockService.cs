using System.Threading.Tasks;

namespace Anandashram.Services;
public class BlockService : IBlockService
{
    private readonly IBlock _repo;

    public BlockService(IBlock repo)
    {
        _repo = repo;
    }

    public Task<PaginatedList<Block>> GetItems(string sortProperty, SortOrder sortOrder,
        string searchText, int pageIndex, int pageSize)
        => _repo.GetItems(sortProperty, sortOrder, searchText, pageIndex, pageSize);

    public async Task<Block?> GetBlock(int id)
        =>await _repo.GetBlock(id);

    public async Task<IEnumerable<Block>> GetBlocks()
        =>await _repo.GetBlocks();

    public async Task<(bool Success, string Message, Block? Entity)> Create(Block block)
    {
        // Example validation
        if (await _repo.IsExists(block.Name))
            return (false, "Block name already exists!", null);

        var created = await _repo.Create(block);
        return (true, "Block created", created);
    }

    public async Task<(bool Success, string Message, Block? Entity)> Edit(Block block)
    {
        var edited = await _repo.Edit(block);
        return (true, "Successfully updated", edited);
    }

    public async Task<(bool Success, string Message)> Delete(Block block)
    {
        await _repo.Delete(block);
        return (true, "Deleted successfully");
    }
}
