using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Information about a product supplier
/// </summary>
public partial class ProductSupplierinfo
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Supplier Product Code
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Supplier
    /// </summary>
    public int Name { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Supplier Product Name
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Delivery Lead Time
    /// </summary>
    public int Delay { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Minimal Quantity
    /// </summary>
    public double MinQty { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Qty { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner NameNavigation { get; set; } = null!;

    public virtual ICollection<PricelistPartnerinfo> PricelistPartnerinfos { get; set; } = new List<PricelistPartnerinfo>();

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
