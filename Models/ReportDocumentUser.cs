using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ReportDocumentUser
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Month { get; set; }

    public int? UserId { get; set; }

    public long? Nbr { get; set; }

    public string? Directory { get; set; }

    public string? DatasFname { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? FileSize { get; set; }

    public string? Type { get; set; }

    public DateTime? ChangeDate { get; set; }
}
