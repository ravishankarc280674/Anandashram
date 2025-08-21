using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN stock_warehouse AND stock_location_route
/// </summary>
public partial class StockRouteWarehouse
{
    public int WarehouseId { get; set; }

    public int RouteId { get; set; }

    public virtual StockLocationRoute Route { get; set; } = null!;

    public virtual StockWarehouse Warehouse { get; set; } = null!;
}
