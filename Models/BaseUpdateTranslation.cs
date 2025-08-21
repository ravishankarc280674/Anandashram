using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// base.update.translations
/// </summary>
public partial class BaseUpdateTranslation
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
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
