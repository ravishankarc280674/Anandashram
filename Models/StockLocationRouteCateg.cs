using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN product_category AND stock_location_route
/// </summary>
public partial class StockLocationRouteCateg
{
    public int CategId { get; set; }

    public int RouteId { get; set; }

    public virtual ProductCategory Categ { get; set; } = null!;

    public virtual StockLocationRoute Route { get; set; } = null!;
}
