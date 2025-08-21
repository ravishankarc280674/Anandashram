using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Scrap Products
/// </summary>
public partial class StockMoveScrap
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUom { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Lot
    /// </summary>
    public int? RestrictLotId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductUom ProductUomNavigation { get; set; } = null!;

    public virtual StockProductionLot? RestrictLot { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
