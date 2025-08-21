using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Floor
/// </summary>
public partial class HotelFloor
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
    /// Floor Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HotelReservationLine> HotelReservationLines { get; set; } = new List<HotelReservationLine>();

    public virtual ICollection<HotelRoom> HotelRooms { get; set; } = new List<HotelRoom>();

    public virtual ResUser? WriteU { get; set; }
}
