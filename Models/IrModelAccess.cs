using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.model.access
/// </summary>
public partial class IrModelAccess
{
    public int Id { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Read Access
    /// </summary>
    public bool? PermRead { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Delete Access
    /// </summary>
    public bool? PermUnlink { get; set; }

    /// <summary>
    /// Write Access
    /// </summary>
    public bool? PermWrite { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Create Access
    /// </summary>
    public bool? PermCreate { get; set; }

    /// <summary>
    /// Group
    /// </summary>
    public int? GroupId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup? Group { get; set; }

    public virtual IrModel Model { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
