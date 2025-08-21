using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// im_chat.presence
/// </summary>
public partial class ImChatPresence
{
    public int Id { get; set; }

    /// <summary>
    /// IM Status
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Presence
    /// </summary>
    public DateTime? LastPresence { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Last Poll
    /// </summary>
    public DateTime? LastPoll { get; set; }

    /// <summary>
    /// Users
    /// </summary>
    public int UserId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
