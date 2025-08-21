using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Inventory Locations
/// </summary>
public partial class StockLocation
{
    public int Id { get; set; }

    public int? ParentLeft { get; set; }

    public int? ParentRight { get; set; }

    /// <summary>
    /// Additional Information
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// Put Away Strategy
    /// </summary>
    public int? PutawayStrategyId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Location
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Removal Strategy
    /// </summary>
    public int? RemovalStrategyId { get; set; }

    /// <summary>
    /// Is a Scrap Location?
    /// </summary>
    public bool? ScrapLocation { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Location Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Location Type
    /// </summary>
    public string Usage { get; set; } = null!;

    /// <summary>
    /// Location Barcode
    /// </summary>
    public string? LocBarcode { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Height (Z)
    /// </summary>
    public int? Posz { get; set; }

    /// <summary>
    /// Corridor (X)
    /// </summary>
    public int? Posx { get; set; }

    /// <summary>
    /// Shelves (Y)
    /// </summary>
    public int? Posy { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Location Name
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockLocation> InverseLocation { get; set; } = new List<StockLocation>();

    public virtual StockLocation? Location { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementRule> ProcurementRuleLocationSrcs { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<ProcurementRule> ProcurementRuleLocations { get; set; } = new List<ProcurementRule>();

    public virtual ProductPutaway? PutawayStrategy { get; set; }

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockFixedPutawayStrat> StockFixedPutawayStrats { get; set; } = new List<StockFixedPutawayStrat>();

    public virtual ICollection<StockInventory> StockInventories { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockLocationPath> StockLocationPathLocationDests { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockLocationPath> StockLocationPathLocationFroms { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockMove> StockMoveLocationDests { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveLocations { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMoveScrap> StockMoveScraps { get; set; } = new List<StockMoveScrap>();

    public virtual ICollection<StockPackOperation> StockPackOperationLocationDests { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockPackOperation> StockPackOperationLocations { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationDests { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPickingType> StockPickingTypeDefaultLocationSrcs { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItemDestinationlocs { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItemSourcelocs { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockWarehouse> StockWarehouseLotStocks { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehouseViewLocations { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhInputStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhOutputStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhPackStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseWhQcStockLocs { get; set; } = new List<StockWarehouse>();

    public virtual ResUser? WriteU { get; set; }
}
