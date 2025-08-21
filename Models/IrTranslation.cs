using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.translation
/// </summary>
public partial class IrTranslation
{
    public int Id { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Old source
    /// </summary>
    public string? Src { get; set; }

    /// <summary>
    /// Translated field
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Record ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public string? Module { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Translation comments
    /// </summary>
    public string? Comments { get; set; }

    /// <summary>
    /// Translation Value
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string? Type { get; set; }

    public virtual ResLang? LangNavigation { get; set; }
}
