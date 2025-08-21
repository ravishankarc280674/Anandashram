using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Invite wizard
/// </summary>
public partial class MailWizardInvite
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
    /// Related Document Model
    /// </summary>
    public string ResModel { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Send Email
    /// </summary>
    public bool? SendMail { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
