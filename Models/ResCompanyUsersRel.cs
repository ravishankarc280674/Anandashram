using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN res_company AND res_users
/// </summary>
public partial class ResCompanyUsersRel
{
    public int Cid { get; set; }

    public int UserId { get; set; }

    public virtual ResCompany CidNavigation { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;
}
