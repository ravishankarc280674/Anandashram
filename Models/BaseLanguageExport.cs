using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// base.language.export
/// </summary>
public partial class BaseLanguageExport
{
    public int Id { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string Lang { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// File Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// File Format
    /// </summary>
    public string Format { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// unknown
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// File
    /// </summary>
    public byte[]? Data { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
