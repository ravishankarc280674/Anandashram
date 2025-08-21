using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Email Aliases
/// </summary>
public partial class MailAlias
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Parent Record Thread ID
    /// </summary>
    public int? AliasParentThreadId { get; set; }

    /// <summary>
    /// Default Values
    /// </summary>
    public string AliasDefaults { get; set; } = null!;

    /// <summary>
    /// Alias Contact Security
    /// </summary>
    public string AliasContact { get; set; } = null!;

    /// <summary>
    /// Parent Model
    /// </summary>
    public int? AliasParentModelId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Record Thread ID
    /// </summary>
    public int? AliasForceThreadId { get; set; }

    /// <summary>
    /// Aliased Model
    /// </summary>
    public int AliasModelId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? AliasUserId { get; set; }

    /// <summary>
    /// Alias Name
    /// </summary>
    public string? AliasName { get; set; }

    public virtual IrModel AliasModel { get; set; } = null!;

    public virtual IrModel? AliasParentModel { get; set; }

    public virtual ResUser? AliasUser { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailGroup> MailGroups { get; set; } = new List<MailGroup>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ResUser? WriteU { get; set; }
}
