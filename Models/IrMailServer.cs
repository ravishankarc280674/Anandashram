using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.mail_server
/// </summary>
public partial class IrMailServer
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Connection Security
    /// </summary>
    public string SmtpEncryption { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// SMTP Port
    /// </summary>
    public int SmtpPort { get; set; }

    /// <summary>
    /// SMTP Server
    /// </summary>
    public string SmtpHost { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string? SmtpPass { get; set; }

    /// <summary>
    /// Debugging
    /// </summary>
    public bool? SmtpDebug { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Username
    /// </summary>
    public string? SmtpUser { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviews { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual ResUser? WriteU { get; set; }
}
