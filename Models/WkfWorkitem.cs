using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// workflow.workitem
/// </summary>
public partial class WkfWorkitem
{
    public int Id { get; set; }

    /// <summary>
    /// Activity
    /// </summary>
    public int ActId { get; set; }

    /// <summary>
    /// Instance
    /// </summary>
    public int InstId { get; set; }

    /// <summary>
    /// Subflow
    /// </summary>
    public int? SubflowId { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    public virtual WkfActivity Act { get; set; } = null!;

    public virtual WkfInstance Inst { get; set; } = null!;

    public virtual WkfInstance? Subflow { get; set; }

    public virtual ICollection<WkfTrigger> WkfTriggers { get; set; } = new List<WkfTrigger>();
}
