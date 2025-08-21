using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// decimal.precision
/// </summary>
public partial class DecimalPrecision
{
    public int Id { get; set; }

    /// <summary>
    /// Digits
    /// </summary>
    public int Digits { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Usage
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

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
