using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.sequence
/// </summary>
public partial class IrSequence
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Sequence Type
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Next Number
    /// </summary>
    public int NumberNext { get; set; }

    /// <summary>
    /// Implementation
    /// </summary>
    public string Implementation { get; set; } = null!;

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Number Padding
    /// </summary>
    public int Padding { get; set; }

    /// <summary>
    /// Increment Number
    /// </summary>
    public int NumberIncrement { get; set; }

    /// <summary>
    /// Prefix
    /// </summary>
    public string? Prefix { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Suffix
    /// </summary>
    public string? Suffix { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockPickingType> StockPickingTypes { get; set; } = new List<StockPickingType>();

    public virtual ResUser? WriteU { get; set; }
}
