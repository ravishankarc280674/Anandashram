using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Hotel Room Reservation
/// </summary>
public partial class HotelRoomReservationLine
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Check In Date
    /// </summary>
    public DateTime CheckIn { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Reservation
    /// </summary>
    public int? ReservationId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Room Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Room id
    /// </summary>
    public int? RoomId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Allocated
    /// </summary>
    public int Allocated { get; set; }

    /// <summary>
    /// Check Out Date
    /// </summary>
    public DateTime CheckOut { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HotelReservation? Reservation { get; set; }

    public virtual HotelRoom? Room { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
