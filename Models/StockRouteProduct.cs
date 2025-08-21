using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN product_template AND stock_location_route
/// </summary>
public partial class StockRouteProduct
{
    public int ProductId { get; set; }

    public int RouteId { get; set; }

    public virtual ProductTemplate Product { get; set; } = null!;

    public virtual StockLocationRoute Route { get; set; } = null!;
}
