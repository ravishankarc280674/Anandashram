using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// POP/IMAP Server
/// </summary>
public partial class FetchmailServer
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Port
    /// </summary>
    public int? Port { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Configuration
    /// </summary>
    public string? Configuration { get; set; }

    /// <summary>
    /// Script
    /// </summary>
    public string? Script { get; set; }

    /// <summary>
    /// Create a New Record
    /// </summary>
    public int? ObjectId { get; set; }

    /// <summary>
    /// Server Priority
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Keep Attachments
    /// </summary>
    public bool? Attach { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Server Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Server Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    public string? User { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Fetch Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string? Password { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// SSL/TLS
    /// </summary>
    public bool? IsSsl { get; set; }

    /// <summary>
    /// Server Name
    /// </summary>
    public string? Server { get; set; }

    /// <summary>
    /// Keep Original
    /// </summary>
    public bool? Original { get; set; }

    public virtual IrActServer? Action { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailMail> MailMails { get; set; } = new List<MailMail>();

    public virtual IrModel? Object { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
