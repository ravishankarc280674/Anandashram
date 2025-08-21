using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Country
/// </summary>
public partial class ResCountry
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Country Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Country Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Image
    /// </summary>
    public byte[]? Image { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Address Format
    /// </summary>
    public string? AddressFormat { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ICollection<ResBank> ResBanks { get; set; } = new List<ResBank>();

    public virtual ICollection<ResCountryState> ResCountryStates { get; set; } = new List<ResCountryState>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ResUser? WriteU { get; set; }
}
