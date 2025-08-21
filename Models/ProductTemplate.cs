using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Product Template
/// </summary>
public partial class ProductTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Warranty
    /// </summary>
    public double? Warranty { get; set; }

    /// <summary>
    /// Unit of Sale
    /// </summary>
    public int? UosId { get; set; }

    /// <summary>
    /// Sale Price
    /// </summary>
    public decimal? ListPrice { get; set; }

    /// <summary>
    /// Gross Weight
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Image
    /// </summary>
    public byte[]? Image { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Measure Type
    /// </summary>
    public string? MesType { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int UomId { get; set; }

    /// <summary>
    /// Purchase Description
    /// </summary>
    public string? DescriptionPurchase { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Unit of Measure -&gt; UOS Coeff
    /// </summary>
    public decimal? UosCoeff { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Can be Sold
    /// </summary>
    public bool? SaleOk { get; set; }

    /// <summary>
    /// Internal Category
    /// </summary>
    public int CategId { get; set; }

    /// <summary>
    /// Product Manager
    /// </summary>
    public int? ProductManager { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Purchase Unit of Measure
    /// </summary>
    public int UomPoId { get; set; }

    /// <summary>
    /// Sale Description
    /// </summary>
    public string? DescriptionSale { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Net Weight
    /// </summary>
    public decimal? WeightNet { get; set; }

    /// <summary>
    /// Volume
    /// </summary>
    public double? Volume { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Can be Rent
    /// </summary>
    public bool? Rental { get; set; }

    /// <summary>
    /// Medium-sized image
    /// </summary>
    public byte[]? ImageMedium { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Product Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Small-sized image
    /// </summary>
    public byte[]? ImageSmall { get; set; }

    /// <summary>
    /// Full Lots Traceability
    /// </summary>
    public bool? TrackAll { get; set; }

    /// <summary>
    /// Track Outgoing Lots
    /// </summary>
    public bool? TrackOutgoing { get; set; }

    /// <summary>
    /// Rack
    /// </summary>
    public string? LocRack { get; set; }

    /// <summary>
    /// Case
    /// </summary>
    public string? LocCase { get; set; }

    /// <summary>
    /// Track Incoming Lots
    /// </summary>
    public bool? TrackIncoming { get; set; }

    /// <summary>
    /// Row
    /// </summary>
    public string? LocRow { get; set; }

    /// <summary>
    /// Customer Lead Time
    /// </summary>
    public double? SaleDelay { get; set; }

    public virtual ProductCategory Categ { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductAttributeLine> ProductAttributeLines { get; set; } = new List<ProductAttributeLine>();

    public virtual ICollection<ProductAttributePrice> ProductAttributePrices { get; set; } = new List<ProductAttributePrice>();

    public virtual ResUser? ProductManagerNavigation { get; set; }

    public virtual ICollection<ProductPackaging> ProductPackagings { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPriceHistory> ProductPriceHistories { get; set; } = new List<ProductPriceHistory>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductProduct> ProductProducts { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ProductUom Uom { get; set; } = null!;

    public virtual ProductUom UomPo { get; set; } = null!;

    public virtual ProductUom? Uos { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
