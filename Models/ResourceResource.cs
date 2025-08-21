using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Resource Detail
/// </summary>
public partial class ResourceResource
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Efficiency Factor
    /// </summary>
    public double TimeEfficiency { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

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
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Working Time
    /// </summary>
    public int? CalendarId { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Resource Type
    /// </summary>
    public string ResourceType { get; set; } = null!;

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
