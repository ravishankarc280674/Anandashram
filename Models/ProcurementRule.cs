using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Procurement Rule
/// </summary>
public partial class ProcurementRule
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
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Fixed Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Propagation of Procurement Group
    /// </summary>
    public string? GroupPropagationOption { get; set; }

    /// <summary>
    /// Partner Address
    /// </summary>
    public int? PartnerAddressId { get; set; }

    /// <summary>
    /// Procurement Location
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int? LocationSrcId { get; set; }

    /// <summary>
    /// Picking Type
    /// </summary>
    public int? PickingTypeId { get; set; }

    /// <summary>
    /// Number of Days
    /// </summary>
    public int? Delay { get; set; }

    /// <summary>
    /// Served Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Propagate cancel and split
    /// </summary>
    public bool? Propagate { get; set; }

    /// <summary>
    /// Move Supply Method
    /// </summary>
    public string ProcureMethod { get; set; } = null!;

    /// <summary>
    /// Route Sequence
    /// </summary>
    public decimal? RouteSequence { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Warehouse to Propagate
    /// </summary>
    public int? PropagateWarehouseId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockLocation? Location { get; set; }

    public virtual StockLocation? LocationSrc { get; set; }

    public virtual ResPartner? PartnerAddress { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual StockWarehouse? PropagateWarehouse { get; set; }

    public virtual StockLocationRoute? Route { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; set; } = new List<StockWarehouse>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
