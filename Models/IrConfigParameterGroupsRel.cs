using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_config_parameter AND res_groups
/// </summary>
public partial class IrConfigParameterGroupsRel
{
    public int IcpId { get; set; }

    public int GroupId { get; set; }

    public virtual ResGroup Group { get; set; } = null!;

    public virtual IrConfigParameter Icp { get; set; } = null!;
}
