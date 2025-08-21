using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.exports
/// </summary>
public partial class IrExport
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public string? Resource { get; set; }

    /// <summary>
    /// Export Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrExportsLine> IrExportsLines { get; set; } = new List<IrExportsLine>();

    public virtual ResUser? WriteU { get; set; }
}
