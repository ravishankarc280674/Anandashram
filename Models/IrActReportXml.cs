using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrActReportXml
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
    /// Parser Class
    /// </summary>
    public string? Parser { get; set; }

    /// <summary>
    /// Add RML Header
    /// </summary>
    public bool? Header { get; set; }

    /// <summary>
    /// Report Type
    /// </summary>
    public string ReportType { get; set; } = null!;

    /// <summary>
    /// Save as Attachment Prefix
    /// </summary>
    public string? Attachment { get; set; }

    /// <summary>
    /// SXW Content
    /// </summary>
    public byte[]? ReportSxwContentData { get; set; }

    /// <summary>
    /// XML Path
    /// </summary>
    public string? ReportXml { get; set; }

    /// <summary>
    /// RML Content
    /// </summary>
    public byte[]? ReportRmlContentData { get; set; }

    /// <summary>
    /// Custom Python Parser
    /// </summary>
    public bool? Auto { get; set; }

    /// <summary>
    /// Report File
    /// </summary>
    public string? ReportFile { get; set; }

    /// <summary>
    /// On Multiple Doc.
    /// </summary>
    public bool? Multi { get; set; }

    /// <summary>
    /// XSL Path
    /// </summary>
    public string? ReportXsl { get; set; }

    /// <summary>
    /// Main Report File Path/controller
    /// </summary>
    public string? ReportRml { get; set; }

    /// <summary>
    /// Template Name
    /// </summary>
    public string ReportName { get; set; } = null!;

    /// <summary>
    /// Reload from Attachment
    /// </summary>
    public bool? AttachmentUse { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Paper format
    /// </summary>
    public int? PaperformatId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<DocumentDirectoryContent> DocumentDirectoryContents { get; set; } = new List<DocumentDirectoryContent>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviews { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplates { get; set; } = new List<EmailTemplate>();

    public virtual ReportPaperformat? Paperformat { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
