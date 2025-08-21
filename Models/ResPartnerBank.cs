using System;
using System.Collections.Generic;

namespace Anandashram.Models;

/// <summary>
/// Bank Accounts
/// </summary>
public partial class ResPartnerBank
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Account Owner Name
    /// </summary>
    public string? OwnerName { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Bank Account
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Display on Reports
    /// </summary>
    public bool? Footer { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Bank Name
    /// </summary>
    public string? BankName { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Bank Account Type
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Street
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Fed. State
    /// </summary>
    public int? StateId { get; set; }

    /// <summary>
    /// Bank Identifier Code
    /// </summary>
    public string? BankBic { get; set; }

    /// <summary>
    /// Account Owner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Bank
    /// </summary>
    public int? Bank { get; set; }

    /// <summary>
    /// Account Number
    /// </summary>
    public string AccNumber { get; set; } = null!;

    public virtual ResBank? BankNavigation { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ResPartner? Partner { get; set; }

    public virtual ResCountryState? StateNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
