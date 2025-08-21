using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Employee Category
/// </summary>
public partial class HrEmployeeCategory
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
    /// Employee Tag
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Employee Tag
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployeeCategory> InverseParent { get; set; } = new List<HrEmployeeCategory>();

    public virtual HrEmployeeCategory? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
