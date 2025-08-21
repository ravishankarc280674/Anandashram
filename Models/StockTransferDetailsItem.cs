using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Picking wizard items
/// </summary>
public partial class StockTransferDetailsItem
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
    /// Source Location
    /// </summary>
    public int SourcelocId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int DestinationlocId { get; set; }

    /// <summary>
    /// Destination package
    /// </summary>
    public int? ResultPackageId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int? ProductUomId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Source package
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Operation
    /// </summary>
    public int? PackopId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Transfer
    /// </summary>
    public int? TransferId { get; set; }

    /// <summary>
    /// Lot/Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Destinationloc { get; set; } = null!;

    public virtual StockProductionLot? Lot { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual StockPackOperation? Packop { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductUom? ProductUom { get; set; }

    public virtual StockQuantPackage? ResultPackage { get; set; }

    public virtual StockLocation Sourceloc { get; set; } = null!;

    public virtual StockTransferDetail? Transfer { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
