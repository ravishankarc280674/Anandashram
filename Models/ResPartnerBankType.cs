using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Bank Account Type
/// </summary>
public partial class ResPartnerBankType
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Format Layout
    /// </summary>
    public string? FormatLayout { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResPartnerBankTypeField> ResPartnerBankTypeFields { get; set; } = new List<ResPartnerBankTypeField>();

    public virtual ResUser? WriteU { get; set; }
}
