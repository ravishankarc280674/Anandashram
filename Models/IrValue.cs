using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.values
/// </summary>
public partial class IrValue
{
    public int Id { get; set; }

    /// <summary>
    /// Model (change only)
    /// </summary>
    public int? ModelId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Qualifier
    /// </summary>
    public string? Key2 { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Key { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Record ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Action (change only)
    /// </summary>
    public int? ActionId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviews { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual IrModel? ModelNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
