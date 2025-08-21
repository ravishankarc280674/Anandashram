using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// pricelist.partnerinfo
/// </summary>
public partial class PricelistPartnerinfo
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
    /// Description
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Partner Information
    /// </summary>
    public int SuppinfoId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double MinQuantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductSupplierinfo Suppinfo { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
