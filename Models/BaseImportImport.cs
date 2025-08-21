using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// base_import.import
/// </summary>
public partial class BaseImportImport
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// File Type
    /// </summary>
    public string? FileType { get; set; }

    /// <summary>
    /// File Name
    /// </summary>
    public string? FileName { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// File
    /// </summary>
    public byte[]? File { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string? ResModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
