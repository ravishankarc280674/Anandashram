using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Hotel Room
/// </summary>
public partial class Room
{
    public int Id { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Max Adult
    /// </summary>
    public int? MaxAdult { get; set; }

    /// <summary>
    /// Capacity
    /// </summary>
    public int? Capacity { get; set; }

    /// <summary>
    /// Block
    /// </summary>
    public int? BlockId { get; set; }

    /// <summary>
    /// Floor No
    /// </summary>
    public int? FloorId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Max Child
    /// </summary>
    public int? MaxChild { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Building
    /// </summary>
    public int? BuildingId { get; set; }

    /// <summary>
    /// Product_id
    /// </summary>
    public int ProductId { get; set; }

    public virtual Block? Block { get; set; }

    public virtual Building? Building { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual Floor? Floor { get; set; }

    public virtual ICollection<FolioRoomLine> FolioRoomLines { get; set; } = new List<FolioRoomLine>();

    public virtual ICollection<HotelReservationLine> HotelReservationLines { get; set; } = new List<HotelReservationLine>();

    public virtual ICollection<HotelRoomReservationLine> HotelRoomReservationLines { get; set; } = new List<HotelRoomReservationLine>();

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ICollection<QuickRoomReservation> QuickRoomReservations { get; set; } = new List<QuickRoomReservation>();

    public virtual ResUser? WriteU { get; set; }
}
