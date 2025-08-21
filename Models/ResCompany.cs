using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ResCompany
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int PartnerId { get; set; }

    public int CurrencyId { get; set; }

    /// <summary>
    /// Report Footer
    /// </summary>
    public string? RmlFooter { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// RML Header
    /// </summary>
    public string RmlHeader { get; set; } = null!;

    /// <summary>
    /// Paper Format
    /// </summary>
    public string RmlPaperFormat { get; set; } = null!;

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Logo Web
    /// </summary>
    public byte[]? LogoWeb { get; set; }

    /// <summary>
    /// Font
    /// </summary>
    public int? Font { get; set; }

    /// <summary>
    /// Account No.
    /// </summary>
    public string? AccountNo { get; set; }

    /// <summary>
    /// Parent Company
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Custom Footer
    /// </summary>
    public bool? CustomFooter { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// RML Internal Header
    /// </summary>
    public string RmlHeader2 { get; set; } = null!;

    /// <summary>
    /// RML Internal Header for Landscape Reports
    /// </summary>
    public string RmlHeader3 { get; set; } = null!;

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Company Tagline
    /// </summary>
    public string? RmlHeader1 { get; set; }

    /// <summary>
    /// Company Registry
    /// </summary>
    public string? CompanyRegistry { get; set; }

    /// <summary>
    /// Paper format
    /// </summary>
    public int? PaperformatId { get; set; }

    /// <summary>
    /// Internal Transit Location
    /// </summary>
    public int? InternalTransitLocationId { get; set; }

    /// <summary>
    /// Minimum Delta for Propagation of a Date Change on moves linked together
    /// </summary>
    public int? PropagationMinimumDelta { get; set; }

    /// <summary>
    /// Additional Hours
    /// </summary>
    public int? AdditionalHours { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ICollection<DocumentDirectory> DocumentDirectories { get; set; } = new List<DocumentDirectory>();

    public virtual ResFont? FontNavigation { get; set; }

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();

    public virtual StockLocation? InternalTransitLocation { get; set; }

    public virtual ICollection<ResCompany> InverseParent { get; set; } = new List<ResCompany>();

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrDefault> IrDefaults { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrProperty> IrProperties { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrSequence> IrSequences { get; set; } = new List<IrSequence>();

    public virtual ICollection<IrValue> IrValues { get; set; } = new List<IrValue>();

    public virtual ICollection<MultiCompanyDefault> MultiCompanyDefaultCompanies { get; set; } = new List<MultiCompanyDefault>();

    public virtual ICollection<MultiCompanyDefault> MultiCompanyDefaultCompanyDests { get; set; } = new List<MultiCompanyDefault>();

    public virtual ReportPaperformat? Paperformat { get; set; }

    public virtual ResCompany? Parent { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementRule> ProcurementRules { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<ProductPriceHistory> ProductPriceHistories { get; set; } = new List<ProductPriceHistory>();

    public virtual ICollection<ProductPricelist1> ProductPricelist1s { get; set; } = new List<ProductPricelist1>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistVersion> ProductPricelistVersions { get; set; } = new List<ProductPricelistVersion>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ResCurrency> ResCurrencies { get; set; } = new List<ResCurrency>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceCalendar> ResourceCalendars { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceResource> ResourceResources { get; set; } = new List<ResourceResource>();

    public virtual ICollection<StockConfigSetting> StockConfigSettings { get; set; } = new List<StockConfigSetting>();

    public virtual ICollection<StockInventory> StockInventories { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockLocationPath> StockLocationPaths { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockLocationRoute> StockLocationRoutes { get; set; } = new List<StockLocationRoute>();

    public virtual ICollection<StockLocation> StockLocations { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; set; } = new List<StockWarehouse>();

    public virtual ResUser? WriteU { get; set; }
}
