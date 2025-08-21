using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrModel
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? State { get; set; }

    public string? Info { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DocumentDirectory> DocumentDirectoryRessourceParentTypes { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<DocumentDirectory> DocumentDirectoryRessourceTypes { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<EmailTemplate> EmailTemplateModelNavigations { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviewModelNavigations { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviewSubObjectNavigations { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplateSubObjectNavigations { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<FetchmailServer> FetchmailServers { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<IrActServer> IrActServerCrudModels { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerModels { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerSubObjectNavigations { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerWkfModels { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrModelAccess> IrModelAccesses { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<IrModelConstraint> IrModelConstraints { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModelField> IrModelFields { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelRelation> IrModelRelations { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrRule> IrRules { get; set; } = new List<IrRule>();

    public virtual ICollection<IrValue> IrValues { get; set; } = new List<IrValue>();

    public virtual ICollection<MailAlias> MailAliasAliasModels { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailAlias> MailAliasAliasParentModels { get; set; } = new List<MailAlias>();

    public virtual ICollection<MultiCompanyDefault> MultiCompanyDefaults { get; set; } = new List<MultiCompanyDefault>();

    public virtual ResUser? WriteU { get; set; }
}
