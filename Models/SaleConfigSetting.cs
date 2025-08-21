using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// sale.config.settings
/// </summary>
public partial class SaleConfigSetting
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Get contacts automatically from linkedIn
    /// </summary>
    public bool? ModuleWebLinkedin { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// SALE
    /// </summary>
    public bool? ModuleSale { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// CRM
    /// </summary>
    public bool? ModuleCrm { get; set; }

    /// <summary>
    /// Manage mass mailing campaigns
    /// </summary>
    public bool? ModuleMassMailing { get; set; }

    /// <summary>
    /// Organize Sales activities into multiple Sales Teams
    /// </summary>
    public bool? GroupMultiSalesteams { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
