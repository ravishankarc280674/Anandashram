using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Message
/// </summary>
public partial class MailMessage
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Outgoing mail server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Parent Message
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Subtype
    /// </summary>
    public int? SubtypeId { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Message-Id
    /// </summary>
    public string? MessageId { get; set; }

    /// <summary>
    /// Contents
    /// </summary>
    public string? Body { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// Message Record Name
    /// </summary>
    public string? RecordName { get; set; }

    /// <summary>
    /// No threading for answers
    /// </summary>
    public bool? NoAutoThread { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Reply-To
    /// </summary>
    public string? ReplyTo { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailMessage> InverseParent { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMail> MailMails { get; set; } = new List<MailMail>();

    public virtual ICollection<MailNotification> MailNotifications { get; set; } = new List<MailNotification>();

    public virtual IrMailServer? MailServer { get; set; }

    public virtual MailMessage? Parent { get; set; }

    public virtual MailMessageSubtype? Subtype { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
