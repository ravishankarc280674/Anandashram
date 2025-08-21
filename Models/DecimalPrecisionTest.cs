using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// decimal.precision.test
/// </summary>
public partial class DecimalPrecisionTest
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
    /// unknown
    /// </summary>
    public decimal? Float2 { get; set; }

    /// <summary>
    /// unknown
    /// </summary>
    public double? Float { get; set; }

    /// <summary>
    /// unknown
    /// </summary>
    public decimal? Float4 { get; set; }

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
