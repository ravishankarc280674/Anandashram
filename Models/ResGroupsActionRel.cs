using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_actions_todo AND res_groups
/// </summary>
public partial class ResGroupsActionRel
{
    public int Uid { get; set; }

    public int Gid { get; set; }

    public virtual ResGroup GidNavigation { get; set; } = null!;

    public virtual IrActionsTodo UidNavigation { get; set; } = null!;
}
