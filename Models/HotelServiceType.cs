using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Service Type
/// </summary>
public partial class HotelServiceType
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
    /// category
    /// </summary>
    public int SerId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductCategory Ser { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
