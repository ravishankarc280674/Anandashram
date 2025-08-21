using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Product uom categ
/// </summary>
public partial class ProductUomCateg
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductUom> ProductUoms { get; set; } = new List<ProductUom>();

    public virtual ResUser? WriteU { get; set; }
}
