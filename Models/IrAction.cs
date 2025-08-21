using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrAction
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
    /// Action description
    /// </summary>
    public string? Help { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Action Usage
    /// </summary>
    public string? Usage { get; set; }

    /// <summary>
    /// Action Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
