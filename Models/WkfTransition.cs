using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// workflow.transition
/// </summary>
public partial class WkfTransition
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
    /// Trigger Object
    /// </summary>
    public string? TriggerModel { get; set; }

    /// <summary>
    /// Signal (Button Name)
    /// </summary>
    public string? Signal { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Source Activity
    /// </summary>
    public int ActFrom { get; set; }

    /// <summary>
    /// Condition
    /// </summary>
    public string Condition { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Trigger Expression
    /// </summary>
    public string? TriggerExprId { get; set; }

    /// <summary>
    /// Group Required
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Destination Activity
    /// </summary>
    public int ActTo { get; set; }

    public virtual WkfActivity ActFromNavigation { get; set; } = null!;

    public virtual WkfActivity ActToNavigation { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResGroup? Group { get; set; }

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual ResUser? WriteU { get; set; }
}
