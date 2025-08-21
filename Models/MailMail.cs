using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Outgoing Mails
/// </summary>
public partial class MailMail
{
    public int Id { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MailMessageId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Is Notification
    /// </summary>
    public bool? Notification { get; set; }

    /// <summary>
    /// Auto Delete
    /// </summary>
    public bool? AutoDelete { get; set; }

    /// <summary>
    /// Rich-text Contents
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// To
    /// </summary>
    public string? EmailTo { get; set; }

    /// <summary>
    /// Headers
    /// </summary>
    public string? Headers { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// References
    /// </summary>
    public string? References { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Inbound Mail Server
    /// </summary>
    public int? FetchmailServerId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual FetchmailServer? FetchmailServer { get; set; }

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
