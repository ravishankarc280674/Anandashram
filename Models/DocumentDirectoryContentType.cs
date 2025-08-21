using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Directory Content Type
/// </summary>
public partial class DocumentDirectoryContentType
{
    public int Id { get; set; }

    /// <summary>
    /// Mime Type
    /// </summary>
    public string? Mimetype { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Extension
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Content Type
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
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
