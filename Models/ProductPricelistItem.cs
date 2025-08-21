using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Pricelist item
/// </summary>
public partial class ProductPricelistItem
{
    public int Id { get; set; }

    /// <summary>
    /// Price Rounding
    /// </summary>
    public decimal? PriceRound { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Min. Price Margin
    /// </summary>
    public decimal? PriceMinMargin { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Price Discount
    /// </summary>
    public decimal? PriceDiscount { get; set; }

    /// <summary>
    /// Rule Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Max. Price Margin
    /// </summary>
    public decimal? PriceMaxMargin { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int? ProductTmplId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Based on
    /// </summary>
    public int Base { get; set; }

    /// <summary>
    /// Other Pricelist
    /// </summary>
    public int? BasePricelistId { get; set; }

    /// <summary>
    /// Price List Version
    /// </summary>
    public int PriceVersionId { get; set; }

    /// <summary>
    /// Min. Quantity
    /// </summary>
    public int MinQuantity { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? CategId { get; set; }

    /// <summary>
    /// Price Surcharge
    /// </summary>
    public decimal? PriceSurcharge { get; set; }

    public virtual ProductPricelist1? BasePricelist { get; set; }

    public virtual ProductCategory? Categ { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductPricelistVersion PriceVersion { get; set; } = null!;

    public virtual ProductProduct? Product { get; set; }

    public virtual ProductTemplate? ProductTmpl { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
