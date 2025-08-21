using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Packing Operation
/// </summary>
public partial class StockPackOperation
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Destination Package
    /// </summary>
    public int? ResultPackageId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? Currency { get; set; }

    /// <summary>
    /// Source Package
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Cost
    /// </summary>
    public double? Cost { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductQty { get; set; }

    /// <summary>
    /// Lot/Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Quantity Processed
    /// </summary>
    public decimal? QtyDone { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Has been processed?
    /// </summary>
    public string Processed { get; set; } = null!;

    /// <summary>
    /// Stock Picking
    /// </summary>
    public int PickingId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? CurrencyNavigation { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockProductionLot? Lot { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPicking Picking { get; set; } = null!;

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductUom? ProductUom { get; set; }

    public virtual StockQuantPackage? ResultPackage { get; set; }

    public virtual ICollection<StockMoveOperationLink> StockMoveOperationLinks { get; set; } = new List<StockMoveOperationLink>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItems { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ResUser? WriteU { get; set; }
}
