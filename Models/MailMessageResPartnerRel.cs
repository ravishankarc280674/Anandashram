using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_message AND res_partner
/// </summary>
public partial class MailMessageResPartnerRel
{
    public int MailMessageId { get; set; }

    public int ResPartnerId { get; set; }

    public virtual MailMessage MailMessage { get; set; } = null!;

    public virtual ResPartner ResPartner { get; set; } = null!;
}
