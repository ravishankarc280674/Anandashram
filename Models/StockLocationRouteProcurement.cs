using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN procurement_order AND stock_location_route
/// </summary>
public partial class StockLocationRouteProcurement
{
    public int ProcurementId { get; set; }

    public int RouteId { get; set; }

    public virtual ProcurementOrder Procurement { get; set; } = null!;

    public virtual StockLocationRoute Route { get; set; } = null!;
}
