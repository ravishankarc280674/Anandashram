using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Quants
/// </summary>
public partial class StockQuant
{
    public int Id { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double Qty { get; set; }

    /// <summary>
    /// Linked Quant
    /// </summary>
    public int? PropagatedFromId { get; set; }

    /// <summary>
    /// Package
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Unit Cost
    /// </summary>
    public double? Cost { get; set; }

    /// <summary>
    /// Lot
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Reserved for Move
    /// </summary>
    public int? ReservationId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Type of packaging
    /// </summary>
    public int? PackagingTypeId { get; set; }

    /// <summary>
    /// Move Negative Quant
    /// </summary>
    public int? NegativeMoveId { get; set; }

    /// <summary>
    /// Incoming Date
    /// </summary>
    public DateTime? InDate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockQuant> InversePropagatedFrom { get; set; } = new List<StockQuant>();

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockProductionLot? Lot { get; set; }

    public virtual StockMove? NegativeMove { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual ProductPackaging? PackagingType { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual StockQuant? PropagatedFrom { get; set; }

    public virtual StockMove? Reservation { get; set; }

    public virtual ICollection<StockMoveOperationLink> StockMoveOperationLinks { get; set; } = new List<StockMoveOperationLink>();

    public virtual ResUser? WriteU { get; set; }
}
