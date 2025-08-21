using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.logging
/// </summary>
public partial class IrLogging
{
    public int Id { get; set; }

    /// <summary>
    /// Uid
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Create Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Level
    /// </summary>
    public string? Level { get; set; }

    /// <summary>
    /// Line
    /// </summary>
    public string Line { get; set; } = null!;

    /// <summary>
    /// Database Name
    /// </summary>
    public string? Dbname { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Function
    /// </summary>
    public string Func { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Path
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Message
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
