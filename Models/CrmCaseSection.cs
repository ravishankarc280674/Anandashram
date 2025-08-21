using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Sales Teams
/// </summary>
public partial class CrmCaseSection
{
    public int Id { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Working Hours
    /// </summary>
    public decimal? WorkingHours { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Team Leader
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Parent Team
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// unknown
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Reassign Escalated
    /// </summary>
    public bool? ChangeResponsible { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Reply-To
    /// </summary>
    public string? ReplyTo { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmCaseSection> InverseParent { get; set; } = new List<CrmCaseSection>();

    public virtual CrmCaseSection? Parent { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
