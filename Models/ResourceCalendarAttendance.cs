using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Work Detail
/// </summary>
public partial class ResourceCalendarAttendance
{
    public int Id { get; set; }

    /// <summary>
    /// Day of Week
    /// </summary>
    public string Dayofweek { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Starting Date
    /// </summary>
    public DateOnly? DateFrom { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Work from
    /// </summary>
    public double HourFrom { get; set; }

    /// <summary>
    /// Work to
    /// </summary>
    public double HourTo { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Resource&apos;s Calendar
    /// </summary>
    public int CalendarId { get; set; }

    public virtual ResourceCalendar Calendar { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
