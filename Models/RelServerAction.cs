using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_act_server AND ir_act_server
/// </summary>
public partial class RelServerAction
{
    public int ServerId { get; set; }

    public int ActionId { get; set; }

    public virtual IrActServer Action { get; set; } = null!;

    public virtual IrActServer Server { get; set; } = null!;
}
