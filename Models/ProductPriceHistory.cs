using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// product.price.history
/// </summary>
public partial class ProductPriceHistory
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
    public int CompanyId { get; set; }

    /// <summary>
    /// Historization Time
    /// </summary>
    public DateTime? Datetime { get; set; }

    /// <summary>
    /// Historized Cost
    /// </summary>
    public decimal? Cost { get; set; }

    /// <summary>
    /// Product Template
    /// </summary>
    public int ProductTemplateId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductTemplate ProductTemplate { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
