using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Change Product Quantity
/// </summary>
public partial class StockChangeProductQty
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
    public int? ProductId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// New Quantity on Hand
    /// </summary>
    public decimal NewQuantity { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockProductionLot? Lot { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
