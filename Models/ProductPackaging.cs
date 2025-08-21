using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Packaging
/// </summary>
public partial class ProductPackaging
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Number of Layers
    /// </summary>
    public int Rows { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Total Package Weight
    /// </summary>
    public double? Weight { get; set; }

    /// <summary>
    /// EAN
    /// </summary>
    public string? Ean { get; set; }

    /// <summary>
    /// Package by layer
    /// </summary>
    public int? UlQty { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Quantity by Package
    /// </summary>
    public double? Qty { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductTmplId { get; set; }

    /// <summary>
    /// Package Logistic Unit
    /// </summary>
    public int Ul { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Pallet Logistic Unit
    /// </summary>
    public int? UlContainer { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate ProductTmpl { get; set; } = null!;

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ProductUl? UlContainerNavigation { get; set; }

    public virtual ProductUl UlNavigation { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
