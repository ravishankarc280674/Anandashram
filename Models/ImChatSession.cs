using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// im_chat.session
/// </summary>
public partial class ImChatSession
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
    /// UUID
    /// </summary>
    public string? Uuid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ImChatMessage> ImChatMessages { get; set; } = new List<ImChatMessage>();

    public virtual ICollection<ImChatSessionResUsersRel> ImChatSessionResUsersRels { get; set; } = new List<ImChatSessionResUsersRel>();

    public virtual ResUser? WriteU { get; set; }
}
