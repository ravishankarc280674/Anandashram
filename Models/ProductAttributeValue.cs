using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// product.attribute.value
/// </summary>
public partial class ProductAttributeValue
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
    /// Value
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Attribute
    /// </summary>
    public int AttributeId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ProductAttribute Attribute { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductAttributePrice> ProductAttributePrices { get; set; } = new List<ProductAttributePrice>();

    public virtual ResUser? WriteU { get; set; }
}
