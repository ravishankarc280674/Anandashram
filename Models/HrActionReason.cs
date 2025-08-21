using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Action Reason
/// </summary>
public partial class HrActionReason
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Reason
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Action Type
    /// </summary>
    public string? ActionType { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrAttendance> HrAttendances { get; set; } = new List<HrAttendance>();

    public virtual ResUser? WriteU { get; set; }
}
