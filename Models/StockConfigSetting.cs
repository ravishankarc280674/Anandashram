using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// stock.config.settings
/// </summary>
public partial class StockConfigSetting
{
    public int Id { get; set; }

    /// <summary>
    /// Manage different units of measure for products
    /// </summary>
    public bool? GroupUom { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Generate procurement in real time
    /// </summary>
    public bool? ModuleProcurementJit { get; set; }

    /// <summary>
    /// Allow to define several packaging methods on products
    /// </summary>
    public bool? GroupStockPackaging { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Allow claim on deliveries
    /// </summary>
    public bool? ModuleClaimFromDelivery { get; set; }

    /// <summary>
    /// Manage multiple locations and warehouses
    /// </summary>
    public bool? GroupStockMultipleLocations { get; set; }

    /// <summary>
    /// Manage picking wave
    /// </summary>
    public bool? ModuleStockPickingWave { get; set; }

    /// <summary>
    /// Decimal precision on weight
    /// </summary>
    public int? DecimalPrecision { get; set; }

    /// <summary>
    /// Expiry date on serial numbers
    /// </summary>
    public bool? ModuleProductExpiry { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Manage advanced routes for your warehouse
    /// </summary>
    public bool? GroupStockAdvLocation { get; set; }

    /// <summary>
    /// Use packages: pallets, boxes, ...
    /// </summary>
    public bool? GroupStockTrackingLot { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Track lots or serial numbers
    /// </summary>
    public bool? GroupStockProductionLot { get; set; }

    /// <summary>
    /// Manage dropshipping
    /// </summary>
    public bool? ModuleStockDropshipping { get; set; }

    /// <summary>
    /// Manage owner on stock
    /// </summary>
    public bool? GroupStockTrackingOwner { get; set; }

    /// <summary>
    /// Store products in a different unit of measure than the sales order
    /// </summary>
    public bool? GroupUos { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
