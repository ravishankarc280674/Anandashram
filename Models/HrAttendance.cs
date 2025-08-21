using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Attendance
/// </summary>
public partial class HrAttendance
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime Name { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Action Reason
    /// </summary>
    public int? ActionDesc { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// Worked Hours
    /// </summary>
    public decimal? WorkedHours { get; set; }

    public virtual HrActionReason? ActionDescNavigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
