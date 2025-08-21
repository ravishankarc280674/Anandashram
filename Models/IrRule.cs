using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.rule
/// </summary>
public partial class IrRule
{
    public int Id { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string? DomainForce { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Global
    /// </summary>
    public bool? Global { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Apply for Read
    /// </summary>
    public bool? PermRead { get; set; }

    /// <summary>
    /// Apply for Delete
    /// </summary>
    public bool? PermUnlink { get; set; }

    /// <summary>
    /// Apply for Write
    /// </summary>
    public bool? PermWrite { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Apply for Create
    /// </summary>
    public bool? PermCreate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModel Model { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
