using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// stock.return.picking.line
/// </summary>
public partial class StockReturnPickingLine
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
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int? WizardId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Move
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockProductionLot? Lot { get; set; }

    public virtual StockMove? Move { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual StockReturnPicking? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
