using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Aaashrmam Services and its charges
/// </summary>
public partial class HotelService
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
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Service_id
    /// </summary>
    public int ServiceId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Service { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
