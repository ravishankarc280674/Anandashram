using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Notifications
/// </summary>
public partial class MailNotification
{
    public int Id { get; set; }

    /// <summary>
    /// Read
    /// </summary>
    public bool? IsRead { get; set; }

    /// <summary>
    /// Starred
    /// </summary>
    public bool? Starred { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public int MessageId { get; set; }

    public virtual MailMessage Message { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;
}
