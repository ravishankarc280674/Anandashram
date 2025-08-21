using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN stock_move AND stock_location_route
/// </summary>
public partial class StockLocationRouteMove
{
    public int MoveId { get; set; }

    public int RouteId { get; set; }

    public virtual StockMove Move { get; set; } = null!;

    public virtual StockLocationRoute Route { get; set; } = null!;
}
