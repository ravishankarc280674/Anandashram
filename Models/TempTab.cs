using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN hotel_room AND hotel_room_amenities
/// </summary>
public partial class TempTab
{
    public int RoomAmenities { get; set; }

    public int RcategId { get; set; }

    public virtual HotelRoomAmenity Rcateg { get; set; } = null!;

    public virtual Room RoomAmenitiesNavigation { get; set; } = null!;
}
