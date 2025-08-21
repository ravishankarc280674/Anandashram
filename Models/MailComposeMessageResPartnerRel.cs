using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_compose_message AND res_partner
/// </summary>
public partial class MailComposeMessageResPartnerRel
{
    public int WizardId { get; set; }

    public int PartnerId { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual MailComposeMessage Wizard { get; set; } = null!;
}
