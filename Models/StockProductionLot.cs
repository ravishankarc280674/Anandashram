using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Lot/Serial
/// </summary>
public partial class StockProductionLot
{
    public int Id { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Serial Number
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Internal Reference
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockInventory> StockInventories { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockMoveScrap> StockMoveScraps { get; set; } = new List<StockMoveScrap>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackOperation> StockPackOperations { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItems { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ResUser? WriteU { get; set; }
}
