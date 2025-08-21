using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_followers AND mail_message_subtype
/// </summary>
public partial class MailFollowersMailMessageSubtypeRel
{
    public int MailFollowersId { get; set; }

    public int MailMessageSubtypeId { get; set; }

    public virtual MailFollower MailFollowers { get; set; } = null!;

    public virtual MailMessageSubtype MailMessageSubtype { get; set; } = null!;
}
