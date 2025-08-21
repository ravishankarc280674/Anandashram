using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// stock.fixed.putaway.strat
/// </summary>
public partial class StockFixedPutawayStrat
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
    /// Put Away Method
    /// </summary>
    public int PutawayId { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int FixedLocationId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int CategoryId { get; set; }

    public virtual ProductCategory Category { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation FixedLocation { get; set; } = null!;

    public virtual ProductPutaway Putaway { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
