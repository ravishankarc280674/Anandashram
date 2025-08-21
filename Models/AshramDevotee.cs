using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ashram.devotee
/// </summary>
public partial class AshramDevotee
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
    /// Photo
    /// </summary>
    public byte[]? Photo { get; set; }

    /// <summary>
    /// Devotee Category
    /// </summary>
    public int MainCategoryId { get; set; }

    /// <summary>
    /// Devotee Code
    /// </summary>
    public string? DevoteeCode { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Devotee Sub Category
    /// </summary>
    public int? SubCategoryId { get; set; }

    /// <summary>
    /// Partner id
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Biometric Code
    /// </summary>
    public string? BiometricCode { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();

    public virtual DevoteeCategory MainCategory { get; set; } = null!;

    public virtual ICollection<MealReservation> MealReservations { get; set; } = new List<MealReservation>();

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<QuickRoomReservation> QuickRoomReservations { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual AshramDevoteeSubCategory? SubCategory { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
