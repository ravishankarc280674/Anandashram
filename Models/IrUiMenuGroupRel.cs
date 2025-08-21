using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_ui_menu AND res_groups
/// </summary>
public partial class IrUiMenuGroupRel
{
    public int MenuId { get; set; }

    public int Gid { get; set; }

    public virtual ResGroup GidNavigation { get; set; } = null!;

    public virtual IrUiMenu Menu { get; set; } = null!;
}
