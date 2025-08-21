using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Pricelist Version
/// </summary>
public partial class ProductPricelistVersion
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? DateEnd { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateOnly? DateStart { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Price List
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductPricelist1 Pricelist { get; set; } = null!;

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ResUser? WriteU { get; set; }
}
