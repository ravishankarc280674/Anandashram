using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.actions.act_window.view
/// </summary>
public partial class IrActWindowView
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// On Multiple Doc.
    /// </summary>
    public bool? Multi { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// View
    /// </summary>
    public int? ViewId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// View Type
    /// </summary>
    public string ViewMode { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public int? ActWindowId { get; set; }

    public virtual IrActWindow? ActWindow { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
