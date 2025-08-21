using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Room amenities
/// </summary>
public partial class HotelRoomAmenity
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
    /// Amenity Catagory
    /// </summary>
    public int? RcategId { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int RoomCategId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HotelRoomAmenitiesType? Rcateg { get; set; }

    public virtual ProductProduct RoomCateg { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
