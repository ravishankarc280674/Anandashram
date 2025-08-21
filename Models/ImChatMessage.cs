using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// im_chat.message
/// </summary>
public partial class ImChatMessage
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Create Date
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Session To
    /// </summary>
    public int ToId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Author
    /// </summary>
    public int? FromId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? From { get; set; }

    public virtual ImChatSession To { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
