using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Return Picking
/// </summary>
public partial class StockReturnPicking
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
    /// Chained Move Exists
    /// </summary>
    public bool? MoveDestExists { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual ResUser? WriteU { get; set; }
}
