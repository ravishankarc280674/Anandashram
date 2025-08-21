using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Partner Tags
/// </summary>
public partial class ResPartnerCategory
{
    public int Id { get; set; }

    public int? ParentLeft { get; set; }

    public int? ParentRight { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Category Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Category
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResPartnerCategory> InverseParent { get; set; } = new List<ResPartnerCategory>();

    public virtual ResPartnerCategory? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
