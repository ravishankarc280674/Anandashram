using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN share_wizard AND res_groups
/// </summary>
public partial class ShareWizardResGroupRel
{
    public int ShareId { get; set; }

    public int GroupId { get; set; }

    public virtual ResGroup Group { get; set; } = null!;

    public virtual ShareWizard Share { get; set; } = null!;
}
