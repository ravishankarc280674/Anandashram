using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// workflow.activity
/// </summary>
public partial class WkfActivity
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Kind
    /// </summary>
    public string Kind { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Join Mode
    /// </summary>
    public string JoinMode { get; set; } = null!;

    /// <summary>
    /// Flow Stop
    /// </summary>
    public bool? FlowStop { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Subflow
    /// </summary>
    public int? SubflowId { get; set; }

    /// <summary>
    /// Split Mode
    /// </summary>
    public string SplitMode { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Python Action
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Workflow
    /// </summary>
    public int WkfId { get; set; }

    /// <summary>
    /// Signal (subflow.*)
    /// </summary>
    public string? SignalSend { get; set; }

    /// <summary>
    /// Flow Start
    /// </summary>
    public bool? FlowStart { get; set; }

    /// <summary>
    /// Server Action
    /// </summary>
    public int? ActionId { get; set; }

    public virtual IrActServer? ActionNavigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual Wkf? Subflow { get; set; }

    public virtual Wkf Wkf { get; set; } = null!;

    public virtual ICollection<WkfTransition> WkfTransitionActFromNavigations { get; set; } = new List<WkfTransition>();

    public virtual ICollection<WkfTransition> WkfTransitionActToNavigations { get; set; } = new List<WkfTransition>();

    public virtual ICollection<WkfWorkitem> WkfWorkitems { get; set; } = new List<WkfWorkitem>();

    public virtual ResUser? WriteU { get; set; }
}
