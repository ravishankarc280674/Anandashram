using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Make Procurements
/// </summary>
public partial class MakeProcurement
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
    /// Planned Date
    /// </summary>
    public DateOnly DatePlanned { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int WarehouseId { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public int UomId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ProductUom Uom { get; set; } = null!;

    public virtual StockWarehouse Warehouse { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
