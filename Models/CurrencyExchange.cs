using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// currency
/// </summary>
public partial class CurrencyExchange
{
    public int Id { get; set; }

    /// <summary>
    /// Guest Name
    /// </summary>
    public int? GuestName { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Output Currency
    /// </summary>
    public int? OutCurr { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Subtotal
    /// </summary>
    public double? OutAmount { get; set; }

    /// <summary>
    /// Room Number
    /// </summary>
    public string? RoomNumber { get; set; }

    /// <summary>
    /// Service Tax
    /// </summary>
    public string? Tax { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Aaashrmam Name
    /// </summary>
    public int? HotelId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date Ordered
    /// </summary>
    public DateTime TodayDate { get; set; }

    /// <summary>
    /// Rate(per unit)
    /// </summary>
    public double? Rate { get; set; }

    /// <summary>
    /// Amount Taken
    /// </summary>
    public double? InAmount { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Folio Number
    /// </summary>
    public int? FolioNo { get; set; }

    /// <summary>
    /// Input Currency
    /// </summary>
    public int? InputCurr { get; set; }

    /// <summary>
    /// Amount Given
    /// </summary>
    public double? Total { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Reg Number
    /// </summary>
    public string? Name { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner? GuestNameNavigation { get; set; }

    public virtual StockWarehouse? Hotel { get; set; }

    public virtual ResCurrency? InputCurrNavigation { get; set; }

    public virtual ResCurrency? OutCurrNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
