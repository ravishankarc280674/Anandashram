using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Update Module
/// </summary>
public partial class BaseModuleUpdate
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Number of modules updated
    /// </summary>
    public int? Updated { get; set; }

    /// <summary>
    /// Number of modules added
    /// </summary>
    public int? Added { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
