using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_act_window AND res_groups
/// </summary>
public partial class IrActWindowGroupRel
{
    public int ActId { get; set; }

    public int Gid { get; set; }

    public virtual IrActWindow Act { get; set; } = null!;

    public virtual ResGroup GidNavigation { get; set; } = null!;
}
