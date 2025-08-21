using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Inventory
/// </summary>
public partial class StockInventory
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
    /// Inventory Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Inventoried Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Inventoried Lot/Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Inventory Date
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Inventoried Pack
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Inventoried Owner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Inventory of
    /// </summary>
    public string Filter { get; set; } = null!;

    /// <summary>
    /// Inventoried Product
    /// </summary>
    public int? ProductId { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockProductionLot? Lot { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }
}
