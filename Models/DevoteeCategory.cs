using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Anandashram.Models;

/// <summary>
/// ashram.devotee.category
/// </summary>
/// 
[Table("AshramDevotee")]
public partial class DevoteeCategory
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
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AshramDevoteeSubCategory> AshramDevoteeSubCategories { get; set; } = new List<AshramDevoteeSubCategory>();

    public virtual ICollection<AshramDevotee> AshramDevotees { get; set; } = new List<AshramDevotee>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
