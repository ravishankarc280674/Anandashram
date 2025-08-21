using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Share Wizard
/// </summary>
public partial class ShareWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Sharing method
    /// </summary>
    public string UserType { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// New user email
    /// </summary>
    public string? Email2 { get; set; }

    /// <summary>
    /// New user email
    /// </summary>
    public string? Email3 { get; set; }

    /// <summary>
    /// New user email
    /// </summary>
    public string? Email1 { get; set; }

    /// <summary>
    /// Record name
    /// </summary>
    public string? RecordName { get; set; }

    /// <summary>
    /// Personal Message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Display title
    /// </summary>
    public bool? EmbedOptionTitle { get; set; }

    /// <summary>
    /// Emails
    /// </summary>
    public string? NewUsers { get; set; }

    /// <summary>
    /// Access Mode
    /// </summary>
    public string AccessMode { get; set; } = null!;

    /// <summary>
    /// Action to share
    /// </summary>
    public int ActionId { get; set; }

    /// <summary>
    /// Invite users to OpenSocial record
    /// </summary>
    public bool? Invite { get; set; }

    /// <summary>
    /// Current View Type
    /// </summary>
    public string ViewType { get; set; } = null!;

    /// <summary>
    /// Display search view
    /// </summary>
    public bool? EmbedOptionSearch { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Share Title
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual IrActWindow Action { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ShareWizardResultLine> ShareWizardResultLines { get; set; } = new List<ShareWizardResultLine>();

    public virtual ResUser? WriteU { get; set; }
}
