using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Directory Content
/// </summary>
public partial class DocumentDirectoryContent
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Report
    /// </summary>
    public int? ReportId { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Content Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Document Type
    /// </summary>
    public string Extension { get; set; } = null!;

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Include Record Name
    /// </summary>
    public bool? IncludeName { get; set; }

    /// <summary>
    /// Directory
    /// </summary>
    public int? DirectoryId { get; set; }

    /// <summary>
    /// Prefix
    /// </summary>
    public string? Prefix { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Suffix
    /// </summary>
    public string? Suffix { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual DocumentDirectory? Directory { get; set; }

    public virtual IrActReportXml? Report { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
