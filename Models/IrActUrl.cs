using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrActUrl
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Help { get; set; }

    public int? WriteUid { get; set; }

    public DateTime? WriteDate { get; set; }

    public string? Usage { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    /// <summary>
    /// Action Target
    /// </summary>
    public string Target { get; set; } = null!;

    /// <summary>
    /// Action URL
    /// </summary>
    public string Url { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
