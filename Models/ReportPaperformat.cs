using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Allows customization of a report.
/// </summary>
public partial class ReportPaperformat
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Page width (mm)
    /// </summary>
    public int? PageWidth { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Paper size
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// Default paper format ?
    /// </summary>
    public bool? Default { get; set; }

    /// <summary>
    /// Display a header line
    /// </summary>
    public bool? HeaderLine { get; set; }

    /// <summary>
    /// Header spacing
    /// </summary>
    public int? HeaderSpacing { get; set; }

    /// <summary>
    /// Output DPI
    /// </summary>
    public int Dpi { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Right Margin (mm)
    /// </summary>
    public int? MarginRight { get; set; }

    /// <summary>
    /// Top Margin (mm)
    /// </summary>
    public int? MarginTop { get; set; }

    /// <summary>
    /// Left Margin (mm)
    /// </summary>
    public int? MarginLeft { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Bottom Margin (mm)
    /// </summary>
    public int? MarginBottom { get; set; }

    /// <summary>
    /// Page height (mm)
    /// </summary>
    public int? PageHeight { get; set; }

    /// <summary>
    /// Orientation
    /// </summary>
    public string? Orientation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrActReportXml> IrActReportXmls { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ResUser? WriteU { get; set; }
}
