using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Reservation
/// </summary>
public partial class MealReservation
{
    public int Id { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// No of Persons
    /// </summary>
    public int NoOfPersons { get; set; }

    /// <summary>
    /// Ashram
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Place
    /// </summary>
    public string Place { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Devotee
    /// </summary>
    public int? DevoteeId { get; set; }

    /// <summary>
    /// Date Ordered
    /// </summary>
    public DateTime DateOrder { get; set; }

    /// <summary>
    /// Guest Name
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// MealPass No
    /// </summary>
    public string? ReservationNo { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AshramDevotee? Devotee { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
