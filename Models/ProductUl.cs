using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Logistic Unit
/// </summary>
public partial class ProductUl
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
    /// Empty Package Weight
    /// </summary>
    public double? Weight { get; set; }

    /// <summary>
    /// Height
    /// </summary>
    public double? Height { get; set; }

    /// <summary>
    /// Width
    /// </summary>
    public double? Width { get; set; }

    /// <summary>
    /// Length
    /// </summary>
    public double? Length { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductPackaging> ProductPackagingUlContainerNavigations { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPackaging> ProductPackagingUlNavigations { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ResUser? WriteU { get; set; }
}
