using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN share_wizard AND res_users
/// </summary>
public partial class ShareWizardResUserRel
{
    public int ShareId { get; set; }

    public int UserId { get; set; }

    public virtual ShareWizard Share { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;
}
