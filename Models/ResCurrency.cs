using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ResCurrency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Rounding Factor
    /// </summary>
    public decimal? Rounding { get; set; }

    /// <summary>
    /// Symbol
    /// </summary>
    public string? Symbol { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Base
    /// </summary>
    public bool? Base { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Symbol Position
    /// </summary>
    public string? Position { get; set; }

    /// <summary>
    /// Computational Accuracy
    /// </summary>
    public int? Accuracy { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CurrencyExchange> CurrencyExchangeInputCurrNavigations { get; set; } = new List<CurrencyExchange>();

    public virtual ICollection<CurrencyExchange> CurrencyExchangeOutCurrNavigations { get; set; } = new List<CurrencyExchange>();

    public virtual ICollection<ProductPriceType> ProductPriceTypes { get; set; } = new List<ProductPriceType>();

    public virtual ICollection<ProductPricelist1> ProductPricelist1s { get; set; } = new List<ProductPricelist1>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCountry> ResCountries { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<StockPackOperation> StockPackOperations { get; set; } = new List<StockPackOperation>();

    public virtual ResUser? WriteU { get; set; }
}
