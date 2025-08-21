using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Resource Calendar
/// </summary>
public partial class ResourceCalendar
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Workgroup Manager
    /// </summary>
    public int? Manager { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? ManagerNavigation { get; set; }

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendances { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceResource> ResourceResources { get; set; } = new List<ResourceResource>();

    public virtual ResUser? WriteU { get; set; }
}
