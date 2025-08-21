using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN ir_model_fields AND res_groups
/// </summary>
public partial class IrModelFieldsGroupRel
{
    public int FieldId { get; set; }

    public int GroupId { get; set; }

    public virtual IrModelField Field { get; set; } = null!;

    public virtual ResGroup Group { get; set; } = null!;
}
