using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// share.wizard.result.line
/// </summary>
public partial class ShareWizardResultLine
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
    /// Newly created
    /// </summary>
    public bool? NewlyCreated { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// unknown
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// Share Wizard
    /// </summary>
    public int ShareWizardId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ShareWizard ShareWizard { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
