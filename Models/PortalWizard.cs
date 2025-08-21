using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Portal Access Management
/// </summary>
public partial class PortalWizard
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
    /// Invitation Message
    /// </summary>
    public string? WelcomeMessage { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Portal
    /// </summary>
    public int PortalId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup Portal { get; set; } = null!;

    public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; set; } = new List<PortalWizardUser>();

    public virtual ResUser? WriteU { get; set; }
}
