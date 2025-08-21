using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// product.attribute.price
/// </summary>
public partial class ProductAttributePrice
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
    /// Price Extra
    /// </summary>
    public decimal? PriceExtra { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Product Attribute Value
    /// </summary>
    public int ValueId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ProductAttributeValue Value { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
