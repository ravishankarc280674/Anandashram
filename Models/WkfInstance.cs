using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// workflow.instance
/// </summary>
public partial class WkfInstance
{
    public int Id { get; set; }

    /// <summary>
    /// Resource Object
    /// </summary>
    public string? ResType { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? Uid { get; set; }

    /// <summary>
    /// Workflow
    /// </summary>
    public int? WkfId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Resource ID
    /// </summary>
    public int? ResId { get; set; }

    public virtual Wkf? Wkf { get; set; }

    public virtual ICollection<WkfTrigger> WkfTriggers { get; set; } = new List<WkfTrigger>();

    public virtual ICollection<WkfWorkitem> WkfWorkitemInsts { get; set; } = new List<WkfWorkitem>();

    public virtual ICollection<WkfWorkitem> WkfWorkitemSubflows { get; set; } = new List<WkfWorkitem>();
}
