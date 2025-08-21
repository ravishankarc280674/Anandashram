using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN wkf_instance AND wkf_transition
/// </summary>
public partial class WkfWitmTran
{
    public int InstId { get; set; }

    public int TransId { get; set; }

    public virtual WkfInstance Inst { get; set; } = null!;

    public virtual WkfTransition Trans { get; set; } = null!;
}
