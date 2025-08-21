using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Quick Room Reservation
/// </summary>
public partial class QuickRoomReservation
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Check In
    /// </summary>
    public DateTime CheckIn { get; set; }

    /// <summary>
    /// Devotee
    /// </summary>
    public int DevoteeId { get; set; }

    /// <summary>
    /// Delivery Address
    /// </summary>
    public int PartnerShippingId { get; set; }

    /// <summary>
    /// Check Out
    /// </summary>
    public DateTime CheckOut { get; set; }

    /// <summary>
    /// Ordering Contact
    /// </summary>
    public int PartnerOrderId { get; set; }

    /// <summary>
    /// Ashram
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Invoice Address
    /// </summary>
    public int PartnerInvoiceId { get; set; }

    /// <summary>
    /// Room
    /// </summary>
    public int RoomId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// pricelist
    /// </summary>
    public int PricelistId { get; set; }

    /// <summary>
    /// No of person(s) to allocate
    /// </summary>
    public int ToAllocate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Already allocated
    /// </summary>
    public int? Allocated { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int PartnerId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AshramDevotee Devotee { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResPartner PartnerInvoice { get; set; } = null!;

    public virtual ResPartner PartnerOrder { get; set; } = null!;

    public virtual ResPartner PartnerShipping { get; set; } = null!;

    public virtual ProductPricelist1 Pricelist { get; set; } = null!;

    public virtual HotelRoom Room { get; set; } = null!;

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
