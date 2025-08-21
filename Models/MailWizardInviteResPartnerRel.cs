using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_wizard_invite AND res_partner
/// </summary>
public partial class MailWizardInviteResPartnerRel
{
    public int MailWizardInviteId { get; set; }

    public int ResPartnerId { get; set; }

    public virtual MailWizardInvite MailWizardInvite { get; set; } = null!;

    public virtual ResPartner ResPartner { get; set; } = null!;
}
