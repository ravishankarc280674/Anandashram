using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Portal User Config
/// </summary>
public partial class PortalWizardUser
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
    /// Wizard
    /// </summary>
    public int WizardId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// In Portal
    /// </summary>
    public bool? InPortal { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int PartnerId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual PortalWizard Wizard { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
