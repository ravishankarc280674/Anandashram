using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Directory
/// </summary>
public partial class DocumentDirectory
{
    public int Id { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Date Created
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Modification User
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Find all resources
    /// </summary>
    public bool? ResourceFindAll { get; set; }

    /// <summary>
    /// Creator
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Tree Structure
    /// </summary>
    public bool? RessourceTree { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Name field
    /// </summary>
    public int? ResourceField { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Parent Directory
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Parent Model
    /// </summary>
    public int? RessourceParentTypeId { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Resource model
    /// </summary>
    public int? RessourceTypeId { get; set; }

    /// <summary>
    /// Date Modified
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Resource ID
    /// </summary>
    public int? RessourceId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DocumentDirectoryContent> DocumentDirectoryContents { get; set; } = new List<DocumentDirectoryContent>();

    public virtual ICollection<DocumentDirectoryDctx> DocumentDirectoryDctxes { get; set; } = new List<DocumentDirectoryDctx>();

    public virtual ICollection<DocumentDirectory> InverseParent { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual DocumentDirectory? Parent { get; set; }

    public virtual IrModelField? ResourceFieldNavigation { get; set; }

    public virtual IrModel? RessourceParentType { get; set; }

    public virtual IrModel? RessourceType { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
