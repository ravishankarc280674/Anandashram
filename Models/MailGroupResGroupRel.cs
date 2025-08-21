using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN mail_group AND res_groups
/// </summary>
public partial class MailGroupResGroupRel
{
    public int MailGroupId { get; set; }

    public int GroupsId { get; set; }

    public virtual ResGroup Groups { get; set; } = null!;

    public virtual MailGroup MailGroup { get; set; } = null!;
}
