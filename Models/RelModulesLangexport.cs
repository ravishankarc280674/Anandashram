using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN base_language_export AND ir_module_module
/// </summary>
public partial class RelModulesLangexport
{
    public int WizId { get; set; }

    public int ModuleId { get; set; }

    public virtual IrModuleModule Module { get; set; } = null!;

    public virtual BaseLanguageExport Wiz { get; set; } = null!;
}
