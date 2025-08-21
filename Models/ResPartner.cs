using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ResPartner
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? CompanyId { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Comment { get; set; }

    /// <summary>
    /// EAN13
    /// </summary>
    public string? Ean13 { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Small-sized image
    /// </summary>
    public byte[]? ImageSmall { get; set; }

    /// <summary>
    /// Image
    /// </summary>
    public byte[]? Image { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? DisplayName { get; set; }

    /// <summary>
    /// Zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public int? Title { get; set; }

    /// <summary>
    /// Job Position
    /// </summary>
    public string? Function { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Related Company
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Supplier
    /// </summary>
    public bool? Supplier { get; set; }

    /// <summary>
    /// Contact Reference
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Is a Company
    /// </summary>
    public bool? IsCompany { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public bool? Customer { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Street2
    /// </summary>
    public string? Street2 { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public bool? Employee { get; set; }

    /// <summary>
    /// Credit Limit
    /// </summary>
    public double? CreditLimit { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    public string? Tz { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? Lang { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Medium-sized image
    /// </summary>
    public byte[]? ImageMedium { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// Address Type
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// Use Company Address
    /// </summary>
    public bool? UseParentAddress { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Birthdate
    /// </summary>
    public string? Birthdate { get; set; }

    /// <summary>
    /// TIN
    /// </summary>
    public string? Vat { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public int? StateId { get; set; }

    /// <summary>
    /// Commercial Entity
    /// </summary>
    public int? CommercialPartnerId { get; set; }

    /// <summary>
    /// Receive Inbox Notifications by Email
    /// </summary>
    public string NotifyEmail { get; set; } = null!;

    /// <summary>
    /// Last Message Date
    /// </summary>
    public DateTime? MessageLastPost { get; set; }

    /// <summary>
    /// Opt-Out
    /// </summary>
    public bool? OptOut { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? SectionId { get; set; }

    /// <summary>
    /// Signup Token Type
    /// </summary>
    public string? SignupType { get; set; }

    /// <summary>
    /// Signup Expiration
    /// </summary>
    public DateTime? SignupExpiration { get; set; }

    /// <summary>
    /// Signup Token
    /// </summary>
    public string? SignupToken { get; set; }

    /// <summary>
    /// Devotee Code
    /// </summary>
    public string? DevoteeCode { get; set; }

    /// <summary>
    /// Devotee
    /// </summary>
    public bool? Devotee { get; set; }

    /// <summary>
    /// Devotee
    /// </summary>
    public int? DevoteeId { get; set; }

    /// <summary>
    /// Biometric Code
    /// </summary>
    public string? BiometricCode { get; set; }

    public virtual ICollection<AshramDevotee> AshramDevotees { get; set; } = new List<AshramDevotee>();

    public virtual ResPartner? CommercialPartner { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CurrencyExchange> CurrencyExchanges { get; set; } = new List<CurrencyExchange>();

    public virtual AshramDevotee? DevoteeNavigation { get; set; }

    public virtual ICollection<HotelReservation> HotelReservationPartnerInvoices { get; set; } = new List<HotelReservation>();

    public virtual ICollection<HotelReservation> HotelReservationPartnerOrders { get; set; } = new List<HotelReservation>();

    public virtual ICollection<HotelReservation> HotelReservationPartnerShippings { get; set; } = new List<HotelReservation>();

    public virtual ICollection<HotelReservation> HotelReservationPartners { get; set; } = new List<HotelReservation>();

    public virtual ICollection<HrEmployee> HrEmployeeAddressHomes { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeAddresses { get; set; } = new List<HrEmployee>();

    public virtual ICollection<ResPartner> InverseCommercialPartner { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartner> InverseParent { get; set; } = new List<ResPartner>();

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailFollower> MailFollowers { get; set; } = new List<MailFollower>();

    public virtual ICollection<MailMessage> MailMessages { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailNotification> MailNotifications { get; set; } = new List<MailNotification>();

    public virtual ICollection<MealReservation> MealReservations { get; set; } = new List<MealReservation>();

    public virtual ResPartner? Parent { get; set; }

    public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; set; } = new List<PortalWizardUser>();

    public virtual ICollection<ProcurementGroup> ProcurementGroups { get; set; } = new List<ProcurementGroup>();

    public virtual ICollection<ProcurementOrder> ProcurementOrders { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementRule> ProcurementRules { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservationPartnerInvoices { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservationPartnerOrders { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservationPartnerShippings { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservationPartners { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual CrmCaseSection? Section { get; set; }

    public virtual ResCountryState? State { get; set; }

    public virtual ICollection<StockInventory> StockInventories { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLines { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockLocation> StockLocations { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockMove> StockMovePartners { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMove> StockMoveRestrictPartners { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackOperation> StockPackOperations { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockPicking> StockPickingOwners { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPicking> StockPickingPartners { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItems { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockWarehouse> StockWarehouses { get; set; } = new List<StockWarehouse>();

    public virtual ResPartnerTitle? TitleNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
