using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Stock Move
/// </summary>
public partial class StockMove
{
    public int Id { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Quantity (UOS)
    /// </summary>
    public decimal? ProductUosQty { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Destination Move
    /// </summary>
    public int? MoveDestId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int ProductUom { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public double? PriceUnit { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductUomQty { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? ProductQty { get; set; }

    /// <summary>
    /// Product UOS
    /// </summary>
    public int? ProductUos { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Picking Type
    /// </summary>
    public int? PickingTypeId { get; set; }

    /// <summary>
    /// Destination Address 
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Origin return move
    /// </summary>
    public int? OriginReturnedMoveId { get; set; }

    /// <summary>
    /// Prefered Packaging
    /// </summary>
    public int? ProductPackaging { get; set; }

    /// <summary>
    /// Expected Date
    /// </summary>
    public DateTime DateExpected { get; set; }

    /// <summary>
    /// Procurement
    /// </summary>
    public int? ProcurementId { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Inventory
    /// </summary>
    public int? InventoryId { get; set; }

    /// <summary>
    /// Partially Available
    /// </summary>
    public bool? PartiallyAvailable { get; set; }

    /// <summary>
    /// Propagate cancel and split
    /// </summary>
    public bool? Propagate { get; set; }

    /// <summary>
    /// Owner 
    /// </summary>
    public int? RestrictPartnerId { get; set; }

    /// <summary>
    /// Supply Method
    /// </summary>
    public string ProcureMethod { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Lot
    /// </summary>
    public int? RestrictLotId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Move Split From
    /// </summary>
    public int? SplitFrom { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Push Rule
    /// </summary>
    public int? PushRuleId { get; set; }

    /// <summary>
    /// Procurement Rule
    /// </summary>
    public int? RuleId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual StockInventory? Inventory { get; set; }

    public virtual ICollection<StockMove> InverseMoveDest { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> InverseOriginReturnedMove { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> InverseSplitFromNavigation { get; set; } = new List<StockMove>();

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockMove? MoveDest { get; set; }

    public virtual StockMove? OriginReturnedMove { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPicking? Picking { get; set; }

    public virtual StockPickingType? PickingType { get; set; }

    public virtual ProcurementOrder? Procurement { get; set; }

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductPackaging? ProductPackagingNavigation { get; set; }

    public virtual ProductUom ProductUomNavigation { get; set; } = null!;

    public virtual ProductUom? ProductUosNavigation { get; set; }

    public virtual StockLocationPath? PushRule { get; set; }

    public virtual StockProductionLot? RestrictLot { get; set; }

    public virtual ResPartner? RestrictPartner { get; set; }

    public virtual ProcurementRule? Rule { get; set; }

    public virtual StockMove? SplitFromNavigation { get; set; }

    public virtual ICollection<StockMoveOperationLink> StockMoveOperationLinks { get; set; } = new List<StockMoveOperationLink>();

    public virtual ICollection<StockQuant> StockQuantNegativeMoves { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockQuant> StockQuantReservations { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
