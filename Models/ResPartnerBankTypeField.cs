using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Bank type fields
/// </summary>
public partial class ResPartnerBankTypeField
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
    /// Field Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Required
    /// </summary>
    public bool? Required { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Readonly
    /// </summary>
    public bool? Readonly { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Bank Type
    /// </summary>
    public int BankTypeId { get; set; }

    /// <summary>
    /// Max. Size
    /// </summary>
    public int? Size { get; set; }

    public virtual ResPartnerBankType BankType { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
