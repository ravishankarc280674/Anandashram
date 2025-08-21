using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Print Error Attendance Report
/// </summary>
public partial class HrAttendanceError
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
    /// Ending Date
    /// </summary>
    public DateOnly EndDate { get; set; }

    /// <summary>
    /// Max. Delay (Min)
    /// </summary>
    public int MaxDelay { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Starting Date
    /// </summary>
    public DateOnly InitDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
