using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Leave Detail
/// </summary>
public partial class ResourceCalendarLeaf
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
    public string? Name { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public int? ResourceId { get; set; }

    /// <summary>
    /// Start Date
    /// </summary>
    public DateTime DateFrom { get; set; }

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
    /// End Date
    /// </summary>
    public DateTime DateTo { get; set; }

    /// <summary>
    /// Working Time
    /// </summary>
    public int? CalendarId { get; set; }

    public virtual ResourceCalendar? Calendar { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResourceResource? Resource { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
