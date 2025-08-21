using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Price List
/// </summary>
public partial class ProductPriceList
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
    /// PriceList
    /// </summary>
    public int PriceList { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Quantity-1
    /// </summary>
    public int? Qty1 { get; set; }

    /// <summary>
    /// Quantity-2
    /// </summary>
    public int? Qty2 { get; set; }

    /// <summary>
    /// Quantity-3
    /// </summary>
    public int? Qty3 { get; set; }

    /// <summary>
    /// Quantity-4
    /// </summary>
    public int? Qty4 { get; set; }

    /// <summary>
    /// Quantity-5
    /// </summary>
    public int? Qty5 { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductPricelist1 PriceListNavigation { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
