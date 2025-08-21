using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// bus.bus
/// </summary>
public partial class BusBu
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Create date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Channel
    /// </summary>
    public string? Channel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
