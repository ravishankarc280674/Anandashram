using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// product.attribute.line
/// </summary>
public partial class ProductAttributeLine
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
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Attribute
    /// </summary>
    public int AttributeId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ProductAttribute Attribute { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
