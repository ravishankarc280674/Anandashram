using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// The picking type determines the picking view
/// </summary>
public partial class StockPickingType
{
    public int Id { get; set; }

    /// <summary>
    /// Type of Operation
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Default Destination Location
    /// </summary>
    public int? DefaultLocationDestId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Reference Sequence
    /// </summary>
    public int SequenceId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Picking Type Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Picking Type for Returns
    /// </summary>
    public int? ReturnPickingTypeId { get; set; }

    /// <summary>
    /// Default Source Location
    /// </summary>
    public int? DefaultLocationSrcId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? DefaultLocationDest { get; set; }

    public virtual StockLocation? DefaultLocationSrc { get; set; }

    public virtual ICollection<StockPickingType> InverseReturnPickingType { get; set; } = new List<StockPickingType>();

    public virtual ICollection<ProcurementRule> ProcurementRules { get; set; } = new List<ProcurementRule>();

    public virtual StockPickingType? ReturnPickingType { get; set; }

    public virtual IrSequence SequenceNavigation { get; set; } = null!;

    public virtual ICollection<StockLocationPath> StockLocationPaths { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockWarehouse> StockWarehouseInTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseIntTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehouseOutTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePackTypes { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouse> StockWarehousePickTypes { get; set; } = new List<StockWarehouse>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
