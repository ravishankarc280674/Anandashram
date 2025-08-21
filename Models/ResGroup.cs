using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Access Groups
/// </summary>
public partial class ResGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Comment
    /// </summary>
    public string? Comment { get; set; }

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
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Application
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Share Group
    /// </summary>
    public bool? Share { get; set; }

    /// <summary>
    /// Portal
    /// </summary>
    public bool? IsPortal { get; set; }

    public virtual IrModuleCategory? Category { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrModelAccess> IrModelAccesses { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<MailGroup> MailGroups { get; set; } = new List<MailGroup>();

    public virtual ICollection<PortalWizard> PortalWizards { get; set; } = new List<PortalWizard>();

    public virtual ICollection<WkfTransition> WkfTransitions { get; set; } = new List<WkfTransition>();

    public virtual ResUser? WriteU { get; set; }
}
