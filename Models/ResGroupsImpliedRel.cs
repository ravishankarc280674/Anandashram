using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN res_groups AND res_groups
/// </summary>
public partial class ResGroupsImpliedRel
{
    public int Gid { get; set; }

    public int Hid { get; set; }

    public virtual ResGroup GidNavigation { get; set; } = null!;

    public virtual ResGroup HidNavigation { get; set; } = null!;
}
