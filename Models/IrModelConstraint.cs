using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrModelConstraint
{
    public int Id { get; set; }

    public DateTime? DateInit { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int Module { get; set; }

    public int Model { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

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
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel ModelNavigation { get; set; } = null!;

    public virtual IrModuleModule ModuleNavigation { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
