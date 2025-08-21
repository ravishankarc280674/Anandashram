using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Configuration Wizards
/// </summary>
public partial class IrActionsTodo
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
    public string? Name { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Text
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Action
    /// </summary>
    public int ActionId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
