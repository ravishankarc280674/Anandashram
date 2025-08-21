using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ReportDocumentFile
{
    public int? Id { get; set; }

    public long? Nbr { get; set; }

    public string? Month { get; set; }

    public long? FileSize { get; set; }
}
