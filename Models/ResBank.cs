using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Bank
/// </summary>
public partial class ResBank
{
    public int Id { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? Country { get; set; }

    /// <summary>
    /// Street2
    /// </summary>
    public string? Street2 { get; set; }

    /// <summary>
    /// Bank Identifier Code
    /// </summary>
    public string? Bic { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Fed. State
    /// </summary>
    public int? State { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    public virtual ResCountry? CountryNavigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ResCountryState? StateNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
