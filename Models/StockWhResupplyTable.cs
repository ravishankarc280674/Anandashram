using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN stock_warehouse AND stock_warehouse
/// </summary>
public partial class StockWhResupplyTable
{
    public int SuppliedWhId { get; set; }

    public int SupplierWhId { get; set; }

    public virtual StockWarehouse SuppliedWh { get; set; } = null!;

    public virtual StockWarehouse SupplierWh { get; set; } = null!;
}
