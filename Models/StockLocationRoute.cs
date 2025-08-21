using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Inventory Routes
/// </summary>
public partial class StockLocationRoute
{
    public int Id { get; set; }

    /// <summary>
    /// Supplier Warehouse
    /// </summary>
    public int? SupplierWhId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Route Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Applicable on Warehouse
    /// </summary>
    public bool? WarehouseSelectable { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Supplied Warehouse
    /// </summary>
    public int? SuppliedWhId { get; set; }

    /// <summary>
    /// Applicable on Product
    /// </summary>
    public bool? ProductSelectable { get; set; }

    /// <summary>
    /// Applicable on Product Category
    /// </summary>
    public bool? ProductCategSelectable { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProcurementRule> ProcurementRules { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<StockLocationPath> StockLocationPaths { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockWarehouse> StockWarehouseCrossdockRoutes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseDeliveryRoutes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseReceptionRoutes { get; set; } = new List<StockWarehouse>();

    public virtual StockWarehouse? SuppliedWh { get; set; }

    public virtual StockWarehouse? SupplierWh { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
