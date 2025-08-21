using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Product Category
/// </summary>
public partial class ProductCategory
{
    public int Id { get; set; }

    public int? ParentLeft { get; set; }

    public int? ParentRight { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
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
    /// Parent Category
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Category Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Force Removal Strategy
    /// </summary>
    public int? RemovalStrategyId { get; set; }

    /// <summary>
    /// Is Amenities Type
    /// </summary>
    public bool? Isamenitytype { get; set; }

    /// <summary>
    /// Is Service Type
    /// </summary>
    public bool? Isservicetype { get; set; }

    /// <summary>
    /// Is Room Type
    /// </summary>
    public bool? Isroomtype { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HotelReservationLine> HotelReservationLines { get; set; } = new List<HotelReservationLine>();

    public virtual ICollection<HotelRoomAmenitiesType> HotelRoomAmenitiesTypes { get; set; } = new List<HotelRoomAmenitiesType>();

    public virtual ICollection<HotelRoomType> HotelRoomTypes { get; set; } = new List<HotelRoomType>();

    public virtual ICollection<HotelServiceType> HotelServiceTypes { get; set; } = new List<HotelServiceType>();

    public virtual ICollection<ProductCategory> InverseParent { get; set; } = new List<ProductCategory>();

    public virtual ProductCategory? Parent { get; set; }

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    public virtual ICollection<StockFixedPutawayStrat> StockFixedPutawayStrats { get; set; } = new List<StockFixedPutawayStrat>();

    public virtual ResUser? WriteU { get; set; }
}
