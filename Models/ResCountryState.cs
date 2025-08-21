using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Country state
/// </summary>
public partial class ResCountryState
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// State Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// State Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Country
    /// </summary>
    public int CountryId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCountry Country { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResBank> ResBanks { get; set; } = new List<ResBank>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ResUser? WriteU { get; set; }
}
