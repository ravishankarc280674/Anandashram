using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN stock_quant AND stock_move
/// </summary>
public partial class StockQuantMoveRel
{
    public int QuantId { get; set; }

    public int MoveId { get; set; }

    public virtual StockMove Move { get; set; } = null!;

    public virtual StockQuant Quant { get; set; } = null!;
}
