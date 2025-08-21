using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Email composition wizard
/// </summary>
public partial class MailComposeMessage
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// No threading for answers
    /// </summary>
    public bool? NoAutoThread { get; set; }

    /// <summary>
    /// Outgoing mail server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Notify followers
    /// </summary>
    public bool? Notify { get; set; }

    /// <summary>
    /// Active domain
    /// </summary>
    public string? ActiveDomain { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Composition mode
    /// </summary>
    public string? CompositionMode { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Log an Internal Note
    /// </summary>
    public bool? IsLog { get; set; }

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
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? AuthorId { get; set; }

    /// <summary>
    /// Use active domain
    /// </summary>
    public bool? UseActiveDomain { get; set; }

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

    /// <summary>
    /// Use template
    /// </summary>
    public int? TemplateId { get; set; }

    public virtual ResPartner? Author { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrMailServer? MailServer { get; set; }

    public virtual MailMessage? Parent { get; set; }

    public virtual MailMessageSubtype? Subtype { get; set; }

    public virtual EmailTemplate? Template { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
