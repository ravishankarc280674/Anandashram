using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN hotel_reservation_line AND hotel_room
/// </summary>
public partial class HotelReservationLineRoomRel
{
    public int HotelReservationLineId { get; set; }

    public int RoomId { get; set; }

    public virtual HotelReservationLine HotelReservationLine { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
