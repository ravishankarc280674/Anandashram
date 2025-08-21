using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.cron
/// </summary>
public partial class IrCron
{
    public int Id { get; set; }

    /// <summary>
    /// Method
    /// </summary>
    public string? Function { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Arguments
    /// </summary>
    public string? Args { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Interval Unit
    /// </summary>
    public string? IntervalType { get; set; }

    /// <summary>
    /// Number of Calls
    /// </summary>
    public int? Numbercall { get; set; }

    /// <summary>
    /// Next Execution Date
    /// </summary>
    public DateTime Nextcall { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Repeat Missed
    /// </summary>
    public bool? Doall { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Interval Number
    /// </summary>
    public int? IntervalNumber { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
