using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Message subtypes
/// </summary>
public partial class MailMessageSubtype
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
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Default
    /// </summary>
    public bool? Default { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Relation field
    /// </summary>
    public string? RelationField { get; set; }

    /// <summary>
    /// Hidden
    /// </summary>
    public bool? Hidden { get; set; }

    /// <summary>
    /// Message Type
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailMessageSubtype> InverseParent { get; set; } = new List<MailMessageSubtype>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual MailMessageSubtype? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
