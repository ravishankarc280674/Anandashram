using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Email Template Preview
/// </summary>
public partial class EmailTemplatePreview
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Sub-model
    /// </summary>
    public int? SubObject { get; set; }

    /// <summary>
    /// Auto Delete
    /// </summary>
    public bool? AutoDelete { get; set; }

    /// <summary>
    /// Outgoing Mail Server
    /// </summary>
    public int? MailServerId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// To (Partners)
    /// </summary>
    public string? PartnerTo { get; set; }

    /// <summary>
    /// Sidebar action
    /// </summary>
    public int? RefIrActWindow { get; set; }

    /// <summary>
    /// Subject
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Optional report to print and attach
    /// </summary>
    public int? ReportTemplate { get; set; }

    /// <summary>
    /// Sidebar Button
    /// </summary>
    public int? RefIrValue { get; set; }

    /// <summary>
    /// Add Signature
    /// </summary>
    public bool? UserSignature { get; set; }

    /// <summary>
    /// Default Value
    /// </summary>
    public string? NullValue { get; set; }

    /// <summary>
    /// Cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Sample Document
    /// </summary>
    public string? ResId { get; set; }

    /// <summary>
    /// Applies to
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// Sub-field
    /// </summary>
    public int? SubModelObjectField { get; set; }

    /// <summary>
    /// Body
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// To (Emails)
    /// </summary>
    public string? EmailTo { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Placeholder Expression
    /// </summary>
    public string? Copyvalue { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int? ModelObjectField { get; set; }

    /// <summary>
    /// Report Filename
    /// </summary>
    public string? ReportName { get; set; }

    /// <summary>
    /// Default recipients
    /// </summary>
    public bool? UseDefaultTo { get; set; }

    /// <summary>
    /// Reply-To
    /// </summary>
    public string? ReplyTo { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string? Model { get; set; }

    /// <summary>
    /// From
    /// </summary>
    public string? EmailFrom { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrMailServer? MailServer { get; set; }

    public virtual IrModel? ModelNavigation { get; set; }

    public virtual IrModelField? ModelObjectFieldNavigation { get; set; }

    public virtual IrActWindow? RefIrActWindowNavigation { get; set; }

    public virtual IrValue? RefIrValueNavigation { get; set; }

    public virtual IrActReportXml? ReportTemplateNavigation { get; set; }

    public virtual IrModelField? SubModelObjectFieldNavigation { get; set; }

    public virtual IrModel? SubObjectNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
