using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.ui.view
/// </summary>
public partial class IrUiView
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Create Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// View Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Inherited View
    /// </summary>
    public int? InheritId { get; set; }

    /// <summary>
    /// View Architecture
    /// </summary>
    public string Arch { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// View inheritance mode
    /// </summary>
    public string Mode { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Model Data
    /// </summary>
    public int? ModelDataId { get; set; }

    /// <summary>
    /// View Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Last Modification Date
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Child Field
    /// </summary>
    public string? FieldParent { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? Inherit { get; set; }

    public virtual ICollection<IrUiView> InverseInherit { get; set; } = new List<IrUiView>();

    public virtual ICollection<IrActWindow> IrActWindowSearchViews { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrActWindow> IrActWindowViews { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrActWindowView> IrActWindowViewsNavigation { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustoms { get; set; } = new List<IrUiViewCustom>();

    public virtual IrModelDatum? ModelData { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
