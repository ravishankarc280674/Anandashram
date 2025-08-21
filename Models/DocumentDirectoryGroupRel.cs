using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// RELATION BETWEEN document_directory AND res_groups
/// </summary>
public partial class DocumentDirectoryGroupRel
{
    public int ItemId { get; set; }

    public int GroupId { get; set; }

    public virtual ResGroup Group { get; set; } = null!;

    public virtual DocumentDirectory Item { get; set; } = null!;
}
