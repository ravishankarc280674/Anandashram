using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Picking List
/// </summary>
public partial class StockPicking
{
    public int Id { get; set; }

    /// <summary>
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Date of Transfer
    /// </summary>
    public DateTime? DateDone { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public string Priority { get; set; } = null!;

    /// <summary>
    /// Back Order of
    /// </summary>
    public int? BackorderId { get; set; }

    /// <summary>
    /// Picking Type
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Delivery Method
    /// </summary>
    public string MoveType { get; set; } = null!;

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateTime? MinDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Recompute pack operation?
    /// </summary>
    public bool? RecomputePackOp { get; set; }

    /// <summary>
    /// Max. Expected Date
    /// </summary>
    public DateTime? MaxDate { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    public virtual StockPicking? Backorder { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual ICollection<StockPicking> InverseBackorder { get; set; } = new List<StockPicking>();

    public virtual ResPartner? Owner { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackOperation> StockPackOperations { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockTransferDetail> StockTransferDetails { get; set; } = new List<StockTransferDetail>();

    public virtual ResUser? WriteU { get; set; }
}
