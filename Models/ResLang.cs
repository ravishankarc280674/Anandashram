using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ResLang
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    /// <summary>
    /// Date Format
    /// </summary>
    public string DateFormat { get; set; } = null!;

    /// <summary>
    /// Direction
    /// </summary>
    public string Direction { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Thousands Separator
    /// </summary>
    public string? ThousandsSep { get; set; }

    /// <summary>
    /// Translatable
    /// </summary>
    public bool? Translatable { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Time Format
    /// </summary>
    public string TimeFormat { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Decimal Separator
    /// </summary>
    public string DecimalPoint { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// ISO code
    /// </summary>
    public string? IsoCode { get; set; }

    /// <summary>
    /// Separator Format
    /// </summary>
    public string Grouping { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrTranslation> IrTranslations { get; set; } = new List<IrTranslation>();

    public virtual ResUser? WriteU { get; set; }
}
