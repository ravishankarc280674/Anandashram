using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Physical Packages
/// </summary>
public partial class StockQuantPackage
{
    public int Id { get; set; }

    public int? ParentLeft { get; set; }

    public int? ParentRight { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Package Reference
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Logistic Unit
    /// </summary>
    public int? UlId { get; set; }

    /// <summary>
    /// Parent Package
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Packaging
    /// </summary>
    public int? PackagingId { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int? LocationId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockQuantPackage> InverseParent { get; set; } = new List<StockQuantPackage>();

    public virtual StockLocation? Location { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual ProductPackaging? Packaging { get; set; }

    public virtual StockQuantPackage? Parent { get; set; }

    public virtual ICollection<StockInventory> StockInventories { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockPackOperation> StockPackOperationPackages { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockPackOperation> StockPackOperationResultPackages { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItemPackages { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItemResultPackages { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ProductUl? Ul { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
