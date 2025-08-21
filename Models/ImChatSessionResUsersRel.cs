using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// im_chat.conversation_state
/// </summary>
public partial class ImChatSessionResUsersRel
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Users
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Session
    /// </summary>
    public int SessionId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// unknown
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ImChatSession Session { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
