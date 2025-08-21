using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_message AND res_users
/// </summary>
public partial class MailVote
{
    public int MessageId { get; set; }

    public int UserId { get; set; }

    public virtual MailMessage Message { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;
}
