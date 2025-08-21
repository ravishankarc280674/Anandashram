using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// workflow.triggers
/// </summary>
public partial class WkfTrigger
{
    public int Id { get; set; }

    /// <summary>
    /// Destination Instance
    /// </summary>
    public int? InstanceId { get; set; }

    /// <summary>
    /// Workitem
    /// </summary>
    public int WorkitemId { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Resource ID
    /// </summary>
    public int? ResId { get; set; }

    public virtual WkfInstance? Instance { get; set; }

    public virtual WkfWorkitem Workitem { get; set; } = null!;
}
