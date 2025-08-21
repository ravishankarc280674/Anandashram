using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ReportStockLinesDate
{
    public int? Id { get; set; }

    public int? ProductId { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? MoveDate { get; set; }

    public bool? Active { get; set; }
}
