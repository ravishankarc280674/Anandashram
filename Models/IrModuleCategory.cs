using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrModuleCategory
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public int? WriteUid { get; set; }

    public int? ParentId { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Visible
    /// </summary>
    public bool? Visible { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrModuleCategory> InverseParent { get; set; } = new List<IrModuleCategory>();

    public virtual ICollection<IrModuleModule> IrModuleModules { get; set; } = new List<IrModuleModule>();

    public virtual IrModuleCategory? Parent { get; set; }

    public virtual ICollection<ResGroup> ResGroups { get; set; } = new List<ResGroup>();

    public virtual ResUser? WriteU { get; set; }
}
