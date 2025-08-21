using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.default
/// </summary>
public partial class IrDefault
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
    /// Users
    /// </summary>
    public int? Uid { get; set; }

    /// <summary>
    /// Table Ref.
    /// </summary>
    public string? RefTable { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Default Value
    /// </summary>
    public string? Value { get; set; }

    /// <summary>
    /// ID Ref.
    /// </summary>
    public int? RefId { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Object
    /// </summary>
    public string? FieldTbl { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Object Field
    /// </summary>
    public string? FieldName { get; set; }

    /// <summary>
    /// View
    /// </summary>
    public string? Page { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? UidNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
