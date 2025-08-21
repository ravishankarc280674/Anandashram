using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Picking wizard
/// </summary>
public partial class StockTransferDetail
{
    public int Id { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItems { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ResUser? WriteU { get; set; }
}
