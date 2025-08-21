using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Discussion group
/// </summary>
public partial class MailGroup
{
    public int Id { get; set; }

    /// <summary>
    /// Related Menu
    /// </summary>
    public int MenuId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Photo
    /// </summary>
    public byte[]? Image { get; set; }

    /// <summary>
    /// Alias
    /// </summary>
    public int AliasId { get; set; }

    /// <summary>
    /// Authorized Group
    /// </summary>
    public int? GroupPublicId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Privacy
    /// </summary>
    public string Public { get; set; } = null!;

    /// <summary>
    /// Medium-sized photo
    /// </summary>
    public byte[]? ImageMedium { get; set; }

    /// <summary>
    /// Small-sized photo
    /// </summary>
    public byte[]? ImageSmall { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual MailAlias Alias { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup? GroupPublic { get; set; }

    public virtual ICollection<IrUiMenu> IrUiMenus { get; set; } = new List<IrUiMenu>();

    public virtual IrUiMenu Menu { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
