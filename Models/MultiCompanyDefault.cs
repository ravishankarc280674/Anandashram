using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Default multi company
/// </summary>
public partial class MultiCompanyDefault
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int? FieldId { get; set; }

    /// <summary>
    /// Main Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public int ObjectId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Default Company
    /// </summary>
    public int CompanyDestId { get; set; }

    /// <summary>
    /// Expression
    /// </summary>
    public string Expression { get; set; } = null!;

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResCompany CompanyDest { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField? Field { get; set; }

    public virtual IrModel Object { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
