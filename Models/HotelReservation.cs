using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Reservation
/// </summary>
public partial class HotelReservation
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Adults
    /// </summary>
    public int? Adults { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date Ordered
    /// </summary>
    public DateTime DateOrder { get; set; }

    /// <summary>
    /// Guest Name
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Children
    /// </summary>
    public int? Children { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Scheme
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// Expected-Date-Departure
    /// </summary>
    public DateTime Checkout { get; set; }

    /// <summary>
    /// Expected-Date-Arrival
    /// </summary>
    public DateTime Checkin { get; set; }

    /// <summary>
    /// Ordering Contact
    /// </summary>
    public int? PartnerOrderId { get; set; }

    /// <summary>
    /// Ashram
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Invoice Address
    /// </summary>
    public int? PartnerInvoiceId { get; set; }

    /// <summary>
    /// Reservation No
    /// </summary>
    public string? ReservationNo { get; set; }

    /// <summary>
    /// Dummy
    /// </summary>
    public DateTime? Dummy { get; set; }

    /// <summary>
    /// Devotee
    /// </summary>
    public int DevoteeId { get; set; }

    /// <summary>
    /// Delivery Address
    /// </summary>
    public int? PartnerShippingId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AshramDevotee Devotee { get; set; } = null!;

    public virtual ICollection<HotelReservationLine> HotelReservationLines { get; set; } = new List<HotelReservationLine>();

    public virtual ICollection<HotelRoomReservationLine> HotelRoomReservationLines { get; set; } = new List<HotelRoomReservationLine>();

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResPartner? PartnerInvoice { get; set; }

    public virtual ResPartner? PartnerOrder { get; set; }

    public virtual ResPartner? PartnerShipping { get; set; }

    public virtual ProductPricelist1 Pricelist { get; set; } = null!;

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
