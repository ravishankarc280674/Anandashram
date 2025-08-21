using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Price Type
/// </summary>
public partial class ProductPriceType
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
    /// Price Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Product Field
    /// </summary>
    public string Field { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
