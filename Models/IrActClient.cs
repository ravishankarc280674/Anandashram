using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrActClient
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
    /// Destination Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Params storage
    /// </summary>
    public byte[]? ParamsStore { get; set; }

    /// <summary>
    /// Client action tag
    /// </summary>
    public string Tag { get; set; } = null!;

    /// <summary>
    /// Context Value
    /// </summary>
    public string Context { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
