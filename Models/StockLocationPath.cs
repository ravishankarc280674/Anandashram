using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Pushed Flows
/// </summary>
public partial class StockLocationPath
{
    public int Id { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationFromId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Route Sequence
    /// </summary>
    public decimal? RouteSequence { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Operation Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type of the new Operation
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Automatic Move
    /// </summary>
    public string Auto { get; set; } = null!;

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Warehouse
    /// </summary>
    public int? WarehouseId { get; set; }

    /// <summary>
    /// Delay (days)
    /// </summary>
    public int? Delay { get; set; }

    /// <summary>
    /// Route
    /// </summary>
    public int? RouteId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Propagate cancel and split
    /// </summary>
    public bool? Propagate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual StockLocation LocationFrom { get; set; } = null!;

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual StockLocationRoute? Route { get; set; }

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual StockWarehouse? Warehouse { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
