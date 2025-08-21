using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Warehouse
/// </summary>
public partial class StockWarehouse
{
    public int Id { get; set; }

    /// <summary>
    /// Crossdock Route
    /// </summary>
    public int? CrossdockRouteId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Location Stock
    /// </summary>
    public int LotStockId { get; set; }

    /// <summary>
    /// Packing Location
    /// </summary>
    public int? WhPackStockLocId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Pick Type
    /// </summary>
    public int? PickTypeId { get; set; }

    /// <summary>
    /// Short Name
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Address
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// MTO rule
    /// </summary>
    public int? MtoPullId { get; set; }

    /// <summary>
    /// Receipt Route
    /// </summary>
    public int? ReceptionRouteId { get; set; }

    /// <summary>
    /// Input Location
    /// </summary>
    public int? WhInputStockLocId { get; set; }

    /// <summary>
    /// Outgoing Shippings
    /// </summary>
    public string DeliverySteps { get; set; } = null!;

    /// <summary>
    /// Default Resupply Warehouse
    /// </summary>
    public int? DefaultResupplyWhId { get; set; }

    /// <summary>
    /// View Location
    /// </summary>
    public int ViewLocationId { get; set; }

    /// <summary>
    /// Quality Control Location
    /// </summary>
    public int? WhQcStockLocId { get; set; }

    /// <summary>
    /// Incoming Shipments
    /// </summary>
    public string ReceptionSteps { get; set; } = null!;

    /// <summary>
    /// Resupply From Other Warehouses
    /// </summary>
    public bool? ResupplyFromWh { get; set; }

    /// <summary>
    /// Pack Type
    /// </summary>
    public int? PackTypeId { get; set; }

    /// <summary>
    /// Output Location
    /// </summary>
    public int? WhOutputStockLocId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Delivery Route
    /// </summary>
    public int? DeliveryRouteId { get; set; }

    /// <summary>
    /// Warehouse Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// In Type
    /// </summary>
    public int? InTypeId { get; set; }

    /// <summary>
    /// Out Type
    /// </summary>
    public int? OutTypeId { get; set; }

    /// <summary>
    /// Internal Type
    /// </summary>
    public int? IntTypeId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocationRoute? CrossdockRoute { get; set; }

    public virtual ICollection<CurrencyExchange> CurrencyExchanges { get; set; } = new List<CurrencyExchange>();

    public virtual StockWarehouse? DefaultResupplyWh { get; set; }

    public virtual StockLocationRoute? DeliveryRoute { get; set; }

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();

    public virtual StockPickingType? InType { get; set; }

    public virtual StockPickingType? IntType { get; set; }

    public virtual ICollection<StockWarehouse> InverseDefaultResupplyWh { get; set; } = new List<StockWarehouse>();

    public virtual StockLocation LotStock { get; set; } = null!;

    public virtual ICollection<MakeProcurement> MakeProcurements { get; set; } = new List<MakeProcurement>();

    public virtual ICollection<MealReservation> MealReservations { get; set; } = new List<MealReservation>();

    public virtual ProcurementRule? MtoPull { get; set; }

    public virtual StockPickingType? OutType { get; set; }

    public virtual StockPickingType? PackType { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPickingType? PickType { get; set; }

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementRule> ProcurementRulePropagateWarehouses { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<ProcurementRule> ProcurementRuleWarehouses { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservations { get; set; } = new List<QuickRoomReservation>();

    public virtual StockLocationRoute? ReceptionRoute { get; set; }

    public virtual ICollection<StockLocationPath> StockLocationPaths { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockLocationRoute> StockLocationRouteSuppliedWhs { get; set; } = new List<StockLocationRoute>();

    public virtual ICollection<StockLocationRoute> StockLocationRouteSupplierWhs { get; set; } = new List<StockLocationRoute>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPickingType> StockPickingTypes { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual StockLocation ViewLocation { get; set; } = null!;

    public virtual StockLocation? WhInputStockLoc { get; set; }

    public virtual StockLocation? WhOutputStockLoc { get; set; }

    public virtual StockLocation? WhPackStockLoc { get; set; }

    public virtual StockLocation? WhQcStockLoc { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
