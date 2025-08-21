using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_act_report_xml AND res_groups
/// </summary>
public partial class ResGroupsReportRel
{
    public int Uid { get; set; }

    public int Gid { get; set; }

    public virtual ResGroup GidNavigation { get; set; } = null!;

    public virtual IrActReportXml UidNavigation { get; set; } = null!;
}
