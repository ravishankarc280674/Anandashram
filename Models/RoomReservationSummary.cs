using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Room reservation summary
/// </summary>
public partial class RoomReservationSummary
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
    /// Date From
    /// </summary>
    public DateTime? DateFrom { get; set; }

    /// <summary>
    /// Summary Header
    /// </summary>
    public string? SummaryHeader { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Date To
    /// </summary>
    public DateTime? DateTo { get; set; }

    /// <summary>
    /// Room Summary
    /// </summary>
    public string? RoomSummary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
