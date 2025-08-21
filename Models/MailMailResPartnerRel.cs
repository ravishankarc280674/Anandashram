using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_mail AND res_partner
/// </summary>
public partial class MailMailResPartnerRel
{
    public int MailMailId { get; set; }

    public int ResPartnerId { get; set; }

    public virtual MailMail MailMail { get; set; } = null!;

    public virtual ResPartner ResPartner { get; set; } = null!;
}
