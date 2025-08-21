using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// ir.property
/// </summary>
public partial class IrProperty
{
    public int Id { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public string? ValueText { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public double? ValueFloat { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int FieldsId { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public DateTime? ValueDatetime { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public byte[]? ValueBinary { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public string? ValueReference { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public int? ValueInteger { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public string? ResId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField Fields { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
