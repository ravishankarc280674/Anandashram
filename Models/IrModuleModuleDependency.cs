using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class IrModuleModuleDependency
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public int? WriteUid { get; set; }

    public string? Name { get; set; }

    public int? ModuleId { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule? Module { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
