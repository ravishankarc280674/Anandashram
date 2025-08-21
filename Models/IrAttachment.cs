using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.attachment
/// </summary>
public partial class IrAttachment
{
    public int Id { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Date Created
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Resource Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// File Size
    /// </summary>
    public int? FileSize { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Resource Name
    /// </summary>
    public string? ResName { get; set; }

    /// <summary>
    /// Database Data
    /// </summary>
    public byte[]? DbDatas { get; set; }

    /// <summary>
    /// File Name
    /// </summary>
    public string? DatasFname { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Resource ID
    /// </summary>
    public int? ResId { get; set; }

    /// <summary>
    /// Stored Filename
    /// </summary>
    public string? StoreFname { get; set; }

    /// <summary>
    /// Attachment Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Content Type
    /// </summary>
    public string? FileType { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Directory
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Indexed Content
    /// </summary>
    public string? IndexContent { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual DocumentDirectory? Parent { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
