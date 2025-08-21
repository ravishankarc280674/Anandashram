using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Directory Dynamic Context
/// </summary>
public partial class DocumentDirectoryDctx
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
    /// Field
    /// </summary>
    public string Field { get; set; } = null!;

    /// <summary>
    /// Expression
    /// </summary>
    public string Expr { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Directory
    /// </summary>
    public int DirId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual DocumentDirectory Dir { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
