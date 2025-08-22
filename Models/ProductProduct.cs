using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Product
/// </summary>
public partial class ProductProduct
{
    public int Id { get; set; }

    /// <summary>
    /// EAN13 Barcode
    /// </summary>
    public string? Ean13 { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Internal Reference
    /// </summary>
    public string? DefaultCode { get; set; }

    /// <summary>
    /// Template Name
    /// </summary>
    public string? NameTemplate { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Variant Image
    /// </summary>
    public byte[]? ImageVariant { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Is Service id
    /// </summary>
    public bool? Isservice { get; set; }

    /// <summary>
    /// Is categ id
    /// </summary>
    public bool? Iscategid { get; set; }

    /// <summary>
    /// Is Room
    /// </summary>
    public bool? Isroom { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HotelRoomAmenity> HotelRoomAmenities { get; set; } = new List<HotelRoomAmenity>();

    public virtual ICollection<Room> HotelRooms { get; set; } = new List<Room>();

    public virtual ICollection<HotelService> HotelServices { get; set; } = new List<HotelService>();

    public virtual ICollection<MakeProcurement> MakeProcurements { get; set; } = new List<MakeProcurement>();

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ICollection<StockChangeProductQty> StockChangeProductQties { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockInventory> StockInventories { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockMoveScrap> StockMoveScraps { get; set; } = new List<StockMoveScrap>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackOperation> StockPackOperations { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockProductionLot> StockProductionLots { get; set; } = new List<StockProductionLot>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLines { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItems { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }
}
