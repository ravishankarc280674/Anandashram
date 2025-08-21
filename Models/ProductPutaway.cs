using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Put Away Strategy
/// </summary>
public partial class ProductPutaway
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Method
    /// </summary>
    public string Method { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockFixedPutawayStrat> StockFixedPutawayStrats { get; set; } = new List<StockFixedPutawayStrat>();

    public virtual ICollection<StockLocation> StockLocations { get; set; } = new List<StockLocation>();

    public virtual ResUser? WriteU { get; set; }
}
