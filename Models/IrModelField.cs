using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrModelField
{
    public int Id { get; set; }

    public string Model { get; set; } = null!;

    public int ModelId { get; set; }

    public string Name { get; set; } = null!;

    public string? Relation { get; set; }

    public string SelectLevel { get; set; } = null!;

    public string FieldDescription { get; set; } = null!;

    public string Ttype { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? RelationField { get; set; }

    public bool? Translate { get; set; }

    public int? SerializationFieldId { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// On Delete
    /// </summary>
    public string? OnDelete { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Selection Options
    /// </summary>
    public string? Selection { get; set; }

    /// <summary>
    /// Size
    /// </summary>
    public int? Size { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Readonly
    /// </summary>
    public bool? Readonly { get; set; }

    /// <summary>
    /// Complete Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Selectable
    /// </summary>
    public bool? Selectable { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    public bool? Required { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DocumentDirectory> DocumentDirectories { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<EmailTemplate> EmailTemplateModelObjectFieldNavigations { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviewModelObjectFieldNavigations { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviewSubModelObjectFieldNavigations { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplateSubModelObjectFieldNavigations { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<IrModelField> InverseSerializationField { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrActServer> IrActServerLinkFields { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerModelObjectFieldNavigations { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerSubModelObjectFieldNavigations { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerWkfFields { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrProperty> IrProperties { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; set; } = new List<IrServerObjectLine>();

    public virtual IrModel ModelNavigation { get; set; } = null!;

    public virtual ICollection<MultiCompanyDefault> MultiCompanyDefaults { get; set; } = new List<MultiCompanyDefault>();

    public virtual IrModelField? SerializationField { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
