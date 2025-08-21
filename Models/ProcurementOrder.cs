using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Procurement
/// </summary>
public partial class ProcurementOrder
{
    public int Id { get; set; }

    /// <summary>
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUom { get; set; }

    /// <summary>
    /// UoS Quantity
    /// </summary>
    public double? ProductUosQty { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Product UoS
    /// </summary>
    public int? ProductUos { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public string Priority { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateTime DatePlanned { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Rule
    /// </summary>
    public int? RuleId { get; set; }

    /// <summary>
    /// Destination Move
    /// </summary>
    public int? MoveDestId { get; set; }

    /// <summary>
    /// Procurement Location
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Customer Address
    /// </summary>
    public int? PartnerDestId { get; set; }

    /// <summary>
    /// Minimum Stock Rule
    /// </summary>
    public int? OrderpointId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockMove? MoveDest { get; set; }

    public virtual StockWarehouseOrderpoint? Orderpoint { get; set; }

    public virtual ResPartner? PartnerDest { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductUom ProductUomNavigation { get; set; } = null!;

    public virtual ProductUom? ProductUosNavigation { get; set; }

    public virtual ProcurementRule? Rule { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
