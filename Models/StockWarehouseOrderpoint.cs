using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Minimum Inventory Rule
/// </summary>
public partial class StockWarehouseOrderpoint
{
    public int Id { get; set; }

    /// <summary>
    /// Maximum Quantity
    /// </summary>
    public decimal ProductMaxQty { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Qty Multiple
    /// </summary>
    public decimal QtyMultiple { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Reordering Mode
    /// </summary>
    public string Logic { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Minimum Quantity
    /// </summary>
    public decimal ProductMinQty { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
