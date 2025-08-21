using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Inventory Line
/// </summary>
public partial class StockInventoryLine
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
    /// Serial Number Name
    /// </summary>
    public string? ProdlotName { get; set; }

    /// <summary>
    /// Product Name
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Serial Number
    /// </summary>
    public int? ProdLotId { get; set; }

    /// <summary>
    /// Location Name
    /// </summary>
    public string? LocationName { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Inventory
    /// </summary>
    public int? InventoryId { get; set; }

    /// <summary>
    /// Pack
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Checked Quantity
    /// </summary>
    public decimal? ProductQty { get; set; }

    /// <summary>
    /// Theoretical Quantity
    /// </summary>
    public decimal? TheoreticalQty { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUomId { get; set; }

    /// <summary>
    /// Product Code
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockInventory? Inventory { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockQuantPackage? Package { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockProductionLot? ProdLot { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductUom ProductUom { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
