using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Reservation Line
/// </summary>
public partial class HotelReservationLine
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
    /// Block
    /// </summary>
    public int? BlockId { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Room
    /// </summary>
    public int Room { get; set; }

    /// <summary>
    /// Floor
    /// </summary>
    public int? FloorId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Line id
    /// </summary>
    public int? LineId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// No of person(s) to allocate
    /// </summary>
    public int ToAllocate { get; set; }

    /// <summary>
    /// Already allocated
    /// </summary>
    public int? Allocated { get; set; }

    /// <summary>
    /// Building
    /// </summary>
    public int? BuildingId { get; set; }

    /// <summary>
    /// Room Type
    /// </summary>
    public int? CategId { get; set; }

    public virtual Block? Block { get; set; }

    public virtual Building? Building { get; set; }

    public virtual ProductCategory? Categ { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HotelFloor? Floor { get; set; }

    public virtual HotelReservation? Line { get; set; }

    public virtual HotelRoom RoomNavigation { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
