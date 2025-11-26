namespace Anandashram.Repositories;
public class BlockRepository : IBlock
{
    private readonly ApplicationDbContext _context; // for connecting to efcore.
    public BlockRepository(ApplicationDbContext context) // will be passed by dependency injection.
    {
        _context = context;
    }
    public async Task<Block> Create(Block block)
    {
        _context.Blocks.Add(block);
        await _context.SaveChangesAsync();
        return block;
    }

    public async Task<Block> Delete(Block block)
    {
        _context.Blocks.Attach(block);
        _context.Entry(block).State = EntityState.Deleted;
        await _context.SaveChangesAsync();
        return block;
    }

    public async Task<Block> Edit(Block block)
    {
        _context.Blocks.Attach(block);
        _context.Entry(block).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return block;
    }


    private List<Block> DoSort(List<Block> blocks, string SortProperty, SortOrder sortOrder)
    {

        if (SortProperty.ToLower() == "name")
        {
            if (sortOrder == SortOrder.Ascending)
                blocks = blocks.OrderBy(n => n.Name).ToList();
            else
                blocks = blocks.OrderByDescending(n => n.Name).ToList();
        }
        else
        {
            if (sortOrder == SortOrder.Ascending)
                blocks = blocks.OrderBy(d => d.Description).ToList();
            else
                blocks = blocks.OrderByDescending(d => d.Description).ToList();
        }

        return blocks;
    }
    public async Task<bool> IsExists(string blockName, int excludeId = 0)
    {
        return await _context.Blocks
            .AnyAsync(b => b.Name.ToLower().Trim() == blockName.ToLower().Trim()
                           && b.Id != excludeId);
    }
    public async Task<PaginatedList<Block>> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pg = 1, int pageSize = 5)
    {
        List<Block> blocks;

        if (!string.IsNullOrEmpty(SearchText))
        {
            blocks = await _context.Blocks.Where(n => n.Name.Contains(SearchText) || n.Description.Contains(SearchText))
                .ToListAsync();
        }
        else
            blocks = await _context.Blocks.ToListAsync();

        blocks = DoSort(blocks, SortProperty, sortOrder);

        PaginatedList<Block> retBlocks = new PaginatedList<Block>(blocks, pg, pageSize);
        return retBlocks;
    }

    public async Task<Block> GetBlock(int id)
    {
        Block block = await _context.Blocks.Where(u => u.Id == id).FirstOrDefaultAsync();
        return block;
    }
    public bool IsBlockNameExists(string name)
    {
        int ct = _context.Blocks.Where(n => n.Name.ToLower() == name.ToLower()).Count();
        if (ct > 0)
            return true;
        else
            return false;
    }

    public bool IsBlockNameExists(string name, int Id)
    {
        int ct = _context.Blocks.Where(n => n.Name.ToLower() == name.ToLower() && n.Id != Id).Count();
        if (ct > 0)
            return true;
        else
            return false;
    }

    public IEnumerable<Block> GetBlocks()
    {
        return _context.Blocks.ToList();
    }
}
