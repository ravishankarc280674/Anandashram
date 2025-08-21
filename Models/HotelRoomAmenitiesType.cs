using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// amenities Type
/// </summary>
public partial class HotelRoomAmenitiesType
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
    public int CatId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ProductCategory Cat { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HotelRoomAmenity> HotelRoomAmenities { get; set; } = new List<HotelRoomAmenity>();

    public virtual ResUser? WriteU { get; set; }
}
