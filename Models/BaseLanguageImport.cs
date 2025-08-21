using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Language Import
/// </summary>
public partial class BaseLanguageImport
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// ISO Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Language Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// File
    /// </summary>
    public byte[] Data { get; set; } = null!;

    /// <summary>
    /// Overwrite Existing Terms
    /// </summary>
    public bool? Overwrite { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
