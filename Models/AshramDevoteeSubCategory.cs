using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ashram.devotee.sub.category
/// </summary>
public partial class AshramDevoteeSubCategory
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Main Category
    /// </summary>
    public int? MainCategoryId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AshramDevotee> AshramDevotees { get; set; } = new List<AshramDevotee>();

    public virtual ResUser? CreateU { get; set; }

    public virtual DevoteeCategory? MainCategory { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
