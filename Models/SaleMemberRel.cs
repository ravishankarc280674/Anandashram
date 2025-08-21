using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN crm_case_section AND res_users
/// </summary>
public partial class SaleMemberRel
{
    public int SectionId { get; set; }

    public int MemberId { get; set; }

    public virtual ResUser Member { get; set; } = null!;

    public virtual CrmCaseSection Section { get; set; } = null!;
}
