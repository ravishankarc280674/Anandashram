using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Fonts available
/// </summary>
public partial class ResFont
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
    /// Font Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Font family
    /// </summary>
    public string Family { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Mode
    /// </summary>
    public string Mode { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Path
    /// </summary>
    public string Path { get; set; } = null!;

    public virtual ICollection<BaseConfigSetting> BaseConfigSettings { get; set; } = new List<BaseConfigSetting>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ResUser? WriteU { get; set; }
}
