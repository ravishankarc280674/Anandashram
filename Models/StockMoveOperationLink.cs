using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Link between stock moves and pack operations
/// </summary>
public partial class StockMoveOperationLink
{
    public int Id { get; set; }

    /// <summary>
    /// Reserved Quant
    /// </summary>
    public int? ReservedQuantId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public double? Qty { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Operation
    /// </summary>
    public int OperationId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Move
    /// </summary>
    public int MoveId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockMove Move { get; set; } = null!;

    public virtual StockPackOperation Operation { get; set; } = null!;

    public virtual StockQuant? ReservedQuant { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
