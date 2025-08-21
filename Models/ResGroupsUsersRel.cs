using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN res_groups AND res_users
/// </summary>
public partial class ResGroupsUsersRel
{
    public int Gid { get; set; }

    public int Uid { get; set; }

    public virtual ResGroup GidNavigation { get; set; } = null!;

    public virtual ResUser UidNavigation { get; set; } = null!;
}
