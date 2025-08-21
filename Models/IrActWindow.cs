using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrActWindow
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Help { get; set; }

    public int? WriteUid { get; set; }

    public DateTime? WriteDate { get; set; }

    public string? Usage { get; set; }

    public string Type { get; set; } = null!;

    public string Name { get; set; } = null!;

    /// <summary>
    /// Domain Value
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Destination Model
    /// </summary>
    public string ResModel { get; set; } = null!;

    /// <summary>
    /// Search View Ref.
    /// </summary>
    public int? SearchViewId { get; set; }

    /// <summary>
    /// View Type
    /// </summary>
    public string ViewType { get; set; } = null!;

    /// <summary>
    /// Source Model
    /// </summary>
    public string? SrcModel { get; set; }

    /// <summary>
    /// View Ref.
    /// </summary>
    public int? ViewId { get; set; }

    /// <summary>
    /// Auto-Refresh
    /// </summary>
    public int? AutoRefresh { get; set; }

    /// <summary>
    /// View Mode
    /// </summary>
    public string ViewMode { get; set; } = null!;

    /// <summary>
    /// Restrict to lists
    /// </summary>
    public bool? Multi { get; set; }

    /// <summary>
    /// Target Window
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// Auto Search
    /// </summary>
    public bool? AutoSearch { get; set; }

    /// <summary>
    /// Record ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Filter
    /// </summary>
    public bool? Filter { get; set; }

    /// <summary>
    /// Limit
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Context Value
    /// </summary>
    public string Context { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviews { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<IrActWindowView> IrActWindowViews { get; set; } = new List<IrActWindowView>();

    public virtual IrUiView? SearchView { get; set; }

    public virtual ICollection<ShareWizard> ShareWizards { get; set; } = new List<ShareWizard>();

    public virtual IrUiView? View { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
