using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Procurement Requisition
/// </summary>
public partial class ProcurementGroup
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
    /// Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Delivery Method
    /// </summary>
    public string MoveType { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementRule> ProcurementRules { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }
}
