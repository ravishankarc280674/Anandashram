using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Pricelist
/// </summary>
public partial class ProductPricelist1
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
    /// Pricelist Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Pricelist Type
    /// </summary>
    public string Type { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ICollection<HotelReservation> HotelReservations { get; set; } = new List<HotelReservation>();

    public virtual ICollection<ProductPriceList> ProductPriceLists { get; set; } = new List<ProductPriceList>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistVersion> ProductPricelistVersions { get; set; } = new List<ProductPricelistVersion>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservations { get; set; } = new List<QuickRoomReservation>();

    public virtual ResUser? WriteU { get; set; }
}
