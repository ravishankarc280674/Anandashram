using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Anandashram.Models;

public partial class AnandashramContext : DbContext
{
    public AnandashramContext()
    {
    }

    public AnandashramContext(DbContextOptions<AnandashramContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AshramDevotee> AshramDevotees { get; set; }

    public virtual DbSet<DevoteeCategory> AshramDevoteeCategories { get; set; }

    public virtual DbSet<AshramDevoteeSubCategory> AshramDevoteeSubCategories { get; set; }

    public virtual DbSet<BaseConfigSetting> BaseConfigSettings { get; set; }

    public virtual DbSet<BaseImportImport> BaseImportImports { get; set; }

    public virtual DbSet<BaseImportTestsModelsChar> BaseImportTestsModelsChars { get; set; }

    public virtual DbSet<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlies { get; set; }

    public virtual DbSet<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlies { get; set; }

    public virtual DbSet<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequireds { get; set; }

    public virtual DbSet<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStates { get; set; }

    public virtual DbSet<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlies { get; set; }

    public virtual DbSet<BaseImportTestsModelsM2o> BaseImportTestsModelsM2os { get; set; }

    public virtual DbSet<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelateds { get; set; }

    public virtual DbSet<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequireds { get; set; }

    public virtual DbSet<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelateds { get; set; }

    public virtual DbSet<BaseImportTestsModelsO2m> BaseImportTestsModelsO2ms { get; set; }

    public virtual DbSet<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildren { get; set; }

    public virtual DbSet<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviews { get; set; }

    public virtual DbSet<BaseLanguageExport> BaseLanguageExports { get; set; }

    public virtual DbSet<BaseLanguageImport> BaseLanguageImports { get; set; }

    public virtual DbSet<BaseLanguageInstall> BaseLanguageInstalls { get; set; }

    public virtual DbSet<BaseModuleConfiguration> BaseModuleConfigurations { get; set; }

    public virtual DbSet<BaseModuleUpdate> BaseModuleUpdates { get; set; }

    public virtual DbSet<BaseModuleUpgrade> BaseModuleUpgrades { get; set; }

    public virtual DbSet<BaseSetupTerminology> BaseSetupTerminologies { get; set; }

    public virtual DbSet<BaseUpdateTranslation> BaseUpdateTranslations { get; set; }

    public virtual DbSet<BoardCreate> BoardCreates { get; set; }

    public virtual DbSet<BusBu> BusBus { get; set; }

    public virtual DbSet<ChangePasswordUser> ChangePasswordUsers { get; set; }

    public virtual DbSet<ChangePasswordWizard> ChangePasswordWizards { get; set; }

    public virtual DbSet<CrmCaseSection> CrmCaseSections { get; set; }

    public virtual DbSet<CurrencyExchange> CurrencyExchanges { get; set; }

    public virtual DbSet<DbBackup> DbBackups { get; set; }

    public virtual DbSet<DecimalPrecision> DecimalPrecisions { get; set; }

    public virtual DbSet<DecimalPrecisionTest> DecimalPrecisionTests { get; set; }

    public virtual DbSet<DocumentConfiguration> DocumentConfigurations { get; set; }

    public virtual DbSet<DocumentDirectory> DocumentDirectories { get; set; }

    public virtual DbSet<DocumentDirectoryContent> DocumentDirectoryContents { get; set; }

    public virtual DbSet<DocumentDirectoryContentType> DocumentDirectoryContentTypes { get; set; }

    public virtual DbSet<DocumentDirectoryDctx> DocumentDirectoryDctxes { get; set; }

    public virtual DbSet<DocumentDirectoryGroupRel> DocumentDirectoryGroupRels { get; set; }

    public virtual DbSet<DocumentStorage> DocumentStorages { get; set; }

    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

    public virtual DbSet<EmailTemplateAttachmentRel> EmailTemplateAttachmentRels { get; set; }

    public virtual DbSet<EmailTemplatePreview> EmailTemplatePreviews { get; set; }

    public virtual DbSet<EmailTemplatePreviewResPartnerRel> EmailTemplatePreviewResPartnerRels { get; set; }

    public virtual DbSet<EmployeeCategoryRel> EmployeeCategoryRels { get; set; }

    public virtual DbSet<FetchmailConfigSetting> FetchmailConfigSettings { get; set; }

    public virtual DbSet<FetchmailServer> FetchmailServers { get; set; }

    public virtual DbSet<FolioRoomLine> FolioRoomLines { get; set; }

    public virtual DbSet<Block> HotelBlocks { get; set; }

    public virtual DbSet<Building> HotelBuildings { get; set; }

    public virtual DbSet<Floor> HotelFloors { get; set; }

    public virtual DbSet<HotelReservation> HotelReservations { get; set; }

    public virtual DbSet<HotelReservationLine> HotelReservationLines { get; set; }

    public virtual DbSet<HotelReservationLineRoomRel> HotelReservationLineRoomRels { get; set; }

    public virtual DbSet<Room> HotelRooms { get; set; }

    public virtual DbSet<HotelRoomAmenitiesType> HotelRoomAmenitiesTypes { get; set; }

    public virtual DbSet<HotelRoomAmenity> HotelRoomAmenities { get; set; }

    public virtual DbSet<HotelRoomReservationLine> HotelRoomReservationLines { get; set; }

    public virtual DbSet<HotelRoomType> HotelRoomTypes { get; set; }

    public virtual DbSet<HotelService> HotelServices { get; set; }

    public virtual DbSet<HotelServiceType> HotelServiceTypes { get; set; }

    public virtual DbSet<HrActionReason> HrActionReasons { get; set; }

    public virtual DbSet<HrAttendance> HrAttendances { get; set; }

    public virtual DbSet<HrAttendanceError> HrAttendanceErrors { get; set; }

    public virtual DbSet<HrConfigSetting> HrConfigSettings { get; set; }

    public virtual DbSet<HrDepartment> HrDepartments { get; set; }

    public virtual DbSet<HrEmployee> HrEmployees { get; set; }

    public virtual DbSet<HrEmployeeCategory> HrEmployeeCategories { get; set; }

    public virtual DbSet<HrJob> HrJobs { get; set; }

    public virtual DbSet<ImChatMessage> ImChatMessages { get; set; }

    public virtual DbSet<ImChatPresence> ImChatPresences { get; set; }

    public virtual DbSet<ImChatSession> ImChatSessions { get; set; }

    public virtual DbSet<ImChatSessionResUsersRel> ImChatSessionResUsersRels { get; set; }

    public virtual DbSet<IrActClient> IrActClients { get; set; }

    public virtual DbSet<IrActReportXml> IrActReportXmls { get; set; }

    public virtual DbSet<IrActServer> IrActServers { get; set; }

    public virtual DbSet<IrActUrl> IrActUrls { get; set; }

    public virtual DbSet<IrActWindow> IrActWindows { get; set; }

    public virtual DbSet<IrActWindowGroupRel> IrActWindowGroupRels { get; set; }

    public virtual DbSet<IrActWindowView> IrActWindowViews { get; set; }

    public virtual DbSet<IrAction> IrActions { get; set; }

    public virtual DbSet<IrActionsTodo> IrActionsTodos { get; set; }

    public virtual DbSet<IrAttachment> IrAttachments { get; set; }

    public virtual DbSet<IrConfigParameter> IrConfigParameters { get; set; }

    public virtual DbSet<IrConfigParameterGroupsRel> IrConfigParameterGroupsRels { get; set; }

    public virtual DbSet<IrCron> IrCrons { get; set; }

    public virtual DbSet<IrDefault> IrDefaults { get; set; }

    public virtual DbSet<IrExport> IrExports { get; set; }

    public virtual DbSet<IrExportsLine> IrExportsLines { get; set; }

    public virtual DbSet<IrFieldsConverter> IrFieldsConverters { get; set; }

    public virtual DbSet<IrFilter> IrFilters { get; set; }

    public virtual DbSet<IrLogging> IrLoggings { get; set; }

    public virtual DbSet<IrMailServer> IrMailServers { get; set; }

    public virtual DbSet<IrModel> IrModels { get; set; }

    public virtual DbSet<IrModelAccess> IrModelAccesses { get; set; }

    public virtual DbSet<IrModelConstraint> IrModelConstraints { get; set; }

    public virtual DbSet<IrModelDatum> IrModelData { get; set; }

    public virtual DbSet<IrModelField> IrModelFields { get; set; }

    public virtual DbSet<IrModelFieldsGroupRel> IrModelFieldsGroupRels { get; set; }

    public virtual DbSet<IrModelRelation> IrModelRelations { get; set; }

    public virtual DbSet<IrModuleCategory> IrModuleCategories { get; set; }

    public virtual DbSet<IrModuleModule> IrModuleModules { get; set; }

    public virtual DbSet<IrModuleModuleDependency> IrModuleModuleDependencies { get; set; }

    public virtual DbSet<IrProperty> IrProperties { get; set; }

    public virtual DbSet<IrRule> IrRules { get; set; }

    public virtual DbSet<IrSequence> IrSequences { get; set; }

    public virtual DbSet<IrSequenceType> IrSequenceTypes { get; set; }

    public virtual DbSet<IrServerObjectLine> IrServerObjectLines { get; set; }

    public virtual DbSet<IrTranslation> IrTranslations { get; set; }

    public virtual DbSet<IrUiMenu> IrUiMenus { get; set; }

    public virtual DbSet<IrUiMenuGroupRel> IrUiMenuGroupRels { get; set; }

    public virtual DbSet<IrUiView> IrUiViews { get; set; }

    public virtual DbSet<IrUiViewCustom> IrUiViewCustoms { get; set; }

    public virtual DbSet<IrUiViewGroupRel> IrUiViewGroupRels { get; set; }

    public virtual DbSet<IrValue> IrValues { get; set; }

    public virtual DbSet<KnowledgeConfigSetting> KnowledgeConfigSettings { get; set; }

    public virtual DbSet<MailAlias> MailAliases { get; set; }

    public virtual DbSet<MailComposeMessage> MailComposeMessages { get; set; }

    public virtual DbSet<MailComposeMessageIrAttachmentsRel> MailComposeMessageIrAttachmentsRels { get; set; }

    public virtual DbSet<MailComposeMessageResPartnerRel> MailComposeMessageResPartnerRels { get; set; }

    public virtual DbSet<MailFollower> MailFollowers { get; set; }

    public virtual DbSet<MailFollowersMailMessageSubtypeRel> MailFollowersMailMessageSubtypeRels { get; set; }

    public virtual DbSet<MailGroup> MailGroups { get; set; }

    public virtual DbSet<MailGroupResGroupRel> MailGroupResGroupRels { get; set; }

    public virtual DbSet<MailMail> MailMails { get; set; }

    public virtual DbSet<MailMailResPartnerRel> MailMailResPartnerRels { get; set; }

    public virtual DbSet<MailMessage> MailMessages { get; set; }

    public virtual DbSet<MailMessageResPartnerRel> MailMessageResPartnerRels { get; set; }

    public virtual DbSet<MailMessageSubtype> MailMessageSubtypes { get; set; }

    public virtual DbSet<MailNotification> MailNotifications { get; set; }

    public virtual DbSet<MailVote> MailVotes { get; set; }

    public virtual DbSet<MailWizardInvite> MailWizardInvites { get; set; }

    public virtual DbSet<MailWizardInviteResPartnerRel> MailWizardInviteResPartnerRels { get; set; }

    public virtual DbSet<MakeProcurement> MakeProcurements { get; set; }

    public virtual DbSet<MealReservation> MealReservations { get; set; }

    public virtual DbSet<MealReservationMealTypeRel> MealReservationMealTypeRels { get; set; }

    public virtual DbSet<MealType> MealTypes { get; set; }

    public virtual DbSet<MessageAttachmentRel> MessageAttachmentRels { get; set; }

    public virtual DbSet<MultiCompanyDefault> MultiCompanyDefaults { get; set; }

    public virtual DbSet<OsvMemoryAutovacuum> OsvMemoryAutovacuums { get; set; }

    public virtual DbSet<PortalWizard> PortalWizards { get; set; }

    public virtual DbSet<PortalWizardUser> PortalWizardUsers { get; set; }

    public virtual DbSet<PricelistPartnerinfo> PricelistPartnerinfos { get; set; }

    public virtual DbSet<ProcurementGroup> ProcurementGroups { get; set; }

    public virtual DbSet<ProcurementOrder> ProcurementOrders { get; set; }

    public virtual DbSet<ProcurementOrderComputeAll> ProcurementOrderComputeAlls { get; set; }

    public virtual DbSet<ProcurementOrderpointCompute> ProcurementOrderpointComputes { get; set; }

    public virtual DbSet<ProcurementRule> ProcurementRules { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    public virtual DbSet<ProductAttributeLine> ProductAttributeLines { get; set; }

    public virtual DbSet<ProductAttributeLineProductAttributeValueRel> ProductAttributeLineProductAttributeValueRels { get; set; }

    public virtual DbSet<ProductAttributePrice> ProductAttributePrices { get; set; }

    public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }

    public virtual DbSet<ProductAttributeValueProductProductRel> ProductAttributeValueProductProductRels { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductPackaging> ProductPackagings { get; set; }

    public virtual DbSet<ProductPriceHistory> ProductPriceHistories { get; set; }

    public virtual DbSet<ProductPriceList> ProductPriceLists { get; set; }

    public virtual DbSet<ProductPriceType> ProductPriceTypes { get; set; }

    public virtual DbSet<ProductPricelist1> ProductPricelists { get; set; }

    public virtual DbSet<ProductPricelistItem> ProductPricelistItems { get; set; }

    public virtual DbSet<ProductPricelistType> ProductPricelistTypes { get; set; }

    public virtual DbSet<ProductPricelistVersion> ProductPricelistVersions { get; set; }

    public virtual DbSet<ProductProduct> ProductProducts { get; set; }

    public virtual DbSet<ProductPutaway> ProductPutaways { get; set; }

    public virtual DbSet<ProductRemoval> ProductRemovals { get; set; }

    public virtual DbSet<ProductSupplierinfo> ProductSupplierinfos { get; set; }

    public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }

    public virtual DbSet<ProductUl> ProductUls { get; set; }

    public virtual DbSet<ProductUom> ProductUoms { get; set; }

    public virtual DbSet<ProductUomCateg> ProductUomCategs { get; set; }

    public virtual DbSet<QuickRoomReservation> QuickRoomReservations { get; set; }

    public virtual DbSet<RelModulesLangexport> RelModulesLangexports { get; set; }

    public virtual DbSet<RelServerAction> RelServerActions { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportDocumentFile> ReportDocumentFiles { get; set; }

    public virtual DbSet<ReportDocumentUser> ReportDocumentUsers { get; set; }

    public virtual DbSet<ReportPaperformat> ReportPaperformats { get; set; }

    public virtual DbSet<ReportStockLinesDate> ReportStockLinesDates { get; set; }

    public virtual DbSet<ResBank> ResBanks { get; set; }

    public virtual DbSet<ResCompany> ResCompanies { get; set; }

    public virtual DbSet<ResCompanyUsersRel> ResCompanyUsersRels { get; set; }

    public virtual DbSet<ResConfig> ResConfigs { get; set; }

    public virtual DbSet<ResConfigInstaller> ResConfigInstallers { get; set; }

    public virtual DbSet<ResConfigSetting> ResConfigSettings { get; set; }

    public virtual DbSet<ResCountry> ResCountries { get; set; }

    public virtual DbSet<ResCountryGroup> ResCountryGroups { get; set; }

    public virtual DbSet<ResCountryResCountryGroupRel> ResCountryResCountryGroupRels { get; set; }

    public virtual DbSet<ResCountryState> ResCountryStates { get; set; }

    public virtual DbSet<ResCurrency> ResCurrencies { get; set; }

    public virtual DbSet<ResCurrencyRate> ResCurrencyRates { get; set; }

    public virtual DbSet<ResFont> ResFonts { get; set; }

    public virtual DbSet<ResGroup> ResGroups { get; set; }

    public virtual DbSet<ResGroupsActionRel> ResGroupsActionRels { get; set; }

    public virtual DbSet<ResGroupsImpliedRel> ResGroupsImpliedRels { get; set; }

    public virtual DbSet<ResGroupsReportRel> ResGroupsReportRels { get; set; }

    public virtual DbSet<ResGroupsUsersRel> ResGroupsUsersRels { get; set; }

    public virtual DbSet<ResLang> ResLangs { get; set; }

    public virtual DbSet<ResPartner> ResPartners { get; set; }

    public virtual DbSet<ResPartnerBank> ResPartnerBanks { get; set; }

    public virtual DbSet<ResPartnerBankType> ResPartnerBankTypes { get; set; }

    public virtual DbSet<ResPartnerBankTypeField> ResPartnerBankTypeFields { get; set; }

    public virtual DbSet<ResPartnerCategory> ResPartnerCategories { get; set; }

    public virtual DbSet<ResPartnerResPartnerCategoryRel> ResPartnerResPartnerCategoryRels { get; set; }

    public virtual DbSet<ResPartnerTitle> ResPartnerTitles { get; set; }

    public virtual DbSet<ResRequestLink> ResRequestLinks { get; set; }

    public virtual DbSet<ResUser> ResUsers { get; set; }

    public virtual DbSet<ResourceCalendar> ResourceCalendars { get; set; }

    public virtual DbSet<ResourceCalendarAttendance> ResourceCalendarAttendances { get; set; }

    public virtual DbSet<ResourceCalendarLeaf> ResourceCalendarLeaves { get; set; }

    public virtual DbSet<ResourceResource> ResourceResources { get; set; }

    public virtual DbSet<RoomReservationSummary> RoomReservationSummaries { get; set; }

    public virtual DbSet<RuleGroupRel> RuleGroupRels { get; set; }

    public virtual DbSet<SaleConfigSetting> SaleConfigSettings { get; set; }

    public virtual DbSet<SaleMemberRel> SaleMemberRels { get; set; }

    public virtual DbSet<ShareWizard> ShareWizards { get; set; }

    public virtual DbSet<ShareWizardResGroupRel> ShareWizardResGroupRels { get; set; }

    public virtual DbSet<ShareWizardResUserRel> ShareWizardResUserRels { get; set; }

    public virtual DbSet<ShareWizardResultLine> ShareWizardResultLines { get; set; }

    public virtual DbSet<StockChangeProductQty> StockChangeProductQties { get; set; }

    public virtual DbSet<StockConfigSetting> StockConfigSettings { get; set; }

    public virtual DbSet<StockFixedPutawayStrat> StockFixedPutawayStrats { get; set; }

    public virtual DbSet<StockIncoterm> StockIncoterms { get; set; }

    public virtual DbSet<StockInventory> StockInventories { get; set; }

    public virtual DbSet<StockInventoryLine> StockInventoryLines { get; set; }

    public virtual DbSet<StockLocation> StockLocations { get; set; }

    public virtual DbSet<StockLocationPath> StockLocationPaths { get; set; }

    public virtual DbSet<StockLocationRoute> StockLocationRoutes { get; set; }

    public virtual DbSet<StockLocationRouteCateg> StockLocationRouteCategs { get; set; }

    public virtual DbSet<StockLocationRouteMove> StockLocationRouteMoves { get; set; }

    public virtual DbSet<StockLocationRouteProcurement> StockLocationRouteProcurements { get; set; }

    public virtual DbSet<StockMove> StockMoves { get; set; }

    public virtual DbSet<StockMoveOperationLink> StockMoveOperationLinks { get; set; }

    public virtual DbSet<StockMoveScrap> StockMoveScraps { get; set; }

    public virtual DbSet<StockPackOperation> StockPackOperations { get; set; }

    public virtual DbSet<StockPicking> StockPickings { get; set; }

    public virtual DbSet<StockPickingType> StockPickingTypes { get; set; }

    public virtual DbSet<StockProductionLot> StockProductionLots { get; set; }

    public virtual DbSet<StockQuant> StockQuants { get; set; }

    public virtual DbSet<StockQuantMoveRel> StockQuantMoveRels { get; set; }

    public virtual DbSet<StockQuantPackage> StockQuantPackages { get; set; }

    public virtual DbSet<StockReturnPicking> StockReturnPickings { get; set; }

    public virtual DbSet<StockReturnPickingLine> StockReturnPickingLines { get; set; }

    public virtual DbSet<StockRouteProduct> StockRouteProducts { get; set; }

    public virtual DbSet<StockRouteWarehouse> StockRouteWarehouses { get; set; }

    public virtual DbSet<StockTransferDetail> StockTransferDetails { get; set; }

    public virtual DbSet<StockTransferDetailsItem> StockTransferDetailsItems { get; set; }

    public virtual DbSet<StockWarehouse> StockWarehouses { get; set; }

    public virtual DbSet<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; }

    public virtual DbSet<StockWhResupplyTable> StockWhResupplyTables { get; set; }

    public virtual DbSet<TempTab> TempTabs { get; set; }

    public virtual DbSet<WizardIrModelMenuCreate> WizardIrModelMenuCreates { get; set; }

    public virtual DbSet<Wkf> Wkfs { get; set; }

    public virtual DbSet<WkfActivity> WkfActivities { get; set; }

    public virtual DbSet<WkfInstance> WkfInstances { get; set; }

    public virtual DbSet<WkfTransition> WkfTransitions { get; set; }

    public virtual DbSet<WkfTrigger> WkfTriggers { get; set; }

    public virtual DbSet<WkfWitmTran> WkfWitmTrans { get; set; }

    public virtual DbSet<WkfWorkitem> WkfWorkitems { get; set; }
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AshramDevotee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ashram_devotee_pkey");

            entity.ToTable("ashram_devotee", tb => tb.HasComment("ashram.devotee"));

            entity.HasIndex(e => e.PartnerId, "ashram_devotee_partner_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BiometricCode)
                .HasComment("Biometric Code")
                .HasColumnType("character varying")
                .HasColumnName("biometric_code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DevoteeCode)
                .HasComment("Devotee Code")
                .HasColumnType("character varying")
                .HasColumnName("devotee_code");
            entity.Property(e => e.MainCategoryId)
                .HasComment("Devotee Category")
                .HasColumnName("main_category_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Partner id")
                .HasColumnName("partner_id");
            entity.Property(e => e.Photo)
                .HasComment("Photo")
                .HasColumnName("photo");
            entity.Property(e => e.SubCategoryId)
                .HasComment("Devotee Sub Category")
                .HasColumnName("sub_category_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AshramDevoteeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_create_uid_fkey");

            entity.HasOne(d => d.MainCategory).WithMany(p => p.AshramDevotees)
                .HasForeignKey(d => d.MainCategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_main_category_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.AshramDevotees)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("ashram_devotee_partner_id_fkey");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.AshramDevotees)
                .HasForeignKey(d => d.SubCategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_sub_category_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AshramDevoteeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_write_uid_fkey");
        });

        modelBuilder.Entity<DevoteeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ashram_devotee_category_pkey");

            entity.ToTable("ashram_devotee_category", tb => tb.HasComment("ashram.devotee.category"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AshramDevoteeCategoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_category_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AshramDevoteeCategoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_category_write_uid_fkey");
        });

        modelBuilder.Entity<AshramDevoteeSubCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ashram_devotee_sub_category_pkey");

            entity.ToTable("ashram_devotee_sub_category", tb => tb.HasComment("ashram.devotee.sub.category"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MainCategoryId)
                .HasComment("Main Category")
                .HasColumnName("main_category_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.AshramDevoteeSubCategoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_sub_category_create_uid_fkey");

            entity.HasOne(d => d.MainCategory).WithMany(p => p.AshramDevoteeSubCategories)
                .HasForeignKey(d => d.MainCategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_sub_category_main_category_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.AshramDevoteeSubCategoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ashram_devotee_sub_category_write_uid_fkey");
        });

        modelBuilder.Entity<BaseConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_config_settings_pkey");

            entity.ToTable("base_config_settings", tb => tb.HasComment("base.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliasDomain)
                .HasComment("Alias Domain")
                .HasColumnType("character varying")
                .HasColumnName("alias_domain");
            entity.Property(e => e.AuthSignupResetPassword)
                .HasComment("Enable password reset from Login page")
                .HasColumnName("auth_signup_reset_password");
            entity.Property(e => e.AuthSignupTemplateUserId)
                .HasComment("Template user for new users created through signup")
                .HasColumnName("auth_signup_template_user_id");
            entity.Property(e => e.AuthSignupUninvited)
                .HasComment("Allow external users to sign up")
                .HasColumnName("auth_signup_uninvited");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Font)
                .HasComment("Report Font")
                .HasColumnName("font");
            entity.Property(e => e.ModuleAuthOauth)
                .HasComment("Use external authentication providers, sign in with google, facebook, ...")
                .HasColumnName("module_auth_oauth");
            entity.Property(e => e.ModuleBaseImport)
                .HasComment("Allow users to import data from CSV files")
                .HasColumnName("module_base_import");
            entity.Property(e => e.ModuleGoogleCalendar)
                .HasComment("Allow the users to synchronize their calendar  with Google Calendar")
                .HasColumnName("module_google_calendar");
            entity.Property(e => e.ModuleGoogleDrive)
                .HasComment("Attach Google documents to any record")
                .HasColumnName("module_google_drive");
            entity.Property(e => e.ModuleMultiCompany)
                .HasComment("Manage multiple companies")
                .HasColumnName("module_multi_company");
            entity.Property(e => e.ModulePortal)
                .HasComment("Activate the customer portal")
                .HasColumnName("module_portal");
            entity.Property(e => e.ModuleShare)
                .HasComment("Allow documents sharing")
                .HasColumnName("module_share");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.AuthSignupTemplateUser).WithMany(p => p.BaseConfigSettingAuthSignupTemplateUsers)
                .HasForeignKey(d => d.AuthSignupTemplateUserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_config_settings_auth_signup_template_user_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_config_settings_create_uid_fkey");

            entity.HasOne(d => d.FontNavigation).WithMany(p => p.BaseConfigSettings)
                .HasForeignKey(d => d.Font)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_config_settings_font_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_import_pkey");

            entity.ToTable("base_import_import", tb => tb.HasComment("base_import.import"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.File)
                .HasComment("File")
                .HasColumnName("file");
            entity.Property(e => e.FileName)
                .HasComment("File Name")
                .HasColumnType("character varying")
                .HasColumnName("file_name");
            entity.Property(e => e.FileType)
                .HasComment("File Type")
                .HasColumnType("character varying")
                .HasColumnName("file_type");
            entity.Property(e => e.ResModel)
                .HasComment("Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportImportCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_import_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportImportWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_import_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsChar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_pkey");

            entity.ToTable("base_import_tests_models_char", tb => tb.HasComment("base_import.tests.models.char"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharNoreadonly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_noreadonly_pkey");

            entity.ToTable("base_import_tests_models_char_noreadonly", tb => tb.HasComment("base_import.tests.models.char.noreadonly"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharNoreadonlyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_noreadonly_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharNoreadonlyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_noreadonly_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharReadonly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_readonly_pkey");

            entity.ToTable("base_import_tests_models_char_readonly", tb => tb.HasComment("base_import.tests.models.char.readonly"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharReadonlyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_readonly_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharReadonlyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_readonly_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharRequired>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_required_pkey");

            entity.ToTable("base_import_tests_models_char_required", tb => tb.HasComment("base_import.tests.models.char.required"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharRequiredCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_required_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharRequiredWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_required_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_states_pkey");

            entity.ToTable("base_import_tests_models_char_states", tb => tb.HasComment("base_import.tests.models.char.states"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharStateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_states_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharStateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_states_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsCharStillreadonly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_char_stillreadonly_pkey");

            entity.ToTable("base_import_tests_models_char_stillreadonly", tb => tb.HasComment("base_import.tests.models.char.stillreadonly"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsCharStillreadonlyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_stillreadonly_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsCharStillreadonlyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_char_stillreadonly_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2o>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_pkey");

            entity.ToTable("base_import_tests_models_m2o", tb => tb.HasComment("base_import.tests.models.m2o"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_create_uid_fkey");

            entity.HasOne(d => d.ValueNavigation).WithMany(p => p.BaseImportTestsModelsM2os)
                .HasForeignKey(d => d.Value)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_value_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2oRelated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_related_pkey");

            entity.ToTable("base_import_tests_models_m2o_related", tb => tb.HasComment("base_import.tests.models.m2o.related"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oRelatedCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_related_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oRelatedWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_related_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2oRequired>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_required_pkey");

            entity.ToTable("base_import_tests_models_m2o_required", tb => tb.HasComment("base_import.tests.models.m2o.required"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oRequiredCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_create_uid_fkey");

            entity.HasOne(d => d.ValueNavigation).WithMany(p => p.BaseImportTestsModelsM2oRequireds)
                .HasForeignKey(d => d.Value)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_value_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oRequiredWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsM2oRequiredRelated>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_m2o_required_related_pkey");

            entity.ToTable("base_import_tests_models_m2o_required_related", tb => tb.HasComment("base_import.tests.models.m2o.required.related"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsM2oRequiredRelatedCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_related_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsM2oRequiredRelatedWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_m2o_required_related_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsO2m>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_o2m_pkey");

            entity.ToTable("base_import_tests_models_o2m", tb => tb.HasComment("base_import.tests.models.o2m"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsO2mCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsO2mWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsO2mChild>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_o2m_child_pkey");

            entity.ToTable("base_import_tests_models_o2m_child", tb => tb.HasComment("base_import.tests.models.o2m.child"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ParentId)
                .HasComment("unknown")
                .HasColumnName("parent_id");
            entity.Property(e => e.Value)
                .HasComment("unknown")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsO2mChildCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_child_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.BaseImportTestsModelsO2mChildren)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_child_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsO2mChildWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_o2m_child_write_uid_fkey");
        });

        modelBuilder.Entity<BaseImportTestsModelsPreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_import_tests_models_preview_pkey");

            entity.ToTable("base_import_tests_models_preview", tb => tb.HasComment("base_import.tests.models.preview"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Othervalue)
                .HasComment("Other Variable")
                .HasColumnName("othervalue");
            entity.Property(e => e.Somevalue)
                .HasComment("Some Value")
                .HasColumnName("somevalue");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseImportTestsModelsPreviewCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_preview_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseImportTestsModelsPreviewWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_import_tests_models_preview_write_uid_fkey");
        });

        modelBuilder.Entity<BaseLanguageExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_language_export_pkey");

            entity.ToTable("base_language_export", tb => tb.HasComment("base.language.export"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Data)
                .HasComment("File")
                .HasColumnName("data");
            entity.Property(e => e.Format)
                .HasComment("File Format")
                .HasColumnType("character varying")
                .HasColumnName("format");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.Name)
                .HasComment("File Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.State)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseLanguageExportCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_export_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseLanguageExportWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_export_write_uid_fkey");
        });

        modelBuilder.Entity<BaseLanguageImport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_language_import_pkey");

            entity.ToTable("base_language_import", tb => tb.HasComment("Language Import"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasComment("ISO Code")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Data)
                .HasComment("File")
                .HasColumnName("data");
            entity.Property(e => e.Name)
                .HasComment("Language Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Overwrite)
                .HasComment("Overwrite Existing Terms")
                .HasColumnName("overwrite");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseLanguageImportCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_import_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseLanguageImportWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_import_write_uid_fkey");
        });

        modelBuilder.Entity<BaseLanguageInstall>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_language_install_pkey");

            entity.ToTable("base_language_install", tb => tb.HasComment("Install Language"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.Overwrite)
                .HasComment("Overwrite Existing Terms")
                .HasColumnName("overwrite");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseLanguageInstallCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_install_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseLanguageInstallWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_language_install_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_configuration_pkey");

            entity.ToTable("base_module_configuration", tb => tb.HasComment("base.module.configuration"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleConfigurationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_configuration_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleConfigurationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_configuration_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_update_pkey");

            entity.ToTable("base_module_update", tb => tb.HasComment("Update Module"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Added)
                .HasComment("Number of modules added")
                .HasColumnName("added");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Updated)
                .HasComment("Number of modules updated")
                .HasColumnName("updated");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleUpdateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_update_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleUpdateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_update_write_uid_fkey");
        });

        modelBuilder.Entity<BaseModuleUpgrade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_module_upgrade_pkey");

            entity.ToTable("base_module_upgrade", tb => tb.HasComment("Module Upgrade"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ModuleInfo)
                .HasComment("Modules to Update")
                .HasColumnName("module_info");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseModuleUpgradeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_upgrade_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseModuleUpgradeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_module_upgrade_write_uid_fkey");
        });

        modelBuilder.Entity<BaseSetupTerminology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_setup_terminology_pkey");

            entity.ToTable("base_setup_terminology", tb => tb.HasComment("base.setup.terminology"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Partner)
                .HasComment("How do you call a Customer")
                .HasColumnType("character varying")
                .HasColumnName("partner");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseSetupTerminologyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_setup_terminology_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseSetupTerminologyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_setup_terminology_write_uid_fkey");
        });

        modelBuilder.Entity<BaseUpdateTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("base_update_translations_pkey");

            entity.ToTable("base_update_translations", tb => tb.HasComment("base.update.translations"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BaseUpdateTranslationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_update_translations_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BaseUpdateTranslationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("base_update_translations_write_uid_fkey");
        });

        modelBuilder.Entity<BoardCreate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("board_create_pkey");

            entity.ToTable("board_create", tb => tb.HasComment("Board Creation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MenuParentId)
                .HasComment("Parent Menu")
                .HasColumnName("menu_parent_id");
            entity.Property(e => e.Name)
                .HasComment("Board Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BoardCreateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("board_create_create_uid_fkey");

            entity.HasOne(d => d.MenuParent).WithMany(p => p.BoardCreates)
                .HasForeignKey(d => d.MenuParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("board_create_menu_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BoardCreateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("board_create_write_uid_fkey");
        });

        modelBuilder.Entity<BusBu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bus_bus_pkey");

            entity.ToTable("bus_bus", tb => tb.HasComment("bus.bus"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Channel)
                .HasComment("Channel")
                .HasColumnType("character varying")
                .HasColumnName("channel");
            entity.Property(e => e.CreateDate)
                .HasComment("Create date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Message)
                .HasComment("Message")
                .HasColumnType("character varying")
                .HasColumnName("message");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.BusBuCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("bus_bus_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.BusBuWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("bus_bus_write_uid_fkey");
        });

        modelBuilder.Entity<ChangePasswordUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_password_user_pkey");

            entity.ToTable("change_password_user", tb => tb.HasComment("Change Password Wizard User"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.NewPasswd)
                .HasComment("New Password")
                .HasColumnType("character varying")
                .HasColumnName("new_passwd");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.UserLogin)
                .HasComment("User Login")
                .HasColumnType("character varying")
                .HasColumnName("user_login");
            entity.Property(e => e.WizardId)
                .HasComment("Wizard")
                .HasColumnName("wizard_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangePasswordUserCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_user_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ChangePasswordUserUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_user_user_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.ChangePasswordUsers)
                .HasForeignKey(d => d.WizardId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_user_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangePasswordUserWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_user_write_uid_fkey");
        });

        modelBuilder.Entity<ChangePasswordWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_password_wizard_pkey");

            entity.ToTable("change_password_wizard", tb => tb.HasComment("Change Password Wizard"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ChangePasswordWizardCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ChangePasswordWizardWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("change_password_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<CrmCaseSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("crm_case_section_pkey");

            entity.ToTable("crm_case_section", tb => tb.HasComment("Sales Teams"));

            entity.HasIndex(e => e.Code, "crm_case_section_code_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.ChangeResponsible)
                .HasComment("Reassign Escalated")
                .HasColumnName("change_responsible");
            entity.Property(e => e.Code)
                .HasMaxLength(8)
                .HasComment("Code")
                .HasColumnName("code");
            entity.Property(e => e.Color)
                .HasComment("Color Index")
                .HasColumnName("color");
            entity.Property(e => e.CompleteName)
                .HasMaxLength(256)
                .HasComment("unknown")
                .HasColumnName("complete_name");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("Sales Team")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasComment("Description")
                .HasColumnName("note");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Team")
                .HasColumnName("parent_id");
            entity.Property(e => e.ReplyTo)
                .HasMaxLength(64)
                .HasComment("Reply-To")
                .HasColumnName("reply_to");
            entity.Property(e => e.UserId)
                .HasComment("Team Leader")
                .HasColumnName("user_id");
            entity.Property(e => e.WorkingHours)
                .HasComment("Working Hours")
                .HasColumnName("working_hours");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CrmCaseSectionCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_case_section_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_case_section_parent_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.CrmCaseSectionUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_case_section_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CrmCaseSectionWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("crm_case_section_write_uid_fkey");
        });

        modelBuilder.Entity<CurrencyExchange>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("currency_exchange_pkey");

            entity.ToTable("currency_exchange", tb => tb.HasComment("currency"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FolioNo)
                .HasComment("Folio Number")
                .HasColumnName("folio_no");
            entity.Property(e => e.GuestName)
                .HasComment("Guest Name")
                .HasColumnName("guest_name");
            entity.Property(e => e.HotelId)
                .HasComment("Aaashrmam Name")
                .HasColumnName("hotel_id");
            entity.Property(e => e.InAmount)
                .HasComment("Amount Taken")
                .HasColumnName("in_amount");
            entity.Property(e => e.InputCurr)
                .HasComment("Input Currency")
                .HasColumnName("input_curr");
            entity.Property(e => e.Name)
                .HasComment("Reg Number")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OutAmount)
                .HasComment("Subtotal")
                .HasColumnName("out_amount");
            entity.Property(e => e.OutCurr)
                .HasComment("Output Currency")
                .HasColumnName("out_curr");
            entity.Property(e => e.Rate)
                .HasComment("Rate(per unit)")
                .HasColumnName("rate");
            entity.Property(e => e.RoomNumber)
                .HasComment("Room Number")
                .HasColumnType("character varying")
                .HasColumnName("room_number");
            entity.Property(e => e.State)
                .HasComment("State")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Tax)
                .HasComment("Service Tax")
                .HasColumnType("character varying")
                .HasColumnName("tax");
            entity.Property(e => e.TodayDate)
                .HasComment("Date Ordered")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("today_date");
            entity.Property(e => e.Total)
                .HasComment("Amount Given")
                .HasColumnName("total");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.CurrencyExchangeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("currency_exchange_create_uid_fkey");

            entity.HasOne(d => d.GuestNameNavigation).WithMany(p => p.CurrencyExchanges)
                .HasForeignKey(d => d.GuestName)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("currency_exchange_guest_name_fkey");

            entity.HasOne(d => d.Hotel).WithMany(p => p.CurrencyExchanges)
                .HasForeignKey(d => d.HotelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("currency_exchange_hotel_id_fkey");

            entity.HasOne(d => d.InputCurrNavigation).WithMany(p => p.CurrencyExchangeInputCurrNavigations)
                .HasForeignKey(d => d.InputCurr)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("currency_exchange_input_curr_fkey");

            entity.HasOne(d => d.OutCurrNavigation).WithMany(p => p.CurrencyExchangeOutCurrNavigations)
                .HasForeignKey(d => d.OutCurr)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("currency_exchange_out_curr_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.CurrencyExchangeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("currency_exchange_write_uid_fkey");
        });

        modelBuilder.Entity<DbBackup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("db_backup_pkey");

            entity.ToTable("db_backup", tb => tb.HasComment("db.backup"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Autoremove)
                .HasComment("Auto. Remove Backups")
                .HasColumnName("autoremove");
            entity.Property(e => e.BkpDir)
                .HasMaxLength(100)
                .HasComment("Backup Directory")
                .HasColumnName("bkp_dir");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Daystokeep)
                .HasComment("Remove after x days")
                .HasColumnName("daystokeep");
            entity.Property(e => e.Daystokeepsftp)
                .HasComment("Remove SFTP after x days")
                .HasColumnName("daystokeepsftp");
            entity.Property(e => e.Emailtonotify)
                .HasComment("E-mail to notify")
                .HasColumnType("character varying")
                .HasColumnName("emailtonotify");
            entity.Property(e => e.Host)
                .HasMaxLength(100)
                .HasComment("Host")
                .HasColumnName("host");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasComment("Database")
                .HasColumnName("name");
            entity.Property(e => e.Port)
                .HasMaxLength(10)
                .HasComment("Port")
                .HasColumnName("port");
            entity.Property(e => e.Sendmailsftpfail)
                .HasComment("Auto. E-mail on backup fail")
                .HasColumnName("sendmailsftpfail");
            entity.Property(e => e.Sftpip)
                .HasComment("IP Address SFTP Server")
                .HasColumnType("character varying")
                .HasColumnName("sftpip");
            entity.Property(e => e.Sftppassword)
                .HasComment("Password User SFTP Server")
                .HasColumnType("character varying")
                .HasColumnName("sftppassword");
            entity.Property(e => e.Sftppath)
                .HasComment("Path external server")
                .HasColumnType("character varying")
                .HasColumnName("sftppath");
            entity.Property(e => e.Sftpusername)
                .HasComment("Username SFTP Server")
                .HasColumnType("character varying")
                .HasColumnName("sftpusername");
            entity.Property(e => e.Sftpwrite)
                .HasComment("Write to external server with sftp")
                .HasColumnName("sftpwrite");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DbBackupCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("db_backup_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DbBackupWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("db_backup_write_uid_fkey");
        });

        modelBuilder.Entity<DecimalPrecision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("decimal_precision_pkey");

            entity.ToTable("decimal_precision", tb => tb.HasComment("decimal.precision"));

            entity.HasIndex(e => e.Name, "decimal_precision_name_index");

            entity.HasIndex(e => e.Name, "decimal_precision_name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Digits)
                .HasComment("Digits")
                .HasColumnName("digits");
            entity.Property(e => e.Name)
                .HasComment("Usage")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DecimalPrecisionCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("decimal_precision_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DecimalPrecisionWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("decimal_precision_write_uid_fkey");
        });

        modelBuilder.Entity<DecimalPrecisionTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("decimal_precision_test_pkey");

            entity.ToTable("decimal_precision_test", tb => tb.HasComment("decimal.precision.test"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Float)
                .HasComment("unknown")
                .HasColumnName("float");
            entity.Property(e => e.Float2)
                .HasComment("unknown")
                .HasColumnName("float_2");
            entity.Property(e => e.Float4)
                .HasComment("unknown")
                .HasColumnName("float_4");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DecimalPrecisionTestCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("decimal_precision_test_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DecimalPrecisionTestWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("decimal_precision_test_write_uid_fkey");
        });

        modelBuilder.Entity<DocumentConfiguration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_configuration_pkey");

            entity.ToTable("document_configuration", tb => tb.HasComment("Directory Configuration"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DocumentConfigurationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_configuration_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DocumentConfigurationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_configuration_write_uid_fkey");
        });

        modelBuilder.Entity<DocumentDirectory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_directory_pkey");

            entity.ToTable("document_directory", tb => tb.HasComment("Directory"));

            entity.HasIndex(e => new { e.Name, e.ParentId, e.RessourceId, e.RessourceParentTypeId }, "document_directory_dirname_uniq").IsUnique();

            entity.HasIndex(e => e.Name, "document_directory_name_index");

            entity.HasIndex(e => e.ParentId, "document_directory_parent_id_index");

            entity.HasIndex(e => e.Type, "document_directory_type_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Date Created")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Creator")
                .HasColumnName("create_uid");
            entity.Property(e => e.Domain)
                .HasComment("Domain")
                .HasColumnType("character varying")
                .HasColumnName("domain");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Directory")
                .HasColumnName("parent_id");
            entity.Property(e => e.ResourceField)
                .HasComment("Name field")
                .HasColumnName("resource_field");
            entity.Property(e => e.ResourceFindAll)
                .HasComment("Find all resources")
                .HasColumnName("resource_find_all");
            entity.Property(e => e.RessourceId)
                .HasComment("Resource ID")
                .HasColumnName("ressource_id");
            entity.Property(e => e.RessourceParentTypeId)
                .HasComment("Parent Model")
                .HasColumnName("ressource_parent_type_id");
            entity.Property(e => e.RessourceTree)
                .HasComment("Tree Structure")
                .HasColumnName("ressource_tree");
            entity.Property(e => e.RessourceTypeId)
                .HasComment("Resource model")
                .HasColumnName("ressource_type_id");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasComment("Owner")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Date Modified")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Modification User")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.DocumentDirectories)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DocumentDirectoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_parent_id_fkey");

            entity.HasOne(d => d.ResourceFieldNavigation).WithMany(p => p.DocumentDirectories)
                .HasForeignKey(d => d.ResourceField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_resource_field_fkey");

            entity.HasOne(d => d.RessourceParentType).WithMany(p => p.DocumentDirectoryRessourceParentTypes)
                .HasForeignKey(d => d.RessourceParentTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_ressource_parent_type_id_fkey");

            entity.HasOne(d => d.RessourceType).WithMany(p => p.DocumentDirectoryRessourceTypes)
                .HasForeignKey(d => d.RessourceTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_ressource_type_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.DocumentDirectoryUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DocumentDirectoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_write_uid_fkey");
        });

        modelBuilder.Entity<DocumentDirectoryContent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_directory_content_pkey");

            entity.ToTable("document_directory_content", tb => tb.HasComment("Directory Content"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DirectoryId)
                .HasComment("Directory")
                .HasColumnName("directory_id");
            entity.Property(e => e.Extension)
                .HasMaxLength(4)
                .HasComment("Document Type")
                .HasColumnName("extension");
            entity.Property(e => e.IncludeName)
                .HasComment("Include Record Name")
                .HasColumnName("include_name");
            entity.Property(e => e.Name)
                .HasComment("Content Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Prefix)
                .HasMaxLength(16)
                .HasComment("Prefix")
                .HasColumnName("prefix");
            entity.Property(e => e.ReportId)
                .HasComment("Report")
                .HasColumnName("report_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.Suffix)
                .HasMaxLength(16)
                .HasComment("Suffix")
                .HasColumnName("suffix");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DocumentDirectoryContentCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_content_create_uid_fkey");

            entity.HasOne(d => d.Directory).WithMany(p => p.DocumentDirectoryContents)
                .HasForeignKey(d => d.DirectoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_content_directory_id_fkey");

            entity.HasOne(d => d.Report).WithMany(p => p.DocumentDirectoryContents)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_content_report_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DocumentDirectoryContentWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_content_write_uid_fkey");
        });

        modelBuilder.Entity<DocumentDirectoryContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_directory_content_type_pkey");

            entity.ToTable("document_directory_content_type", tb => tb.HasComment("Directory Content Type"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Code)
                .HasMaxLength(4)
                .HasComment("Extension")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Mimetype)
                .HasComment("Mime Type")
                .HasColumnType("character varying")
                .HasColumnName("mimetype");
            entity.Property(e => e.Name)
                .HasComment("Content Type")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DocumentDirectoryContentTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_content_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DocumentDirectoryContentTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_content_type_write_uid_fkey");
        });

        modelBuilder.Entity<DocumentDirectoryDctx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_directory_dctx_pkey");

            entity.ToTable("document_directory_dctx", tb => tb.HasComment("Directory Dynamic Context"));

            entity.HasIndex(e => e.Field, "document_directory_dctx_field_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DirId)
                .HasComment("Directory")
                .HasColumnName("dir_id");
            entity.Property(e => e.Expr)
                .HasComment("Expression")
                .HasColumnType("character varying")
                .HasColumnName("expr");
            entity.Property(e => e.Field)
                .HasComment("Field")
                .HasColumnType("character varying")
                .HasColumnName("field");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DocumentDirectoryDctxCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_dctx_create_uid_fkey");

            entity.HasOne(d => d.Dir).WithMany(p => p.DocumentDirectoryDctxes)
                .HasForeignKey(d => d.DirId)
                .HasConstraintName("document_directory_dctx_dir_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DocumentDirectoryDctxWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_directory_dctx_write_uid_fkey");
        });

        modelBuilder.Entity<DocumentDirectoryGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("document_directory_group_rel", tb => tb.HasComment("RELATION BETWEEN document_directory AND res_groups"));

            entity.HasIndex(e => e.GroupId, "document_directory_group_rel_group_id_index");

            entity.HasIndex(e => new { e.ItemId, e.GroupId }, "document_directory_group_rel_item_id_group_id_key").IsUnique();

            entity.HasIndex(e => e.ItemId, "document_directory_group_rel_item_id_index");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.ItemId).HasColumnName("item_id");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("document_directory_group_rel_group_id_fkey");

            entity.HasOne(d => d.Item).WithMany()
                .HasForeignKey(d => d.ItemId)
                .HasConstraintName("document_directory_group_rel_item_id_fkey");
        });

        modelBuilder.Entity<DocumentStorage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("document_storage_pkey");

            entity.ToTable("document_storage", tb => tb.HasComment("Storage Media"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.DocumentStorageCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_storage_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.DocumentStorageWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("document_storage_write_uid_fkey");
        });

        modelBuilder.Entity<EmailTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("email_template_pkey");

            entity.ToTable("email_template", tb => tb.HasComment("Email Templates"));

            entity.HasIndex(e => e.Model, "email_template_model_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutoDelete)
                .HasComment("Auto Delete")
                .HasColumnName("auto_delete");
            entity.Property(e => e.BodyHtml)
                .HasComment("Body")
                .HasColumnName("body_html");
            entity.Property(e => e.Copyvalue)
                .HasComment("Placeholder Expression")
                .HasColumnType("character varying")
                .HasColumnName("copyvalue");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.EmailCc)
                .HasComment("Cc")
                .HasColumnType("character varying")
                .HasColumnName("email_cc");
            entity.Property(e => e.EmailFrom)
                .HasComment("From")
                .HasColumnType("character varying")
                .HasColumnName("email_from");
            entity.Property(e => e.EmailTo)
                .HasComment("To (Emails)")
                .HasColumnType("character varying")
                .HasColumnName("email_to");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.MailServerId)
                .HasComment("Outgoing Mail Server")
                .HasColumnName("mail_server_id");
            entity.Property(e => e.Model)
                .HasComment("Related Document Model")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelId)
                .HasComment("Applies to")
                .HasColumnName("model_id");
            entity.Property(e => e.ModelObjectField)
                .HasComment("Field")
                .HasColumnName("model_object_field");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NullValue)
                .HasComment("Default Value")
                .HasColumnType("character varying")
                .HasColumnName("null_value");
            entity.Property(e => e.PartnerTo)
                .HasComment("To (Partners)")
                .HasColumnType("character varying")
                .HasColumnName("partner_to");
            entity.Property(e => e.RefIrActWindow)
                .HasComment("Sidebar action")
                .HasColumnName("ref_ir_act_window");
            entity.Property(e => e.RefIrValue)
                .HasComment("Sidebar Button")
                .HasColumnName("ref_ir_value");
            entity.Property(e => e.ReplyTo)
                .HasComment("Reply-To")
                .HasColumnType("character varying")
                .HasColumnName("reply_to");
            entity.Property(e => e.ReportName)
                .HasComment("Report Filename")
                .HasColumnType("character varying")
                .HasColumnName("report_name");
            entity.Property(e => e.ReportTemplate)
                .HasComment("Optional report to print and attach")
                .HasColumnName("report_template");
            entity.Property(e => e.SubModelObjectField)
                .HasComment("Sub-field")
                .HasColumnName("sub_model_object_field");
            entity.Property(e => e.SubObject)
                .HasComment("Sub-model")
                .HasColumnName("sub_object");
            entity.Property(e => e.Subject)
                .HasComment("Subject")
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.UseDefaultTo)
                .HasComment("Default recipients")
                .HasColumnName("use_default_to");
            entity.Property(e => e.UserSignature)
                .HasComment("Add Signature")
                .HasColumnName("user_signature");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.EmailTemplateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_create_uid_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.EmailTemplates)
                .HasForeignKey(d => d.MailServerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_mail_server_id_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.EmailTemplateModelNavigations)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_model_id_fkey");

            entity.HasOne(d => d.ModelObjectFieldNavigation).WithMany(p => p.EmailTemplateModelObjectFieldNavigations)
                .HasForeignKey(d => d.ModelObjectField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_model_object_field_fkey");

            entity.HasOne(d => d.RefIrActWindowNavigation).WithMany(p => p.EmailTemplates)
                .HasForeignKey(d => d.RefIrActWindow)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_ref_ir_act_window_fkey");

            entity.HasOne(d => d.RefIrValueNavigation).WithMany(p => p.EmailTemplates)
                .HasForeignKey(d => d.RefIrValue)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_ref_ir_value_fkey");

            entity.HasOne(d => d.ReportTemplateNavigation).WithMany(p => p.EmailTemplates)
                .HasForeignKey(d => d.ReportTemplate)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_report_template_fkey");

            entity.HasOne(d => d.SubModelObjectFieldNavigation).WithMany(p => p.EmailTemplateSubModelObjectFieldNavigations)
                .HasForeignKey(d => d.SubModelObjectField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_sub_model_object_field_fkey");

            entity.HasOne(d => d.SubObjectNavigation).WithMany(p => p.EmailTemplateSubObjectNavigations)
                .HasForeignKey(d => d.SubObject)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_sub_object_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.EmailTemplateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_write_uid_fkey");
        });

        modelBuilder.Entity<EmailTemplateAttachmentRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("email_template_attachment_rel", tb => tb.HasComment("RELATION BETWEEN email_template AND ir_attachment"));

            entity.HasIndex(e => e.AttachmentId, "email_template_attachment_rel_attachment_id_index");

            entity.HasIndex(e => new { e.EmailTemplateId, e.AttachmentId }, "email_template_attachment_rel_email_template_id_attachment__key").IsUnique();

            entity.HasIndex(e => e.EmailTemplateId, "email_template_attachment_rel_email_template_id_index");

            entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");
            entity.Property(e => e.EmailTemplateId).HasColumnName("email_template_id");

            entity.HasOne(d => d.Attachment).WithMany()
                .HasForeignKey(d => d.AttachmentId)
                .HasConstraintName("email_template_attachment_rel_attachment_id_fkey");

            entity.HasOne(d => d.EmailTemplate).WithMany()
                .HasForeignKey(d => d.EmailTemplateId)
                .HasConstraintName("email_template_attachment_rel_email_template_id_fkey");
        });

        modelBuilder.Entity<EmailTemplatePreview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("email_template_preview_pkey");

            entity.ToTable("email_template_preview", tb => tb.HasComment("Email Template Preview"));

            entity.HasIndex(e => e.Model, "email_template_preview_model_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutoDelete)
                .HasComment("Auto Delete")
                .HasColumnName("auto_delete");
            entity.Property(e => e.BodyHtml)
                .HasComment("Body")
                .HasColumnName("body_html");
            entity.Property(e => e.Copyvalue)
                .HasComment("Placeholder Expression")
                .HasColumnType("character varying")
                .HasColumnName("copyvalue");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.EmailCc)
                .HasComment("Cc")
                .HasColumnType("character varying")
                .HasColumnName("email_cc");
            entity.Property(e => e.EmailFrom)
                .HasComment("From")
                .HasColumnType("character varying")
                .HasColumnName("email_from");
            entity.Property(e => e.EmailTo)
                .HasComment("To (Emails)")
                .HasColumnType("character varying")
                .HasColumnName("email_to");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.MailServerId)
                .HasComment("Outgoing Mail Server")
                .HasColumnName("mail_server_id");
            entity.Property(e => e.Model)
                .HasComment("Related Document Model")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelId)
                .HasComment("Applies to")
                .HasColumnName("model_id");
            entity.Property(e => e.ModelObjectField)
                .HasComment("Field")
                .HasColumnName("model_object_field");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NullValue)
                .HasComment("Default Value")
                .HasColumnType("character varying")
                .HasColumnName("null_value");
            entity.Property(e => e.PartnerTo)
                .HasComment("To (Partners)")
                .HasColumnType("character varying")
                .HasColumnName("partner_to");
            entity.Property(e => e.RefIrActWindow)
                .HasComment("Sidebar action")
                .HasColumnName("ref_ir_act_window");
            entity.Property(e => e.RefIrValue)
                .HasComment("Sidebar Button")
                .HasColumnName("ref_ir_value");
            entity.Property(e => e.ReplyTo)
                .HasComment("Reply-To")
                .HasColumnType("character varying")
                .HasColumnName("reply_to");
            entity.Property(e => e.ReportName)
                .HasComment("Report Filename")
                .HasColumnType("character varying")
                .HasColumnName("report_name");
            entity.Property(e => e.ReportTemplate)
                .HasComment("Optional report to print and attach")
                .HasColumnName("report_template");
            entity.Property(e => e.ResId)
                .HasComment("Sample Document")
                .HasColumnType("character varying")
                .HasColumnName("res_id");
            entity.Property(e => e.SubModelObjectField)
                .HasComment("Sub-field")
                .HasColumnName("sub_model_object_field");
            entity.Property(e => e.SubObject)
                .HasComment("Sub-model")
                .HasColumnName("sub_object");
            entity.Property(e => e.Subject)
                .HasComment("Subject")
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.UseDefaultTo)
                .HasComment("Default recipients")
                .HasColumnName("use_default_to");
            entity.Property(e => e.UserSignature)
                .HasComment("Add Signature")
                .HasColumnName("user_signature");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.EmailTemplatePreviewCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_create_uid_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.EmailTemplatePreviews)
                .HasForeignKey(d => d.MailServerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_mail_server_id_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.EmailTemplatePreviewModelNavigations)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_model_id_fkey");

            entity.HasOne(d => d.ModelObjectFieldNavigation).WithMany(p => p.EmailTemplatePreviewModelObjectFieldNavigations)
                .HasForeignKey(d => d.ModelObjectField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_model_object_field_fkey");

            entity.HasOne(d => d.RefIrActWindowNavigation).WithMany(p => p.EmailTemplatePreviews)
                .HasForeignKey(d => d.RefIrActWindow)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_ref_ir_act_window_fkey");

            entity.HasOne(d => d.RefIrValueNavigation).WithMany(p => p.EmailTemplatePreviews)
                .HasForeignKey(d => d.RefIrValue)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_ref_ir_value_fkey");

            entity.HasOne(d => d.ReportTemplateNavigation).WithMany(p => p.EmailTemplatePreviews)
                .HasForeignKey(d => d.ReportTemplate)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_report_template_fkey");

            entity.HasOne(d => d.SubModelObjectFieldNavigation).WithMany(p => p.EmailTemplatePreviewSubModelObjectFieldNavigations)
                .HasForeignKey(d => d.SubModelObjectField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_sub_model_object_field_fkey");

            entity.HasOne(d => d.SubObjectNavigation).WithMany(p => p.EmailTemplatePreviewSubObjectNavigations)
                .HasForeignKey(d => d.SubObject)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_sub_object_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.EmailTemplatePreviewWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("email_template_preview_write_uid_fkey");
        });

        modelBuilder.Entity<EmailTemplatePreviewResPartnerRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("email_template_preview_res_partner_rel", tb => tb.HasComment("RELATION BETWEEN email_template_preview AND res_partner"));

            entity.HasIndex(e => new { e.EmailTemplatePreviewId, e.ResPartnerId }, "email_template_preview_res_pa_email_template_preview_id_res_key").IsUnique();

            entity.HasIndex(e => e.EmailTemplatePreviewId, "email_template_preview_res_partner_rel_email_template_preview_i");

            entity.HasIndex(e => e.ResPartnerId, "email_template_preview_res_partner_rel_res_partner_id_index");

            entity.Property(e => e.EmailTemplatePreviewId).HasColumnName("email_template_preview_id");
            entity.Property(e => e.ResPartnerId).HasColumnName("res_partner_id");

            entity.HasOne(d => d.EmailTemplatePreview).WithMany()
                .HasForeignKey(d => d.EmailTemplatePreviewId)
                .HasConstraintName("email_template_preview_res_partn_email_template_preview_id_fkey");

            entity.HasOne(d => d.ResPartner).WithMany()
                .HasForeignKey(d => d.ResPartnerId)
                .HasConstraintName("email_template_preview_res_partner_rel_res_partner_id_fkey");
        });

        modelBuilder.Entity<EmployeeCategoryRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("employee_category_rel", tb => tb.HasComment("RELATION BETWEEN hr_employee_category AND hr_employee"));

            entity.HasIndex(e => new { e.CategoryId, e.EmpId }, "employee_category_rel_category_id_emp_id_key").IsUnique();

            entity.HasIndex(e => e.CategoryId, "employee_category_rel_category_id_index");

            entity.HasIndex(e => e.EmpId, "employee_category_rel_emp_id_index");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.EmpId).HasColumnName("emp_id");

            entity.HasOne(d => d.Category).WithMany()
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("employee_category_rel_category_id_fkey");

            entity.HasOne(d => d.Emp).WithMany()
                .HasForeignKey(d => d.EmpId)
                .HasConstraintName("employee_category_rel_emp_id_fkey");
        });

        modelBuilder.Entity<FetchmailConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fetchmail_config_settings_pkey");

            entity.ToTable("fetchmail_config_settings", tb => tb.HasComment("fetchmail.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FetchmailConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_config_settings_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FetchmailConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<FetchmailServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fetchmail_server_pkey");

            entity.ToTable("fetchmail_server", tb => tb.HasComment("POP/IMAP Server"));

            entity.HasIndex(e => e.State, "fetchmail_server_state_index");

            entity.HasIndex(e => e.Type, "fetchmail_server_type_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasComment("Server Action")
                .HasColumnName("action_id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Attach)
                .HasComment("Keep Attachments")
                .HasColumnName("attach");
            entity.Property(e => e.Configuration)
                .HasComment("Configuration")
                .HasColumnName("configuration");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Last Fetch Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.IsSsl)
                .HasComment("SSL/TLS")
                .HasColumnName("is_ssl");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ObjectId)
                .HasComment("Create a New Record")
                .HasColumnName("object_id");
            entity.Property(e => e.Original)
                .HasComment("Keep Original")
                .HasColumnName("original");
            entity.Property(e => e.Password)
                .HasComment("Password")
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.Port)
                .HasComment("Port")
                .HasColumnName("port");
            entity.Property(e => e.Priority)
                .HasComment("Server Priority")
                .HasColumnName("priority");
            entity.Property(e => e.Script)
                .HasComment("Script")
                .HasColumnType("character varying")
                .HasColumnName("script");
            entity.Property(e => e.Server)
                .HasComment("Server Name")
                .HasColumnType("character varying")
                .HasColumnName("server");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Type)
                .HasComment("Server Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.User)
                .HasComment("Username")
                .HasColumnType("character varying")
                .HasColumnName("user");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Action).WithMany(p => p.FetchmailServers)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_action_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FetchmailServerCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_create_uid_fkey");

            entity.HasOne(d => d.Object).WithMany(p => p.FetchmailServers)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_object_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FetchmailServerWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("fetchmail_server_write_uid_fkey");
        });

        modelBuilder.Entity<FolioRoomLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("folio_room_line_pkey");

            entity.ToTable("folio_room_line", tb => tb.HasComment("Hotel Room Reservation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CheckIn)
                .HasComment("Check In Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("check_in");
            entity.Property(e => e.CheckOut)
                .HasComment("Check Out Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("check_out");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.RoomId)
                .HasComment("Room id")
                .HasColumnName("room_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.FolioRoomLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("folio_room_line_create_uid_fkey");

            entity.HasOne(d => d.Room).WithMany(p => p.FolioRoomLines)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("folio_room_line_room_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.FolioRoomLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("folio_room_line_write_uid_fkey");
        });

        modelBuilder.Entity<Block>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_block_pkey");

            entity.ToTable("hotel_block", tb => tb.HasComment("Block"));

            entity.HasIndex(e => e.Name, "hotel_block_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("Block Name")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelBlockCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_block_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelBlockWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_block_write_uid_fkey");
        });

        modelBuilder.Entity<Building>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_building_pkey");

            entity.ToTable("hotel_building", tb => tb.HasComment("Building"));

            entity.HasIndex(e => e.Name, "hotel_building_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("Building Name")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelBuildingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_building_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelBuildingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_building_write_uid_fkey");
        });

        modelBuilder.Entity<Floor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_floor_pkey");

            entity.ToTable("hotel_floor", tb => tb.HasComment("Floor"));

            entity.HasIndex(e => e.Name, "hotel_floor_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("Floor Name")
                .HasColumnName("name");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelFloorCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_floor_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelFloorWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_floor_write_uid_fkey");
        });

        modelBuilder.Entity<HotelReservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_reservation_pkey");

            entity.ToTable("hotel_reservation", tb => tb.HasComment("Reservation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adults)
                .HasComment("Adults")
                .HasColumnName("adults");
            entity.Property(e => e.Checkin)
                .HasComment("Expected-Date-Arrival")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checkin");
            entity.Property(e => e.Checkout)
                .HasComment("Expected-Date-Departure")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("checkout");
            entity.Property(e => e.Children)
                .HasComment("Children")
                .HasColumnName("children");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateOrder)
                .HasComment("Date Ordered")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_order");
            entity.Property(e => e.DevoteeId)
                .HasComment("Devotee")
                .HasColumnName("devotee_id");
            entity.Property(e => e.Dummy)
                .HasComment("Dummy")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dummy");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.PartnerId)
                .HasComment("Guest Name")
                .HasColumnName("partner_id");
            entity.Property(e => e.PartnerInvoiceId)
                .HasComment("Invoice Address")
                .HasColumnName("partner_invoice_id");
            entity.Property(e => e.PartnerOrderId)
                .HasComment("Ordering Contact")
                .HasColumnName("partner_order_id");
            entity.Property(e => e.PartnerShippingId)
                .HasComment("Delivery Address")
                .HasColumnName("partner_shipping_id");
            entity.Property(e => e.PricelistId)
                .HasComment("Scheme")
                .HasColumnName("pricelist_id");
            entity.Property(e => e.ReservationNo)
                .HasMaxLength(64)
                .HasComment("Reservation No")
                .HasColumnName("reservation_no");
            entity.Property(e => e.State)
                .HasComment("State")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WarehouseId)
                .HasComment("Ashram")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelReservationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_create_uid_fkey");

            entity.HasOne(d => d.Devotee).WithMany(p => p.HotelReservations)
                .HasForeignKey(d => d.DevoteeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_devotee_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.HotelReservationPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_partner_id_fkey");

            entity.HasOne(d => d.PartnerInvoice).WithMany(p => p.HotelReservationPartnerInvoices)
                .HasForeignKey(d => d.PartnerInvoiceId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_partner_invoice_id_fkey");

            entity.HasOne(d => d.PartnerOrder).WithMany(p => p.HotelReservationPartnerOrders)
                .HasForeignKey(d => d.PartnerOrderId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_partner_order_id_fkey");

            entity.HasOne(d => d.PartnerShipping).WithMany(p => p.HotelReservationPartnerShippings)
                .HasForeignKey(d => d.PartnerShippingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_partner_shipping_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.HotelReservations)
                .HasForeignKey(d => d.PricelistId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_pricelist_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.HotelReservations)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelReservationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_write_uid_fkey");
        });

        modelBuilder.Entity<HotelReservationLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_reservation_line_pkey");

            entity.ToTable("hotel_reservation_line", tb => tb.HasComment("Reservation Line"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allocated)
                .HasComment("Already allocated")
                .HasColumnName("allocated");
            entity.Property(e => e.BlockId)
                .HasComment("Block")
                .HasColumnName("block_id");
            entity.Property(e => e.BuildingId)
                .HasComment("Building")
                .HasColumnName("building_id");
            entity.Property(e => e.CategId)
                .HasComment("Room Type")
                .HasColumnName("categ_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FloorId)
                .HasComment("Floor")
                .HasColumnName("floor_id");
            entity.Property(e => e.LineId)
                .HasComment("Line id")
                .HasColumnName("line_id");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("Name")
                .HasColumnName("name");
            entity.Property(e => e.Room)
                .HasComment("Room")
                .HasColumnName("room");
            entity.Property(e => e.ToAllocate)
                .HasComment("No of person(s) to allocate")
                .HasColumnName("to_allocate");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Block).WithMany(p => p.HotelReservationLines)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_block_id_fkey");

            entity.HasOne(d => d.Building).WithMany(p => p.HotelReservationLines)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_building_id_fkey");

            entity.HasOne(d => d.Categ).WithMany(p => p.HotelReservationLines)
                .HasForeignKey(d => d.CategId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_categ_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelReservationLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_create_uid_fkey");

            entity.HasOne(d => d.Floor).WithMany(p => p.HotelReservationLines)
                .HasForeignKey(d => d.FloorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_floor_id_fkey");

            entity.HasOne(d => d.Line).WithMany(p => p.HotelReservationLines)
                .HasForeignKey(d => d.LineId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_line_id_fkey");

            entity.HasOne(d => d.RoomNavigation).WithMany(p => p.HotelReservationLines)
                .HasForeignKey(d => d.Room)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_room_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelReservationLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_reservation_line_write_uid_fkey");
        });

        modelBuilder.Entity<HotelReservationLineRoomRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hotel_reservation_line_room_rel", tb => tb.HasComment("RELATION BETWEEN hotel_reservation_line AND hotel_room"));

            entity.HasIndex(e => new { e.HotelReservationLineId, e.RoomId }, "hotel_reservation_line_room_r_hotel_reservation_line_id_roo_key").IsUnique();

            entity.HasIndex(e => e.HotelReservationLineId, "hotel_reservation_line_room_rel_hotel_reservation_line_id_index");

            entity.HasIndex(e => e.RoomId, "hotel_reservation_line_room_rel_room_id_index");

            entity.Property(e => e.HotelReservationLineId).HasColumnName("hotel_reservation_line_id");
            entity.Property(e => e.RoomId).HasColumnName("room_id");

            entity.HasOne(d => d.HotelReservationLine).WithMany()
                .HasForeignKey(d => d.HotelReservationLineId)
                .HasConstraintName("hotel_reservation_line_room_rel_hotel_reservation_line_id_fkey");

            entity.HasOne(d => d.Room).WithMany()
                .HasForeignKey(d => d.RoomId)
                .HasConstraintName("hotel_reservation_line_room_rel_room_id_fkey");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_room_pkey");

            entity.ToTable("hotel_room", tb => tb.HasComment("Hotel Room"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BlockId)
                .HasComment("Block")
                .HasColumnName("block_id");
            entity.Property(e => e.BuildingId)
                .HasComment("Building")
                .HasColumnName("building_id");
            entity.Property(e => e.Capacity)
                .HasComment("Capacity")
                .HasColumnName("capacity");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FloorId)
                .HasComment("Floor No")
                .HasColumnName("floor_id");
            entity.Property(e => e.MaxAdult)
                .HasComment("Max Adult")
                .HasColumnName("max_adult");
            entity.Property(e => e.MaxChild)
                .HasComment("Max Child")
                .HasColumnName("max_child");
            entity.Property(e => e.ProductId)
                .HasComment("Product_id")
                .HasColumnName("product_id");
            entity.Property(e => e.Status)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Block).WithMany(p => p.HotelRooms)
                .HasForeignKey(d => d.BlockId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_block_id_fkey");

            entity.HasOne(d => d.Building).WithMany(p => p.HotelRooms)
                .HasForeignKey(d => d.BuildingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_building_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelRoomCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_create_uid_fkey");

            entity.HasOne(d => d.Floor).WithMany(p => p.HotelRooms)
                .HasForeignKey(d => d.FloorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_floor_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.HotelRooms)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("hotel_room_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelRoomWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_write_uid_fkey");
        });

        modelBuilder.Entity<HotelRoomAmenitiesType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_room_amenities_type_pkey");

            entity.ToTable("hotel_room_amenities_type", tb => tb.HasComment("amenities Type"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatId)
                .HasComment("category")
                .HasColumnName("cat_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Cat).WithMany(p => p.HotelRoomAmenitiesTypes)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("hotel_room_amenities_type_cat_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelRoomAmenitiesTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_amenities_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelRoomAmenitiesTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_amenities_type_write_uid_fkey");
        });

        modelBuilder.Entity<HotelRoomAmenity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_room_amenities_pkey");

            entity.ToTable("hotel_room_amenities", tb => tb.HasComment("Room amenities"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.RcategId)
                .HasComment("Amenity Catagory")
                .HasColumnName("rcateg_id");
            entity.Property(e => e.RoomCategId)
                .HasComment("Product Category")
                .HasColumnName("room_categ_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelRoomAmenityCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_amenities_create_uid_fkey");

            entity.HasOne(d => d.Rcateg).WithMany(p => p.HotelRoomAmenities)
                .HasForeignKey(d => d.RcategId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_amenities_rcateg_id_fkey");

            entity.HasOne(d => d.RoomCateg).WithMany(p => p.HotelRoomAmenities)
                .HasForeignKey(d => d.RoomCategId)
                .HasConstraintName("hotel_room_amenities_room_categ_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelRoomAmenityWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_amenities_write_uid_fkey");
        });

        modelBuilder.Entity<HotelRoomReservationLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_room_reservation_line_pkey");

            entity.ToTable("hotel_room_reservation_line", tb => tb.HasComment("Hotel Room Reservation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allocated)
                .HasComment("Allocated")
                .HasColumnName("allocated");
            entity.Property(e => e.CheckIn)
                .HasComment("Check In Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("check_in");
            entity.Property(e => e.CheckOut)
                .HasComment("Check Out Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("check_out");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ReservationId)
                .HasComment("Reservation")
                .HasColumnName("reservation_id");
            entity.Property(e => e.RoomId)
                .HasComment("Room id")
                .HasColumnName("room_id");
            entity.Property(e => e.State)
                .HasComment("Room Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelRoomReservationLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_reservation_line_create_uid_fkey");

            entity.HasOne(d => d.Reservation).WithMany(p => p.HotelRoomReservationLines)
                .HasForeignKey(d => d.ReservationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_reservation_line_reservation_id_fkey");

            entity.HasOne(d => d.Room).WithMany(p => p.HotelRoomReservationLines)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_reservation_line_room_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelRoomReservationLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_reservation_line_write_uid_fkey");
        });

        modelBuilder.Entity<HotelRoomType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_room_type_pkey");

            entity.ToTable("hotel_room_type", tb => tb.HasComment("Room Type"));

            entity.HasIndex(e => e.CatId, "hotel_room_type_cat_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CatId)
                .HasComment("category")
                .HasColumnName("cat_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Cat).WithMany(p => p.HotelRoomTypes)
                .HasForeignKey(d => d.CatId)
                .HasConstraintName("hotel_room_type_cat_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelRoomTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelRoomTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_room_type_write_uid_fkey");
        });

        modelBuilder.Entity<HotelService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_services_pkey");

            entity.ToTable("hotel_services", tb => tb.HasComment("Aaashrmam Services and its charges"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ServiceId)
                .HasComment("Service_id")
                .HasColumnName("service_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelServiceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_services_create_uid_fkey");

            entity.HasOne(d => d.Service).WithMany(p => p.HotelServices)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("hotel_services_service_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelServiceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_services_write_uid_fkey");
        });

        modelBuilder.Entity<HotelServiceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hotel_service_type_pkey");

            entity.ToTable("hotel_service_type", tb => tb.HasComment("Service Type"));

            entity.HasIndex(e => e.SerId, "hotel_service_type_ser_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.SerId)
                .HasComment("category")
                .HasColumnName("ser_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HotelServiceTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_service_type_create_uid_fkey");

            entity.HasOne(d => d.Ser).WithMany(p => p.HotelServiceTypes)
                .HasForeignKey(d => d.SerId)
                .HasConstraintName("hotel_service_type_ser_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HotelServiceTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hotel_service_type_write_uid_fkey");
        });

        modelBuilder.Entity<HrActionReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_action_reason_pkey");

            entity.ToTable("hr_action_reason", tb => tb.HasComment("Action Reason"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionType)
                .HasComment("Action Type")
                .HasColumnType("character varying")
                .HasColumnName("action_type");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Reason")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrActionReasonCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_action_reason_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrActionReasonWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_action_reason_write_uid_fkey");
        });

        modelBuilder.Entity<HrAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_attendance_pkey");

            entity.ToTable("hr_attendance", tb => tb.HasComment("Attendance"));

            entity.HasIndex(e => e.EmployeeId, "hr_attendance_employee_id_index");

            entity.HasIndex(e => e.Name, "hr_attendance_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasComment("Action")
                .HasColumnType("character varying")
                .HasColumnName("action");
            entity.Property(e => e.ActionDesc)
                .HasComment("Action Reason")
                .HasColumnName("action_desc");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.EmployeeId)
                .HasComment("Employee")
                .HasColumnName("employee_id");
            entity.Property(e => e.Name)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("name");
            entity.Property(e => e.WorkedHours)
                .HasComment("Worked Hours")
                .HasColumnName("worked_hours");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.ActionDescNavigation).WithMany(p => p.HrAttendances)
                .HasForeignKey(d => d.ActionDesc)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_action_desc_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrAttendanceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_create_uid_fkey");

            entity.HasOne(d => d.Employee).WithMany(p => p.HrAttendances)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_employee_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrAttendanceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_write_uid_fkey");
        });

        modelBuilder.Entity<HrAttendanceError>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_attendance_error_pkey");

            entity.ToTable("hr_attendance_error", tb => tb.HasComment("Print Error Attendance Report"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.EndDate)
                .HasComment("Ending Date")
                .HasColumnName("end_date");
            entity.Property(e => e.InitDate)
                .HasComment("Starting Date")
                .HasColumnName("init_date");
            entity.Property(e => e.MaxDelay)
                .HasComment("Max. Delay (Min)")
                .HasColumnName("max_delay");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrAttendanceErrorCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_error_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrAttendanceErrorWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_attendance_error_write_uid_fkey");
        });

        modelBuilder.Entity<HrConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_config_settings_pkey");

            entity.ToTable("hr_config_settings", tb => tb.HasComment("hr.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.GroupHrAttendance)
                .HasComment("Track attendances for all employees")
                .HasColumnName("group_hr_attendance");
            entity.Property(e => e.ModuleAccountAnalyticAnalysis)
                .HasComment("Allow invoicing based on timesheets (the sale application will be installed)")
                .HasColumnName("module_account_analytic_analysis");
            entity.Property(e => e.ModuleHrAttendance)
                .HasComment("Install attendances feature")
                .HasColumnName("module_hr_attendance");
            entity.Property(e => e.ModuleHrContract)
                .HasComment("Record contracts per employee")
                .HasColumnName("module_hr_contract");
            entity.Property(e => e.ModuleHrEvaluation)
                .HasComment("Organize employees periodic evaluation")
                .HasColumnName("module_hr_evaluation");
            entity.Property(e => e.ModuleHrExpense)
                .HasComment("Manage employees expenses")
                .HasColumnName("module_hr_expense");
            entity.Property(e => e.ModuleHrGamification)
                .HasComment("Drive engagement with challenges and badges")
                .HasColumnName("module_hr_gamification");
            entity.Property(e => e.ModuleHrHolidays)
                .HasComment("Manage holidays, leaves and allocation requests")
                .HasColumnName("module_hr_holidays");
            entity.Property(e => e.ModuleHrPayroll)
                .HasComment("Manage payroll")
                .HasColumnName("module_hr_payroll");
            entity.Property(e => e.ModuleHrRecruitment)
                .HasComment("Manage the recruitment process")
                .HasColumnName("module_hr_recruitment");
            entity.Property(e => e.ModuleHrTimesheet)
                .HasComment("Manage timesheets")
                .HasColumnName("module_hr_timesheet");
            entity.Property(e => e.ModuleHrTimesheetSheet)
                .HasComment("Allow timesheets validation by managers")
                .HasColumnName("module_hr_timesheet_sheet");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_config_settings_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<HrDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_department_pkey");

            entity.ToTable("hr_department", tb => tb.HasComment("hr.department"));

            entity.HasIndex(e => e.CompanyId, "hr_department_company_id_index");

            entity.HasIndex(e => e.ParentId, "hr_department_parent_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ManagerId)
                .HasComment("Manager")
                .HasColumnName("manager_id");
            entity.Property(e => e.Name)
                .HasComment("Department Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasComment("Note")
                .HasColumnName("note");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Department")
                .HasColumnName("parent_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.HrDepartments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrDepartmentCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_create_uid_fkey");

            entity.HasOne(d => d.Manager).WithMany(p => p.HrDepartments)
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_manager_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrDepartmentWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_department_write_uid_fkey");
        });

        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_pkey");

            entity.ToTable("hr_employee", tb => tb.HasComment("Employee"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressHomeId)
                .HasComment("Home Address")
                .HasColumnName("address_home_id");
            entity.Property(e => e.AddressId)
                .HasComment("Working Address")
                .HasColumnName("address_id");
            entity.Property(e => e.BankAccountId)
                .HasComment("Bank Account Number")
                .HasColumnName("bank_account_id");
            entity.Property(e => e.Birthday)
                .HasComment("Date of Birth")
                .HasColumnName("birthday");
            entity.Property(e => e.CoachId)
                .HasComment("Coach")
                .HasColumnName("coach_id");
            entity.Property(e => e.Code)
                .HasComment("Roll number")
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.Color)
                .HasComment("Color Index")
                .HasColumnName("color");
            entity.Property(e => e.CountryId)
                .HasComment("Nationality")
                .HasColumnName("country_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DepartmentId)
                .HasComment("Department")
                .HasColumnName("department_id");
            entity.Property(e => e.Gender)
                .HasComment("Gender")
                .HasColumnType("character varying")
                .HasColumnName("gender");
            entity.Property(e => e.IdentificationId)
                .HasComment("Identification No")
                .HasColumnType("character varying")
                .HasColumnName("identification_id");
            entity.Property(e => e.Image)
                .HasComment("Photo")
                .HasColumnName("image");
            entity.Property(e => e.ImageMedium)
                .HasComment("Medium-sized photo")
                .HasColumnName("image_medium");
            entity.Property(e => e.ImageSmall)
                .HasComment("Small-sized photo")
                .HasColumnName("image_small");
            entity.Property(e => e.JobId)
                .HasComment("Job Title")
                .HasColumnName("job_id");
            entity.Property(e => e.Marital)
                .HasComment("Marital Status")
                .HasColumnType("character varying")
                .HasColumnName("marital");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.MobilePhone)
                .HasComment("Work Mobile")
                .HasColumnType("character varying")
                .HasColumnName("mobile_phone");
            entity.Property(e => e.NameRelated)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name_related");
            entity.Property(e => e.Notes)
                .HasComment("Notes")
                .HasColumnName("notes");
            entity.Property(e => e.Otherid)
                .HasComment("Other Id")
                .HasColumnType("character varying")
                .HasColumnName("otherid");
            entity.Property(e => e.ParentId)
                .HasComment("Manager")
                .HasColumnName("parent_id");
            entity.Property(e => e.PassportId)
                .HasComment("Passport No")
                .HasColumnType("character varying")
                .HasColumnName("passport_id");
            entity.Property(e => e.ResourceId)
                .HasComment("Resource")
                .HasColumnName("resource_id");
            entity.Property(e => e.Sinid)
                .HasComment("SIN No")
                .HasColumnType("character varying")
                .HasColumnName("sinid");
            entity.Property(e => e.Ssnid)
                .HasComment("SSN No")
                .HasColumnType("character varying")
                .HasColumnName("ssnid");
            entity.Property(e => e.WorkEmail)
                .HasMaxLength(240)
                .HasComment("Work Email")
                .HasColumnName("work_email");
            entity.Property(e => e.WorkLocation)
                .HasComment("Office Location")
                .HasColumnType("character varying")
                .HasColumnName("work_location");
            entity.Property(e => e.WorkPhone)
                .HasComment("Work Phone")
                .HasColumnType("character varying")
                .HasColumnName("work_phone");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.AddressHome).WithMany(p => p.HrEmployeeAddressHomes)
                .HasForeignKey(d => d.AddressHomeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_address_home_id_fkey");

            entity.HasOne(d => d.Address).WithMany(p => p.HrEmployeeAddresses)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_address_id_fkey");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.BankAccountId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_bank_account_id_fkey");

            entity.HasOne(d => d.Coach).WithMany(p => p.InverseCoach)
                .HasForeignKey(d => d.CoachId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_coach_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_department_id_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_job_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_parent_id_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.ResourceId)
                .HasConstraintName("hr_employee_resource_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_write_uid_fkey");
        });

        modelBuilder.Entity<HrEmployeeCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_category_pkey");

            entity.ToTable("hr_employee_category", tb => tb.HasComment("Employee Category"));

            entity.HasIndex(e => e.ParentId, "hr_employee_category_parent_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Employee Tag")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Employee Tag")
                .HasColumnName("parent_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeCategoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_category_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeCategoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_category_write_uid_fkey");
        });

        modelBuilder.Entity<HrJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_job_pkey");

            entity.ToTable("hr_job", tb => tb.HasComment("Job Position"));

            entity.HasIndex(e => new { e.Name, e.CompanyId, e.DepartmentId }, "hr_job_name_company_uniq").IsUnique();

            entity.HasIndex(e => e.Name, "hr_job_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DepartmentId)
                .HasComment("Department")
                .HasColumnName("department_id");
            entity.Property(e => e.Description)
                .HasComment("Job Description")
                .HasColumnName("description");
            entity.Property(e => e.ExpectedEmployees)
                .HasComment("Total Forecasted Employees")
                .HasColumnName("expected_employees");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.Name)
                .HasComment("Job Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NoOfEmployee)
                .HasComment("Current Number of Employees")
                .HasColumnName("no_of_employee");
            entity.Property(e => e.NoOfHiredEmployee)
                .HasComment("Hired Employees")
                .HasColumnName("no_of_hired_employee");
            entity.Property(e => e.NoOfRecruitment)
                .HasComment("Expected New Employees")
                .HasColumnName("no_of_recruitment");
            entity.Property(e => e.Requirements)
                .HasComment("Requirements")
                .HasColumnName("requirements");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Update Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.HrJobs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrJobCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrJobs)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_department_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrJobWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_job_write_uid_fkey");
        });

        modelBuilder.Entity<ImChatMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("im_chat_message_pkey");

            entity.ToTable("im_chat_message", tb => tb.HasComment("im_chat.message"));

            entity.HasIndex(e => e.CreateDate, "im_chat_message_create_date_index");

            entity.HasIndex(e => e.ToId, "im_chat_message_to_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Create Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FromId)
                .HasComment("Author")
                .HasColumnName("from_id");
            entity.Property(e => e.Message)
                .HasComment("Message")
                .HasColumnType("character varying")
                .HasColumnName("message");
            entity.Property(e => e.ToId)
                .HasComment("Session To")
                .HasColumnName("to_id");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ImChatMessageCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_message_create_uid_fkey");

            entity.HasOne(d => d.From).WithMany(p => p.ImChatMessageFroms)
                .HasForeignKey(d => d.FromId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_message_from_id_fkey");

            entity.HasOne(d => d.To).WithMany(p => p.ImChatMessages)
                .HasForeignKey(d => d.ToId)
                .HasConstraintName("im_chat_message_to_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ImChatMessageWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_message_write_uid_fkey");
        });

        modelBuilder.Entity<ImChatPresence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("im_chat_presence_pkey");

            entity.ToTable("im_chat_presence", tb => tb.HasComment("im_chat.presence"));

            entity.HasIndex(e => e.UserId, "im_chat_presence_im_chat_user_status_unique").IsUnique();

            entity.HasIndex(e => e.UserId, "im_chat_presence_user_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.LastPoll)
                .HasComment("Last Poll")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_poll");
            entity.Property(e => e.LastPresence)
                .HasComment("Last Presence")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_presence");
            entity.Property(e => e.Status)
                .HasComment("IM Status")
                .HasColumnType("character varying")
                .HasColumnName("status");
            entity.Property(e => e.UserId)
                .HasComment("Users")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ImChatPresenceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_presence_create_uid_fkey");

            entity.HasOne(d => d.User).WithOne(p => p.ImChatPresenceUser)
                .HasForeignKey<ImChatPresence>(d => d.UserId)
                .HasConstraintName("im_chat_presence_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ImChatPresenceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_presence_write_uid_fkey");
        });

        modelBuilder.Entity<ImChatSession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("im_chat_session_pkey");

            entity.ToTable("im_chat_session", tb => tb.HasComment("im_chat.session"));

            entity.HasIndex(e => e.Uuid, "im_chat_session_uuid_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Uuid)
                .HasMaxLength(50)
                .HasComment("UUID")
                .HasColumnName("uuid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ImChatSessionCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_session_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ImChatSessionWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_session_write_uid_fkey");
        });

        modelBuilder.Entity<ImChatSessionResUsersRel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("im_chat_session_res_users_rel_pkey");

            entity.ToTable("im_chat_session_res_users_rel", tb => tb.HasComment("im_chat.conversation_state"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.SessionId)
                .HasComment("Session")
                .HasColumnName("session_id");
            entity.Property(e => e.State)
                .HasComment("unknown")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.UserId)
                .HasComment("Users")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ImChatSessionResUsersRelCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_session_res_users_rel_create_uid_fkey");

            entity.HasOne(d => d.Session).WithMany(p => p.ImChatSessionResUsersRels)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("im_chat_session_res_users_rel_session_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ImChatSessionResUsersRelUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("im_chat_session_res_users_rel_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ImChatSessionResUsersRelWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("im_chat_session_res_users_rel_write_uid_fkey");
        });

        modelBuilder.Entity<IrActClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_client_pkey");

            entity.ToTable("ir_act_client");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('ir_actions_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Context)
                .HasComment("Context Value")
                .HasColumnType("character varying")
                .HasColumnName("context");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParamsStore)
                .HasComment("Params storage")
                .HasColumnName("params_store");
            entity.Property(e => e.ResModel)
                .HasComment("Destination Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");
            entity.Property(e => e.Tag)
                .HasComment("Client action tag")
                .HasColumnType("character varying")
                .HasColumnName("tag");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Usage)
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActClientCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_client_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActClientWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_client_write_uid_fkey");
        });

        modelBuilder.Entity<IrActReportXml>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_report_xml_pkey");

            entity.ToTable("ir_act_report_xml");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('ir_actions_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Attachment)
                .HasComment("Save as Attachment Prefix")
                .HasColumnType("character varying")
                .HasColumnName("attachment");
            entity.Property(e => e.AttachmentUse)
                .HasComment("Reload from Attachment")
                .HasColumnName("attachment_use");
            entity.Property(e => e.Auto)
                .HasComment("Custom Python Parser")
                .HasColumnName("auto");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.Header)
                .HasComment("Add RML Header")
                .HasColumnName("header");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Model)
                .HasComment("Model")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.Multi)
                .HasComment("On Multiple Doc.")
                .HasColumnName("multi");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PaperformatId)
                .HasComment("Paper format")
                .HasColumnName("paperformat_id");
            entity.Property(e => e.Parser)
                .HasComment("Parser Class")
                .HasColumnType("character varying")
                .HasColumnName("parser");
            entity.Property(e => e.ReportFile)
                .HasComment("Report File")
                .HasColumnType("character varying")
                .HasColumnName("report_file");
            entity.Property(e => e.ReportName)
                .HasComment("Template Name")
                .HasColumnType("character varying")
                .HasColumnName("report_name");
            entity.Property(e => e.ReportRml)
                .HasComment("Main Report File Path/controller")
                .HasColumnType("character varying")
                .HasColumnName("report_rml");
            entity.Property(e => e.ReportRmlContentData)
                .HasComment("RML Content")
                .HasColumnName("report_rml_content_data");
            entity.Property(e => e.ReportSxwContentData)
                .HasComment("SXW Content")
                .HasColumnName("report_sxw_content_data");
            entity.Property(e => e.ReportType)
                .HasComment("Report Type")
                .HasColumnType("character varying")
                .HasColumnName("report_type");
            entity.Property(e => e.ReportXml)
                .HasComment("XML Path")
                .HasColumnType("character varying")
                .HasColumnName("report_xml");
            entity.Property(e => e.ReportXsl)
                .HasComment("XSL Path")
                .HasColumnType("character varying")
                .HasColumnName("report_xsl");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Usage)
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActReportXmlCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_report_xml_create_uid_fkey");

            entity.HasOne(d => d.Paperformat).WithMany(p => p.IrActReportXmls)
                .HasForeignKey(d => d.PaperformatId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_report_xml_paperformat_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActReportXmlWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_report_xml_write_uid_fkey");
        });

        modelBuilder.Entity<IrActServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_server_pkey");

            entity.ToTable("ir_act_server");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('ir_actions_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasComment("Client Action")
                .HasColumnName("action_id");
            entity.Property(e => e.Code)
                .HasComment("Python Code")
                .HasColumnName("code");
            entity.Property(e => e.Condition)
                .HasComment("Condition")
                .HasColumnType("character varying")
                .HasColumnName("condition");
            entity.Property(e => e.Copyvalue)
                .HasComment("Placeholder Expression")
                .HasColumnType("character varying")
                .HasColumnName("copyvalue");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.CrudModelId)
                .HasComment("Target Model")
                .HasColumnName("crud_model_id");
            entity.Property(e => e.CrudModelName)
                .HasComment("Create/Write Target Model Name")
                .HasColumnType("character varying")
                .HasColumnName("crud_model_name");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.IdObject)
                .HasMaxLength(128)
                .HasComment("Record")
                .HasColumnName("id_object");
            entity.Property(e => e.IdValue)
                .HasComment("Record ID")
                .HasColumnType("character varying")
                .HasColumnName("id_value");
            entity.Property(e => e.LinkFieldId)
                .HasComment("Link using field")
                .HasColumnName("link_field_id");
            entity.Property(e => e.LinkNewRecord)
                .HasComment("Attach the new record")
                .HasColumnName("link_new_record");
            entity.Property(e => e.MenuIrValuesId)
                .HasComment("More Menu entry")
                .HasColumnName("menu_ir_values_id");
            entity.Property(e => e.ModelId)
                .HasComment("Base Model")
                .HasColumnName("model_id");
            entity.Property(e => e.ModelObjectField)
                .HasComment("Field")
                .HasColumnName("model_object_field");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.RefObject)
                .HasMaxLength(128)
                .HasComment("Reference record")
                .HasColumnName("ref_object");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.State)
                .HasComment("Action To Do")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.SubModelObjectField)
                .HasComment("Sub-field")
                .HasColumnName("sub_model_object_field");
            entity.Property(e => e.SubObject)
                .HasComment("Sub-model")
                .HasColumnName("sub_object");
            entity.Property(e => e.TemplateId)
                .HasComment("Email Template")
                .HasColumnName("template_id");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Usage)
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.UseCreate)
                .HasComment("Creation Policy")
                .HasColumnType("character varying")
                .HasColumnName("use_create");
            entity.Property(e => e.UseRelationalModel)
                .HasComment("Target Model")
                .HasColumnType("character varying")
                .HasColumnName("use_relational_model");
            entity.Property(e => e.UseWrite)
                .HasComment("Update Policy")
                .HasColumnType("character varying")
                .HasColumnName("use_write");
            entity.Property(e => e.WkfFieldId)
                .HasComment("Relation Field")
                .HasColumnName("wkf_field_id");
            entity.Property(e => e.WkfModelId)
                .HasComment("Target Model")
                .HasColumnName("wkf_model_id");
            entity.Property(e => e.WkfModelName)
                .HasComment("Target Model Name")
                .HasColumnType("character varying")
                .HasColumnName("wkf_model_name");
            entity.Property(e => e.WkfTransitionId)
                .HasComment("Signal to Trigger")
                .HasColumnName("wkf_transition_id");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteExpression)
                .HasComment("Expression")
                .HasColumnType("character varying")
                .HasColumnName("write_expression");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActServerCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_create_uid_fkey");

            entity.HasOne(d => d.CrudModel).WithMany(p => p.IrActServerCrudModels)
                .HasForeignKey(d => d.CrudModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_crud_model_id_fkey");

            entity.HasOne(d => d.LinkField).WithMany(p => p.IrActServerLinkFields)
                .HasForeignKey(d => d.LinkFieldId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_link_field_id_fkey");

            entity.HasOne(d => d.MenuIrValues).WithMany(p => p.IrActServers)
                .HasForeignKey(d => d.MenuIrValuesId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_menu_ir_values_id_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.IrActServerModels)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("ir_act_server_model_id_fkey");

            entity.HasOne(d => d.ModelObjectFieldNavigation).WithMany(p => p.IrActServerModelObjectFieldNavigations)
                .HasForeignKey(d => d.ModelObjectField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_model_object_field_fkey");

            entity.HasOne(d => d.SubModelObjectFieldNavigation).WithMany(p => p.IrActServerSubModelObjectFieldNavigations)
                .HasForeignKey(d => d.SubModelObjectField)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_sub_model_object_field_fkey");

            entity.HasOne(d => d.SubObjectNavigation).WithMany(p => p.IrActServerSubObjectNavigations)
                .HasForeignKey(d => d.SubObject)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_sub_object_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.IrActServers)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_template_id_fkey");

            entity.HasOne(d => d.WkfField).WithMany(p => p.IrActServerWkfFields)
                .HasForeignKey(d => d.WkfFieldId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_wkf_field_id_fkey");

            entity.HasOne(d => d.WkfModel).WithMany(p => p.IrActServerWkfModels)
                .HasForeignKey(d => d.WkfModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_wkf_model_id_fkey");

            entity.HasOne(d => d.WkfTransition).WithMany(p => p.IrActServers)
                .HasForeignKey(d => d.WkfTransitionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_wkf_transition_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActServerWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_server_write_uid_fkey");
        });

        modelBuilder.Entity<IrActUrl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_url_pkey");

            entity.ToTable("ir_act_url");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('ir_actions_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Target)
                .HasComment("Action Target")
                .HasColumnType("character varying")
                .HasColumnName("target");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Url)
                .HasComment("Action URL")
                .HasColumnName("url");
            entity.Property(e => e.Usage)
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActUrlCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_url_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActUrlWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_url_write_uid_fkey");
        });

        modelBuilder.Entity<IrActWindow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_window_pkey");

            entity.ToTable("ir_act_window");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('ir_actions_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AutoRefresh)
                .HasComment("Auto-Refresh")
                .HasColumnName("auto_refresh");
            entity.Property(e => e.AutoSearch)
                .HasComment("Auto Search")
                .HasColumnName("auto_search");
            entity.Property(e => e.Context)
                .HasComment("Context Value")
                .HasColumnType("character varying")
                .HasColumnName("context");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.Domain)
                .HasComment("Domain Value")
                .HasColumnType("character varying")
                .HasColumnName("domain");
            entity.Property(e => e.Filter)
                .HasComment("Filter")
                .HasColumnName("filter");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Limit)
                .HasComment("Limit")
                .HasColumnName("limit");
            entity.Property(e => e.Multi)
                .HasComment("Restrict to lists")
                .HasColumnName("multi");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ResId)
                .HasComment("Record ID")
                .HasColumnName("res_id");
            entity.Property(e => e.ResModel)
                .HasComment("Destination Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");
            entity.Property(e => e.SearchViewId)
                .HasComment("Search View Ref.")
                .HasColumnName("search_view_id");
            entity.Property(e => e.SrcModel)
                .HasComment("Source Model")
                .HasColumnType("character varying")
                .HasColumnName("src_model");
            entity.Property(e => e.Target)
                .HasComment("Target Window")
                .HasColumnType("character varying")
                .HasColumnName("target");
            entity.Property(e => e.Type)
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Usage)
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.ViewId)
                .HasComment("View Ref.")
                .HasColumnName("view_id");
            entity.Property(e => e.ViewMode)
                .HasComment("View Mode")
                .HasColumnType("character varying")
                .HasColumnName("view_mode");
            entity.Property(e => e.ViewType)
                .HasComment("View Type")
                .HasColumnType("character varying")
                .HasColumnName("view_type");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActWindowCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_create_uid_fkey");

            entity.HasOne(d => d.SearchView).WithMany(p => p.IrActWindowSearchViews)
                .HasForeignKey(d => d.SearchViewId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_search_view_id_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.IrActWindowViews)
                .HasForeignKey(d => d.ViewId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActWindowWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_write_uid_fkey");
        });

        modelBuilder.Entity<IrActWindowGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ir_act_window_group_rel", tb => tb.HasComment("RELATION BETWEEN ir_act_window AND res_groups"));

            entity.HasIndex(e => new { e.ActId, e.Gid }, "ir_act_window_group_rel_act_id_gid_key").IsUnique();

            entity.HasIndex(e => e.ActId, "ir_act_window_group_rel_act_id_index");

            entity.HasIndex(e => e.Gid, "ir_act_window_group_rel_gid_index");

            entity.Property(e => e.ActId).HasColumnName("act_id");
            entity.Property(e => e.Gid).HasColumnName("gid");

            entity.HasOne(d => d.Act).WithMany()
                .HasForeignKey(d => d.ActId)
                .HasConstraintName("ir_act_window_group_rel_act_id_fkey");

            entity.HasOne(d => d.GidNavigation).WithMany()
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("ir_act_window_group_rel_gid_fkey");
        });

        modelBuilder.Entity<IrActWindowView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_act_window_view_pkey");

            entity.ToTable("ir_act_window_view", tb => tb.HasComment("ir.actions.act_window.view"));

            entity.HasIndex(e => new { e.ActWindowId, e.ViewMode }, "act_window_view_unique_mode_per_action").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActWindowId)
                .HasComment("Action")
                .HasColumnName("act_window_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Multi)
                .HasComment("On Multiple Doc.")
                .HasColumnName("multi");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.ViewId)
                .HasComment("View")
                .HasColumnName("view_id");
            entity.Property(e => e.ViewMode)
                .HasComment("View Type")
                .HasColumnType("character varying")
                .HasColumnName("view_mode");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.ActWindow).WithMany(p => p.IrActWindowViews)
                .HasForeignKey(d => d.ActWindowId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_act_window_view_act_window_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActWindowViewCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_create_uid_fkey");

            entity.HasOne(d => d.View).WithMany(p => p.IrActWindowViewsNavigation)
                .HasForeignKey(d => d.ViewId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_view_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActWindowViewWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_act_window_view_write_uid_fkey");
        });

        modelBuilder.Entity<IrAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_actions_pkey");

            entity.ToTable("ir_actions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Help)
                .HasComment("Action description")
                .HasColumnName("help");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasComment("Action Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Usage)
                .HasComment("Action Usage")
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActionCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActionWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_write_uid_fkey");
        });

        modelBuilder.Entity<IrActionsTodo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_actions_todo_pkey");

            entity.ToTable("ir_actions_todo", tb => tb.HasComment("Configuration Wizards"));

            entity.HasIndex(e => e.ActionId, "ir_actions_todo_action_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasComment("Action")
                .HasColumnName("action_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasComment("Text")
                .HasColumnName("note");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrActionsTodoCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_todo_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrActionsTodoWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_actions_todo_write_uid_fkey");
        });

        modelBuilder.Entity<IrAttachment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_attachment_pkey");

            entity.ToTable("ir_attachment", tb => tb.HasComment("ir.attachment"));

            entity.HasIndex(e => new { e.Name, e.ParentId }, "ir_attachment_filename_unique").IsUnique();

            entity.HasIndex(e => e.ParentId, "ir_attachment_parent_id_index");

            entity.HasIndex(e => e.PartnerId, "ir_attachment_partner_id_index");

            entity.HasIndex(e => new { e.ResModel, e.ResId }, "ir_attachment_res_idx");

            entity.HasIndex(e => e.UserId, "ir_attachment_user_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Date Created")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Owner")
                .HasColumnName("create_uid");
            entity.Property(e => e.DatasFname)
                .HasComment("File Name")
                .HasColumnType("character varying")
                .HasColumnName("datas_fname");
            entity.Property(e => e.DbDatas)
                .HasComment("Database Data")
                .HasColumnName("db_datas");
            entity.Property(e => e.Description)
                .HasComment("Description")
                .HasColumnName("description");
            entity.Property(e => e.FileSize)
                .HasComment("File Size")
                .HasColumnName("file_size");
            entity.Property(e => e.FileType)
                .HasComment("Content Type")
                .HasColumnType("character varying")
                .HasColumnName("file_type");
            entity.Property(e => e.IndexContent)
                .HasComment("Indexed Content")
                .HasColumnName("index_content");
            entity.Property(e => e.Name)
                .HasComment("Attachment Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasComment("Directory")
                .HasColumnName("parent_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Partner")
                .HasColumnName("partner_id");
            entity.Property(e => e.ResId)
                .HasComment("Resource ID")
                .HasColumnName("res_id");
            entity.Property(e => e.ResModel)
                .HasComment("Resource Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");
            entity.Property(e => e.ResName)
                .HasComment("Resource Name")
                .HasColumnType("character varying")
                .HasColumnName("res_name");
            entity.Property(e => e.StoreFname)
                .HasComment("Stored Filename")
                .HasColumnType("character varying")
                .HasColumnName("store_fname");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Url)
                .HasMaxLength(1024)
                .HasComment("Url")
                .HasColumnName("url");
            entity.Property(e => e.UserId)
                .HasComment("Owner")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.IrAttachments)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrAttachmentCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.IrAttachments)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_parent_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.IrAttachments)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_partner_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrAttachmentUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrAttachmentWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_attachment_write_uid_fkey");
        });

        modelBuilder.Entity<IrConfigParameter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_config_parameter_pkey");

            entity.ToTable("ir_config_parameter", tb => tb.HasComment("ir.config_parameter"));

            entity.HasIndex(e => e.Key, "ir_config_parameter_key_index");

            entity.HasIndex(e => e.Key, "ir_config_parameter_key_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Key)
                .HasComment("Key")
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Value)
                .HasComment("Value")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrConfigParameterCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_config_parameter_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrConfigParameterWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_config_parameter_write_uid_fkey");
        });

        modelBuilder.Entity<IrConfigParameterGroupsRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ir_config_parameter_groups_rel", tb => tb.HasComment("RELATION BETWEEN ir_config_parameter AND res_groups"));

            entity.HasIndex(e => e.GroupId, "ir_config_parameter_groups_rel_group_id_index");

            entity.HasIndex(e => new { e.IcpId, e.GroupId }, "ir_config_parameter_groups_rel_icp_id_group_id_key").IsUnique();

            entity.HasIndex(e => e.IcpId, "ir_config_parameter_groups_rel_icp_id_index");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.IcpId).HasColumnName("icp_id");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("ir_config_parameter_groups_rel_group_id_fkey");

            entity.HasOne(d => d.Icp).WithMany()
                .HasForeignKey(d => d.IcpId)
                .HasConstraintName("ir_config_parameter_groups_rel_icp_id_fkey");
        });

        modelBuilder.Entity<IrCron>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_cron_pkey");

            entity.ToTable("ir_cron", tb => tb.HasComment("ir.cron"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Args)
                .HasComment("Arguments")
                .HasColumnName("args");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Doall)
                .HasComment("Repeat Missed")
                .HasColumnName("doall");
            entity.Property(e => e.Function)
                .HasComment("Method")
                .HasColumnType("character varying")
                .HasColumnName("function");
            entity.Property(e => e.IntervalNumber)
                .HasComment("Interval Number")
                .HasColumnName("interval_number");
            entity.Property(e => e.IntervalType)
                .HasComment("Interval Unit")
                .HasColumnType("character varying")
                .HasColumnName("interval_type");
            entity.Property(e => e.Model)
                .HasComment("Object")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Nextcall)
                .HasComment("Next Execution Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("nextcall");
            entity.Property(e => e.Numbercall)
                .HasComment("Number of Calls")
                .HasColumnName("numbercall");
            entity.Property(e => e.Priority)
                .HasComment("Priority")
                .HasColumnName("priority");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrCronCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrCronUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrCronWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_cron_write_uid_fkey");
        });

        modelBuilder.Entity<IrDefault>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_default_pkey");

            entity.ToTable("ir_default", tb => tb.HasComment("ir.default"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FieldName)
                .HasComment("Object Field")
                .HasColumnType("character varying")
                .HasColumnName("field_name");
            entity.Property(e => e.FieldTbl)
                .HasComment("Object")
                .HasColumnType("character varying")
                .HasColumnName("field_tbl");
            entity.Property(e => e.Page)
                .HasComment("View")
                .HasColumnType("character varying")
                .HasColumnName("page");
            entity.Property(e => e.RefId)
                .HasComment("ID Ref.")
                .HasColumnName("ref_id");
            entity.Property(e => e.RefTable)
                .HasComment("Table Ref.")
                .HasColumnType("character varying")
                .HasColumnName("ref_table");
            entity.Property(e => e.Uid)
                .HasComment("Users")
                .HasColumnName("uid");
            entity.Property(e => e.Value)
                .HasComment("Default Value")
                .HasColumnType("character varying")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.IrDefaults)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_default_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrDefaultCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_default_create_uid_fkey");

            entity.HasOne(d => d.UidNavigation).WithMany(p => p.IrDefaultUidNavigations)
                .HasForeignKey(d => d.Uid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_default_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrDefaultWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_default_write_uid_fkey");
        });

        modelBuilder.Entity<IrExport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_exports_pkey");

            entity.ToTable("ir_exports", tb => tb.HasComment("ir.exports"));

            entity.HasIndex(e => e.Resource, "ir_exports_resource_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Export Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Resource)
                .HasComment("Resource")
                .HasColumnType("character varying")
                .HasColumnName("resource");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrExportCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrExportWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_write_uid_fkey");
        });

        modelBuilder.Entity<IrExportsLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_exports_line_pkey");

            entity.ToTable("ir_exports_line", tb => tb.HasComment("ir.exports.line"));

            entity.HasIndex(e => e.ExportId, "ir_exports_line_export_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ExportId)
                .HasComment("Export")
                .HasColumnName("export_id");
            entity.Property(e => e.Name)
                .HasComment("Field Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrExportsLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_line_create_uid_fkey");

            entity.HasOne(d => d.Export).WithMany(p => p.IrExportsLines)
                .HasForeignKey(d => d.ExportId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_exports_line_export_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrExportsLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_exports_line_write_uid_fkey");
        });

        modelBuilder.Entity<IrFieldsConverter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_fields_converter_pkey");

            entity.ToTable("ir_fields_converter", tb => tb.HasComment("ir.fields.converter"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrFieldsConverterCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_fields_converter_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrFieldsConverterWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_fields_converter_write_uid_fkey");
        });

        modelBuilder.Entity<IrFilter>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_filters_pkey");

            entity.ToTable("ir_filters", tb => tb.HasComment("Filters"));

            entity.HasIndex(e => new { e.Name, e.ModelId, e.UserId, e.ActionId }, "ir_filters_name_model_uid_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasComment("Action")
                .HasColumnName("action_id");
            entity.Property(e => e.Context)
                .HasComment("Context")
                .HasColumnName("context");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Domain)
                .HasComment("Domain")
                .HasColumnName("domain");
            entity.Property(e => e.IsDefault)
                .HasComment("Default filter")
                .HasColumnName("is_default");
            entity.Property(e => e.ModelId)
                .HasComment("Model")
                .HasColumnType("character varying")
                .HasColumnName("model_id");
            entity.Property(e => e.Name)
                .HasComment("Filter Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrFilterCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_filters_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrFilterUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_filters_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrFilterWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_filters_write_uid_fkey");
        });

        modelBuilder.Entity<IrLogging>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_logging_pkey");

            entity.ToTable("ir_logging", tb => tb.HasComment("ir.logging"));

            entity.HasIndex(e => e.Dbname, "ir_logging_dbname_index");

            entity.HasIndex(e => e.Level, "ir_logging_level_index");

            entity.HasIndex(e => e.Type, "ir_logging_type_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Create Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Uid")
                .HasColumnName("create_uid");
            entity.Property(e => e.Dbname)
                .HasComment("Database Name")
                .HasColumnType("character varying")
                .HasColumnName("dbname");
            entity.Property(e => e.Func)
                .HasComment("Function")
                .HasColumnType("character varying")
                .HasColumnName("func");
            entity.Property(e => e.Level)
                .HasComment("Level")
                .HasColumnType("character varying")
                .HasColumnName("level");
            entity.Property(e => e.Line)
                .HasComment("Line")
                .HasColumnType("character varying")
                .HasColumnName("line");
            entity.Property(e => e.Message)
                .HasComment("Message")
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasComment("Path")
                .HasColumnType("character varying")
                .HasColumnName("path");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrLoggings)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_logging_write_uid_fkey");
        });

        modelBuilder.Entity<IrMailServer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_mail_server_pkey");

            entity.ToTable("ir_mail_server", tb => tb.HasComment("ir.mail_server"));

            entity.HasIndex(e => e.Name, "ir_mail_server_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Description")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Sequence)
                .HasComment("Priority")
                .HasColumnName("sequence");
            entity.Property(e => e.SmtpDebug)
                .HasComment("Debugging")
                .HasColumnName("smtp_debug");
            entity.Property(e => e.SmtpEncryption)
                .HasComment("Connection Security")
                .HasColumnType("character varying")
                .HasColumnName("smtp_encryption");
            entity.Property(e => e.SmtpHost)
                .HasComment("SMTP Server")
                .HasColumnType("character varying")
                .HasColumnName("smtp_host");
            entity.Property(e => e.SmtpPass)
                .HasMaxLength(64)
                .HasComment("Password")
                .HasColumnName("smtp_pass");
            entity.Property(e => e.SmtpPort)
                .HasComment("SMTP Port")
                .HasColumnName("smtp_port");
            entity.Property(e => e.SmtpUser)
                .HasMaxLength(64)
                .HasComment("Username")
                .HasColumnName("smtp_user");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrMailServerCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_mail_server_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrMailServerWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_mail_server_write_uid_fkey");
        });

        modelBuilder.Entity<IrModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_pkey");

            entity.ToTable("ir_model");

            entity.HasIndex(e => e.Model, "ir_model_model_index");

            entity.HasIndex(e => e.Model, "ir_model_obj_name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Info).HasColumnName("info");
            entity.Property(e => e.Model)
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelAccess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_access_pkey");

            entity.ToTable("ir_model_access", tb => tb.HasComment("ir.model.access"));

            entity.HasIndex(e => e.GroupId, "ir_model_access_group_id_index");

            entity.HasIndex(e => e.ModelId, "ir_model_access_model_id_index");

            entity.HasIndex(e => e.Name, "ir_model_access_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.GroupId)
                .HasComment("Group")
                .HasColumnName("group_id");
            entity.Property(e => e.ModelId)
                .HasComment("Object")
                .HasColumnName("model_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PermCreate)
                .HasComment("Create Access")
                .HasColumnName("perm_create");
            entity.Property(e => e.PermRead)
                .HasComment("Read Access")
                .HasColumnName("perm_read");
            entity.Property(e => e.PermUnlink)
                .HasComment("Delete Access")
                .HasColumnName("perm_unlink");
            entity.Property(e => e.PermWrite)
                .HasComment("Write Access")
                .HasColumnName("perm_write");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelAccessCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_access_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.IrModelAccesses)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_access_group_id_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.IrModelAccesses)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("ir_model_access_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelAccessWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_access_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelConstraint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_constraint_pkey");

            entity.ToTable("ir_model_constraint");

            entity.HasIndex(e => e.Model, "ir_model_constraint_model_index");

            entity.HasIndex(e => e.Module, "ir_model_constraint_module_index");

            entity.HasIndex(e => new { e.Name, e.Module }, "ir_model_constraint_module_name_uniq").IsUnique();

            entity.HasIndex(e => e.Name, "ir_model_constraint_name_index");

            entity.HasIndex(e => e.Type, "ir_model_constraint_type_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateInit)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_init");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_update");
            entity.Property(e => e.Model).HasColumnName("model");
            entity.Property(e => e.Module).HasColumnName("module");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelConstraintCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_constraint_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrModelConstraints)
                .HasForeignKey(d => d.Model)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_constraint_model_fkey");

            entity.HasOne(d => d.ModuleNavigation).WithMany(p => p.IrModelConstraints)
                .HasForeignKey(d => d.Module)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_constraint_module_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelConstraintWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_constraint_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_data_pkey");

            entity.ToTable("ir_model_data");

            entity.HasIndex(e => e.Model, "ir_model_data_model_index");

            entity.HasIndex(e => e.Module, "ir_model_data_module_index");

            entity.HasIndex(e => new { e.Module, e.Name }, "ir_model_data_module_name_index");

            entity.HasIndex(e => new { e.Name, e.Module }, "ir_model_data_module_name_uniq").IsUnique();

            entity.HasIndex(e => e.Name, "ir_model_data_name_index");

            entity.HasIndex(e => e.ResId, "ir_model_data_res_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.DateInit)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_init");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_update");
            entity.Property(e => e.Model)
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.Module)
                .HasColumnType("character varying")
                .HasColumnName("module");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Noupdate).HasColumnName("noupdate");
            entity.Property(e => e.ResId).HasColumnName("res_id");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelDatumCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_data_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelDatumWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_data_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_fields_pkey");

            entity.ToTable("ir_model_fields");

            entity.HasIndex(e => e.CompleteName, "ir_model_fields_complete_name_index");

            entity.HasIndex(e => e.ModelId, "ir_model_fields_model_id_index");

            entity.HasIndex(e => e.Model, "ir_model_fields_model_index");

            entity.HasIndex(e => e.Name, "ir_model_fields_name_index");

            entity.HasIndex(e => e.State, "ir_model_fields_state_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompleteName)
                .HasComment("Complete Name")
                .HasColumnType("character varying")
                .HasColumnName("complete_name");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Domain)
                .HasComment("Domain")
                .HasColumnType("character varying")
                .HasColumnName("domain");
            entity.Property(e => e.FieldDescription)
                .HasColumnType("character varying")
                .HasColumnName("field_description");
            entity.Property(e => e.Model)
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OnDelete)
                .HasComment("On Delete")
                .HasColumnType("character varying")
                .HasColumnName("on_delete");
            entity.Property(e => e.Readonly)
                .HasComment("Readonly")
                .HasColumnName("readonly");
            entity.Property(e => e.Relation)
                .HasColumnType("character varying")
                .HasColumnName("relation");
            entity.Property(e => e.RelationField)
                .HasColumnType("character varying")
                .HasColumnName("relation_field");
            entity.Property(e => e.Required)
                .HasComment("Required")
                .HasColumnName("required");
            entity.Property(e => e.SelectLevel)
                .HasColumnType("character varying")
                .HasColumnName("select_level");
            entity.Property(e => e.Selectable)
                .HasComment("Selectable")
                .HasColumnName("selectable");
            entity.Property(e => e.Selection)
                .HasComment("Selection Options")
                .HasColumnType("character varying")
                .HasColumnName("selection");
            entity.Property(e => e.SerializationFieldId).HasColumnName("serialization_field_id");
            entity.Property(e => e.Size)
                .HasComment("Size")
                .HasColumnName("size");
            entity.Property(e => e.State)
                .HasDefaultValueSql("'base'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Translate)
                .HasDefaultValue(false)
                .HasColumnName("translate");
            entity.Property(e => e.Ttype)
                .HasColumnType("character varying")
                .HasColumnName("ttype");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelFieldCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_fields_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrModelFields)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("ir_model_fields_model_id_fkey");

            entity.HasOne(d => d.SerializationField).WithMany(p => p.InverseSerializationField)
                .HasForeignKey(d => d.SerializationFieldId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_model_fields_serialization_field_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelFieldWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_fields_write_uid_fkey");
        });

        modelBuilder.Entity<IrModelFieldsGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ir_model_fields_group_rel", tb => tb.HasComment("RELATION BETWEEN ir_model_fields AND res_groups"));

            entity.HasIndex(e => new { e.FieldId, e.GroupId }, "ir_model_fields_group_rel_field_id_group_id_key").IsUnique();

            entity.HasIndex(e => e.FieldId, "ir_model_fields_group_rel_field_id_index");

            entity.HasIndex(e => e.GroupId, "ir_model_fields_group_rel_group_id_index");

            entity.Property(e => e.FieldId).HasColumnName("field_id");
            entity.Property(e => e.GroupId).HasColumnName("group_id");

            entity.HasOne(d => d.Field).WithMany()
                .HasForeignKey(d => d.FieldId)
                .HasConstraintName("ir_model_fields_group_rel_field_id_fkey");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("ir_model_fields_group_rel_group_id_fkey");
        });

        modelBuilder.Entity<IrModelRelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_model_relation_pkey");

            entity.ToTable("ir_model_relation");

            entity.HasIndex(e => e.Model, "ir_model_relation_model_index");

            entity.HasIndex(e => e.Module, "ir_model_relation_module_index");

            entity.HasIndex(e => e.Name, "ir_model_relation_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateInit)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_init");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_update");
            entity.Property(e => e.Model).HasColumnName("model");
            entity.Property(e => e.Module).HasColumnName("module");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModelRelationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_relation_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrModelRelations)
                .HasForeignKey(d => d.Model)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_relation_model_fkey");

            entity.HasOne(d => d.ModuleNavigation).WithMany(p => p.IrModelRelations)
                .HasForeignKey(d => d.Module)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_relation_module_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModelRelationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_model_relation_write_uid_fkey");
        });

        modelBuilder.Entity<IrModuleCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_category_pkey");

            entity.ToTable("ir_module_category");

            entity.HasIndex(e => e.Name, "ir_module_category_name_index");

            entity.HasIndex(e => e.ParentId, "ir_module_category_parent_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.Description)
                .HasComment("Description")
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.Visible)
                .HasComment("Visible")
                .HasColumnName("visible");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModuleCategoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_category_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModuleCategoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_category_write_uid_fkey");
        });

        modelBuilder.Entity<IrModuleModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_module_pkey");

            entity.ToTable("ir_module_module");

            entity.HasIndex(e => e.CategoryId, "ir_module_module_category_id_index");

            entity.HasIndex(e => e.Name, "ir_module_module_name_index");

            entity.HasIndex(e => e.Name, "ir_module_module_name_uniq").IsUnique();

            entity.HasIndex(e => e.State, "ir_module_module_state_index");

            entity.HasIndex(e => e.Name, "name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Application)
                .HasDefaultValue(false)
                .HasColumnName("application");
            entity.Property(e => e.Author)
                .HasColumnType("character varying")
                .HasColumnName("author");
            entity.Property(e => e.AutoInstall)
                .HasDefaultValue(false)
                .HasColumnName("auto_install");
            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Contributors)
                .HasComment("Contributors")
                .HasColumnName("contributors");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.Demo)
                .HasDefaultValue(false)
                .HasColumnName("demo");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Icon)
                .HasColumnType("character varying")
                .HasColumnName("icon");
            entity.Property(e => e.LatestVersion)
                .HasColumnType("character varying")
                .HasColumnName("latest_version");
            entity.Property(e => e.License)
                .HasColumnType("character varying")
                .HasColumnName("license");
            entity.Property(e => e.Maintainer)
                .HasComment("Maintainer")
                .HasColumnType("character varying")
                .HasColumnName("maintainer");
            entity.Property(e => e.MenusByModule)
                .HasComment("Menus")
                .HasColumnName("menus_by_module");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PublishedVersion)
                .HasComment("Published Version")
                .HasColumnType("character varying")
                .HasColumnName("published_version");
            entity.Property(e => e.ReportsByModule)
                .HasComment("Reports")
                .HasColumnName("reports_by_module");
            entity.Property(e => e.Sequence)
                .HasDefaultValue(100)
                .HasColumnName("sequence");
            entity.Property(e => e.Shortdesc)
                .HasColumnType("character varying")
                .HasColumnName("shortdesc");
            entity.Property(e => e.State)
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Summary)
                .HasColumnType("character varying")
                .HasColumnName("summary");
            entity.Property(e => e.Url)
                .HasComment("URL")
                .HasColumnType("character varying")
                .HasColumnName("url");
            entity.Property(e => e.ViewsByModule)
                .HasComment("Views")
                .HasColumnName("views_by_module");
            entity.Property(e => e.Web)
                .HasDefaultValue(false)
                .HasColumnName("web");
            entity.Property(e => e.Website)
                .HasColumnType("character varying")
                .HasColumnName("website");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.Category).WithMany(p => p.IrModuleModules)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModuleModuleCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModuleModuleWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_write_uid_fkey");
        });

        modelBuilder.Entity<IrModuleModuleDependency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_module_module_dependency_pkey");

            entity.ToTable("ir_module_module_dependency");

            entity.HasIndex(e => e.Name, "ir_module_module_dependency_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid).HasColumnName("create_uid");
            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid).HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrModuleModuleDependencyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_dependency_create_uid_fkey");

            entity.HasOne(d => d.Module).WithMany(p => p.IrModuleModuleDependencies)
                .HasForeignKey(d => d.ModuleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_module_module_dependency_module_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrModuleModuleDependencyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_module_module_dependency_write_uid_fkey");
        });

        modelBuilder.Entity<IrProperty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_property_pkey");

            entity.ToTable("ir_property", tb => tb.HasComment("ir.property"));

            entity.HasIndex(e => e.CompanyId, "ir_property_company_id_index");

            entity.HasIndex(e => e.FieldsId, "ir_property_fields_id_index");

            entity.HasIndex(e => e.Name, "ir_property_name_index");

            entity.HasIndex(e => e.ResId, "ir_property_res_id_index");

            entity.HasIndex(e => e.Type, "ir_property_type_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FieldsId)
                .HasComment("Field")
                .HasColumnName("fields_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ResId)
                .HasComment("Resource")
                .HasColumnType("character varying")
                .HasColumnName("res_id");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.ValueBinary)
                .HasComment("Value")
                .HasColumnName("value_binary");
            entity.Property(e => e.ValueDatetime)
                .HasComment("Value")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("value_datetime");
            entity.Property(e => e.ValueFloat)
                .HasComment("Value")
                .HasColumnName("value_float");
            entity.Property(e => e.ValueInteger)
                .HasComment("Value")
                .HasColumnName("value_integer");
            entity.Property(e => e.ValueReference)
                .HasComment("Value")
                .HasColumnType("character varying")
                .HasColumnName("value_reference");
            entity.Property(e => e.ValueText)
                .HasComment("Value")
                .HasColumnName("value_text");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.IrProperties)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_property_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrPropertyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_property_create_uid_fkey");

            entity.HasOne(d => d.Fields).WithMany(p => p.IrProperties)
                .HasForeignKey(d => d.FieldsId)
                .HasConstraintName("ir_property_fields_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrPropertyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_property_write_uid_fkey");
        });

        modelBuilder.Entity<IrRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_rule_pkey");

            entity.ToTable("ir_rule", tb => tb.HasComment("ir.rule"));

            entity.HasIndex(e => e.ModelId, "ir_rule_model_id_index");

            entity.HasIndex(e => e.Name, "ir_rule_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DomainForce)
                .HasComment("Domain")
                .HasColumnName("domain_force");
            entity.Property(e => e.Global)
                .HasComment("Global")
                .HasColumnName("global");
            entity.Property(e => e.ModelId)
                .HasComment("Object")
                .HasColumnName("model_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PermCreate)
                .HasComment("Apply for Create")
                .HasColumnName("perm_create");
            entity.Property(e => e.PermRead)
                .HasComment("Apply for Read")
                .HasColumnName("perm_read");
            entity.Property(e => e.PermUnlink)
                .HasComment("Apply for Delete")
                .HasColumnName("perm_unlink");
            entity.Property(e => e.PermWrite)
                .HasComment("Apply for Write")
                .HasColumnName("perm_write");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrRuleCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_rule_create_uid_fkey");

            entity.HasOne(d => d.Model).WithMany(p => p.IrRules)
                .HasForeignKey(d => d.ModelId)
                .HasConstraintName("ir_rule_model_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrRuleWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_rule_write_uid_fkey");
        });

        modelBuilder.Entity<IrSequence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_sequence_pkey");

            entity.ToTable("ir_sequence", tb => tb.HasComment("ir.sequence"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasComment("Sequence Type")
                .HasColumnName("code");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Implementation)
                .HasComment("Implementation")
                .HasColumnType("character varying")
                .HasColumnName("implementation");
            entity.Property(e => e.Name)
                .HasMaxLength(64)
                .HasComment("Name")
                .HasColumnName("name");
            entity.Property(e => e.NumberIncrement)
                .HasComment("Increment Number")
                .HasColumnName("number_increment");
            entity.Property(e => e.NumberNext)
                .HasComment("Next Number")
                .HasColumnName("number_next");
            entity.Property(e => e.Padding)
                .HasComment("Number Padding")
                .HasColumnName("padding");
            entity.Property(e => e.Prefix)
                .HasComment("Prefix")
                .HasColumnType("character varying")
                .HasColumnName("prefix");
            entity.Property(e => e.Suffix)
                .HasComment("Suffix")
                .HasColumnType("character varying")
                .HasColumnName("suffix");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.IrSequences)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrSequenceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrSequenceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_write_uid_fkey");
        });

        modelBuilder.Entity<IrSequenceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_sequence_type_pkey");

            entity.ToTable("ir_sequence_type", tb => tb.HasComment("ir.sequence.type"));

            entity.HasIndex(e => e.Code, "ir_sequence_type_code_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(32)
                .HasComment("Code")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrSequenceTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrSequenceTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_sequence_type_write_uid_fkey");
        });

        modelBuilder.Entity<IrServerObjectLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_server_object_lines_pkey");

            entity.ToTable("ir_server_object_lines", tb => tb.HasComment("Server Action value mapping"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Col1)
                .HasComment("Field")
                .HasColumnName("col1");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ServerId)
                .HasComment("Related Server Action")
                .HasColumnName("server_id");
            entity.Property(e => e.Type)
                .HasComment("Evaluation Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasComment("Value")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Col1Navigation).WithMany(p => p.IrServerObjectLines)
                .HasForeignKey(d => d.Col1)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_server_object_lines_col1_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrServerObjectLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_server_object_lines_create_uid_fkey");

            entity.HasOne(d => d.Server).WithMany(p => p.IrServerObjectLines)
                .HasForeignKey(d => d.ServerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_server_object_lines_server_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrServerObjectLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_server_object_lines_write_uid_fkey");
        });

        modelBuilder.Entity<IrTranslation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_translation_pkey");

            entity.ToTable("ir_translation", tb => tb.HasComment("ir.translation"));

            entity.HasIndex(e => e.Comments, "ir_translation_comments_index");

            entity.HasIndex(e => new { e.Name, e.Lang, e.Type }, "ir_translation_ltn");

            entity.HasIndex(e => e.Module, "ir_translation_module_index");

            entity.HasIndex(e => e.ResId, "ir_translation_res_id_index");

            entity.HasIndex(e => e.Src, "ir_translation_src_hash_idx").HasMethod("hash");

            entity.HasIndex(e => e.Type, "ir_translation_type_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Comments)
                .HasComment("Translation comments")
                .HasColumnName("comments");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.Module)
                .HasComment("Module")
                .HasColumnType("character varying")
                .HasColumnName("module");
            entity.Property(e => e.Name)
                .HasComment("Translated field")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ResId)
                .HasComment("Record ID")
                .HasColumnName("res_id");
            entity.Property(e => e.Src)
                .HasComment("Old source")
                .HasColumnName("src");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasComment("Translation Value")
                .HasColumnName("value");

            entity.HasOne(d => d.LangNavigation).WithMany(p => p.IrTranslations)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Lang)
                .HasConstraintName("ir_translation_lang_fkey_res_lang");
        });

        modelBuilder.Entity<IrUiMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_ui_menu_pkey");

            entity.ToTable("ir_ui_menu", tb => tb.HasComment("ir.ui.menu"));

            entity.HasIndex(e => e.ParentId, "ir_ui_menu_parent_id_index");

            entity.HasIndex(e => e.ParentLeft, "ir_ui_menu_parent_left_index");

            entity.HasIndex(e => e.ParentRight, "ir_ui_menu_parent_right_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Icon)
                .HasMaxLength(64)
                .HasComment("Icon")
                .HasColumnName("icon");
            entity.Property(e => e.MailGroupId)
                .HasComment("Mail Group")
                .HasColumnName("mail_group_id");
            entity.Property(e => e.Name)
                .HasComment("Menu")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NeedactionEnabled)
                .HasComment("Target model uses the need action mechanism")
                .HasColumnName("needaction_enabled");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Menu")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentLeft).HasColumnName("parent_left");
            entity.Property(e => e.ParentRight).HasColumnName("parent_right");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WebIcon)
                .HasComment("Web Icon File")
                .HasColumnType("character varying")
                .HasColumnName("web_icon");
            entity.Property(e => e.WebIconData)
                .HasComment("Web Icon Image")
                .HasColumnName("web_icon_data");
            entity.Property(e => e.WebIconHover)
                .HasComment("Web Icon File (hover)")
                .HasColumnType("character varying")
                .HasColumnName("web_icon_hover");
            entity.Property(e => e.WebIconHoverData)
                .HasComment("Web Icon Image (hover)")
                .HasColumnName("web_icon_hover_data");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrUiMenuCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_menu_create_uid_fkey");

            entity.HasOne(d => d.MailGroup).WithMany(p => p.IrUiMenus)
                .HasForeignKey(d => d.MailGroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_menu_mail_group_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_ui_menu_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrUiMenuWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_menu_write_uid_fkey");
        });

        modelBuilder.Entity<IrUiMenuGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ir_ui_menu_group_rel", tb => tb.HasComment("RELATION BETWEEN ir_ui_menu AND res_groups"));

            entity.HasIndex(e => e.Gid, "ir_ui_menu_group_rel_gid_index");

            entity.HasIndex(e => new { e.MenuId, e.Gid }, "ir_ui_menu_group_rel_menu_id_gid_key").IsUnique();

            entity.HasIndex(e => e.MenuId, "ir_ui_menu_group_rel_menu_id_index");

            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.MenuId).HasColumnName("menu_id");

            entity.HasOne(d => d.GidNavigation).WithMany()
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("ir_ui_menu_group_rel_gid_fkey");

            entity.HasOne(d => d.Menu).WithMany()
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("ir_ui_menu_group_rel_menu_id_fkey");
        });

        modelBuilder.Entity<IrUiView>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_ui_view_pkey");

            entity.ToTable("ir_ui_view", tb => tb.HasComment("ir.ui.view"));

            entity.HasIndex(e => e.InheritId, "ir_ui_view_inherit_id_index");

            entity.HasIndex(e => e.Model, "ir_ui_view_model_index");

            entity.HasIndex(e => new { e.Model, e.InheritId }, "ir_ui_view_model_type_inherit_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Arch)
                .HasComment("View Architecture")
                .HasColumnName("arch");
            entity.Property(e => e.CreateDate)
                .HasComment("Create Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FieldParent)
                .HasComment("Child Field")
                .HasColumnType("character varying")
                .HasColumnName("field_parent");
            entity.Property(e => e.InheritId)
                .HasComment("Inherited View")
                .HasColumnName("inherit_id");
            entity.Property(e => e.Mode)
                .HasComment("View inheritance mode")
                .HasColumnType("character varying")
                .HasColumnName("mode");
            entity.Property(e => e.Model)
                .HasComment("Object")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelDataId)
                .HasComment("Model Data")
                .HasColumnName("model_data_id");
            entity.Property(e => e.Name)
                .HasComment("View Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Priority)
                .HasComment("Sequence")
                .HasColumnName("priority");
            entity.Property(e => e.Type)
                .HasComment("View Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Modification Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrUiViewCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_create_uid_fkey");

            entity.HasOne(d => d.Inherit).WithMany(p => p.InverseInherit)
                .HasForeignKey(d => d.InheritId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("ir_ui_view_inherit_id_fkey");

            entity.HasOne(d => d.ModelData).WithMany(p => p.IrUiViews)
                .HasForeignKey(d => d.ModelDataId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_model_data_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrUiViewWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_write_uid_fkey");
        });

        modelBuilder.Entity<IrUiViewCustom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_ui_view_custom_pkey");

            entity.ToTable("ir_ui_view_custom", tb => tb.HasComment("ir.ui.view.custom"));

            entity.HasIndex(e => e.RefId, "ir_ui_view_custom_ref_id_index");

            entity.HasIndex(e => e.UserId, "ir_ui_view_custom_user_id_index");

            entity.HasIndex(e => new { e.UserId, e.RefId }, "ir_ui_view_custom_user_id_ref_id");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arch)
                .HasComment("View Architecture")
                .HasColumnName("arch");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.RefId)
                .HasComment("Original View")
                .HasColumnName("ref_id");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrUiViewCustomCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_custom_create_uid_fkey");

            entity.HasOne(d => d.Ref).WithMany(p => p.IrUiViewCustoms)
                .HasForeignKey(d => d.RefId)
                .HasConstraintName("ir_ui_view_custom_ref_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrUiViewCustomUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("ir_ui_view_custom_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrUiViewCustomWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_ui_view_custom_write_uid_fkey");
        });

        modelBuilder.Entity<IrUiViewGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ir_ui_view_group_rel", tb => tb.HasComment("RELATION BETWEEN ir_ui_view AND res_groups"));

            entity.HasIndex(e => e.GroupId, "ir_ui_view_group_rel_group_id_index");

            entity.HasIndex(e => new { e.ViewId, e.GroupId }, "ir_ui_view_group_rel_view_id_group_id_key").IsUnique();

            entity.HasIndex(e => e.ViewId, "ir_ui_view_group_rel_view_id_index");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.ViewId).HasColumnName("view_id");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("ir_ui_view_group_rel_group_id_fkey");

            entity.HasOne(d => d.View).WithMany()
                .HasForeignKey(d => d.ViewId)
                .HasConstraintName("ir_ui_view_group_rel_view_id_fkey");
        });

        modelBuilder.Entity<IrValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ir_values_pkey");

            entity.ToTable("ir_values", tb => tb.HasComment("ir.values"));

            entity.HasIndex(e => e.CompanyId, "ir_values_company_id_index");

            entity.HasIndex(e => e.Key2, "ir_values_key2_index");

            entity.HasIndex(e => e.Key, "ir_values_key_index");

            entity.HasIndex(e => new { e.Key, e.Model, e.Key2, e.ResId, e.UserId }, "ir_values_key_model_key2_res_id_user_id_idx");

            entity.HasIndex(e => e.Model, "ir_values_model_index");

            entity.HasIndex(e => e.ResId, "ir_values_res_id_index");

            entity.HasIndex(e => e.UserId, "ir_values_user_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasComment("Action (change only)")
                .HasColumnName("action_id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Key)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Key2)
                .HasComment("Qualifier")
                .HasColumnType("character varying")
                .HasColumnName("key2");
            entity.Property(e => e.Model)
                .HasComment("Model Name")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ModelId)
                .HasComment("Model (change only)")
                .HasColumnName("model_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ResId)
                .HasComment("Record ID")
                .HasColumnName("res_id");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasComment("Value")
                .HasColumnName("value");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.IrValues)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_values_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.IrValueCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_values_create_uid_fkey");

            entity.HasOne(d => d.ModelNavigation).WithMany(p => p.IrValues)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_values_model_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.IrValueUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ir_values_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.IrValueWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("ir_values_write_uid_fkey");
        });

        modelBuilder.Entity<KnowledgeConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("knowledge_config_settings_pkey");

            entity.ToTable("knowledge_config_settings", tb => tb.HasComment("knowledge.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ModuleDocument)
                .HasComment("Manage documents")
                .HasColumnName("module_document");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.KnowledgeConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("knowledge_config_settings_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.KnowledgeConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("knowledge_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<MailAlias>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_alias_pkey");

            entity.ToTable("mail_alias", tb => tb.HasComment("Email Aliases"));

            entity.HasIndex(e => e.AliasName, "mail_alias_alias_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliasContact)
                .HasComment("Alias Contact Security")
                .HasColumnType("character varying")
                .HasColumnName("alias_contact");
            entity.Property(e => e.AliasDefaults)
                .HasComment("Default Values")
                .HasColumnName("alias_defaults");
            entity.Property(e => e.AliasForceThreadId)
                .HasComment("Record Thread ID")
                .HasColumnName("alias_force_thread_id");
            entity.Property(e => e.AliasModelId)
                .HasComment("Aliased Model")
                .HasColumnName("alias_model_id");
            entity.Property(e => e.AliasName)
                .HasComment("Alias Name")
                .HasColumnType("character varying")
                .HasColumnName("alias_name");
            entity.Property(e => e.AliasParentModelId)
                .HasComment("Parent Model")
                .HasColumnName("alias_parent_model_id");
            entity.Property(e => e.AliasParentThreadId)
                .HasComment("Parent Record Thread ID")
                .HasColumnName("alias_parent_thread_id");
            entity.Property(e => e.AliasUserId)
                .HasComment("Owner")
                .HasColumnName("alias_user_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.AliasModel).WithMany(p => p.MailAliasAliasModels)
                .HasForeignKey(d => d.AliasModelId)
                .HasConstraintName("mail_alias_alias_model_id_fkey");

            entity.HasOne(d => d.AliasParentModel).WithMany(p => p.MailAliasAliasParentModels)
                .HasForeignKey(d => d.AliasParentModelId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_alias_parent_model_id_fkey");

            entity.HasOne(d => d.AliasUser).WithMany(p => p.MailAliasAliasUsers)
                .HasForeignKey(d => d.AliasUserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_alias_user_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailAliasCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailAliasWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_alias_write_uid_fkey");
        });

        modelBuilder.Entity<MailComposeMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_compose_message_pkey");

            entity.ToTable("mail_compose_message", tb => tb.HasComment("Email composition wizard"));

            entity.HasIndex(e => e.AuthorId, "mail_compose_message_author_id_index");

            entity.HasIndex(e => e.MessageId, "mail_compose_message_message_id_index");

            entity.HasIndex(e => e.Model, "mail_compose_message_model_index");

            entity.HasIndex(e => e.ParentId, "mail_compose_message_parent_id_index");

            entity.HasIndex(e => e.ResId, "mail_compose_message_res_id_index");

            entity.HasIndex(e => e.SubtypeId, "mail_compose_message_subtype_id_index");

            entity.HasIndex(e => e.TemplateId, "mail_compose_message_template_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveDomain)
                .HasComment("Active domain")
                .HasColumnType("character varying")
                .HasColumnName("active_domain");
            entity.Property(e => e.AuthorId)
                .HasComment("Author")
                .HasColumnName("author_id");
            entity.Property(e => e.Body)
                .HasComment("Contents")
                .HasColumnName("body");
            entity.Property(e => e.CompositionMode)
                .HasComment("Composition mode")
                .HasColumnType("character varying")
                .HasColumnName("composition_mode");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.EmailFrom)
                .HasComment("From")
                .HasColumnType("character varying")
                .HasColumnName("email_from");
            entity.Property(e => e.IsLog)
                .HasComment("Log an Internal Note")
                .HasColumnName("is_log");
            entity.Property(e => e.MailServerId)
                .HasComment("Outgoing mail server")
                .HasColumnName("mail_server_id");
            entity.Property(e => e.MessageId)
                .HasComment("Message-Id")
                .HasColumnType("character varying")
                .HasColumnName("message_id");
            entity.Property(e => e.Model)
                .HasMaxLength(128)
                .HasComment("Related Document Model")
                .HasColumnName("model");
            entity.Property(e => e.NoAutoThread)
                .HasComment("No threading for answers")
                .HasColumnName("no_auto_thread");
            entity.Property(e => e.Notify)
                .HasComment("Notify followers")
                .HasColumnName("notify");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Message")
                .HasColumnName("parent_id");
            entity.Property(e => e.RecordName)
                .HasComment("Message Record Name")
                .HasColumnType("character varying")
                .HasColumnName("record_name");
            entity.Property(e => e.ReplyTo)
                .HasComment("Reply-To")
                .HasColumnType("character varying")
                .HasColumnName("reply_to");
            entity.Property(e => e.ResId)
                .HasComment("Related Document ID")
                .HasColumnName("res_id");
            entity.Property(e => e.Subject)
                .HasComment("Subject")
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.SubtypeId)
                .HasComment("Subtype")
                .HasColumnName("subtype_id");
            entity.Property(e => e.TemplateId)
                .HasComment("Use template")
                .HasColumnName("template_id");
            entity.Property(e => e.Type)
                .HasMaxLength(12)
                .HasComment("Type")
                .HasColumnName("type");
            entity.Property(e => e.UseActiveDomain)
                .HasComment("Use active domain")
                .HasColumnName("use_active_domain");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Author).WithMany(p => p.MailComposeMessages)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_author_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailComposeMessageCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_create_uid_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.MailComposeMessages)
                .HasForeignKey(d => d.MailServerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_mail_server_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.MailComposeMessages)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_parent_id_fkey");

            entity.HasOne(d => d.Subtype).WithMany(p => p.MailComposeMessages)
                .HasForeignKey(d => d.SubtypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_subtype_id_fkey");

            entity.HasOne(d => d.Template).WithMany(p => p.MailComposeMessages)
                .HasForeignKey(d => d.TemplateId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailComposeMessageWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_compose_message_write_uid_fkey");
        });

        modelBuilder.Entity<MailComposeMessageIrAttachmentsRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_compose_message_ir_attachments_rel", tb => tb.HasComment("RELATION BETWEEN mail_compose_message AND ir_attachment"));

            entity.HasIndex(e => e.AttachmentId, "mail_compose_message_ir_attachments_rel_attachment_id_index");

            entity.HasIndex(e => e.WizardId, "mail_compose_message_ir_attachments_rel_wizard_id_index");

            entity.HasIndex(e => new { e.WizardId, e.AttachmentId }, "mail_compose_message_ir_attachments_wizard_id_attachment_id_key").IsUnique();

            entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");
            entity.Property(e => e.WizardId).HasColumnName("wizard_id");

            entity.HasOne(d => d.Attachment).WithMany()
                .HasForeignKey(d => d.AttachmentId)
                .HasConstraintName("mail_compose_message_ir_attachments_rel_attachment_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany()
                .HasForeignKey(d => d.WizardId)
                .HasConstraintName("mail_compose_message_ir_attachments_rel_wizard_id_fkey");
        });

        modelBuilder.Entity<MailComposeMessageResPartnerRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_compose_message_res_partner_rel", tb => tb.HasComment("RELATION BETWEEN mail_compose_message AND res_partner"));

            entity.HasIndex(e => e.PartnerId, "mail_compose_message_res_partner_rel_partner_id_index");

            entity.HasIndex(e => e.WizardId, "mail_compose_message_res_partner_rel_wizard_id_index");

            entity.HasIndex(e => new { e.WizardId, e.PartnerId }, "mail_compose_message_res_partner_rel_wizard_id_partner_id_key").IsUnique();

            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.WizardId).HasColumnName("wizard_id");

            entity.HasOne(d => d.Partner).WithMany()
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("mail_compose_message_res_partner_rel_partner_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany()
                .HasForeignKey(d => d.WizardId)
                .HasConstraintName("mail_compose_message_res_partner_rel_wizard_id_fkey");
        });

        modelBuilder.Entity<MailFollower>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_followers_pkey");

            entity.ToTable("mail_followers", tb => tb.HasComment("Document Followers"));

            entity.HasIndex(e => new { e.ResModel, e.ResId, e.PartnerId }, "mail_followers_mail_followers_res_partner_res_model_id_uniq").IsUnique();

            entity.HasIndex(e => e.PartnerId, "mail_followers_partner_id_index");

            entity.HasIndex(e => e.ResId, "mail_followers_res_id_index");

            entity.HasIndex(e => e.ResModel, "mail_followers_res_model_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.PartnerId)
                .HasComment("Related Partner")
                .HasColumnName("partner_id");
            entity.Property(e => e.ResId)
                .HasComment("Related Document ID")
                .HasColumnName("res_id");
            entity.Property(e => e.ResModel)
                .HasComment("Related Document Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");

            entity.HasOne(d => d.Partner).WithMany(p => p.MailFollowers)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("mail_followers_partner_id_fkey");
        });

        modelBuilder.Entity<MailFollowersMailMessageSubtypeRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_followers_mail_message_subtype_rel", tb => tb.HasComment("RELATION BETWEEN mail_followers AND mail_message_subtype"));

            entity.HasIndex(e => new { e.MailFollowersId, e.MailMessageSubtypeId }, "mail_followers_mail_message_s_mail_followers_id_mail_messag_key").IsUnique();

            entity.HasIndex(e => e.MailFollowersId, "mail_followers_mail_message_subtype_rel_mail_followers_id_index");

            entity.HasIndex(e => e.MailMessageSubtypeId, "mail_followers_mail_message_subtype_rel_mail_message_subtype_id");

            entity.Property(e => e.MailFollowersId).HasColumnName("mail_followers_id");
            entity.Property(e => e.MailMessageSubtypeId).HasColumnName("mail_message_subtype_id");

            entity.HasOne(d => d.MailFollowers).WithMany()
                .HasForeignKey(d => d.MailFollowersId)
                .HasConstraintName("mail_followers_mail_message_subtype_rel_mail_followers_id_fkey");

            entity.HasOne(d => d.MailMessageSubtype).WithMany()
                .HasForeignKey(d => d.MailMessageSubtypeId)
                .HasConstraintName("mail_followers_mail_message_subtyp_mail_message_subtype_id_fkey");
        });

        modelBuilder.Entity<MailGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_group_pkey");

            entity.ToTable("mail_group", tb => tb.HasComment("Discussion group"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AliasId)
                .HasComment("Alias")
                .HasColumnName("alias_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Description)
                .HasComment("Description")
                .HasColumnName("description");
            entity.Property(e => e.GroupPublicId)
                .HasComment("Authorized Group")
                .HasColumnName("group_public_id");
            entity.Property(e => e.Image)
                .HasComment("Photo")
                .HasColumnName("image");
            entity.Property(e => e.ImageMedium)
                .HasComment("Medium-sized photo")
                .HasColumnName("image_medium");
            entity.Property(e => e.ImageSmall)
                .HasComment("Small-sized photo")
                .HasColumnName("image_small");
            entity.Property(e => e.MenuId)
                .HasComment("Related Menu")
                .HasColumnName("menu_id");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Public)
                .HasComment("Privacy")
                .HasColumnType("character varying")
                .HasColumnName("public");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Alias).WithMany(p => p.MailGroups)
                .HasForeignKey(d => d.AliasId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("mail_group_alias_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailGroupCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_group_create_uid_fkey");

            entity.HasOne(d => d.GroupPublic).WithMany(p => p.MailGroups)
                .HasForeignKey(d => d.GroupPublicId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_group_group_public_id_fkey");

            entity.HasOne(d => d.Menu).WithMany(p => p.MailGroups)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("mail_group_menu_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailGroupWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_group_write_uid_fkey");
        });

        modelBuilder.Entity<MailGroupResGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_group_res_group_rel", tb => tb.HasComment("RELATION BETWEEN mail_group AND res_groups"));

            entity.HasIndex(e => e.GroupsId, "mail_group_res_group_rel_groups_id_index");

            entity.HasIndex(e => new { e.MailGroupId, e.GroupsId }, "mail_group_res_group_rel_mail_group_id_groups_id_key").IsUnique();

            entity.HasIndex(e => e.MailGroupId, "mail_group_res_group_rel_mail_group_id_index");

            entity.Property(e => e.GroupsId).HasColumnName("groups_id");
            entity.Property(e => e.MailGroupId).HasColumnName("mail_group_id");

            entity.HasOne(d => d.Groups).WithMany()
                .HasForeignKey(d => d.GroupsId)
                .HasConstraintName("mail_group_res_group_rel_groups_id_fkey");

            entity.HasOne(d => d.MailGroup).WithMany()
                .HasForeignKey(d => d.MailGroupId)
                .HasConstraintName("mail_group_res_group_rel_mail_group_id_fkey");
        });

        modelBuilder.Entity<MailMail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_mail_pkey");

            entity.ToTable("mail_mail", tb => tb.HasComment("Outgoing Mails"));

            entity.HasIndex(e => e.FetchmailServerId, "mail_mail_fetchmail_server_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AutoDelete)
                .HasComment("Auto Delete")
                .HasColumnName("auto_delete");
            entity.Property(e => e.BodyHtml)
                .HasComment("Rich-text Contents")
                .HasColumnName("body_html");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.EmailCc)
                .HasComment("Cc")
                .HasColumnType("character varying")
                .HasColumnName("email_cc");
            entity.Property(e => e.EmailTo)
                .HasComment("To")
                .HasColumnName("email_to");
            entity.Property(e => e.FetchmailServerId)
                .HasComment("Inbound Mail Server")
                .HasColumnName("fetchmail_server_id");
            entity.Property(e => e.Headers)
                .HasComment("Headers")
                .HasColumnName("headers");
            entity.Property(e => e.MailMessageId)
                .HasComment("Message")
                .HasColumnName("mail_message_id");
            entity.Property(e => e.Notification)
                .HasComment("Is Notification")
                .HasColumnName("notification");
            entity.Property(e => e.References)
                .HasComment("References")
                .HasColumnName("references");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMailCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_mail_create_uid_fkey");

            entity.HasOne(d => d.FetchmailServer).WithMany(p => p.MailMails)
                .HasForeignKey(d => d.FetchmailServerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_mail_fetchmail_server_id_fkey");

            entity.HasOne(d => d.MailMessage).WithMany(p => p.MailMails)
                .HasForeignKey(d => d.MailMessageId)
                .HasConstraintName("mail_mail_mail_message_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMailWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_mail_write_uid_fkey");
        });

        modelBuilder.Entity<MailMailResPartnerRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_mail_res_partner_rel", tb => tb.HasComment("RELATION BETWEEN mail_mail AND res_partner"));

            entity.HasIndex(e => e.MailMailId, "mail_mail_res_partner_rel_mail_mail_id_index");

            entity.HasIndex(e => new { e.MailMailId, e.ResPartnerId }, "mail_mail_res_partner_rel_mail_mail_id_res_partner_id_key").IsUnique();

            entity.HasIndex(e => e.ResPartnerId, "mail_mail_res_partner_rel_res_partner_id_index");

            entity.Property(e => e.MailMailId).HasColumnName("mail_mail_id");
            entity.Property(e => e.ResPartnerId).HasColumnName("res_partner_id");

            entity.HasOne(d => d.MailMail).WithMany()
                .HasForeignKey(d => d.MailMailId)
                .HasConstraintName("mail_mail_res_partner_rel_mail_mail_id_fkey");

            entity.HasOne(d => d.ResPartner).WithMany()
                .HasForeignKey(d => d.ResPartnerId)
                .HasConstraintName("mail_mail_res_partner_rel_res_partner_id_fkey");
        });

        modelBuilder.Entity<MailMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_message_pkey");

            entity.ToTable("mail_message", tb => tb.HasComment("Message"));

            entity.HasIndex(e => e.AuthorId, "mail_message_author_id_index");

            entity.HasIndex(e => e.MessageId, "mail_message_message_id_index");

            entity.HasIndex(e => e.Model, "mail_message_model_index");

            entity.HasIndex(e => new { e.Model, e.ResId }, "mail_message_model_res_id_idx");

            entity.HasIndex(e => e.ParentId, "mail_message_parent_id_index");

            entity.HasIndex(e => e.ResId, "mail_message_res_id_index");

            entity.HasIndex(e => e.SubtypeId, "mail_message_subtype_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AuthorId)
                .HasComment("Author")
                .HasColumnName("author_id");
            entity.Property(e => e.Body)
                .HasComment("Contents")
                .HasColumnName("body");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.EmailFrom)
                .HasComment("From")
                .HasColumnType("character varying")
                .HasColumnName("email_from");
            entity.Property(e => e.MailServerId)
                .HasComment("Outgoing mail server")
                .HasColumnName("mail_server_id");
            entity.Property(e => e.MessageId)
                .HasComment("Message-Id")
                .HasColumnType("character varying")
                .HasColumnName("message_id");
            entity.Property(e => e.Model)
                .HasMaxLength(128)
                .HasComment("Related Document Model")
                .HasColumnName("model");
            entity.Property(e => e.NoAutoThread)
                .HasComment("No threading for answers")
                .HasColumnName("no_auto_thread");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Message")
                .HasColumnName("parent_id");
            entity.Property(e => e.RecordName)
                .HasComment("Message Record Name")
                .HasColumnType("character varying")
                .HasColumnName("record_name");
            entity.Property(e => e.ReplyTo)
                .HasComment("Reply-To")
                .HasColumnType("character varying")
                .HasColumnName("reply_to");
            entity.Property(e => e.ResId)
                .HasComment("Related Document ID")
                .HasColumnName("res_id");
            entity.Property(e => e.Subject)
                .HasComment("Subject")
                .HasColumnType("character varying")
                .HasColumnName("subject");
            entity.Property(e => e.SubtypeId)
                .HasComment("Subtype")
                .HasColumnName("subtype_id");
            entity.Property(e => e.Type)
                .HasMaxLength(12)
                .HasComment("Type")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Author).WithMany(p => p.MailMessages)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_author_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMessageCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_create_uid_fkey");

            entity.HasOne(d => d.MailServer).WithMany(p => p.MailMessages)
                .HasForeignKey(d => d.MailServerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_mail_server_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_parent_id_fkey");

            entity.HasOne(d => d.Subtype).WithMany(p => p.MailMessages)
                .HasForeignKey(d => d.SubtypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMessageWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_write_uid_fkey");
        });

        modelBuilder.Entity<MailMessageResPartnerRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_message_res_partner_rel", tb => tb.HasComment("RELATION BETWEEN mail_message AND res_partner"));

            entity.HasIndex(e => e.MailMessageId, "mail_message_res_partner_rel_mail_message_id_index");

            entity.HasIndex(e => new { e.MailMessageId, e.ResPartnerId }, "mail_message_res_partner_rel_mail_message_id_res_partner_id_key").IsUnique();

            entity.HasIndex(e => e.ResPartnerId, "mail_message_res_partner_rel_res_partner_id_index");

            entity.Property(e => e.MailMessageId).HasColumnName("mail_message_id");
            entity.Property(e => e.ResPartnerId).HasColumnName("res_partner_id");

            entity.HasOne(d => d.MailMessage).WithMany()
                .HasForeignKey(d => d.MailMessageId)
                .HasConstraintName("mail_message_res_partner_rel_mail_message_id_fkey");

            entity.HasOne(d => d.ResPartner).WithMany()
                .HasForeignKey(d => d.ResPartnerId)
                .HasConstraintName("mail_message_res_partner_rel_res_partner_id_fkey");
        });

        modelBuilder.Entity<MailMessageSubtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_message_subtype_pkey");

            entity.ToTable("mail_message_subtype", tb => tb.HasComment("Message subtypes"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Default)
                .HasComment("Default")
                .HasColumnName("default");
            entity.Property(e => e.Description)
                .HasComment("Description")
                .HasColumnName("description");
            entity.Property(e => e.Hidden)
                .HasComment("Hidden")
                .HasColumnName("hidden");
            entity.Property(e => e.Name)
                .HasComment("Message Type")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasComment("Parent")
                .HasColumnName("parent_id");
            entity.Property(e => e.RelationField)
                .HasComment("Relation field")
                .HasColumnType("character varying")
                .HasColumnName("relation_field");
            entity.Property(e => e.ResModel)
                .HasComment("Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailMessageSubtypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailMessageSubtypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_message_subtype_write_uid_fkey");
        });

        modelBuilder.Entity<MailNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_notification_pkey");

            entity.ToTable("mail_notification", tb => tb.HasComment("Notifications"));

            entity.HasIndex(e => e.IsRead, "mail_notification_is_read_index");

            entity.HasIndex(e => e.MessageId, "mail_notification_message_id_index");

            entity.HasIndex(e => e.PartnerId, "mail_notification_partner_id_index");

            entity.HasIndex(e => new { e.PartnerId, e.IsRead, e.Starred, e.MessageId }, "mail_notification_partner_id_read_starred_message_id");

            entity.HasIndex(e => e.Starred, "mail_notification_starred_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsRead)
                .HasComment("Read")
                .HasColumnName("is_read");
            entity.Property(e => e.MessageId)
                .HasComment("Message")
                .HasColumnName("message_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Contact")
                .HasColumnName("partner_id");
            entity.Property(e => e.Starred)
                .HasComment("Starred")
                .HasColumnName("starred");

            entity.HasOne(d => d.Message).WithMany(p => p.MailNotifications)
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("mail_notification_message_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.MailNotifications)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("mail_notification_partner_id_fkey");
        });

        modelBuilder.Entity<MailVote>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_vote", tb => tb.HasComment("RELATION BETWEEN mail_message AND res_users"));

            entity.HasIndex(e => e.MessageId, "mail_vote_message_id_index");

            entity.HasIndex(e => new { e.MessageId, e.UserId }, "mail_vote_message_id_user_id_key").IsUnique();

            entity.HasIndex(e => e.UserId, "mail_vote_user_id_index");

            entity.Property(e => e.MessageId).HasColumnName("message_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Message).WithMany()
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("mail_vote_message_id_fkey");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("mail_vote_user_id_fkey");
        });

        modelBuilder.Entity<MailWizardInvite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mail_wizard_invite_pkey");

            entity.ToTable("mail_wizard_invite", tb => tb.HasComment("Invite wizard"));

            entity.HasIndex(e => e.ResId, "mail_wizard_invite_res_id_index");

            entity.HasIndex(e => e.ResModel, "mail_wizard_invite_res_model_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Message)
                .HasComment("Message")
                .HasColumnName("message");
            entity.Property(e => e.ResId)
                .HasComment("Related Document ID")
                .HasColumnName("res_id");
            entity.Property(e => e.ResModel)
                .HasComment("Related Document Model")
                .HasColumnType("character varying")
                .HasColumnName("res_model");
            entity.Property(e => e.SendMail)
                .HasComment("Send Email")
                .HasColumnName("send_mail");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MailWizardInviteCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_wizard_invite_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MailWizardInviteWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("mail_wizard_invite_write_uid_fkey");
        });

        modelBuilder.Entity<MailWizardInviteResPartnerRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mail_wizard_invite_res_partner_rel", tb => tb.HasComment("RELATION BETWEEN mail_wizard_invite AND res_partner"));

            entity.HasIndex(e => new { e.MailWizardInviteId, e.ResPartnerId }, "mail_wizard_invite_res_partne_mail_wizard_invite_id_res_par_key").IsUnique();

            entity.HasIndex(e => e.MailWizardInviteId, "mail_wizard_invite_res_partner_rel_mail_wizard_invite_id_index");

            entity.HasIndex(e => e.ResPartnerId, "mail_wizard_invite_res_partner_rel_res_partner_id_index");

            entity.Property(e => e.MailWizardInviteId).HasColumnName("mail_wizard_invite_id");
            entity.Property(e => e.ResPartnerId).HasColumnName("res_partner_id");

            entity.HasOne(d => d.MailWizardInvite).WithMany()
                .HasForeignKey(d => d.MailWizardInviteId)
                .HasConstraintName("mail_wizard_invite_res_partner_rel_mail_wizard_invite_id_fkey");

            entity.HasOne(d => d.ResPartner).WithMany()
                .HasForeignKey(d => d.ResPartnerId)
                .HasConstraintName("mail_wizard_invite_res_partner_rel_res_partner_id_fkey");
        });

        modelBuilder.Entity<MakeProcurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("make_procurement_pkey");

            entity.ToTable("make_procurement", tb => tb.HasComment("Make Procurements"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DatePlanned)
                .HasComment("Planned Date")
                .HasColumnName("date_planned");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.Qty)
                .HasComment("Quantity")
                .HasColumnName("qty");
            entity.Property(e => e.UomId)
                .HasComment("Unit of Measure")
                .HasColumnName("uom_id");
            entity.Property(e => e.WarehouseId)
                .HasComment("Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MakeProcurementCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("make_procurement_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.MakeProcurements)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("make_procurement_product_id_fkey");

            entity.HasOne(d => d.Uom).WithMany(p => p.MakeProcurements)
                .HasForeignKey(d => d.UomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("make_procurement_uom_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.MakeProcurements)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("make_procurement_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MakeProcurementWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("make_procurement_write_uid_fkey");
        });

        modelBuilder.Entity<MealReservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meal_reservation_pkey");

            entity.ToTable("meal_reservation", tb => tb.HasComment("Reservation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateOrder)
                .HasComment("Date Ordered")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_order");
            entity.Property(e => e.Description)
                .HasComment("Description")
                .HasColumnName("description");
            entity.Property(e => e.DevoteeId)
                .HasComment("Devotee")
                .HasColumnName("devotee_id");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.NoOfPersons)
                .HasComment("No of Persons")
                .HasColumnName("no_of_persons");
            entity.Property(e => e.PartnerId)
                .HasComment("Guest Name")
                .HasColumnName("partner_id");
            entity.Property(e => e.Place)
                .HasComment("Place")
                .HasColumnType("character varying")
                .HasColumnName("place");
            entity.Property(e => e.ReservationNo)
                .HasMaxLength(64)
                .HasComment("MealPass No")
                .HasColumnName("reservation_no");
            entity.Property(e => e.State)
                .HasComment("State")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WarehouseId)
                .HasComment("Ashram")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MealReservationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_reservation_create_uid_fkey");

            entity.HasOne(d => d.Devotee).WithMany(p => p.MealReservations)
                .HasForeignKey(d => d.DevoteeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_reservation_devotee_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.MealReservations)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_reservation_partner_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.MealReservations)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_reservation_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MealReservationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_reservation_write_uid_fkey");
        });

        modelBuilder.Entity<MealReservationMealTypeRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("meal_reservation_meal_type_rel", tb => tb.HasComment("RELATION BETWEEN meal_reservation AND meal_type"));

            entity.HasIndex(e => new { e.MealReservationId, e.MealTypeId }, "meal_reservation_meal_type_re_meal_reservation_id_meal_type_key").IsUnique();

            entity.HasIndex(e => e.MealReservationId, "meal_reservation_meal_type_rel_meal_reservation_id_index");

            entity.HasIndex(e => e.MealTypeId, "meal_reservation_meal_type_rel_meal_type_id_index");

            entity.Property(e => e.MealReservationId).HasColumnName("meal_reservation_id");
            entity.Property(e => e.MealTypeId).HasColumnName("meal_type_id");

            entity.HasOne(d => d.MealReservation).WithMany()
                .HasForeignKey(d => d.MealReservationId)
                .HasConstraintName("meal_reservation_meal_type_rel_meal_reservation_id_fkey");

            entity.HasOne(d => d.MealType).WithMany()
                .HasForeignKey(d => d.MealTypeId)
                .HasConstraintName("meal_reservation_meal_type_rel_meal_type_id_fkey");
        });

        modelBuilder.Entity<MealType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("meal_type_pkey");

            entity.ToTable("meal_type", tb => tb.HasComment("meal.type"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Meal type")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MealTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MealTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("meal_type_write_uid_fkey");
        });

        modelBuilder.Entity<MessageAttachmentRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("message_attachment_rel", tb => tb.HasComment("RELATION BETWEEN mail_message AND ir_attachment"));

            entity.HasIndex(e => e.AttachmentId, "message_attachment_rel_attachment_id_index");

            entity.HasIndex(e => new { e.MessageId, e.AttachmentId }, "message_attachment_rel_message_id_attachment_id_key").IsUnique();

            entity.HasIndex(e => e.MessageId, "message_attachment_rel_message_id_index");

            entity.Property(e => e.AttachmentId).HasColumnName("attachment_id");
            entity.Property(e => e.MessageId).HasColumnName("message_id");

            entity.HasOne(d => d.Attachment).WithMany()
                .HasForeignKey(d => d.AttachmentId)
                .HasConstraintName("message_attachment_rel_attachment_id_fkey");

            entity.HasOne(d => d.Message).WithMany()
                .HasForeignKey(d => d.MessageId)
                .HasConstraintName("message_attachment_rel_message_id_fkey");
        });

        modelBuilder.Entity<MultiCompanyDefault>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("multi_company_default_pkey");

            entity.ToTable("multi_company_default", tb => tb.HasComment("Default multi company"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyDestId)
                .HasComment("Default Company")
                .HasColumnName("company_dest_id");
            entity.Property(e => e.CompanyId)
                .HasComment("Main Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Expression)
                .HasComment("Expression")
                .HasColumnType("character varying")
                .HasColumnName("expression");
            entity.Property(e => e.FieldId)
                .HasComment("Field")
                .HasColumnName("field_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ObjectId)
                .HasComment("Object")
                .HasColumnName("object_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CompanyDest).WithMany(p => p.MultiCompanyDefaultCompanyDests)
                .HasForeignKey(d => d.CompanyDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("multi_company_default_company_dest_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.MultiCompanyDefaultCompanies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("multi_company_default_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.MultiCompanyDefaultCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("multi_company_default_create_uid_fkey");

            entity.HasOne(d => d.Field).WithMany(p => p.MultiCompanyDefaults)
                .HasForeignKey(d => d.FieldId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("multi_company_default_field_id_fkey");

            entity.HasOne(d => d.Object).WithMany(p => p.MultiCompanyDefaults)
                .HasForeignKey(d => d.ObjectId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("multi_company_default_object_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.MultiCompanyDefaultWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("multi_company_default_write_uid_fkey");
        });

        modelBuilder.Entity<OsvMemoryAutovacuum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("osv_memory_autovacuum_pkey");

            entity.ToTable("osv_memory_autovacuum", tb => tb.HasComment("osv_memory.autovacuum"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.OsvMemoryAutovacuumCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("osv_memory_autovacuum_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.OsvMemoryAutovacuumWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("osv_memory_autovacuum_write_uid_fkey");
        });

        modelBuilder.Entity<PortalWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("portal_wizard_pkey");

            entity.ToTable("portal_wizard", tb => tb.HasComment("Portal Access Management"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.PortalId)
                .HasComment("Portal")
                .HasColumnName("portal_id");
            entity.Property(e => e.WelcomeMessage)
                .HasComment("Invitation Message")
                .HasColumnName("welcome_message");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PortalWizardCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_create_uid_fkey");

            entity.HasOne(d => d.Portal).WithMany(p => p.PortalWizards)
                .HasForeignKey(d => d.PortalId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_portal_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PortalWizardWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<PortalWizardUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("portal_wizard_user_pkey");

            entity.ToTable("portal_wizard_user", tb => tb.HasComment("Portal User Config"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Email)
                .HasMaxLength(240)
                .HasComment("Email")
                .HasColumnName("email");
            entity.Property(e => e.InPortal)
                .HasComment("In Portal")
                .HasColumnName("in_portal");
            entity.Property(e => e.PartnerId)
                .HasComment("Contact")
                .HasColumnName("partner_id");
            entity.Property(e => e.WizardId)
                .HasComment("Wizard")
                .HasColumnName("wizard_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PortalWizardUserCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_user_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.PortalWizardUsers)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_user_partner_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.PortalWizardUsers)
                .HasForeignKey(d => d.WizardId)
                .HasConstraintName("portal_wizard_user_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PortalWizardUserWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("portal_wizard_user_write_uid_fkey");
        });

        modelBuilder.Entity<PricelistPartnerinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pricelist_partnerinfo_pkey");

            entity.ToTable("pricelist_partnerinfo", tb => tb.HasComment("pricelist.partnerinfo"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MinQuantity)
                .HasComment("Quantity")
                .HasColumnName("min_quantity");
            entity.Property(e => e.Name)
                .HasComment("Description")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Price)
                .HasComment("Unit Price")
                .HasColumnName("price");
            entity.Property(e => e.SuppinfoId)
                .HasComment("Partner Information")
                .HasColumnName("suppinfo_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.PricelistPartnerinfoCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pricelist_partnerinfo_create_uid_fkey");

            entity.HasOne(d => d.Suppinfo).WithMany(p => p.PricelistPartnerinfos)
                .HasForeignKey(d => d.SuppinfoId)
                .HasConstraintName("pricelist_partnerinfo_suppinfo_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.PricelistPartnerinfoWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("pricelist_partnerinfo_write_uid_fkey");
        });

        modelBuilder.Entity<ProcurementGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("procurement_group_pkey");

            entity.ToTable("procurement_group", tb => tb.HasComment("Procurement Requisition"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MoveType)
                .HasComment("Delivery Method")
                .HasColumnType("character varying")
                .HasColumnName("move_type");
            entity.Property(e => e.Name)
                .HasComment("Reference")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PartnerId)
                .HasComment("Partner")
                .HasColumnName("partner_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProcurementGroupCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ProcurementGroups)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProcurementGroupWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_group_write_uid_fkey");
        });

        modelBuilder.Entity<ProcurementOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("procurement_order_pkey");

            entity.ToTable("procurement_order", tb => tb.HasComment("Procurement"));

            entity.HasIndex(e => e.DatePlanned, "procurement_order_date_planned_index");

            entity.HasIndex(e => e.Priority, "procurement_order_priority_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DatePlanned)
                .HasComment("Scheduled Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_planned");
            entity.Property(e => e.GroupId)
                .HasComment("Procurement Group")
                .HasColumnName("group_id");
            entity.Property(e => e.LocationId)
                .HasComment("Procurement Location")
                .HasColumnName("location_id");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.MoveDestId)
                .HasComment("Destination Move")
                .HasColumnName("move_dest_id");
            entity.Property(e => e.Name)
                .HasComment("Description")
                .HasColumnName("name");
            entity.Property(e => e.OrderpointId)
                .HasComment("Minimum Stock Rule")
                .HasColumnName("orderpoint_id");
            entity.Property(e => e.Origin)
                .HasComment("Source Document")
                .HasColumnType("character varying")
                .HasColumnName("origin");
            entity.Property(e => e.PartnerDestId)
                .HasComment("Customer Address")
                .HasColumnName("partner_dest_id");
            entity.Property(e => e.Priority)
                .HasComment("Priority")
                .HasColumnType("character varying")
                .HasColumnName("priority");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductQty)
                .HasComment("Quantity")
                .HasColumnName("product_qty");
            entity.Property(e => e.ProductUom)
                .HasComment("Product Unit of Measure")
                .HasColumnName("product_uom");
            entity.Property(e => e.ProductUos)
                .HasComment("Product UoS")
                .HasColumnName("product_uos");
            entity.Property(e => e.ProductUosQty)
                .HasComment("UoS Quantity")
                .HasColumnName("product_uos_qty");
            entity.Property(e => e.RuleId)
                .HasComment("Rule")
                .HasColumnName("rule_id");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WarehouseId)
                .HasComment("Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProcurementOrderCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_group_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_location_id_fkey");

            entity.HasOne(d => d.MoveDest).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.MoveDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_move_dest_id_fkey");

            entity.HasOne(d => d.Orderpoint).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.OrderpointId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_orderpoint_id_fkey");

            entity.HasOne(d => d.PartnerDest).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.PartnerDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_partner_dest_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_product_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.ProcurementOrderProductUomNavigations)
                .HasForeignKey(d => d.ProductUom)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_product_uom_fkey");

            entity.HasOne(d => d.ProductUosNavigation).WithMany(p => p.ProcurementOrderProductUosNavigations)
                .HasForeignKey(d => d.ProductUos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_product_uos_fkey");

            entity.HasOne(d => d.Rule).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.RuleId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_rule_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ProcurementOrders)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProcurementOrderWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_write_uid_fkey");
        });

        modelBuilder.Entity<ProcurementOrderComputeAll>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("procurement_order_compute_all_pkey");

            entity.ToTable("procurement_order_compute_all", tb => tb.HasComment("Compute all schedulers"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProcurementOrderComputeAllCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_compute_all_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProcurementOrderComputeAllWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_order_compute_all_write_uid_fkey");
        });

        modelBuilder.Entity<ProcurementOrderpointCompute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("procurement_orderpoint_compute_pkey");

            entity.ToTable("procurement_orderpoint_compute", tb => tb.HasComment("Compute Minimum Stock Rules"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProcurementOrderpointComputeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_orderpoint_compute_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProcurementOrderpointComputeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_orderpoint_compute_write_uid_fkey");
        });

        modelBuilder.Entity<ProcurementRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("procurement_rule_pkey");

            entity.ToTable("procurement_rule", tb => tb.HasComment("Procurement Rule"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasComment("Action")
                .HasColumnType("character varying")
                .HasColumnName("action");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Delay)
                .HasComment("Number of Days")
                .HasColumnName("delay");
            entity.Property(e => e.GroupId)
                .HasComment("Fixed Procurement Group")
                .HasColumnName("group_id");
            entity.Property(e => e.GroupPropagationOption)
                .HasComment("Propagation of Procurement Group")
                .HasColumnType("character varying")
                .HasColumnName("group_propagation_option");
            entity.Property(e => e.LocationId)
                .HasComment("Procurement Location")
                .HasColumnName("location_id");
            entity.Property(e => e.LocationSrcId)
                .HasComment("Source Location")
                .HasColumnName("location_src_id");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PartnerAddressId)
                .HasComment("Partner Address")
                .HasColumnName("partner_address_id");
            entity.Property(e => e.PickingTypeId)
                .HasComment("Picking Type")
                .HasColumnName("picking_type_id");
            entity.Property(e => e.ProcureMethod)
                .HasComment("Move Supply Method")
                .HasColumnType("character varying")
                .HasColumnName("procure_method");
            entity.Property(e => e.Propagate)
                .HasComment("Propagate cancel and split")
                .HasColumnName("propagate");
            entity.Property(e => e.PropagateWarehouseId)
                .HasComment("Warehouse to Propagate")
                .HasColumnName("propagate_warehouse_id");
            entity.Property(e => e.RouteId)
                .HasComment("Route")
                .HasColumnName("route_id");
            entity.Property(e => e.RouteSequence)
                .HasComment("Route Sequence")
                .HasColumnName("route_sequence");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WarehouseId)
                .HasComment("Served Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ProcurementRules)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProcurementRuleCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.ProcurementRules)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_group_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.ProcurementRuleLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_location_id_fkey");

            entity.HasOne(d => d.LocationSrc).WithMany(p => p.ProcurementRuleLocationSrcs)
                .HasForeignKey(d => d.LocationSrcId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_location_src_id_fkey");

            entity.HasOne(d => d.PartnerAddress).WithMany(p => p.ProcurementRules)
                .HasForeignKey(d => d.PartnerAddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_partner_address_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.ProcurementRules)
                .HasForeignKey(d => d.PickingTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_picking_type_id_fkey");

            entity.HasOne(d => d.PropagateWarehouse).WithMany(p => p.ProcurementRulePropagateWarehouses)
                .HasForeignKey(d => d.PropagateWarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_propagate_warehouse_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.ProcurementRules)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_route_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.ProcurementRuleWarehouses)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProcurementRuleWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("procurement_rule_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_pkey");

            entity.ToTable("product_attribute", tb => tb.HasComment("Product Attribute"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttributeLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_line_pkey");

            entity.ToTable("product_attribute_line", tb => tb.HasComment("product.attribute.line"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttributeId)
                .HasComment("Attribute")
                .HasColumnName("attribute_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.ProductTmplId)
                .HasComment("Product Template")
                .HasColumnName("product_tmpl_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Attribute).WithMany(p => p.ProductAttributeLines)
                .HasForeignKey(d => d.AttributeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("product_attribute_line_attribute_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributeLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_line_create_uid_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductAttributeLines)
                .HasForeignKey(d => d.ProductTmplId)
                .HasConstraintName("product_attribute_line_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributeLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_line_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttributeLineProductAttributeValueRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("product_attribute_line_product_attribute_value_rel", tb => tb.HasComment("RELATION BETWEEN product_attribute_line AND product_attribute_value"));

            entity.HasIndex(e => new { e.LineId, e.ValId }, "product_attribute_line_product_attribute_val_line_id_val_id_key").IsUnique();

            entity.HasIndex(e => e.LineId, "product_attribute_line_product_attribute_value_rel_line_id_inde");

            entity.HasIndex(e => e.ValId, "product_attribute_line_product_attribute_value_rel_val_id_index");

            entity.Property(e => e.LineId).HasColumnName("line_id");
            entity.Property(e => e.ValId).HasColumnName("val_id");

            entity.HasOne(d => d.Line).WithMany()
                .HasForeignKey(d => d.LineId)
                .HasConstraintName("product_attribute_line_product_attribute_value_rel_line_id_fkey");

            entity.HasOne(d => d.Val).WithMany()
                .HasForeignKey(d => d.ValId)
                .HasConstraintName("product_attribute_line_product_attribute_value_rel_val_id_fkey");
        });

        modelBuilder.Entity<ProductAttributePrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_price_pkey");

            entity.ToTable("product_attribute_price", tb => tb.HasComment("product.attribute.price"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.PriceExtra)
                .HasComment("Price Extra")
                .HasColumnName("price_extra");
            entity.Property(e => e.ProductTmplId)
                .HasComment("Product Template")
                .HasColumnName("product_tmpl_id");
            entity.Property(e => e.ValueId)
                .HasComment("Product Attribute Value")
                .HasColumnName("value_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributePriceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_price_create_uid_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductAttributePrices)
                .HasForeignKey(d => d.ProductTmplId)
                .HasConstraintName("product_attribute_price_product_tmpl_id_fkey");

            entity.HasOne(d => d.Value).WithMany(p => p.ProductAttributePrices)
                .HasForeignKey(d => d.ValueId)
                .HasConstraintName("product_attribute_price_value_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributePriceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_price_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttributeValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_attribute_value_pkey");

            entity.ToTable("product_attribute_value", tb => tb.HasComment("product.attribute.value"));

            entity.HasIndex(e => new { e.Name, e.AttributeId }, "product_attribute_value_value_company_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AttributeId)
                .HasComment("Attribute")
                .HasColumnName("attribute_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Value")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Attribute).WithMany(p => p.ProductAttributeValues)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("product_attribute_value_attribute_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductAttributeValueCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_value_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductAttributeValueWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_attribute_value_write_uid_fkey");
        });

        modelBuilder.Entity<ProductAttributeValueProductProductRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("product_attribute_value_product_product_rel", tb => tb.HasComment("RELATION BETWEEN product_attribute_value AND product_product"));

            entity.HasIndex(e => e.AttId, "product_attribute_value_product_product_rel_att_id_index");

            entity.HasIndex(e => new { e.AttId, e.ProdId }, "product_attribute_value_product_product_rel_att_id_prod_id_key").IsUnique();

            entity.HasIndex(e => e.ProdId, "product_attribute_value_product_product_rel_prod_id_index");

            entity.Property(e => e.AttId).HasColumnName("att_id");
            entity.Property(e => e.ProdId).HasColumnName("prod_id");

            entity.HasOne(d => d.Att).WithMany()
                .HasForeignKey(d => d.AttId)
                .HasConstraintName("product_attribute_value_product_product_rel_att_id_fkey");

            entity.HasOne(d => d.Prod).WithMany()
                .HasForeignKey(d => d.ProdId)
                .HasConstraintName("product_attribute_value_product_product_rel_prod_id_fkey");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_category_pkey");

            entity.ToTable("product_category", tb => tb.HasComment("Product Category"));

            entity.HasIndex(e => e.Name, "product_category_name_index");

            entity.HasIndex(e => e.ParentId, "product_category_parent_id_index");

            entity.HasIndex(e => e.ParentLeft, "product_category_parent_left_index");

            entity.HasIndex(e => e.ParentRight, "product_category_parent_right_index");

            entity.HasIndex(e => e.Sequence, "product_category_sequence_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Isamenitytype)
                .HasComment("Is Amenities Type")
                .HasColumnName("isamenitytype");
            entity.Property(e => e.Isroomtype)
                .HasComment("Is Room Type")
                .HasColumnName("isroomtype");
            entity.Property(e => e.Isservicetype)
                .HasComment("Is Service Type")
                .HasColumnName("isservicetype");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Category")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentLeft).HasColumnName("parent_left");
            entity.Property(e => e.ParentRight).HasColumnName("parent_right");
            entity.Property(e => e.RemovalStrategyId)
                .HasComment("Force Removal Strategy")
                .HasColumnName("removal_strategy_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.Type)
                .HasComment("Category Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductCategoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_category_parent_id_fkey");

            entity.HasOne(d => d.RemovalStrategy).WithMany(p => p.ProductCategories)
                .HasForeignKey(d => d.RemovalStrategyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_category_removal_strategy_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductCategoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_category_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPackaging>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_packaging_pkey");

            entity.ToTable("product_packaging", tb => tb.HasComment("Packaging"));

            entity.HasIndex(e => e.ProductTmplId, "product_packaging_product_tmpl_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasComment("Code")
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Ean)
                .HasMaxLength(14)
                .HasComment("EAN")
                .HasColumnName("ean");
            entity.Property(e => e.Name)
                .HasComment("Description")
                .HasColumnName("name");
            entity.Property(e => e.ProductTmplId)
                .HasComment("Product")
                .HasColumnName("product_tmpl_id");
            entity.Property(e => e.Qty)
                .HasComment("Quantity by Package")
                .HasColumnName("qty");
            entity.Property(e => e.Rows)
                .HasComment("Number of Layers")
                .HasColumnName("rows");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.Ul)
                .HasComment("Package Logistic Unit")
                .HasColumnName("ul");
            entity.Property(e => e.UlContainer)
                .HasComment("Pallet Logistic Unit")
                .HasColumnName("ul_container");
            entity.Property(e => e.UlQty)
                .HasComment("Package by layer")
                .HasColumnName("ul_qty");
            entity.Property(e => e.Weight)
                .HasComment("Total Package Weight")
                .HasColumnName("weight");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPackagingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_create_uid_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductPackagings)
                .HasForeignKey(d => d.ProductTmplId)
                .HasConstraintName("product_packaging_product_tmpl_id_fkey");

            entity.HasOne(d => d.UlNavigation).WithMany(p => p.ProductPackagingUlNavigations)
                .HasForeignKey(d => d.Ul)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_ul_fkey");

            entity.HasOne(d => d.UlContainerNavigation).WithMany(p => p.ProductPackagingUlContainerNavigations)
                .HasForeignKey(d => d.UlContainer)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_ul_container_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPackagingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_packaging_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPriceHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_price_history_pkey");

            entity.ToTable("product_price_history", tb => tb.HasComment("product.price.history"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("unknown")
                .HasColumnName("company_id");
            entity.Property(e => e.Cost)
                .HasComment("Historized Cost")
                .HasColumnName("cost");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Datetime)
                .HasComment("Historization Time")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datetime");
            entity.Property(e => e.ProductTemplateId)
                .HasComment("Product Template")
                .HasColumnName("product_template_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPriceHistories)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_history_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPriceHistoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_history_create_uid_fkey");

            entity.HasOne(d => d.ProductTemplate).WithMany(p => p.ProductPriceHistories)
                .HasForeignKey(d => d.ProductTemplateId)
                .HasConstraintName("product_price_history_product_template_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPriceHistoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_history_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPriceList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_price_list_pkey");

            entity.ToTable("product_price_list", tb => tb.HasComment("Price List"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.PriceList)
                .HasComment("PriceList")
                .HasColumnName("price_list");
            entity.Property(e => e.Qty1)
                .HasComment("Quantity-1")
                .HasColumnName("qty1");
            entity.Property(e => e.Qty2)
                .HasComment("Quantity-2")
                .HasColumnName("qty2");
            entity.Property(e => e.Qty3)
                .HasComment("Quantity-3")
                .HasColumnName("qty3");
            entity.Property(e => e.Qty4)
                .HasComment("Quantity-4")
                .HasColumnName("qty4");
            entity.Property(e => e.Qty5)
                .HasComment("Quantity-5")
                .HasColumnName("qty5");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPriceListCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_list_create_uid_fkey");

            entity.HasOne(d => d.PriceListNavigation).WithMany(p => p.ProductPriceLists)
                .HasForeignKey(d => d.PriceList)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_list_price_list_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPriceListWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_list_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPriceType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_price_type_pkey");

            entity.ToTable("product_price_type", tb => tb.HasComment("Price Type"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CurrencyId)
                .HasComment("Currency")
                .HasColumnName("currency_id");
            entity.Property(e => e.Field)
                .HasMaxLength(32)
                .HasComment("Product Field")
                .HasColumnName("field");
            entity.Property(e => e.Name)
                .HasComment("Price Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPriceTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_type_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ProductPriceTypes)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_type_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPriceTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_price_type_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPricelist1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pricelist_pkey");

            entity.ToTable("product_pricelist", tb => tb.HasComment("Pricelist"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CurrencyId)
                .HasComment("Currency")
                .HasColumnName("currency_id");
            entity.Property(e => e.Name)
                .HasComment("Pricelist Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasComment("Pricelist Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPricelist1s)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPricelist1CreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ProductPricelist1s)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPricelist1WriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPricelistItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pricelist_item_pkey");

            entity.ToTable("product_pricelist_item", tb => tb.HasComment("Pricelist item"));

            entity.HasIndex(e => e.PriceVersionId, "product_pricelist_item_price_version_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Base)
                .HasComment("Based on")
                .HasColumnName("base");
            entity.Property(e => e.BasePricelistId)
                .HasComment("Other Pricelist")
                .HasColumnName("base_pricelist_id");
            entity.Property(e => e.CategId)
                .HasComment("Product Category")
                .HasColumnName("categ_id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MinQuantity)
                .HasComment("Min. Quantity")
                .HasColumnName("min_quantity");
            entity.Property(e => e.Name)
                .HasComment("Rule Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PriceDiscount)
                .HasComment("Price Discount")
                .HasColumnName("price_discount");
            entity.Property(e => e.PriceMaxMargin)
                .HasComment("Max. Price Margin")
                .HasColumnName("price_max_margin");
            entity.Property(e => e.PriceMinMargin)
                .HasComment("Min. Price Margin")
                .HasColumnName("price_min_margin");
            entity.Property(e => e.PriceRound)
                .HasComment("Price Rounding")
                .HasColumnName("price_round");
            entity.Property(e => e.PriceSurcharge)
                .HasComment("Price Surcharge")
                .HasColumnName("price_surcharge");
            entity.Property(e => e.PriceVersionId)
                .HasComment("Price List Version")
                .HasColumnName("price_version_id");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductTmplId)
                .HasComment("Product Template")
                .HasColumnName("product_tmpl_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.BasePricelist).WithMany(p => p.ProductPricelistItems)
                .HasForeignKey(d => d.BasePricelistId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_base_pricelist_id_fkey");

            entity.HasOne(d => d.Categ).WithMany(p => p.ProductPricelistItems)
                .HasForeignKey(d => d.CategId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_categ_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPricelistItems)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPricelistItemCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_create_uid_fkey");

            entity.HasOne(d => d.PriceVersion).WithMany(p => p.ProductPricelistItems)
                .HasForeignKey(d => d.PriceVersionId)
                .HasConstraintName("product_pricelist_item_price_version_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductPricelistItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_product_id_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductPricelistItems)
                .HasForeignKey(d => d.ProductTmplId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("product_pricelist_item_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPricelistItemWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_item_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPricelistType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pricelist_type_pkey");

            entity.ToTable("product_pricelist_type", tb => tb.HasComment("Pricelist Type"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Key)
                .HasComment("Key")
                .HasColumnType("character varying")
                .HasColumnName("key");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPricelistTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPricelistTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_type_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPricelistVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pricelist_version_pkey");

            entity.ToTable("product_pricelist_version", tb => tb.HasComment("Pricelist Version"));

            entity.HasIndex(e => e.PricelistId, "product_pricelist_version_pricelist_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateEnd)
                .HasComment("End Date")
                .HasColumnName("date_end");
            entity.Property(e => e.DateStart)
                .HasComment("Start Date")
                .HasColumnName("date_start");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PricelistId)
                .HasComment("Price List")
                .HasColumnName("pricelist_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductPricelistVersions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_version_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPricelistVersionCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_version_create_uid_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.ProductPricelistVersions)
                .HasForeignKey(d => d.PricelistId)
                .HasConstraintName("product_pricelist_version_pricelist_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPricelistVersionWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_pricelist_version_write_uid_fkey");
        });

        modelBuilder.Entity<ProductProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_product_pkey");

            entity.ToTable("product_product", tb => tb.HasComment("Product"));

            entity.HasIndex(e => e.DefaultCode, "product_product_default_code_index");

            entity.HasIndex(e => e.NameTemplate, "product_product_name_template_index");

            entity.HasIndex(e => e.ProductTmplId, "product_product_product_tmpl_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DefaultCode)
                .HasComment("Internal Reference")
                .HasColumnType("character varying")
                .HasColumnName("default_code");
            entity.Property(e => e.Ean13)
                .HasMaxLength(13)
                .HasComment("EAN13 Barcode")
                .HasColumnName("ean13");
            entity.Property(e => e.ImageVariant)
                .HasComment("Variant Image")
                .HasColumnName("image_variant");
            entity.Property(e => e.Iscategid)
                .HasComment("Is categ id")
                .HasColumnName("iscategid");
            entity.Property(e => e.Isroom)
                .HasComment("Is Room")
                .HasColumnName("isroom");
            entity.Property(e => e.Isservice)
                .HasComment("Is Service id")
                .HasColumnName("isservice");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.NameTemplate)
                .HasComment("Template Name")
                .HasColumnType("character varying")
                .HasColumnName("name_template");
            entity.Property(e => e.ProductTmplId)
                .HasComment("Product Template")
                .HasColumnName("product_tmpl_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductProductCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_product_create_uid_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductProducts)
                .HasForeignKey(d => d.ProductTmplId)
                .HasConstraintName("product_product_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductProductWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_product_write_uid_fkey");
        });

        modelBuilder.Entity<ProductPutaway>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_putaway_pkey");

            entity.ToTable("product_putaway", tb => tb.HasComment("Put Away Strategy"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Method)
                .HasComment("Method")
                .HasColumnType("character varying")
                .HasColumnName("method");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductPutawayCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_putaway_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductPutawayWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_putaway_write_uid_fkey");
        });

        modelBuilder.Entity<ProductRemoval>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_removal_pkey");

            entity.ToTable("product_removal", tb => tb.HasComment("Removal Strategy"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Method)
                .HasComment("Method")
                .HasColumnType("character varying")
                .HasColumnName("method");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductRemovalCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_removal_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductRemovalWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_removal_write_uid_fkey");
        });

        modelBuilder.Entity<ProductSupplierinfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_supplierinfo_pkey");

            entity.ToTable("product_supplierinfo", tb => tb.HasComment("Information about a product supplier"));

            entity.HasIndex(e => e.CompanyId, "product_supplierinfo_company_id_index");

            entity.HasIndex(e => e.ProductTmplId, "product_supplierinfo_product_tmpl_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Delay)
                .HasComment("Delivery Lead Time")
                .HasColumnName("delay");
            entity.Property(e => e.MinQty)
                .HasComment("Minimal Quantity")
                .HasColumnName("min_qty");
            entity.Property(e => e.Name)
                .HasComment("Supplier")
                .HasColumnName("name");
            entity.Property(e => e.ProductCode)
                .HasComment("Supplier Product Code")
                .HasColumnType("character varying")
                .HasColumnName("product_code");
            entity.Property(e => e.ProductName)
                .HasComment("Supplier Product Name")
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.ProductTmplId)
                .HasComment("Product Template")
                .HasColumnName("product_tmpl_id");
            entity.Property(e => e.Qty)
                .HasComment("Quantity")
                .HasColumnName("qty");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductSupplierinfos)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductSupplierinfoCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_create_uid_fkey");

            entity.HasOne(d => d.NameNavigation).WithMany(p => p.ProductSupplierinfos)
                .HasForeignKey(d => d.Name)
                .HasConstraintName("product_supplierinfo_name_fkey");

            entity.HasOne(d => d.ProductTmpl).WithMany(p => p.ProductSupplierinfos)
                .HasForeignKey(d => d.ProductTmplId)
                .HasConstraintName("product_supplierinfo_product_tmpl_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductSupplierinfoWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_supplierinfo_write_uid_fkey");
        });

        modelBuilder.Entity<ProductTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_template_pkey");

            entity.ToTable("product_template", tb => tb.HasComment("Product Template"));

            entity.HasIndex(e => e.CompanyId, "product_template_company_id_index");

            entity.HasIndex(e => e.Name, "product_template_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CategId)
                .HasComment("Internal Category")
                .HasColumnName("categ_id");
            entity.Property(e => e.Color)
                .HasComment("Color Index")
                .HasColumnName("color");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Description)
                .HasComment("Description")
                .HasColumnName("description");
            entity.Property(e => e.DescriptionPurchase)
                .HasComment("Purchase Description")
                .HasColumnName("description_purchase");
            entity.Property(e => e.DescriptionSale)
                .HasComment("Sale Description")
                .HasColumnName("description_sale");
            entity.Property(e => e.Image)
                .HasComment("Image")
                .HasColumnName("image");
            entity.Property(e => e.ImageMedium)
                .HasComment("Medium-sized image")
                .HasColumnName("image_medium");
            entity.Property(e => e.ImageSmall)
                .HasComment("Small-sized image")
                .HasColumnName("image_small");
            entity.Property(e => e.ListPrice)
                .HasComment("Sale Price")
                .HasColumnName("list_price");
            entity.Property(e => e.LocCase)
                .HasMaxLength(16)
                .HasComment("Case")
                .HasColumnName("loc_case");
            entity.Property(e => e.LocRack)
                .HasMaxLength(16)
                .HasComment("Rack")
                .HasColumnName("loc_rack");
            entity.Property(e => e.LocRow)
                .HasMaxLength(16)
                .HasComment("Row")
                .HasColumnName("loc_row");
            entity.Property(e => e.MesType)
                .HasComment("Measure Type")
                .HasColumnType("character varying")
                .HasColumnName("mes_type");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ProductManager)
                .HasComment("Product Manager")
                .HasColumnName("product_manager");
            entity.Property(e => e.Rental)
                .HasComment("Can be Rent")
                .HasColumnName("rental");
            entity.Property(e => e.SaleDelay)
                .HasComment("Customer Lead Time")
                .HasColumnName("sale_delay");
            entity.Property(e => e.SaleOk)
                .HasComment("Can be Sold")
                .HasColumnName("sale_ok");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.TrackAll)
                .HasComment("Full Lots Traceability")
                .HasColumnName("track_all");
            entity.Property(e => e.TrackIncoming)
                .HasComment("Track Incoming Lots")
                .HasColumnName("track_incoming");
            entity.Property(e => e.TrackOutgoing)
                .HasComment("Track Outgoing Lots")
                .HasColumnName("track_outgoing");
            entity.Property(e => e.Type)
                .HasComment("Product Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.UomId)
                .HasComment("Unit of Measure")
                .HasColumnName("uom_id");
            entity.Property(e => e.UomPoId)
                .HasComment("Purchase Unit of Measure")
                .HasColumnName("uom_po_id");
            entity.Property(e => e.UosCoeff)
                .HasComment("Unit of Measure -> UOS Coeff")
                .HasColumnName("uos_coeff");
            entity.Property(e => e.UosId)
                .HasComment("Unit of Sale")
                .HasColumnName("uos_id");
            entity.Property(e => e.Volume)
                .HasComment("Volume")
                .HasColumnName("volume");
            entity.Property(e => e.Warranty)
                .HasComment("Warranty")
                .HasColumnName("warranty");
            entity.Property(e => e.Weight)
                .HasComment("Gross Weight")
                .HasColumnName("weight");
            entity.Property(e => e.WeightNet)
                .HasComment("Net Weight")
                .HasColumnName("weight_net");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Categ).WithMany(p => p.ProductTemplates)
                .HasForeignKey(d => d.CategId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_categ_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ProductTemplates)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductTemplateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_create_uid_fkey");

            entity.HasOne(d => d.ProductManagerNavigation).WithMany(p => p.ProductTemplateProductManagerNavigations)
                .HasForeignKey(d => d.ProductManager)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_product_manager_fkey");

            entity.HasOne(d => d.Uom).WithMany(p => p.ProductTemplateUoms)
                .HasForeignKey(d => d.UomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_uom_id_fkey");

            entity.HasOne(d => d.UomPo).WithMany(p => p.ProductTemplateUomPos)
                .HasForeignKey(d => d.UomPoId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_uom_po_id_fkey");

            entity.HasOne(d => d.Uos).WithMany(p => p.ProductTemplateUos)
                .HasForeignKey(d => d.UosId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_uos_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductTemplateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_template_write_uid_fkey");
        });

        modelBuilder.Entity<ProductUl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_ul_pkey");

            entity.ToTable("product_ul", tb => tb.HasComment("Logistic Unit"));

            entity.HasIndex(e => e.Name, "product_ul_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Height)
                .HasComment("Height")
                .HasColumnName("height");
            entity.Property(e => e.Length)
                .HasComment("Length")
                .HasColumnName("length");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Weight)
                .HasComment("Empty Package Weight")
                .HasColumnName("weight");
            entity.Property(e => e.Width)
                .HasComment("Width")
                .HasColumnName("width");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductUlCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_ul_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductUlWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_ul_write_uid_fkey");
        });

        modelBuilder.Entity<ProductUom>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_uom_pkey");

            entity.ToTable("product_uom", tb => tb.HasComment("Product Unit of Measure"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CategoryId)
                .HasComment("Unit of Measure Category")
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Factor)
                .HasComment("Ratio")
                .HasColumnName("factor");
            entity.Property(e => e.Name)
                .HasComment("Unit of Measure")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Rounding)
                .HasComment("Rounding Precision")
                .HasColumnName("rounding");
            entity.Property(e => e.UomType)
                .HasComment("Type")
                .HasColumnType("character varying")
                .HasColumnName("uom_type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductUoms)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("product_uom_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductUomCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_uom_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductUomWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_uom_write_uid_fkey");
        });

        modelBuilder.Entity<ProductUomCateg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_uom_categ_pkey");

            entity.ToTable("product_uom_categ", tb => tb.HasComment("Product uom categ"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ProductUomCategCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_uom_categ_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ProductUomCategWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("product_uom_categ_write_uid_fkey");
        });

        modelBuilder.Entity<QuickRoomReservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("quick_room_reservation_pkey");

            entity.ToTable("quick_room_reservation", tb => tb.HasComment("Quick Room Reservation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Allocated)
                .HasComment("Already allocated")
                .HasColumnName("allocated");
            entity.Property(e => e.CheckIn)
                .HasComment("Check In")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("check_in");
            entity.Property(e => e.CheckOut)
                .HasComment("Check Out")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("check_out");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DevoteeId)
                .HasComment("Devotee")
                .HasColumnName("devotee_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Customer")
                .HasColumnName("partner_id");
            entity.Property(e => e.PartnerInvoiceId)
                .HasComment("Invoice Address")
                .HasColumnName("partner_invoice_id");
            entity.Property(e => e.PartnerOrderId)
                .HasComment("Ordering Contact")
                .HasColumnName("partner_order_id");
            entity.Property(e => e.PartnerShippingId)
                .HasComment("Delivery Address")
                .HasColumnName("partner_shipping_id");
            entity.Property(e => e.PricelistId)
                .HasComment("pricelist")
                .HasColumnName("pricelist_id");
            entity.Property(e => e.RoomId)
                .HasComment("Room")
                .HasColumnName("room_id");
            entity.Property(e => e.ToAllocate)
                .HasComment("No of person(s) to allocate")
                .HasColumnName("to_allocate");
            entity.Property(e => e.WarehouseId)
                .HasComment("Ashram")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.QuickRoomReservationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_create_uid_fkey");

            entity.HasOne(d => d.Devotee).WithMany(p => p.QuickRoomReservations)
                .HasForeignKey(d => d.DevoteeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_devotee_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.QuickRoomReservationPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_partner_id_fkey");

            entity.HasOne(d => d.PartnerInvoice).WithMany(p => p.QuickRoomReservationPartnerInvoices)
                .HasForeignKey(d => d.PartnerInvoiceId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_partner_invoice_id_fkey");

            entity.HasOne(d => d.PartnerOrder).WithMany(p => p.QuickRoomReservationPartnerOrders)
                .HasForeignKey(d => d.PartnerOrderId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_partner_order_id_fkey");

            entity.HasOne(d => d.PartnerShipping).WithMany(p => p.QuickRoomReservationPartnerShippings)
                .HasForeignKey(d => d.PartnerShippingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_partner_shipping_id_fkey");

            entity.HasOne(d => d.Pricelist).WithMany(p => p.QuickRoomReservations)
                .HasForeignKey(d => d.PricelistId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_pricelist_id_fkey");

            entity.HasOne(d => d.Room).WithMany(p => p.QuickRoomReservations)
                .HasForeignKey(d => d.RoomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_room_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.QuickRoomReservations)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.QuickRoomReservationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("quick_room_reservation_write_uid_fkey");
        });

        modelBuilder.Entity<RelModulesLangexport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rel_modules_langexport", tb => tb.HasComment("RELATION BETWEEN base_language_export AND ir_module_module"));

            entity.HasIndex(e => e.ModuleId, "rel_modules_langexport_module_id_index");

            entity.HasIndex(e => e.WizId, "rel_modules_langexport_wiz_id_index");

            entity.HasIndex(e => new { e.WizId, e.ModuleId }, "rel_modules_langexport_wiz_id_module_id_key").IsUnique();

            entity.Property(e => e.ModuleId).HasColumnName("module_id");
            entity.Property(e => e.WizId).HasColumnName("wiz_id");

            entity.HasOne(d => d.Module).WithMany()
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("rel_modules_langexport_module_id_fkey");

            entity.HasOne(d => d.Wiz).WithMany()
                .HasForeignKey(d => d.WizId)
                .HasConstraintName("rel_modules_langexport_wiz_id_fkey");
        });

        modelBuilder.Entity<RelServerAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rel_server_actions", tb => tb.HasComment("RELATION BETWEEN ir_act_server AND ir_act_server"));

            entity.HasIndex(e => e.ActionId, "rel_server_actions_action_id_index");

            entity.HasIndex(e => new { e.ServerId, e.ActionId }, "rel_server_actions_server_id_action_id_key").IsUnique();

            entity.HasIndex(e => e.ServerId, "rel_server_actions_server_id_index");

            entity.Property(e => e.ActionId).HasColumnName("action_id");
            entity.Property(e => e.ServerId).HasColumnName("server_id");

            entity.HasOne(d => d.Action).WithMany()
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("rel_server_actions_action_id_fkey");

            entity.HasOne(d => d.Server).WithMany()
                .HasForeignKey(d => d.ServerId)
                .HasConstraintName("rel_server_actions_server_id_fkey");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("report_pkey");

            entity.ToTable("report", tb => tb.HasComment("Report"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ReportCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ReportWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_write_uid_fkey");
        });

        modelBuilder.Entity<ReportDocumentFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("report_document_file");

            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Nbr).HasColumnName("nbr");
        });

        modelBuilder.Entity<ReportDocumentUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("report_document_user");

            entity.Property(e => e.ChangeDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("change_date");
            entity.Property(e => e.CreateDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.DatasFname)
                .HasColumnType("character varying")
                .HasColumnName("datas_fname");
            entity.Property(e => e.Directory)
                .HasColumnType("character varying")
                .HasColumnName("directory");
            entity.Property(e => e.FileSize).HasColumnName("file_size");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Month).HasColumnName("month");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Nbr).HasColumnName("nbr");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<ReportPaperformat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("report_paperformat_pkey");

            entity.ToTable("report_paperformat", tb => tb.HasComment("Allows customization of a report."));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Default)
                .HasComment("Default paper format ?")
                .HasColumnName("default");
            entity.Property(e => e.Dpi)
                .HasComment("Output DPI")
                .HasColumnName("dpi");
            entity.Property(e => e.Format)
                .HasComment("Paper size")
                .HasColumnType("character varying")
                .HasColumnName("format");
            entity.Property(e => e.HeaderLine)
                .HasComment("Display a header line")
                .HasColumnName("header_line");
            entity.Property(e => e.HeaderSpacing)
                .HasComment("Header spacing")
                .HasColumnName("header_spacing");
            entity.Property(e => e.MarginBottom)
                .HasComment("Bottom Margin (mm)")
                .HasColumnName("margin_bottom");
            entity.Property(e => e.MarginLeft)
                .HasComment("Left Margin (mm)")
                .HasColumnName("margin_left");
            entity.Property(e => e.MarginRight)
                .HasComment("Right Margin (mm)")
                .HasColumnName("margin_right");
            entity.Property(e => e.MarginTop)
                .HasComment("Top Margin (mm)")
                .HasColumnName("margin_top");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Orientation)
                .HasComment("Orientation")
                .HasColumnType("character varying")
                .HasColumnName("orientation");
            entity.Property(e => e.PageHeight)
                .HasComment("Page height (mm)")
                .HasColumnName("page_height");
            entity.Property(e => e.PageWidth)
                .HasComment("Page width (mm)")
                .HasColumnName("page_width");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ReportPaperformatCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_paperformat_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ReportPaperformatWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("report_paperformat_write_uid_fkey");
        });

        modelBuilder.Entity<ReportStockLinesDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("report_stock_lines_date");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Date)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MoveDate)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("move_date");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
        });

        modelBuilder.Entity<ResBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_bank_pkey");

            entity.ToTable("res_bank", tb => tb.HasComment("Bank"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Bic)
                .HasMaxLength(64)
                .HasComment("Bank Identifier Code")
                .HasColumnName("bic");
            entity.Property(e => e.City)
                .HasComment("City")
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasComment("Country")
                .HasColumnName("country");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Email)
                .HasComment("Email")
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Fax)
                .HasComment("Fax")
                .HasColumnType("character varying")
                .HasColumnName("fax");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Phone)
                .HasComment("Phone")
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.State)
                .HasComment("Fed. State")
                .HasColumnName("state");
            entity.Property(e => e.Street)
                .HasComment("Street")
                .HasColumnType("character varying")
                .HasColumnName("street");
            entity.Property(e => e.Street2)
                .HasComment("Street2")
                .HasColumnType("character varying")
                .HasColumnName("street2");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");
            entity.Property(e => e.Zip)
                .HasMaxLength(24)
                .HasComment("Zip")
                .HasColumnName("zip");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.ResBanks)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_country_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResBankCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_create_uid_fkey");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.ResBanks)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_state_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResBankWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_bank_write_uid_fkey");
        });

        modelBuilder.Entity<ResCompany>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_company_pkey");

            entity.ToTable("res_company");

            entity.HasIndex(e => e.Name, "res_company_name_uniq").IsUnique();

            entity.HasIndex(e => e.ParentId, "res_company_parent_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountNo)
                .HasComment("Account No.")
                .HasColumnType("character varying")
                .HasColumnName("account_no");
            entity.Property(e => e.AdditionalHours)
                .HasComment("Additional Hours")
                .HasColumnName("additional_hours");
            entity.Property(e => e.CompanyRegistry)
                .HasMaxLength(64)
                .HasComment("Company Registry")
                .HasColumnName("company_registry");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CurrencyId).HasColumnName("currency_id");
            entity.Property(e => e.CustomFooter)
                .HasComment("Custom Footer")
                .HasColumnName("custom_footer");
            entity.Property(e => e.Email)
                .HasMaxLength(64)
                .HasComment("Email")
                .HasColumnName("email");
            entity.Property(e => e.Font)
                .HasComment("Font")
                .HasColumnName("font");
            entity.Property(e => e.InternalTransitLocationId)
                .HasComment("Internal Transit Location")
                .HasColumnName("internal_transit_location_id");
            entity.Property(e => e.LogoWeb)
                .HasComment("Logo Web")
                .HasColumnName("logo_web");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PaperformatId)
                .HasComment("Paper format")
                .HasColumnName("paperformat_id");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Company")
                .HasColumnName("parent_id");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(64)
                .HasComment("Phone")
                .HasColumnName("phone");
            entity.Property(e => e.PropagationMinimumDelta)
                .HasComment("Minimum Delta for Propagation of a Date Change on moves linked together")
                .HasColumnName("propagation_minimum_delta");
            entity.Property(e => e.RmlFooter)
                .HasComment("Report Footer")
                .HasColumnName("rml_footer");
            entity.Property(e => e.RmlHeader)
                .HasComment("RML Header")
                .HasColumnName("rml_header");
            entity.Property(e => e.RmlHeader1)
                .HasComment("Company Tagline")
                .HasColumnType("character varying")
                .HasColumnName("rml_header1");
            entity.Property(e => e.RmlHeader2)
                .HasComment("RML Internal Header")
                .HasColumnName("rml_header2");
            entity.Property(e => e.RmlHeader3)
                .HasComment("RML Internal Header for Landscape Reports")
                .HasColumnName("rml_header3");
            entity.Property(e => e.RmlPaperFormat)
                .HasComment("Paper Format")
                .HasColumnType("character varying")
                .HasColumnName("rml_paper_format");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCompanyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResCompanies)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_currency_id_fkey");

            entity.HasOne(d => d.FontNavigation).WithMany(p => p.ResCompanies)
                .HasForeignKey(d => d.Font)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_font_fkey");

            entity.HasOne(d => d.InternalTransitLocation).WithMany(p => p.ResCompanies)
                .HasForeignKey(d => d.InternalTransitLocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_internal_transit_location_id_fkey");

            entity.HasOne(d => d.Paperformat).WithMany(p => p.ResCompanies)
                .HasForeignKey(d => d.PaperformatId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_paperformat_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_parent_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResCompanies)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCompanyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_company_write_uid_fkey");
        });

        modelBuilder.Entity<ResCompanyUsersRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_company_users_rel", tb => tb.HasComment("RELATION BETWEEN res_company AND res_users"));

            entity.HasIndex(e => e.Cid, "res_company_users_rel_cid_index");

            entity.HasIndex(e => new { e.Cid, e.UserId }, "res_company_users_rel_cid_user_id_key").IsUnique();

            entity.HasIndex(e => e.UserId, "res_company_users_rel_user_id_index");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.CidNavigation).WithMany()
                .HasForeignKey(d => d.Cid)
                .HasConstraintName("res_company_users_rel_cid_fkey");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("res_company_users_rel_user_id_fkey");
        });

        modelBuilder.Entity<ResConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_config_pkey");

            entity.ToTable("res_config", tb => tb.HasComment("res.config"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResConfigCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResConfigWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_write_uid_fkey");
        });

        modelBuilder.Entity<ResConfigInstaller>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_config_installer_pkey");

            entity.ToTable("res_config_installer", tb => tb.HasComment("res.config.installer"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResConfigInstallerCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_installer_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResConfigInstallerWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_installer_write_uid_fkey");
        });

        modelBuilder.Entity<ResConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_config_settings_pkey");

            entity.ToTable("res_config_settings", tb => tb.HasComment("res.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<ResCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_country_pkey");

            entity.ToTable("res_country", tb => tb.HasComment("Country"));

            entity.HasIndex(e => e.Code, "res_country_code_uniq").IsUnique();

            entity.HasIndex(e => e.Name, "res_country_name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddressFormat)
                .HasComment("Address Format")
                .HasColumnName("address_format");
            entity.Property(e => e.Code)
                .HasMaxLength(2)
                .HasComment("Country Code")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CurrencyId)
                .HasComment("Currency")
                .HasColumnName("currency_id");
            entity.Property(e => e.Image)
                .HasComment("Image")
                .HasColumnName("image");
            entity.Property(e => e.Name)
                .HasComment("Country Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCountryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResCountries)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCountryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_write_uid_fkey");
        });

        modelBuilder.Entity<ResCountryGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_country_group_pkey");

            entity.ToTable("res_country_group", tb => tb.HasComment("Country Group"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCountryGroupCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_group_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCountryGroupWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_group_write_uid_fkey");
        });

        modelBuilder.Entity<ResCountryResCountryGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_country_res_country_group_rel", tb => tb.HasComment("RELATION BETWEEN res_country AND res_country_group"));

            entity.HasIndex(e => e.ResCountryGroupId, "res_country_res_country_group_rel_res_country_group_id_index");

            entity.HasIndex(e => e.ResCountryId, "res_country_res_country_group_rel_res_country_id_index");

            entity.HasIndex(e => new { e.ResCountryId, e.ResCountryGroupId }, "res_country_res_country_group_res_country_id_res_country_gr_key").IsUnique();

            entity.Property(e => e.ResCountryGroupId).HasColumnName("res_country_group_id");
            entity.Property(e => e.ResCountryId).HasColumnName("res_country_id");

            entity.HasOne(d => d.ResCountryGroup).WithMany()
                .HasForeignKey(d => d.ResCountryGroupId)
                .HasConstraintName("res_country_res_country_group_rel_res_country_group_id_fkey");

            entity.HasOne(d => d.ResCountry).WithMany()
                .HasForeignKey(d => d.ResCountryId)
                .HasConstraintName("res_country_res_country_group_rel_res_country_id_fkey");
        });

        modelBuilder.Entity<ResCountryState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_country_state_pkey");

            entity.ToTable("res_country_state", tb => tb.HasComment("Country state"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .HasComment("State Code")
                .HasColumnName("code");
            entity.Property(e => e.CountryId)
                .HasComment("Country")
                .HasColumnName("country_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("State Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Country).WithMany(p => p.ResCountryStates)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_state_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCountryStateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_state_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCountryStateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_country_state_write_uid_fkey");
        });

        modelBuilder.Entity<ResCurrency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_currency_pkey");

            entity.ToTable("res_currency");

            entity.HasIndex(e => new { e.Name, e.CompanyId }, "res_currency_unique_name_company_id").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Accuracy)
                .HasComment("Computational Accuracy")
                .HasColumnName("accuracy");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Base)
                .HasComment("Base")
                .HasColumnName("base");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Position)
                .HasComment("Symbol Position")
                .HasColumnType("character varying")
                .HasColumnName("position");
            entity.Property(e => e.Rounding)
                .HasComment("Rounding Factor")
                .HasColumnName("rounding");
            entity.Property(e => e.Symbol)
                .HasMaxLength(4)
                .HasComment("Symbol")
                .HasColumnName("symbol");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ResCurrencies)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCurrencyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCurrencyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_write_uid_fkey");
        });

        modelBuilder.Entity<ResCurrencyRate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_currency_rate_pkey");

            entity.ToTable("res_currency_rate", tb => tb.HasComment("Currency Rate"));

            entity.HasIndex(e => e.Name, "res_currency_rate_name_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CurrencyId)
                .HasComment("Currency")
                .HasColumnName("currency_id");
            entity.Property(e => e.Name)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("name");
            entity.Property(e => e.Rate)
                .HasComment("Rate")
                .HasColumnName("rate");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResCurrencyRateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_rate_create_uid_fkey");

            entity.HasOne(d => d.Currency).WithMany(p => p.ResCurrencyRates)
                .HasForeignKey(d => d.CurrencyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_rate_currency_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResCurrencyRateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_currency_rate_write_uid_fkey");
        });

        modelBuilder.Entity<ResFont>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_font_pkey");

            entity.ToTable("res_font", tb => tb.HasComment("Fonts available"));

            entity.HasIndex(e => new { e.Family, e.Name }, "res_font_name_font_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Family)
                .HasComment("Font family")
                .HasColumnType("character varying")
                .HasColumnName("family");
            entity.Property(e => e.Mode)
                .HasComment("Mode")
                .HasColumnType("character varying")
                .HasColumnName("mode");
            entity.Property(e => e.Name)
                .HasComment("Font Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Path)
                .HasComment("Path")
                .HasColumnType("character varying")
                .HasColumnName("path");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResFontCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_font_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResFontWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_font_write_uid_fkey");
        });

        modelBuilder.Entity<ResGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_groups_pkey");

            entity.ToTable("res_groups", tb => tb.HasComment("Access Groups"));

            entity.HasIndex(e => e.CategoryId, "res_groups_category_id_index");

            entity.HasIndex(e => new { e.CategoryId, e.Name }, "res_groups_name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasComment("Application")
                .HasColumnName("category_id");
            entity.Property(e => e.Comment)
                .HasComment("Comment")
                .HasColumnName("comment");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.IsPortal)
                .HasComment("Portal")
                .HasColumnName("is_portal");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Share)
                .HasComment("Share Group")
                .HasColumnName("share");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Category).WithMany(p => p.ResGroups)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_groups_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResGroupCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_groups_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResGroupWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_groups_write_uid_fkey");
        });

        modelBuilder.Entity<ResGroupsActionRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_groups_action_rel", tb => tb.HasComment("RELATION BETWEEN ir_actions_todo AND res_groups"));

            entity.HasIndex(e => e.Gid, "res_groups_action_rel_gid_index");

            entity.HasIndex(e => new { e.Uid, e.Gid }, "res_groups_action_rel_uid_gid_key").IsUnique();

            entity.HasIndex(e => e.Uid, "res_groups_action_rel_uid_index");

            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.GidNavigation).WithMany()
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("res_groups_action_rel_gid_fkey");

            entity.HasOne(d => d.UidNavigation).WithMany()
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("res_groups_action_rel_uid_fkey");
        });

        modelBuilder.Entity<ResGroupsImpliedRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_groups_implied_rel", tb => tb.HasComment("RELATION BETWEEN res_groups AND res_groups"));

            entity.HasIndex(e => new { e.Gid, e.Hid }, "res_groups_implied_rel_gid_hid_key").IsUnique();

            entity.HasIndex(e => e.Gid, "res_groups_implied_rel_gid_index");

            entity.HasIndex(e => e.Hid, "res_groups_implied_rel_hid_index");

            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Hid).HasColumnName("hid");

            entity.HasOne(d => d.GidNavigation).WithMany()
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("res_groups_implied_rel_gid_fkey");

            entity.HasOne(d => d.HidNavigation).WithMany()
                .HasForeignKey(d => d.Hid)
                .HasConstraintName("res_groups_implied_rel_hid_fkey");
        });

        modelBuilder.Entity<ResGroupsReportRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_groups_report_rel", tb => tb.HasComment("RELATION BETWEEN ir_act_report_xml AND res_groups"));

            entity.HasIndex(e => e.Gid, "res_groups_report_rel_gid_index");

            entity.HasIndex(e => new { e.Uid, e.Gid }, "res_groups_report_rel_uid_gid_key").IsUnique();

            entity.HasIndex(e => e.Uid, "res_groups_report_rel_uid_index");

            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.GidNavigation).WithMany()
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("res_groups_report_rel_gid_fkey");

            entity.HasOne(d => d.UidNavigation).WithMany()
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("res_groups_report_rel_uid_fkey");
        });

        modelBuilder.Entity<ResGroupsUsersRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_groups_users_rel", tb => tb.HasComment("RELATION BETWEEN res_groups AND res_users"));

            entity.HasIndex(e => e.Gid, "res_groups_users_rel_gid_index");

            entity.HasIndex(e => new { e.Gid, e.Uid }, "res_groups_users_rel_gid_uid_key").IsUnique();

            entity.HasIndex(e => e.Uid, "res_groups_users_rel_uid_index");

            entity.Property(e => e.Gid).HasColumnName("gid");
            entity.Property(e => e.Uid).HasColumnName("uid");

            entity.HasOne(d => d.GidNavigation).WithMany()
                .HasForeignKey(d => d.Gid)
                .HasConstraintName("res_groups_users_rel_gid_fkey");

            entity.HasOne(d => d.UidNavigation).WithMany()
                .HasForeignKey(d => d.Uid)
                .HasConstraintName("res_groups_users_rel_uid_fkey");
        });

        modelBuilder.Entity<ResLang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_lang_pkey");

            entity.ToTable("res_lang");

            entity.HasIndex(e => e.Code, "res_lang_code_key").IsUnique();

            entity.HasIndex(e => e.Code, "res_lang_code_uniq").IsUnique();

            entity.HasIndex(e => e.Name, "res_lang_name_key").IsUnique();

            entity.HasIndex(e => e.Name, "res_lang_name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateFormat)
                .HasComment("Date Format")
                .HasColumnType("character varying")
                .HasColumnName("date_format");
            entity.Property(e => e.DecimalPoint)
                .HasComment("Decimal Separator")
                .HasColumnType("character varying")
                .HasColumnName("decimal_point");
            entity.Property(e => e.Direction)
                .HasComment("Direction")
                .HasColumnType("character varying")
                .HasColumnName("direction");
            entity.Property(e => e.Grouping)
                .HasComment("Separator Format")
                .HasColumnType("character varying")
                .HasColumnName("grouping");
            entity.Property(e => e.IsoCode)
                .HasMaxLength(16)
                .HasComment("ISO code")
                .HasColumnName("iso_code");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ThousandsSep)
                .HasComment("Thousands Separator")
                .HasColumnType("character varying")
                .HasColumnName("thousands_sep");
            entity.Property(e => e.TimeFormat)
                .HasComment("Time Format")
                .HasColumnType("character varying")
                .HasColumnName("time_format");
            entity.Property(e => e.Translatable)
                .HasComment("Translatable")
                .HasColumnName("translatable");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResLangCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_lang_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResLangWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_lang_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_pkey");

            entity.ToTable("res_partner");

            entity.HasIndex(e => e.CompanyId, "res_partner_company_id_index");

            entity.HasIndex(e => e.Date, "res_partner_date_index");

            entity.HasIndex(e => e.DisplayName, "res_partner_display_name_index");

            entity.HasIndex(e => e.Name, "res_partner_name_index");

            entity.HasIndex(e => e.ParentId, "res_partner_parent_id_index");

            entity.HasIndex(e => e.Ref, "res_partner_ref_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.BiometricCode)
                .HasComment("Biometric Code")
                .HasColumnType("character varying")
                .HasColumnName("biometric_code");
            entity.Property(e => e.Birthdate)
                .HasComment("Birthdate")
                .HasColumnType("character varying")
                .HasColumnName("birthdate");
            entity.Property(e => e.City)
                .HasComment("City")
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.Color)
                .HasComment("Color Index")
                .HasColumnName("color");
            entity.Property(e => e.Comment)
                .HasComment("Notes")
                .HasColumnName("comment");
            entity.Property(e => e.CommercialPartnerId)
                .HasComment("Commercial Entity")
                .HasColumnName("commercial_partner_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CountryId)
                .HasComment("Country")
                .HasColumnName("country_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CreditLimit)
                .HasComment("Credit Limit")
                .HasColumnName("credit_limit");
            entity.Property(e => e.Customer)
                .HasComment("Customer")
                .HasColumnName("customer");
            entity.Property(e => e.Date)
                .HasComment("Date")
                .HasColumnName("date");
            entity.Property(e => e.Devotee)
                .HasComment("Devotee")
                .HasColumnName("devotee");
            entity.Property(e => e.DevoteeCode)
                .HasComment("Devotee Code")
                .HasColumnType("character varying")
                .HasColumnName("devotee_code");
            entity.Property(e => e.DevoteeId)
                .HasComment("Devotee")
                .HasColumnName("devotee_id");
            entity.Property(e => e.DisplayName)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("display_name");
            entity.Property(e => e.Ean13)
                .HasMaxLength(13)
                .HasComment("EAN13")
                .HasColumnName("ean13");
            entity.Property(e => e.Email)
                .HasComment("Email")
                .HasColumnType("character varying")
                .HasColumnName("email");
            entity.Property(e => e.Employee)
                .HasComment("Employee")
                .HasColumnName("employee");
            entity.Property(e => e.Fax)
                .HasComment("Fax")
                .HasColumnType("character varying")
                .HasColumnName("fax");
            entity.Property(e => e.Function)
                .HasComment("Job Position")
                .HasColumnType("character varying")
                .HasColumnName("function");
            entity.Property(e => e.Image)
                .HasComment("Image")
                .HasColumnName("image");
            entity.Property(e => e.ImageMedium)
                .HasComment("Medium-sized image")
                .HasColumnName("image_medium");
            entity.Property(e => e.ImageSmall)
                .HasComment("Small-sized image")
                .HasColumnName("image_small");
            entity.Property(e => e.IsCompany)
                .HasComment("Is a Company")
                .HasColumnName("is_company");
            entity.Property(e => e.Lang)
                .HasComment("Language")
                .HasColumnType("character varying")
                .HasColumnName("lang");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.Mobile)
                .HasComment("Mobile")
                .HasColumnType("character varying")
                .HasColumnName("mobile");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NotifyEmail)
                .HasComment("Receive Inbox Notifications by Email")
                .HasColumnType("character varying")
                .HasColumnName("notify_email");
            entity.Property(e => e.OptOut)
                .HasComment("Opt-Out")
                .HasColumnName("opt_out");
            entity.Property(e => e.ParentId)
                .HasComment("Related Company")
                .HasColumnName("parent_id");
            entity.Property(e => e.Phone)
                .HasComment("Phone")
                .HasColumnType("character varying")
                .HasColumnName("phone");
            entity.Property(e => e.Ref)
                .HasComment("Contact Reference")
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.SectionId)
                .HasComment("Sales Team")
                .HasColumnName("section_id");
            entity.Property(e => e.SignupExpiration)
                .HasComment("Signup Expiration")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("signup_expiration");
            entity.Property(e => e.SignupToken)
                .HasComment("Signup Token")
                .HasColumnType("character varying")
                .HasColumnName("signup_token");
            entity.Property(e => e.SignupType)
                .HasComment("Signup Token Type")
                .HasColumnType("character varying")
                .HasColumnName("signup_type");
            entity.Property(e => e.StateId)
                .HasComment("State")
                .HasColumnName("state_id");
            entity.Property(e => e.Street)
                .HasComment("Street")
                .HasColumnType("character varying")
                .HasColumnName("street");
            entity.Property(e => e.Street2)
                .HasComment("Street2")
                .HasColumnType("character varying")
                .HasColumnName("street2");
            entity.Property(e => e.Supplier)
                .HasComment("Supplier")
                .HasColumnName("supplier");
            entity.Property(e => e.Title)
                .HasComment("Title")
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasComment("Address Type")
                .HasColumnType("character varying")
                .HasColumnName("type");
            entity.Property(e => e.Tz)
                .HasMaxLength(64)
                .HasComment("Timezone")
                .HasColumnName("tz");
            entity.Property(e => e.UseParentAddress)
                .HasComment("Use Company Address")
                .HasColumnName("use_parent_address");
            entity.Property(e => e.UserId)
                .HasComment("Salesperson")
                .HasColumnName("user_id");
            entity.Property(e => e.Vat)
                .HasComment("TIN")
                .HasColumnType("character varying")
                .HasColumnName("vat");
            entity.Property(e => e.Website)
                .HasComment("Website")
                .HasColumnType("character varying")
                .HasColumnName("website");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");
            entity.Property(e => e.Zip)
                .HasMaxLength(24)
                .HasComment("Zip")
                .HasColumnName("zip");

            entity.HasOne(d => d.CommercialPartner).WithMany(p => p.InverseCommercialPartner)
                .HasForeignKey(d => d.CommercialPartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_commercial_partner_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResPartners)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_company_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.ResPartners)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_partner_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_create_uid_fkey");

            entity.HasOne(d => d.DevoteeNavigation).WithMany(p => p.ResPartners)
                .HasForeignKey(d => d.DevoteeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_devotee_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_parent_id_fkey");

            entity.HasOne(d => d.Section).WithMany(p => p.ResPartners)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_section_id_fkey");

            entity.HasOne(d => d.State).WithMany(p => p.ResPartners)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_partner_state_id_fkey");

            entity.HasOne(d => d.TitleNavigation).WithMany(p => p.ResPartners)
                .HasForeignKey(d => d.Title)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_title_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ResPartnerUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerBank>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_bank_pkey");

            entity.ToTable("res_partner_bank", tb => tb.HasComment("Bank Accounts"));

            entity.HasIndex(e => e.PartnerId, "res_partner_bank_partner_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccNumber)
                .HasMaxLength(64)
                .HasComment("Account Number")
                .HasColumnName("acc_number");
            entity.Property(e => e.Bank)
                .HasComment("Bank")
                .HasColumnName("bank");
            entity.Property(e => e.BankBic)
                .HasMaxLength(16)
                .HasComment("Bank Identifier Code")
                .HasColumnName("bank_bic");
            entity.Property(e => e.BankName)
                .HasComment("Bank Name")
                .HasColumnType("character varying")
                .HasColumnName("bank_name");
            entity.Property(e => e.City)
                .HasComment("City")
                .HasColumnType("character varying")
                .HasColumnName("city");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CountryId)
                .HasComment("Country")
                .HasColumnName("country_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Footer)
                .HasComment("Display on Reports")
                .HasColumnName("footer");
            entity.Property(e => e.Name)
                .HasComment("Bank Account")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OwnerName)
                .HasComment("Account Owner Name")
                .HasColumnType("character varying")
                .HasColumnName("owner_name");
            entity.Property(e => e.PartnerId)
                .HasComment("Account Owner")
                .HasColumnName("partner_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.State)
                .HasComment("Bank Account Type")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.StateId)
                .HasComment("Fed. State")
                .HasColumnName("state_id");
            entity.Property(e => e.Street)
                .HasComment("Street")
                .HasColumnType("character varying")
                .HasColumnName("street");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");
            entity.Property(e => e.Zip)
                .HasMaxLength(24)
                .HasComment("Zip")
                .HasColumnName("zip");

            entity.HasOne(d => d.BankNavigation).WithMany(p => p.ResPartnerBanks)
                .HasForeignKey(d => d.Bank)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_bank_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResPartnerBanks)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_partner_bank_company_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.ResPartnerBanks)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_country_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerBankCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_create_uid_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResPartnerBanks)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_partner_bank_partner_id_fkey");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.ResPartnerBanks)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_state_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerBankWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerBankType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_bank_type_pkey");

            entity.ToTable("res_partner_bank_type", tb => tb.HasComment("Bank Account Type"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .HasComment("Code")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FormatLayout)
                .HasComment("Format Layout")
                .HasColumnName("format_layout");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerBankTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_type_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerBankTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_type_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerBankTypeField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_bank_type_field_pkey");

            entity.ToTable("res_partner_bank_type_field", tb => tb.HasComment("Bank type fields"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BankTypeId)
                .HasComment("Bank Type")
                .HasColumnName("bank_type_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Field Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Readonly)
                .HasComment("Readonly")
                .HasColumnName("readonly");
            entity.Property(e => e.Required)
                .HasComment("Required")
                .HasColumnName("required");
            entity.Property(e => e.Size)
                .HasComment("Max. Size")
                .HasColumnName("size");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.BankType).WithMany(p => p.ResPartnerBankTypeFields)
                .HasForeignKey(d => d.BankTypeId)
                .HasConstraintName("res_partner_bank_type_field_bank_type_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerBankTypeFieldCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_type_field_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerBankTypeFieldWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_bank_type_field_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_category_pkey");

            entity.ToTable("res_partner_category", tb => tb.HasComment("Partner Tags"));

            entity.HasIndex(e => e.ParentId, "res_partner_category_parent_id_index");

            entity.HasIndex(e => e.ParentLeft, "res_partner_category_parent_left_index");

            entity.HasIndex(e => e.ParentRight, "res_partner_category_parent_right_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Category Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Category")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentLeft).HasColumnName("parent_left");
            entity.Property(e => e.ParentRight).HasColumnName("parent_right");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerCategoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_category_create_uid_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("res_partner_category_parent_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerCategoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_category_write_uid_fkey");
        });

        modelBuilder.Entity<ResPartnerResPartnerCategoryRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("res_partner_res_partner_category_rel", tb => tb.HasComment("RELATION BETWEEN res_partner_category AND res_partner"));

            entity.HasIndex(e => e.CategoryId, "res_partner_res_partner_category_rel_category_id_index");

            entity.HasIndex(e => new { e.CategoryId, e.PartnerId }, "res_partner_res_partner_category_rel_category_id_partner_id_key").IsUnique();

            entity.HasIndex(e => e.PartnerId, "res_partner_res_partner_category_rel_partner_id_index");

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");

            entity.HasOne(d => d.Category).WithMany()
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("res_partner_res_partner_category_rel_category_id_fkey");

            entity.HasOne(d => d.Partner).WithMany()
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("res_partner_res_partner_category_rel_partner_id_fkey");
        });

        modelBuilder.Entity<ResPartnerTitle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_partner_title_pkey");

            entity.ToTable("res_partner_title", tb => tb.HasComment("res.partner.title"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Domain)
                .HasComment("Domain")
                .HasColumnType("character varying")
                .HasColumnName("domain");
            entity.Property(e => e.Name)
                .HasComment("Title")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Shortcut)
                .HasComment("Abbreviation")
                .HasColumnType("character varying")
                .HasColumnName("shortcut");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResPartnerTitleCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_title_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResPartnerTitleWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_partner_title_write_uid_fkey");
        });

        modelBuilder.Entity<ResRequestLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_request_link_pkey");

            entity.ToTable("res_request_link", tb => tb.HasComment("res.request.link"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Object)
                .HasComment("Object")
                .HasColumnType("character varying")
                .HasColumnName("object");
            entity.Property(e => e.Priority)
                .HasComment("Priority")
                .HasColumnName("priority");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResRequestLinkCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_request_link_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResRequestLinkWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_request_link_write_uid_fkey");
        });

        modelBuilder.Entity<ResUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("res_users_pkey");

            entity.ToTable("res_users");

            entity.HasIndex(e => e.LoginDate, "res_users_login_date_index");

            entity.HasIndex(e => e.Login, "res_users_login_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActionId)
                .HasComment("Home Action")
                .HasColumnName("action_id");
            entity.Property(e => e.Active)
                .HasDefaultValue(true)
                .HasColumnName("active");
            entity.Property(e => e.AliasId)
                .HasComment("Alias")
                .HasColumnName("alias_id");
            entity.Property(e => e.CompanyId).HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DefaultSectionId)
                .HasComment("Default Sales Team")
                .HasColumnName("default_section_id");
            entity.Property(e => e.DisplayEmployeesSuggestions)
                .HasComment("Display Employees Suggestions")
                .HasColumnName("display_employees_suggestions");
            entity.Property(e => e.DisplayGroupsSuggestions)
                .HasComment("Display Groups Suggestions")
                .HasColumnName("display_groups_suggestions");
            entity.Property(e => e.Login)
                .HasMaxLength(64)
                .HasColumnName("login");
            entity.Property(e => e.LoginDate)
                .HasComment("Latest connection")
                .HasColumnName("login_date");
            entity.Property(e => e.PartnerId).HasColumnName("partner_id");
            entity.Property(e => e.Password)
                .HasColumnType("character varying")
                .HasColumnName("password");
            entity.Property(e => e.PasswordCrypt)
                .HasComment("Encrypted Password")
                .HasColumnType("character varying")
                .HasColumnName("password_crypt");
            entity.Property(e => e.Share)
                .HasComment("Share User")
                .HasColumnName("share");
            entity.Property(e => e.Signature)
                .HasComment("Signature")
                .HasColumnName("signature");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Alias).WithMany(p => p.ResUsers)
                .HasForeignKey(d => d.AliasId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_users_alias_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResUsers)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.InverseCreateU)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_create_uid_fkey");

            entity.HasOne(d => d.DefaultSection).WithMany(p => p.ResUsers)
                .HasForeignKey(d => d.DefaultSectionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_default_section_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.ResUsers)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("res_users_partner_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.InverseWriteU)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("res_users_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceCalendar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_calendar_pkey");

            entity.ToTable("resource_calendar", tb => tb.HasComment("Resource Calendar"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Manager)
                .HasComment("Workgroup Manager")
                .HasColumnName("manager");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.ResourceCalendars)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceCalendarCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_create_uid_fkey");

            entity.HasOne(d => d.ManagerNavigation).WithMany(p => p.ResourceCalendarManagerNavigations)
                .HasForeignKey(d => d.Manager)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_manager_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceCalendarWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceCalendarAttendance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_calendar_attendance_pkey");

            entity.ToTable("resource_calendar_attendance", tb => tb.HasComment("Work Detail"));

            entity.HasIndex(e => e.Dayofweek, "resource_calendar_attendance_dayofweek_index");

            entity.HasIndex(e => e.HourFrom, "resource_calendar_attendance_hour_from_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalendarId)
                .HasComment("Resource's Calendar")
                .HasColumnName("calendar_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateFrom)
                .HasComment("Starting Date")
                .HasColumnName("date_from");
            entity.Property(e => e.Dayofweek)
                .HasComment("Day of Week")
                .HasColumnType("character varying")
                .HasColumnName("dayofweek");
            entity.Property(e => e.HourFrom)
                .HasComment("Work from")
                .HasColumnName("hour_from");
            entity.Property(e => e.HourTo)
                .HasComment("Work to")
                .HasColumnName("hour_to");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Calendar).WithMany(p => p.ResourceCalendarAttendances)
                .HasForeignKey(d => d.CalendarId)
                .HasConstraintName("resource_calendar_attendance_calendar_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceCalendarAttendanceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_attendance_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceCalendarAttendanceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_attendance_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceCalendarLeaf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_calendar_leaves_pkey");

            entity.ToTable("resource_calendar_leaves", tb => tb.HasComment("Leave Detail"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalendarId)
                .HasComment("Working Time")
                .HasColumnName("calendar_id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateFrom)
                .HasComment("Start Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_from");
            entity.Property(e => e.DateTo)
                .HasComment("End Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_to");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ResourceId)
                .HasComment("Resource")
                .HasColumnName("resource_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Calendar).WithMany(p => p.ResourceCalendarLeaves)
                .HasForeignKey(d => d.CalendarId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_calendar_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResourceCalendarLeaves)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceCalendarLeafCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_create_uid_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.ResourceCalendarLeaves)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_resource_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceCalendarLeafWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_calendar_leaves_write_uid_fkey");
        });

        modelBuilder.Entity<ResourceResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("resource_resource_pkey");

            entity.ToTable("resource_resource", tb => tb.HasComment("Resource Detail"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CalendarId)
                .HasComment("Working Time")
                .HasColumnName("calendar_id");
            entity.Property(e => e.Code)
                .HasMaxLength(16)
                .HasComment("Code")
                .HasColumnName("code");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ResourceType)
                .HasComment("Resource Type")
                .HasColumnType("character varying")
                .HasColumnName("resource_type");
            entity.Property(e => e.TimeEfficiency)
                .HasComment("Efficiency Factor")
                .HasColumnName("time_efficiency");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Calendar).WithMany(p => p.ResourceResources)
                .HasForeignKey(d => d.CalendarId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_calendar_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.ResourceResources)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ResourceResourceCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_create_uid_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ResourceResourceUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ResourceResourceWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("resource_resource_write_uid_fkey");
        });

        modelBuilder.Entity<RoomReservationSummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("room_reservation_summary_pkey");

            entity.ToTable("room_reservation_summary", tb => tb.HasComment("Room reservation summary"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DateFrom)
                .HasComment("Date From")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_from");
            entity.Property(e => e.DateTo)
                .HasComment("Date To")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_to");
            entity.Property(e => e.RoomSummary)
                .HasComment("Room Summary")
                .HasColumnName("room_summary");
            entity.Property(e => e.SummaryHeader)
                .HasComment("Summary Header")
                .HasColumnName("summary_header");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.RoomReservationSummaryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("room_reservation_summary_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.RoomReservationSummaryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("room_reservation_summary_write_uid_fkey");
        });

        modelBuilder.Entity<RuleGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rule_group_rel", tb => tb.HasComment("RELATION BETWEEN ir_rule AND res_groups"));

            entity.HasIndex(e => e.GroupId, "rule_group_rel_group_id_index");

            entity.HasIndex(e => new { e.RuleGroupId, e.GroupId }, "rule_group_rel_rule_group_id_group_id_key").IsUnique();

            entity.HasIndex(e => e.RuleGroupId, "rule_group_rel_rule_group_id_index");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.RuleGroupId).HasColumnName("rule_group_id");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("rule_group_rel_group_id_fkey");

            entity.HasOne(d => d.RuleGroup).WithMany()
                .HasForeignKey(d => d.RuleGroupId)
                .HasConstraintName("rule_group_rel_rule_group_id_fkey");
        });

        modelBuilder.Entity<SaleConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sale_config_settings_pkey");

            entity.ToTable("sale_config_settings", tb => tb.HasComment("sale.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.GroupMultiSalesteams)
                .HasComment("Organize Sales activities into multiple Sales Teams")
                .HasColumnName("group_multi_salesteams");
            entity.Property(e => e.ModuleCrm)
                .HasComment("CRM")
                .HasColumnName("module_crm");
            entity.Property(e => e.ModuleMassMailing)
                .HasComment("Manage mass mailing campaigns")
                .HasColumnName("module_mass_mailing");
            entity.Property(e => e.ModuleSale)
                .HasComment("SALE")
                .HasColumnName("module_sale");
            entity.Property(e => e.ModuleWebLinkedin)
                .HasComment("Get contacts automatically from linkedIn")
                .HasColumnName("module_web_linkedin");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.SaleConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_config_settings_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.SaleConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("sale_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<SaleMemberRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("sale_member_rel", tb => tb.HasComment("RELATION BETWEEN crm_case_section AND res_users"));

            entity.HasIndex(e => e.MemberId, "sale_member_rel_member_id_index");

            entity.HasIndex(e => e.SectionId, "sale_member_rel_section_id_index");

            entity.HasIndex(e => new { e.SectionId, e.MemberId }, "sale_member_rel_section_id_member_id_key").IsUnique();

            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.SectionId).HasColumnName("section_id");

            entity.HasOne(d => d.Member).WithMany()
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("sale_member_rel_member_id_fkey");

            entity.HasOne(d => d.Section).WithMany()
                .HasForeignKey(d => d.SectionId)
                .HasConstraintName("sale_member_rel_section_id_fkey");
        });

        modelBuilder.Entity<ShareWizard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("share_wizard_pkey");

            entity.ToTable("share_wizard", tb => tb.HasComment("Share Wizard"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccessMode)
                .HasComment("Access Mode")
                .HasColumnType("character varying")
                .HasColumnName("access_mode");
            entity.Property(e => e.ActionId)
                .HasComment("Action to share")
                .HasColumnName("action_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Domain)
                .HasComment("Domain")
                .HasColumnType("character varying")
                .HasColumnName("domain");
            entity.Property(e => e.Email1)
                .HasMaxLength(64)
                .HasComment("New user email")
                .HasColumnName("email_1");
            entity.Property(e => e.Email2)
                .HasMaxLength(64)
                .HasComment("New user email")
                .HasColumnName("email_2");
            entity.Property(e => e.Email3)
                .HasMaxLength(64)
                .HasComment("New user email")
                .HasColumnName("email_3");
            entity.Property(e => e.EmbedOptionSearch)
                .HasComment("Display search view")
                .HasColumnName("embed_option_search");
            entity.Property(e => e.EmbedOptionTitle)
                .HasComment("Display title")
                .HasColumnName("embed_option_title");
            entity.Property(e => e.Invite)
                .HasComment("Invite users to OpenSocial record")
                .HasColumnName("invite");
            entity.Property(e => e.Message)
                .HasComment("Personal Message")
                .HasColumnName("message");
            entity.Property(e => e.Name)
                .HasComment("Share Title")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.NewUsers)
                .HasComment("Emails")
                .HasColumnName("new_users");
            entity.Property(e => e.RecordName)
                .HasComment("Record name")
                .HasColumnType("character varying")
                .HasColumnName("record_name");
            entity.Property(e => e.UserType)
                .HasComment("Sharing method")
                .HasColumnType("character varying")
                .HasColumnName("user_type");
            entity.Property(e => e.ViewType)
                .HasComment("Current View Type")
                .HasColumnType("character varying")
                .HasColumnName("view_type");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Action).WithMany(p => p.ShareWizards)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("share_wizard_action_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ShareWizardCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("share_wizard_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ShareWizardWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("share_wizard_write_uid_fkey");
        });

        modelBuilder.Entity<ShareWizardResGroupRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("share_wizard_res_group_rel", tb => tb.HasComment("RELATION BETWEEN share_wizard AND res_groups"));

            entity.HasIndex(e => e.GroupId, "share_wizard_res_group_rel_group_id_index");

            entity.HasIndex(e => new { e.ShareId, e.GroupId }, "share_wizard_res_group_rel_share_id_group_id_key").IsUnique();

            entity.HasIndex(e => e.ShareId, "share_wizard_res_group_rel_share_id_index");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity.Property(e => e.ShareId).HasColumnName("share_id");

            entity.HasOne(d => d.Group).WithMany()
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("share_wizard_res_group_rel_group_id_fkey");

            entity.HasOne(d => d.Share).WithMany()
                .HasForeignKey(d => d.ShareId)
                .HasConstraintName("share_wizard_res_group_rel_share_id_fkey");
        });

        modelBuilder.Entity<ShareWizardResUserRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("share_wizard_res_user_rel", tb => tb.HasComment("RELATION BETWEEN share_wizard AND res_users"));

            entity.HasIndex(e => e.ShareId, "share_wizard_res_user_rel_share_id_index");

            entity.HasIndex(e => new { e.ShareId, e.UserId }, "share_wizard_res_user_rel_share_id_user_id_key").IsUnique();

            entity.HasIndex(e => e.UserId, "share_wizard_res_user_rel_user_id_index");

            entity.Property(e => e.ShareId).HasColumnName("share_id");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Share).WithMany()
                .HasForeignKey(d => d.ShareId)
                .HasConstraintName("share_wizard_res_user_rel_share_id_fkey");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("share_wizard_res_user_rel_user_id_fkey");
        });

        modelBuilder.Entity<ShareWizardResultLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("share_wizard_result_line_pkey");

            entity.ToTable("share_wizard_result_line", tb => tb.HasComment("share.wizard.result.line"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.NewlyCreated)
                .HasComment("Newly created")
                .HasColumnName("newly_created");
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .HasComment("Password")
                .HasColumnName("password");
            entity.Property(e => e.ShareWizardId)
                .HasComment("Share Wizard")
                .HasColumnName("share_wizard_id");
            entity.Property(e => e.UserId)
                .HasComment("unknown")
                .HasColumnName("user_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.ShareWizardResultLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("share_wizard_result_line_create_uid_fkey");

            entity.HasOne(d => d.ShareWizard).WithMany(p => p.ShareWizardResultLines)
                .HasForeignKey(d => d.ShareWizardId)
                .HasConstraintName("share_wizard_result_line_share_wizard_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.ShareWizardResultLineUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("share_wizard_result_line_user_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.ShareWizardResultLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("share_wizard_result_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockChangeProductQty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_change_product_qty_pkey");

            entity.ToTable("stock_change_product_qty", tb => tb.HasComment("Change Product Quantity"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.LocationId)
                .HasComment("Location")
                .HasColumnName("location_id");
            entity.Property(e => e.LotId)
                .HasComment("Serial Number")
                .HasColumnName("lot_id");
            entity.Property(e => e.NewQuantity)
                .HasComment("New Quantity on Hand")
                .HasColumnName("new_quantity");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockChangeProductQtyCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockChangeProductQties)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockChangeProductQties)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_lot_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockChangeProductQties)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockChangeProductQtyWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_change_product_qty_write_uid_fkey");
        });

        modelBuilder.Entity<StockConfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_config_settings_pkey");

            entity.ToTable("stock_config_settings", tb => tb.HasComment("stock.config.settings"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DecimalPrecision)
                .HasComment("Decimal precision on weight")
                .HasColumnName("decimal_precision");
            entity.Property(e => e.GroupStockAdvLocation)
                .HasComment("Manage advanced routes for your warehouse")
                .HasColumnName("group_stock_adv_location");
            entity.Property(e => e.GroupStockMultipleLocations)
                .HasComment("Manage multiple locations and warehouses")
                .HasColumnName("group_stock_multiple_locations");
            entity.Property(e => e.GroupStockPackaging)
                .HasComment("Allow to define several packaging methods on products")
                .HasColumnName("group_stock_packaging");
            entity.Property(e => e.GroupStockProductionLot)
                .HasComment("Track lots or serial numbers")
                .HasColumnName("group_stock_production_lot");
            entity.Property(e => e.GroupStockTrackingLot)
                .HasComment("Use packages: pallets, boxes, ...")
                .HasColumnName("group_stock_tracking_lot");
            entity.Property(e => e.GroupStockTrackingOwner)
                .HasComment("Manage owner on stock")
                .HasColumnName("group_stock_tracking_owner");
            entity.Property(e => e.GroupUom)
                .HasComment("Manage different units of measure for products")
                .HasColumnName("group_uom");
            entity.Property(e => e.GroupUos)
                .HasComment("Store products in a different unit of measure than the sales order")
                .HasColumnName("group_uos");
            entity.Property(e => e.ModuleClaimFromDelivery)
                .HasComment("Allow claim on deliveries")
                .HasColumnName("module_claim_from_delivery");
            entity.Property(e => e.ModuleProcurementJit)
                .HasComment("Generate procurement in real time")
                .HasColumnName("module_procurement_jit");
            entity.Property(e => e.ModuleProductExpiry)
                .HasComment("Expiry date on serial numbers")
                .HasColumnName("module_product_expiry");
            entity.Property(e => e.ModuleStockDropshipping)
                .HasComment("Manage dropshipping")
                .HasColumnName("module_stock_dropshipping");
            entity.Property(e => e.ModuleStockPickingWave)
                .HasComment("Manage picking wave")
                .HasColumnName("module_stock_picking_wave");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockConfigSettings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_config_settings_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockConfigSettingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_config_settings_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockConfigSettingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_config_settings_write_uid_fkey");
        });

        modelBuilder.Entity<StockFixedPutawayStrat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_fixed_putaway_strat_pkey");

            entity.ToTable("stock_fixed_putaway_strat", tb => tb.HasComment("stock.fixed.putaway.strat"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasComment("Product Category")
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FixedLocationId)
                .HasComment("Location")
                .HasColumnName("fixed_location_id");
            entity.Property(e => e.PutawayId)
                .HasComment("Put Away Method")
                .HasColumnName("putaway_id");
            entity.Property(e => e.Sequence)
                .HasComment("Priority")
                .HasColumnName("sequence");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Category).WithMany(p => p.StockFixedPutawayStrats)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_fixed_putaway_strat_category_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockFixedPutawayStratCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_fixed_putaway_strat_create_uid_fkey");

            entity.HasOne(d => d.FixedLocation).WithMany(p => p.StockFixedPutawayStrats)
                .HasForeignKey(d => d.FixedLocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_fixed_putaway_strat_fixed_location_id_fkey");

            entity.HasOne(d => d.Putaway).WithMany(p => p.StockFixedPutawayStrats)
                .HasForeignKey(d => d.PutawayId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_fixed_putaway_strat_putaway_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockFixedPutawayStratWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_fixed_putaway_strat_write_uid_fkey");
        });

        modelBuilder.Entity<StockIncoterm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_incoterms_pkey");

            entity.ToTable("stock_incoterms", tb => tb.HasComment("Incoterms"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Code)
                .HasMaxLength(3)
                .HasComment("Code")
                .HasColumnName("code");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockIncotermCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_incoterms_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockIncotermWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_incoterms_write_uid_fkey");
        });

        modelBuilder.Entity<StockInventory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_inventory_pkey");

            entity.ToTable("stock_inventory", tb => tb.HasComment("Inventory"));

            entity.HasIndex(e => e.CompanyId, "stock_inventory_company_id_index");

            entity.HasIndex(e => e.State, "stock_inventory_state_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Inventory Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.Filter)
                .HasComment("Inventory of")
                .HasColumnType("character varying")
                .HasColumnName("filter");
            entity.Property(e => e.LocationId)
                .HasComment("Inventoried Location")
                .HasColumnName("location_id");
            entity.Property(e => e.LotId)
                .HasComment("Inventoried Lot/Serial Number")
                .HasColumnName("lot_id");
            entity.Property(e => e.Name)
                .HasComment("Inventory Reference")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PackageId)
                .HasComment("Inventoried Pack")
                .HasColumnName("package_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Inventoried Owner")
                .HasColumnName("partner_id");
            entity.Property(e => e.ProductId)
                .HasComment("Inventoried Product")
                .HasColumnName("product_id");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockInventories)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockInventoryCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockInventories)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockInventories)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_lot_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockInventories)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_package_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockInventories)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_partner_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockInventories)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockInventoryWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_write_uid_fkey");
        });

        modelBuilder.Entity<StockInventoryLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_inventory_line_pkey");

            entity.ToTable("stock_inventory_line", tb => tb.HasComment("Inventory Line"));

            entity.HasIndex(e => e.CompanyId, "stock_inventory_line_company_id_index");

            entity.HasIndex(e => e.InventoryId, "stock_inventory_line_inventory_id_index");

            entity.HasIndex(e => e.LocationId, "stock_inventory_line_location_id_index");

            entity.HasIndex(e => e.PackageId, "stock_inventory_line_package_id_index");

            entity.HasIndex(e => e.ProductId, "stock_inventory_line_product_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.InventoryId)
                .HasComment("Inventory")
                .HasColumnName("inventory_id");
            entity.Property(e => e.LocationId)
                .HasComment("Location")
                .HasColumnName("location_id");
            entity.Property(e => e.LocationName)
                .HasComment("Location Name")
                .HasColumnType("character varying")
                .HasColumnName("location_name");
            entity.Property(e => e.PackageId)
                .HasComment("Pack")
                .HasColumnName("package_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Owner")
                .HasColumnName("partner_id");
            entity.Property(e => e.ProdLotId)
                .HasComment("Serial Number")
                .HasColumnName("prod_lot_id");
            entity.Property(e => e.ProdlotName)
                .HasComment("Serial Number Name")
                .HasColumnType("character varying")
                .HasColumnName("prodlot_name");
            entity.Property(e => e.ProductCode)
                .HasComment("Product Code")
                .HasColumnType("character varying")
                .HasColumnName("product_code");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductName)
                .HasComment("Product Name")
                .HasColumnType("character varying")
                .HasColumnName("product_name");
            entity.Property(e => e.ProductQty)
                .HasComment("Checked Quantity")
                .HasColumnName("product_qty");
            entity.Property(e => e.ProductUomId)
                .HasComment("Product Unit of Measure")
                .HasColumnName("product_uom_id");
            entity.Property(e => e.TheoreticalQty)
                .HasComment("Theoretical Quantity")
                .HasColumnName("theoretical_qty");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockInventoryLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_create_uid_fkey");

            entity.HasOne(d => d.Inventory).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_inventory_line_inventory_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_location_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_package_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_partner_id_fkey");

            entity.HasOne(d => d.ProdLot).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.ProdLotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_prod_lot_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.StockInventoryLines)
                .HasForeignKey(d => d.ProductUomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_product_uom_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockInventoryLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_inventory_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockLocation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_location_pkey");

            entity.ToTable("stock_location", tb => tb.HasComment("Inventory Locations"));

            entity.HasIndex(e => e.CompanyId, "stock_location_company_id_index");

            entity.HasIndex(e => new { e.LocBarcode, e.CompanyId }, "stock_location_loc_barcode_company_uniq").IsUnique();

            entity.HasIndex(e => e.LocationId, "stock_location_location_id_index");

            entity.HasIndex(e => e.ParentLeft, "stock_location_parent_left_index");

            entity.HasIndex(e => e.ParentRight, "stock_location_parent_right_index");

            entity.HasIndex(e => e.Usage, "stock_location_usage_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Comment)
                .HasComment("Additional Information")
                .HasColumnName("comment");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CompleteName)
                .HasComment("Location Name")
                .HasColumnType("character varying")
                .HasColumnName("complete_name");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.LocBarcode)
                .HasComment("Location Barcode")
                .HasColumnType("character varying")
                .HasColumnName("loc_barcode");
            entity.Property(e => e.LocationId)
                .HasComment("Parent Location")
                .HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasComment("Location Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ParentLeft).HasColumnName("parent_left");
            entity.Property(e => e.ParentRight).HasColumnName("parent_right");
            entity.Property(e => e.PartnerId)
                .HasComment("Owner")
                .HasColumnName("partner_id");
            entity.Property(e => e.Posx)
                .HasComment("Corridor (X)")
                .HasColumnName("posx");
            entity.Property(e => e.Posy)
                .HasComment("Shelves (Y)")
                .HasColumnName("posy");
            entity.Property(e => e.Posz)
                .HasComment("Height (Z)")
                .HasColumnName("posz");
            entity.Property(e => e.PutawayStrategyId)
                .HasComment("Put Away Strategy")
                .HasColumnName("putaway_strategy_id");
            entity.Property(e => e.RemovalStrategyId)
                .HasComment("Removal Strategy")
                .HasColumnName("removal_strategy_id");
            entity.Property(e => e.ScrapLocation)
                .HasComment("Is a Scrap Location?")
                .HasColumnName("scrap_location");
            entity.Property(e => e.Usage)
                .HasComment("Location Type")
                .HasColumnType("character varying")
                .HasColumnName("usage");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockLocations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockLocationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.InverseLocation)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_location_location_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockLocations)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_partner_id_fkey");

            entity.HasOne(d => d.PutawayStrategy).WithMany(p => p.StockLocations)
                .HasForeignKey(d => d.PutawayStrategyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_putaway_strategy_id_fkey");

            entity.HasOne(d => d.RemovalStrategy).WithMany(p => p.StockLocations)
                .HasForeignKey(d => d.RemovalStrategyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_removal_strategy_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockLocationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_write_uid_fkey");
        });

        modelBuilder.Entity<StockLocationPath>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_location_path_pkey");

            entity.ToTable("stock_location_path", tb => tb.HasComment("Pushed Flows"));

            entity.HasIndex(e => e.Auto, "stock_location_path_auto_index");

            entity.HasIndex(e => e.LocationDestId, "stock_location_path_location_dest_id_index");

            entity.HasIndex(e => e.LocationFromId, "stock_location_path_location_from_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Auto)
                .HasComment("Automatic Move")
                .HasColumnType("character varying")
                .HasColumnName("auto");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Delay)
                .HasComment("Delay (days)")
                .HasColumnName("delay");
            entity.Property(e => e.LocationDestId)
                .HasComment("Destination Location")
                .HasColumnName("location_dest_id");
            entity.Property(e => e.LocationFromId)
                .HasComment("Source Location")
                .HasColumnName("location_from_id");
            entity.Property(e => e.Name)
                .HasComment("Operation Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.PickingTypeId)
                .HasComment("Type of the new Operation")
                .HasColumnName("picking_type_id");
            entity.Property(e => e.Propagate)
                .HasComment("Propagate cancel and split")
                .HasColumnName("propagate");
            entity.Property(e => e.RouteId)
                .HasComment("Route")
                .HasColumnName("route_id");
            entity.Property(e => e.RouteSequence)
                .HasComment("Route Sequence")
                .HasColumnName("route_sequence");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.WarehouseId)
                .HasComment("Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockLocationPaths)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_path_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockLocationPathCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_path_create_uid_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockLocationPathLocationDests)
                .HasForeignKey(d => d.LocationDestId)
                .HasConstraintName("stock_location_path_location_dest_id_fkey");

            entity.HasOne(d => d.LocationFrom).WithMany(p => p.StockLocationPathLocationFroms)
                .HasForeignKey(d => d.LocationFromId)
                .HasConstraintName("stock_location_path_location_from_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.StockLocationPaths)
                .HasForeignKey(d => d.PickingTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_path_picking_type_id_fkey");

            entity.HasOne(d => d.Route).WithMany(p => p.StockLocationPaths)
                .HasForeignKey(d => d.RouteId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_path_route_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockLocationPaths)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_path_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockLocationPathWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_path_write_uid_fkey");
        });

        modelBuilder.Entity<StockLocationRoute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_location_route_pkey");

            entity.ToTable("stock_location_route", tb => tb.HasComment("Inventory Routes"));

            entity.HasIndex(e => e.CompanyId, "stock_location_route_company_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasComment("Route Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ProductCategSelectable)
                .HasComment("Applicable on Product Category")
                .HasColumnName("product_categ_selectable");
            entity.Property(e => e.ProductSelectable)
                .HasComment("Applicable on Product")
                .HasColumnName("product_selectable");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.SuppliedWhId)
                .HasComment("Supplied Warehouse")
                .HasColumnName("supplied_wh_id");
            entity.Property(e => e.SupplierWhId)
                .HasComment("Supplier Warehouse")
                .HasColumnName("supplier_wh_id");
            entity.Property(e => e.WarehouseSelectable)
                .HasComment("Applicable on Warehouse")
                .HasColumnName("warehouse_selectable");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockLocationRoutes)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_route_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockLocationRouteCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_route_create_uid_fkey");

            entity.HasOne(d => d.SuppliedWh).WithMany(p => p.StockLocationRouteSuppliedWhs)
                .HasForeignKey(d => d.SuppliedWhId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_route_supplied_wh_id_fkey");

            entity.HasOne(d => d.SupplierWh).WithMany(p => p.StockLocationRouteSupplierWhs)
                .HasForeignKey(d => d.SupplierWhId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_route_supplier_wh_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockLocationRouteWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_location_route_write_uid_fkey");
        });

        modelBuilder.Entity<StockLocationRouteCateg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_location_route_categ", tb => tb.HasComment("RELATION BETWEEN product_category AND stock_location_route"));

            entity.HasIndex(e => e.CategId, "stock_location_route_categ_categ_id_index");

            entity.HasIndex(e => new { e.CategId, e.RouteId }, "stock_location_route_categ_categ_id_route_id_key").IsUnique();

            entity.HasIndex(e => e.RouteId, "stock_location_route_categ_route_id_index");

            entity.Property(e => e.CategId).HasColumnName("categ_id");
            entity.Property(e => e.RouteId).HasColumnName("route_id");

            entity.HasOne(d => d.Categ).WithMany()
                .HasForeignKey(d => d.CategId)
                .HasConstraintName("stock_location_route_categ_categ_id_fkey");

            entity.HasOne(d => d.Route).WithMany()
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("stock_location_route_categ_route_id_fkey");
        });

        modelBuilder.Entity<StockLocationRouteMove>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_location_route_move", tb => tb.HasComment("RELATION BETWEEN stock_move AND stock_location_route"));

            entity.HasIndex(e => e.MoveId, "stock_location_route_move_move_id_index");

            entity.HasIndex(e => new { e.MoveId, e.RouteId }, "stock_location_route_move_move_id_route_id_key").IsUnique();

            entity.HasIndex(e => e.RouteId, "stock_location_route_move_route_id_index");

            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.RouteId).HasColumnName("route_id");

            entity.HasOne(d => d.Move).WithMany()
                .HasForeignKey(d => d.MoveId)
                .HasConstraintName("stock_location_route_move_move_id_fkey");

            entity.HasOne(d => d.Route).WithMany()
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("stock_location_route_move_route_id_fkey");
        });

        modelBuilder.Entity<StockLocationRouteProcurement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_location_route_procurement", tb => tb.HasComment("RELATION BETWEEN procurement_order AND stock_location_route"));

            entity.HasIndex(e => e.ProcurementId, "stock_location_route_procurement_procurement_id_index");

            entity.HasIndex(e => new { e.ProcurementId, e.RouteId }, "stock_location_route_procurement_procurement_id_route_id_key").IsUnique();

            entity.HasIndex(e => e.RouteId, "stock_location_route_procurement_route_id_index");

            entity.Property(e => e.ProcurementId).HasColumnName("procurement_id");
            entity.Property(e => e.RouteId).HasColumnName("route_id");

            entity.HasOne(d => d.Procurement).WithMany()
                .HasForeignKey(d => d.ProcurementId)
                .HasConstraintName("stock_location_route_procurement_procurement_id_fkey");

            entity.HasOne(d => d.Route).WithMany()
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("stock_location_route_procurement_route_id_fkey");
        });

        modelBuilder.Entity<StockMove>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_move_pkey");

            entity.ToTable("stock_move", tb => tb.HasComment("Stock Move"));

            entity.HasIndex(e => e.CompanyId, "stock_move_company_id_index");

            entity.HasIndex(e => e.CreateDate, "stock_move_create_date_index");

            entity.HasIndex(e => e.DateExpected, "stock_move_date_expected_index");

            entity.HasIndex(e => e.Date, "stock_move_date_index");

            entity.HasIndex(e => e.LocationDestId, "stock_move_location_dest_id_index");

            entity.HasIndex(e => e.LocationId, "stock_move_location_id_index");

            entity.HasIndex(e => e.MoveDestId, "stock_move_move_dest_id_index");

            entity.HasIndex(e => e.Name, "stock_move_name_index");

            entity.HasIndex(e => e.PickingId, "stock_move_picking_id_index");

            entity.HasIndex(e => e.ProductId, "stock_move_product_id_index");

            entity.HasIndex(e => new { e.ProductId, e.LocationId, e.LocationDestId, e.CompanyId, e.State }, "stock_move_product_location_index");

            entity.HasIndex(e => e.State, "stock_move_state_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Creation Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.DateExpected)
                .HasComment("Expected Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_expected");
            entity.Property(e => e.GroupId)
                .HasComment("Procurement Group")
                .HasColumnName("group_id");
            entity.Property(e => e.InventoryId)
                .HasComment("Inventory")
                .HasColumnName("inventory_id");
            entity.Property(e => e.LocationDestId)
                .HasComment("Destination Location")
                .HasColumnName("location_dest_id");
            entity.Property(e => e.LocationId)
                .HasComment("Source Location")
                .HasColumnName("location_id");
            entity.Property(e => e.MoveDestId)
                .HasComment("Destination Move")
                .HasColumnName("move_dest_id");
            entity.Property(e => e.Name)
                .HasComment("Description")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasComment("Notes")
                .HasColumnName("note");
            entity.Property(e => e.Origin)
                .HasComment("Source")
                .HasColumnType("character varying")
                .HasColumnName("origin");
            entity.Property(e => e.OriginReturnedMoveId)
                .HasComment("Origin return move")
                .HasColumnName("origin_returned_move_id");
            entity.Property(e => e.PartiallyAvailable)
                .HasComment("Partially Available")
                .HasColumnName("partially_available");
            entity.Property(e => e.PartnerId)
                .HasComment("Destination Address ")
                .HasColumnName("partner_id");
            entity.Property(e => e.PickingId)
                .HasComment("Reference")
                .HasColumnName("picking_id");
            entity.Property(e => e.PickingTypeId)
                .HasComment("Picking Type")
                .HasColumnName("picking_type_id");
            entity.Property(e => e.PriceUnit)
                .HasComment("Unit Price")
                .HasColumnName("price_unit");
            entity.Property(e => e.Priority)
                .HasComment("Priority")
                .HasColumnType("character varying")
                .HasColumnName("priority");
            entity.Property(e => e.ProcureMethod)
                .HasComment("Supply Method")
                .HasColumnType("character varying")
                .HasColumnName("procure_method");
            entity.Property(e => e.ProcurementId)
                .HasComment("Procurement")
                .HasColumnName("procurement_id");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductPackaging)
                .HasComment("Prefered Packaging")
                .HasColumnName("product_packaging");
            entity.Property(e => e.ProductQty)
                .HasComment("Quantity")
                .HasColumnName("product_qty");
            entity.Property(e => e.ProductUom)
                .HasComment("Unit of Measure")
                .HasColumnName("product_uom");
            entity.Property(e => e.ProductUomQty)
                .HasComment("Quantity")
                .HasColumnName("product_uom_qty");
            entity.Property(e => e.ProductUos)
                .HasComment("Product UOS")
                .HasColumnName("product_uos");
            entity.Property(e => e.ProductUosQty)
                .HasComment("Quantity (UOS)")
                .HasColumnName("product_uos_qty");
            entity.Property(e => e.Propagate)
                .HasComment("Propagate cancel and split")
                .HasColumnName("propagate");
            entity.Property(e => e.PushRuleId)
                .HasComment("Push Rule")
                .HasColumnName("push_rule_id");
            entity.Property(e => e.RestrictLotId)
                .HasComment("Lot")
                .HasColumnName("restrict_lot_id");
            entity.Property(e => e.RestrictPartnerId)
                .HasComment("Owner ")
                .HasColumnName("restrict_partner_id");
            entity.Property(e => e.RuleId)
                .HasComment("Procurement Rule")
                .HasColumnName("rule_id");
            entity.Property(e => e.SplitFrom)
                .HasComment("Move Split From")
                .HasColumnName("split_from");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WarehouseId)
                .HasComment("Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockMoveCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_group_id_fkey");

            entity.HasOne(d => d.Inventory).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.InventoryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_inventory_id_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockMoveLocationDests)
                .HasForeignKey(d => d.LocationDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockMoveLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_location_id_fkey");

            entity.HasOne(d => d.MoveDest).WithMany(p => p.InverseMoveDest)
                .HasForeignKey(d => d.MoveDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_move_dest_id_fkey");

            entity.HasOne(d => d.OriginReturnedMove).WithMany(p => p.InverseOriginReturnedMove)
                .HasForeignKey(d => d.OriginReturnedMoveId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_origin_returned_move_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockMovePartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_partner_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.PickingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_picking_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.PickingTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_picking_type_id_fkey");

            entity.HasOne(d => d.Procurement).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.ProcurementId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_procurement_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_product_id_fkey");

            entity.HasOne(d => d.ProductPackagingNavigation).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.ProductPackaging)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_product_packaging_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.StockMoveProductUomNavigations)
                .HasForeignKey(d => d.ProductUom)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_product_uom_fkey");

            entity.HasOne(d => d.ProductUosNavigation).WithMany(p => p.StockMoveProductUosNavigations)
                .HasForeignKey(d => d.ProductUos)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_product_uos_fkey");

            entity.HasOne(d => d.PushRule).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.PushRuleId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_push_rule_id_fkey");

            entity.HasOne(d => d.RestrictLot).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.RestrictLotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_restrict_lot_id_fkey");

            entity.HasOne(d => d.RestrictPartner).WithMany(p => p.StockMoveRestrictPartners)
                .HasForeignKey(d => d.RestrictPartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_restrict_partner_id_fkey");

            entity.HasOne(d => d.Rule).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.RuleId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_rule_id_fkey");

            entity.HasOne(d => d.SplitFromNavigation).WithMany(p => p.InverseSplitFromNavigation)
                .HasForeignKey(d => d.SplitFrom)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_split_from_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockMoves)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockMoveWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_write_uid_fkey");
        });

        modelBuilder.Entity<StockMoveOperationLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_move_operation_link_pkey");

            entity.ToTable("stock_move_operation_link", tb => tb.HasComment("Link between stock moves and pack operations"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MoveId)
                .HasComment("Move")
                .HasColumnName("move_id");
            entity.Property(e => e.OperationId)
                .HasComment("Operation")
                .HasColumnName("operation_id");
            entity.Property(e => e.Qty)
                .HasComment("Quantity")
                .HasColumnName("qty");
            entity.Property(e => e.ReservedQuantId)
                .HasComment("Reserved Quant")
                .HasColumnName("reserved_quant_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockMoveOperationLinkCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_operation_link_create_uid_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.StockMoveOperationLinks)
                .HasForeignKey(d => d.MoveId)
                .HasConstraintName("stock_move_operation_link_move_id_fkey");

            entity.HasOne(d => d.Operation).WithMany(p => p.StockMoveOperationLinks)
                .HasForeignKey(d => d.OperationId)
                .HasConstraintName("stock_move_operation_link_operation_id_fkey");

            entity.HasOne(d => d.ReservedQuant).WithMany(p => p.StockMoveOperationLinks)
                .HasForeignKey(d => d.ReservedQuantId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_operation_link_reserved_quant_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockMoveOperationLinkWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_operation_link_write_uid_fkey");
        });

        modelBuilder.Entity<StockMoveScrap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_move_scrap_pkey");

            entity.ToTable("stock_move_scrap", tb => tb.HasComment("Scrap Products"));

            entity.HasIndex(e => e.ProductId, "stock_move_scrap_product_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.LocationId)
                .HasComment("Location")
                .HasColumnName("location_id");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductQty)
                .HasComment("Quantity")
                .HasColumnName("product_qty");
            entity.Property(e => e.ProductUom)
                .HasComment("Product Unit of Measure")
                .HasColumnName("product_uom");
            entity.Property(e => e.RestrictLotId)
                .HasComment("Lot")
                .HasColumnName("restrict_lot_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockMoveScrapCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_scrap_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockMoveScraps)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_scrap_location_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockMoveScraps)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_scrap_product_id_fkey");

            entity.HasOne(d => d.ProductUomNavigation).WithMany(p => p.StockMoveScraps)
                .HasForeignKey(d => d.ProductUom)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_scrap_product_uom_fkey");

            entity.HasOne(d => d.RestrictLot).WithMany(p => p.StockMoveScraps)
                .HasForeignKey(d => d.RestrictLotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_scrap_restrict_lot_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockMoveScrapWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_move_scrap_write_uid_fkey");
        });

        modelBuilder.Entity<StockPackOperation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_pack_operation_pkey");

            entity.ToTable("stock_pack_operation", tb => tb.HasComment("Packing Operation"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost)
                .HasComment("Cost")
                .HasColumnName("cost");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Currency)
                .HasComment("Currency")
                .HasColumnName("currency");
            entity.Property(e => e.Date)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.LocationDestId)
                .HasComment("Destination Location")
                .HasColumnName("location_dest_id");
            entity.Property(e => e.LocationId)
                .HasComment("Source Location")
                .HasColumnName("location_id");
            entity.Property(e => e.LotId)
                .HasComment("Lot/Serial Number")
                .HasColumnName("lot_id");
            entity.Property(e => e.OwnerId)
                .HasComment("Owner")
                .HasColumnName("owner_id");
            entity.Property(e => e.PackageId)
                .HasComment("Source Package")
                .HasColumnName("package_id");
            entity.Property(e => e.PickingId)
                .HasComment("Stock Picking")
                .HasColumnName("picking_id");
            entity.Property(e => e.Processed)
                .HasComment("Has been processed?")
                .HasColumnType("character varying")
                .HasColumnName("processed");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductQty)
                .HasComment("Quantity")
                .HasColumnName("product_qty");
            entity.Property(e => e.ProductUomId)
                .HasComment("Product Unit of Measure")
                .HasColumnName("product_uom_id");
            entity.Property(e => e.QtyDone)
                .HasComment("Quantity Processed")
                .HasColumnName("qty_done");
            entity.Property(e => e.ResultPackageId)
                .HasComment("Destination Package")
                .HasColumnName("result_package_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPackOperationCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_create_uid_fkey");

            entity.HasOne(d => d.CurrencyNavigation).WithMany(p => p.StockPackOperations)
                .HasForeignKey(d => d.Currency)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_pack_operation_currency_fkey");

            entity.HasOne(d => d.LocationDest).WithMany(p => p.StockPackOperationLocationDests)
                .HasForeignKey(d => d.LocationDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_location_dest_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockPackOperationLocations)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockPackOperations)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_lot_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockPackOperations)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_owner_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockPackOperationPackages)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_package_id_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockPackOperations)
                .HasForeignKey(d => d.PickingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_picking_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockPackOperations)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_pack_operation_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.StockPackOperations)
                .HasForeignKey(d => d.ProductUomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_product_uom_id_fkey");

            entity.HasOne(d => d.ResultPackage).WithMany(p => p.StockPackOperationResultPackages)
                .HasForeignKey(d => d.ResultPackageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_pack_operation_result_package_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPackOperationWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_pack_operation_write_uid_fkey");
        });

        modelBuilder.Entity<StockPicking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_picking_pkey");

            entity.ToTable("stock_picking", tb => tb.HasComment("Picking List"));

            entity.HasIndex(e => e.BackorderId, "stock_picking_backorder_id_index");

            entity.HasIndex(e => e.CompanyId, "stock_picking_company_id_index");

            entity.HasIndex(e => e.Date, "stock_picking_date_index");

            entity.HasIndex(e => e.MaxDate, "stock_picking_max_date_index");

            entity.HasIndex(e => e.MinDate, "stock_picking_min_date_index");

            entity.HasIndex(e => e.Name, "stock_picking_name_index");

            entity.HasIndex(e => new { e.Name, e.CompanyId }, "stock_picking_name_uniq").IsUnique();

            entity.HasIndex(e => e.Origin, "stock_picking_origin_index");

            entity.HasIndex(e => e.Priority, "stock_picking_priority_index");

            entity.HasIndex(e => e.State, "stock_picking_state_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BackorderId)
                .HasComment("Back Order of")
                .HasColumnName("backorder_id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Creation Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.DateDone)
                .HasComment("Date of Transfer")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_done");
            entity.Property(e => e.GroupId)
                .HasComment("Procurement Group")
                .HasColumnName("group_id");
            entity.Property(e => e.MaxDate)
                .HasComment("Max. Expected Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("max_date");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.MinDate)
                .HasComment("Scheduled Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("min_date");
            entity.Property(e => e.MoveType)
                .HasComment("Delivery Method")
                .HasColumnType("character varying")
                .HasColumnName("move_type");
            entity.Property(e => e.Name)
                .HasComment("Reference")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasComment("Notes")
                .HasColumnName("note");
            entity.Property(e => e.Origin)
                .HasComment("Source Document")
                .HasColumnType("character varying")
                .HasColumnName("origin");
            entity.Property(e => e.OwnerId)
                .HasComment("Owner")
                .HasColumnName("owner_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Partner")
                .HasColumnName("partner_id");
            entity.Property(e => e.PickingTypeId)
                .HasComment("Picking Type")
                .HasColumnName("picking_type_id");
            entity.Property(e => e.Priority)
                .HasComment("Priority")
                .HasColumnType("character varying")
                .HasColumnName("priority");
            entity.Property(e => e.RecomputePackOp)
                .HasComment("Recompute pack operation?")
                .HasColumnName("recompute_pack_op");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Backorder).WithMany(p => p.InverseBackorder)
                .HasForeignKey(d => d.BackorderId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_backorder_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.StockPickings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPickingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockPickings)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_group_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockPickingOwners)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_owner_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockPickingPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_partner_id_fkey");

            entity.HasOne(d => d.PickingType).WithMany(p => p.StockPickings)
                .HasForeignKey(d => d.PickingTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_picking_type_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPickingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_write_uid_fkey");
        });

        modelBuilder.Entity<StockPickingType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_picking_type_pkey");

            entity.ToTable("stock_picking_type", tb => tb.HasComment("The picking type determines the picking view"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.Code)
                .HasComment("Type of Operation")
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.Color)
                .HasComment("Color")
                .HasColumnName("color");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DefaultLocationDestId)
                .HasComment("Default Destination Location")
                .HasColumnName("default_location_dest_id");
            entity.Property(e => e.DefaultLocationSrcId)
                .HasComment("Default Source Location")
                .HasColumnName("default_location_src_id");
            entity.Property(e => e.Name)
                .HasComment("Picking Type Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ReturnPickingTypeId)
                .HasComment("Picking Type for Returns")
                .HasColumnName("return_picking_type_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.SequenceId)
                .HasComment("Reference Sequence")
                .HasColumnName("sequence_id");
            entity.Property(e => e.WarehouseId)
                .HasComment("Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockPickingTypeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_create_uid_fkey");

            entity.HasOne(d => d.DefaultLocationDest).WithMany(p => p.StockPickingTypeDefaultLocationDests)
                .HasForeignKey(d => d.DefaultLocationDestId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_default_location_dest_id_fkey");

            entity.HasOne(d => d.DefaultLocationSrc).WithMany(p => p.StockPickingTypeDefaultLocationSrcs)
                .HasForeignKey(d => d.DefaultLocationSrcId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_default_location_src_id_fkey");

            entity.HasOne(d => d.ReturnPickingType).WithMany(p => p.InverseReturnPickingType)
                .HasForeignKey(d => d.ReturnPickingTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_return_picking_type_id_fkey");

            entity.HasOne(d => d.SequenceNavigation).WithMany(p => p.StockPickingTypes)
                .HasForeignKey(d => d.SequenceId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_sequence_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockPickingTypes)
                .HasForeignKey(d => d.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("stock_picking_type_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockPickingTypeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_picking_type_write_uid_fkey");
        });

        modelBuilder.Entity<StockProductionLot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_production_lot_pkey");

            entity.ToTable("stock_production_lot", tb => tb.HasComment("Lot/Serial"));

            entity.HasIndex(e => new { e.Name, e.Ref, e.ProductId }, "stock_production_lot_name_ref_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Creation Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MessageLastPost)
                .HasComment("Last Message Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("message_last_post");
            entity.Property(e => e.Name)
                .HasComment("Serial Number")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.Ref)
                .HasComment("Internal Reference")
                .HasColumnType("character varying")
                .HasColumnName("ref");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockProductionLotCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_production_lot_create_uid_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockProductionLots)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_production_lot_product_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockProductionLotWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_production_lot_write_uid_fkey");
        });

        modelBuilder.Entity<StockQuant>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_quant_pkey");

            entity.ToTable("stock_quant", tb => tb.HasComment("Quants"));

            entity.HasIndex(e => e.CompanyId, "stock_quant_company_id_index");

            entity.HasIndex(e => e.InDate, "stock_quant_in_date_index");

            entity.HasIndex(e => e.LocationId, "stock_quant_location_id_index");

            entity.HasIndex(e => e.LotId, "stock_quant_lot_id_index");

            entity.HasIndex(e => e.OwnerId, "stock_quant_owner_id_index");

            entity.HasIndex(e => e.PackageId, "stock_quant_package_id_index");

            entity.HasIndex(e => e.ProductId, "stock_quant_product_id_index");

            entity.HasIndex(e => new { e.ProductId, e.LocationId, e.CompanyId, e.Qty, e.InDate, e.ReservationId }, "stock_quant_product_location_index");

            entity.HasIndex(e => e.PropagatedFromId, "stock_quant_propagated_from_id_index");

            entity.HasIndex(e => e.Qty, "stock_quant_qty_index");

            entity.HasIndex(e => e.ReservationId, "stock_quant_reservation_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.Cost)
                .HasComment("Unit Cost")
                .HasColumnName("cost");
            entity.Property(e => e.CreateDate)
                .HasComment("Creation Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.InDate)
                .HasComment("Incoming Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("in_date");
            entity.Property(e => e.LocationId)
                .HasComment("Location")
                .HasColumnName("location_id");
            entity.Property(e => e.LotId)
                .HasComment("Lot")
                .HasColumnName("lot_id");
            entity.Property(e => e.NegativeMoveId)
                .HasComment("Move Negative Quant")
                .HasColumnName("negative_move_id");
            entity.Property(e => e.OwnerId)
                .HasComment("Owner")
                .HasColumnName("owner_id");
            entity.Property(e => e.PackageId)
                .HasComment("Package")
                .HasColumnName("package_id");
            entity.Property(e => e.PackagingTypeId)
                .HasComment("Type of packaging")
                .HasColumnName("packaging_type_id");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.PropagatedFromId)
                .HasComment("Linked Quant")
                .HasColumnName("propagated_from_id");
            entity.Property(e => e.Qty)
                .HasComment("Quantity")
                .HasColumnName("qty");
            entity.Property(e => e.ReservationId)
                .HasComment("Reserved for Move")
                .HasColumnName("reservation_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockQuantCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_location_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_lot_id_fkey");

            entity.HasOne(d => d.NegativeMove).WithMany(p => p.StockQuantNegativeMoves)
                .HasForeignKey(d => d.NegativeMoveId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_negative_move_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_owner_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_id_fkey");

            entity.HasOne(d => d.PackagingType).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.PackagingTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_packaging_type_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockQuants)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_product_id_fkey");

            entity.HasOne(d => d.PropagatedFrom).WithMany(p => p.InversePropagatedFrom)
                .HasForeignKey(d => d.PropagatedFromId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_propagated_from_id_fkey");

            entity.HasOne(d => d.Reservation).WithMany(p => p.StockQuantReservations)
                .HasForeignKey(d => d.ReservationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_reservation_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockQuantWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_write_uid_fkey");
        });

        modelBuilder.Entity<StockQuantMoveRel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_quant_move_rel", tb => tb.HasComment("RELATION BETWEEN stock_quant AND stock_move"));

            entity.HasIndex(e => e.MoveId, "stock_quant_move_rel_move_id_index");

            entity.HasIndex(e => e.QuantId, "stock_quant_move_rel_quant_id_index");

            entity.HasIndex(e => new { e.QuantId, e.MoveId }, "stock_quant_move_rel_quant_id_move_id_key").IsUnique();

            entity.Property(e => e.MoveId).HasColumnName("move_id");
            entity.Property(e => e.QuantId).HasColumnName("quant_id");

            entity.HasOne(d => d.Move).WithMany()
                .HasForeignKey(d => d.MoveId)
                .HasConstraintName("stock_quant_move_rel_move_id_fkey");

            entity.HasOne(d => d.Quant).WithMany()
                .HasForeignKey(d => d.QuantId)
                .HasConstraintName("stock_quant_move_rel_quant_id_fkey");
        });

        modelBuilder.Entity<StockQuantPackage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_quant_package_pkey");

            entity.ToTable("stock_quant_package", tb => tb.HasComment("Physical Packages"));

            entity.HasIndex(e => e.CompanyId, "stock_quant_package_company_id_index");

            entity.HasIndex(e => e.LocationId, "stock_quant_package_location_id_index");

            entity.HasIndex(e => e.Name, "stock_quant_package_name_index");

            entity.HasIndex(e => e.OwnerId, "stock_quant_package_owner_id_index");

            entity.HasIndex(e => e.PackagingId, "stock_quant_package_packaging_id_index");

            entity.HasIndex(e => e.ParentLeft, "stock_quant_package_parent_left_index");

            entity.HasIndex(e => e.ParentRight, "stock_quant_package_parent_right_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.LocationId)
                .HasComment("Location")
                .HasColumnName("location_id");
            entity.Property(e => e.Name)
                .HasComment("Package Reference")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OwnerId)
                .HasComment("Owner")
                .HasColumnName("owner_id");
            entity.Property(e => e.PackagingId)
                .HasComment("Packaging")
                .HasColumnName("packaging_id");
            entity.Property(e => e.ParentId)
                .HasComment("Parent Package")
                .HasColumnName("parent_id");
            entity.Property(e => e.ParentLeft).HasColumnName("parent_left");
            entity.Property(e => e.ParentRight).HasColumnName("parent_right");
            entity.Property(e => e.UlId)
                .HasComment("Logistic Unit")
                .HasColumnName("ul_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockQuantPackages)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockQuantPackageCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_create_uid_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockQuantPackages)
                .HasForeignKey(d => d.LocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_location_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockQuantPackages)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_owner_id_fkey");

            entity.HasOne(d => d.Packaging).WithMany(p => p.StockQuantPackages)
                .HasForeignKey(d => d.PackagingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_packaging_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("stock_quant_package_parent_id_fkey");

            entity.HasOne(d => d.Ul).WithMany(p => p.StockQuantPackages)
                .HasForeignKey(d => d.UlId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_ul_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockQuantPackageWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_quant_package_write_uid_fkey");
        });

        modelBuilder.Entity<StockReturnPicking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_return_picking_pkey");

            entity.ToTable("stock_return_picking", tb => tb.HasComment("Return Picking"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MoveDestExists)
                .HasComment("Chained Move Exists")
                .HasColumnName("move_dest_exists");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockReturnPickingCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockReturnPickingWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_write_uid_fkey");
        });

        modelBuilder.Entity<StockReturnPickingLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_return_picking_line_pkey");

            entity.ToTable("stock_return_picking_line", tb => tb.HasComment("stock.return.picking.line"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.LotId)
                .HasComment("Serial Number")
                .HasColumnName("lot_id");
            entity.Property(e => e.MoveId)
                .HasComment("Move")
                .HasColumnName("move_id");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.Quantity)
                .HasComment("Quantity")
                .HasColumnName("quantity");
            entity.Property(e => e.WizardId)
                .HasComment("Wizard")
                .HasColumnName("wizard_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockReturnPickingLineCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_create_uid_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockReturnPickingLines)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_lot_id_fkey");

            entity.HasOne(d => d.Move).WithMany(p => p.StockReturnPickingLines)
                .HasForeignKey(d => d.MoveId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_move_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockReturnPickingLines)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_product_id_fkey");

            entity.HasOne(d => d.Wizard).WithMany(p => p.StockReturnPickingLines)
                .HasForeignKey(d => d.WizardId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_wizard_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockReturnPickingLineWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_return_picking_line_write_uid_fkey");
        });

        modelBuilder.Entity<StockRouteProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_route_product", tb => tb.HasComment("RELATION BETWEEN product_template AND stock_location_route"));

            entity.HasIndex(e => e.ProductId, "stock_route_product_product_id_index");

            entity.HasIndex(e => new { e.ProductId, e.RouteId }, "stock_route_product_product_id_route_id_key").IsUnique();

            entity.HasIndex(e => e.RouteId, "stock_route_product_route_id_index");

            entity.Property(e => e.ProductId).HasColumnName("product_id");
            entity.Property(e => e.RouteId).HasColumnName("route_id");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("stock_route_product_product_id_fkey");

            entity.HasOne(d => d.Route).WithMany()
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("stock_route_product_route_id_fkey");
        });

        modelBuilder.Entity<StockRouteWarehouse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_route_warehouse", tb => tb.HasComment("RELATION BETWEEN stock_warehouse AND stock_location_route"));

            entity.HasIndex(e => e.RouteId, "stock_route_warehouse_route_id_index");

            entity.HasIndex(e => e.WarehouseId, "stock_route_warehouse_warehouse_id_index");

            entity.HasIndex(e => new { e.WarehouseId, e.RouteId }, "stock_route_warehouse_warehouse_id_route_id_key").IsUnique();

            entity.Property(e => e.RouteId).HasColumnName("route_id");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

            entity.HasOne(d => d.Route).WithMany()
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("stock_route_warehouse_route_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany()
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("stock_route_warehouse_warehouse_id_fkey");
        });

        modelBuilder.Entity<StockTransferDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_transfer_details_pkey");

            entity.ToTable("stock_transfer_details", tb => tb.HasComment("Picking wizard"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.PickingId)
                .HasComment("Picking")
                .HasColumnName("picking_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockTransferDetailCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_create_uid_fkey");

            entity.HasOne(d => d.Picking).WithMany(p => p.StockTransferDetails)
                .HasForeignKey(d => d.PickingId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_picking_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockTransferDetailWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_write_uid_fkey");
        });

        modelBuilder.Entity<StockTransferDetailsItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_transfer_details_items_pkey");

            entity.ToTable("stock_transfer_details_items", tb => tb.HasComment("Picking wizard items"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Date)
                .HasComment("Date")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date");
            entity.Property(e => e.DestinationlocId)
                .HasComment("Destination Location")
                .HasColumnName("destinationloc_id");
            entity.Property(e => e.LotId)
                .HasComment("Lot/Serial Number")
                .HasColumnName("lot_id");
            entity.Property(e => e.OwnerId)
                .HasComment("Owner")
                .HasColumnName("owner_id");
            entity.Property(e => e.PackageId)
                .HasComment("Source package")
                .HasColumnName("package_id");
            entity.Property(e => e.PackopId)
                .HasComment("Operation")
                .HasColumnName("packop_id");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductUomId)
                .HasComment("Product Unit of Measure")
                .HasColumnName("product_uom_id");
            entity.Property(e => e.Quantity)
                .HasComment("Quantity")
                .HasColumnName("quantity");
            entity.Property(e => e.ResultPackageId)
                .HasComment("Destination package")
                .HasColumnName("result_package_id");
            entity.Property(e => e.SourcelocId)
                .HasComment("Source Location")
                .HasColumnName("sourceloc_id");
            entity.Property(e => e.TransferId)
                .HasComment("Transfer")
                .HasColumnName("transfer_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockTransferDetailsItemCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_create_uid_fkey");

            entity.HasOne(d => d.Destinationloc).WithMany(p => p.StockTransferDetailsItemDestinationlocs)
                .HasForeignKey(d => d.DestinationlocId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_destinationloc_id_fkey");

            entity.HasOne(d => d.Lot).WithMany(p => p.StockTransferDetailsItems)
                .HasForeignKey(d => d.LotId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_lot_id_fkey");

            entity.HasOne(d => d.Owner).WithMany(p => p.StockTransferDetailsItems)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_owner_id_fkey");

            entity.HasOne(d => d.Package).WithMany(p => p.StockTransferDetailsItemPackages)
                .HasForeignKey(d => d.PackageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_package_id_fkey");

            entity.HasOne(d => d.Packop).WithMany(p => p.StockTransferDetailsItems)
                .HasForeignKey(d => d.PackopId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_packop_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockTransferDetailsItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_product_id_fkey");

            entity.HasOne(d => d.ProductUom).WithMany(p => p.StockTransferDetailsItems)
                .HasForeignKey(d => d.ProductUomId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_product_uom_id_fkey");

            entity.HasOne(d => d.ResultPackage).WithMany(p => p.StockTransferDetailsItemResultPackages)
                .HasForeignKey(d => d.ResultPackageId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_result_package_id_fkey");

            entity.HasOne(d => d.Sourceloc).WithMany(p => p.StockTransferDetailsItemSourcelocs)
                .HasForeignKey(d => d.SourcelocId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_sourceloc_id_fkey");

            entity.HasOne(d => d.Transfer).WithMany(p => p.StockTransferDetailsItems)
                .HasForeignKey(d => d.TransferId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_transfer_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockTransferDetailsItemWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_transfer_details_items_write_uid_fkey");
        });

        modelBuilder.Entity<StockWarehouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warehouse_pkey");

            entity.ToTable("stock_warehouse", tb => tb.HasComment("Warehouse"));

            entity.HasIndex(e => e.CompanyId, "stock_warehouse_company_id_index");

            entity.HasIndex(e => e.Name, "stock_warehouse_name_index");

            entity.HasIndex(e => new { e.Code, e.CompanyId }, "stock_warehouse_warehouse_code_uniq").IsUnique();

            entity.HasIndex(e => new { e.Name, e.CompanyId }, "stock_warehouse_warehouse_name_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(5)
                .HasComment("Short Name")
                .HasColumnName("code");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.CrossdockRouteId)
                .HasComment("Crossdock Route")
                .HasColumnName("crossdock_route_id");
            entity.Property(e => e.DefaultResupplyWhId)
                .HasComment("Default Resupply Warehouse")
                .HasColumnName("default_resupply_wh_id");
            entity.Property(e => e.DeliveryRouteId)
                .HasComment("Delivery Route")
                .HasColumnName("delivery_route_id");
            entity.Property(e => e.DeliverySteps)
                .HasComment("Outgoing Shippings")
                .HasColumnType("character varying")
                .HasColumnName("delivery_steps");
            entity.Property(e => e.InTypeId)
                .HasComment("In Type")
                .HasColumnName("in_type_id");
            entity.Property(e => e.IntTypeId)
                .HasComment("Internal Type")
                .HasColumnName("int_type_id");
            entity.Property(e => e.LotStockId)
                .HasComment("Location Stock")
                .HasColumnName("lot_stock_id");
            entity.Property(e => e.MtoPullId)
                .HasComment("MTO rule")
                .HasColumnName("mto_pull_id");
            entity.Property(e => e.Name)
                .HasComment("Warehouse Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OutTypeId)
                .HasComment("Out Type")
                .HasColumnName("out_type_id");
            entity.Property(e => e.PackTypeId)
                .HasComment("Pack Type")
                .HasColumnName("pack_type_id");
            entity.Property(e => e.PartnerId)
                .HasComment("Address")
                .HasColumnName("partner_id");
            entity.Property(e => e.PickTypeId)
                .HasComment("Pick Type")
                .HasColumnName("pick_type_id");
            entity.Property(e => e.ReceptionRouteId)
                .HasComment("Receipt Route")
                .HasColumnName("reception_route_id");
            entity.Property(e => e.ReceptionSteps)
                .HasComment("Incoming Shipments")
                .HasColumnType("character varying")
                .HasColumnName("reception_steps");
            entity.Property(e => e.ResupplyFromWh)
                .HasComment("Resupply From Other Warehouses")
                .HasColumnName("resupply_from_wh");
            entity.Property(e => e.ViewLocationId)
                .HasComment("View Location")
                .HasColumnName("view_location_id");
            entity.Property(e => e.WhInputStockLocId)
                .HasComment("Input Location")
                .HasColumnName("wh_input_stock_loc_id");
            entity.Property(e => e.WhOutputStockLocId)
                .HasComment("Output Location")
                .HasColumnName("wh_output_stock_loc_id");
            entity.Property(e => e.WhPackStockLocId)
                .HasComment("Packing Location")
                .HasColumnName("wh_pack_stock_loc_id");
            entity.Property(e => e.WhQcStockLocId)
                .HasComment("Quality Control Location")
                .HasColumnName("wh_qc_stock_loc_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockWarehouses)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarehouseCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_create_uid_fkey");

            entity.HasOne(d => d.CrossdockRoute).WithMany(p => p.StockWarehouseCrossdockRoutes)
                .HasForeignKey(d => d.CrossdockRouteId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_crossdock_route_id_fkey");

            entity.HasOne(d => d.DefaultResupplyWh).WithMany(p => p.InverseDefaultResupplyWh)
                .HasForeignKey(d => d.DefaultResupplyWhId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_default_resupply_wh_id_fkey");

            entity.HasOne(d => d.DeliveryRoute).WithMany(p => p.StockWarehouseDeliveryRoutes)
                .HasForeignKey(d => d.DeliveryRouteId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_delivery_route_id_fkey");

            entity.HasOne(d => d.InType).WithMany(p => p.StockWarehouseInTypes)
                .HasForeignKey(d => d.InTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_in_type_id_fkey");

            entity.HasOne(d => d.IntType).WithMany(p => p.StockWarehouseIntTypes)
                .HasForeignKey(d => d.IntTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_int_type_id_fkey");

            entity.HasOne(d => d.LotStock).WithMany(p => p.StockWarehouseLotStocks)
                .HasForeignKey(d => d.LotStockId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_lot_stock_id_fkey");

            entity.HasOne(d => d.MtoPull).WithMany(p => p.StockWarehouses)
                .HasForeignKey(d => d.MtoPullId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_mto_pull_id_fkey");

            entity.HasOne(d => d.OutType).WithMany(p => p.StockWarehouseOutTypes)
                .HasForeignKey(d => d.OutTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_out_type_id_fkey");

            entity.HasOne(d => d.PackType).WithMany(p => p.StockWarehousePackTypes)
                .HasForeignKey(d => d.PackTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pack_type_id_fkey");

            entity.HasOne(d => d.Partner).WithMany(p => p.StockWarehouses)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_partner_id_fkey");

            entity.HasOne(d => d.PickType).WithMany(p => p.StockWarehousePickTypes)
                .HasForeignKey(d => d.PickTypeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_pick_type_id_fkey");

            entity.HasOne(d => d.ReceptionRoute).WithMany(p => p.StockWarehouseReceptionRoutes)
                .HasForeignKey(d => d.ReceptionRouteId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_reception_route_id_fkey");

            entity.HasOne(d => d.ViewLocation).WithMany(p => p.StockWarehouseViewLocations)
                .HasForeignKey(d => d.ViewLocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_view_location_id_fkey");

            entity.HasOne(d => d.WhInputStockLoc).WithMany(p => p.StockWarehouseWhInputStockLocs)
                .HasForeignKey(d => d.WhInputStockLocId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_input_stock_loc_id_fkey");

            entity.HasOne(d => d.WhOutputStockLoc).WithMany(p => p.StockWarehouseWhOutputStockLocs)
                .HasForeignKey(d => d.WhOutputStockLocId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_output_stock_loc_id_fkey");

            entity.HasOne(d => d.WhPackStockLoc).WithMany(p => p.StockWarehouseWhPackStockLocs)
                .HasForeignKey(d => d.WhPackStockLocId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_pack_stock_loc_id_fkey");

            entity.HasOne(d => d.WhQcStockLoc).WithMany(p => p.StockWarehouseWhQcStockLocs)
                .HasForeignKey(d => d.WhQcStockLocId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_wh_qc_stock_loc_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarehouseWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_write_uid_fkey");
        });

        modelBuilder.Entity<StockWarehouseOrderpoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("stock_warehouse_orderpoint_pkey");

            entity.ToTable("stock_warehouse_orderpoint", tb => tb.HasComment("Minimum Inventory Rule"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.GroupId)
                .HasComment("Procurement Group")
                .HasColumnName("group_id");
            entity.Property(e => e.LocationId)
                .HasComment("Location")
                .HasColumnName("location_id");
            entity.Property(e => e.Logic)
                .HasComment("Reordering Mode")
                .HasColumnType("character varying")
                .HasColumnName("logic");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.ProductId)
                .HasComment("Product")
                .HasColumnName("product_id");
            entity.Property(e => e.ProductMaxQty)
                .HasComment("Maximum Quantity")
                .HasColumnName("product_max_qty");
            entity.Property(e => e.ProductMinQty)
                .HasComment("Minimum Quantity")
                .HasColumnName("product_min_qty");
            entity.Property(e => e.QtyMultiple)
                .HasComment("Qty Multiple")
                .HasColumnName("qty_multiple");
            entity.Property(e => e.WarehouseId)
                .HasComment("Warehouse")
                .HasColumnName("warehouse_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.Company).WithMany(p => p.StockWarehouseOrderpoints)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_company_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.StockWarehouseOrderpointCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.StockWarehouseOrderpoints)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_group_id_fkey");

            entity.HasOne(d => d.Location).WithMany(p => p.StockWarehouseOrderpoints)
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("stock_warehouse_orderpoint_location_id_fkey");

            entity.HasOne(d => d.Product).WithMany(p => p.StockWarehouseOrderpoints)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("stock_warehouse_orderpoint_product_id_fkey");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.StockWarehouseOrderpoints)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("stock_warehouse_orderpoint_warehouse_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.StockWarehouseOrderpointWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("stock_warehouse_orderpoint_write_uid_fkey");
        });

        modelBuilder.Entity<StockWhResupplyTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("stock_wh_resupply_table", tb => tb.HasComment("RELATION BETWEEN stock_warehouse AND stock_warehouse"));

            entity.HasIndex(e => e.SuppliedWhId, "stock_wh_resupply_table_supplied_wh_id_index");

            entity.HasIndex(e => new { e.SuppliedWhId, e.SupplierWhId }, "stock_wh_resupply_table_supplied_wh_id_supplier_wh_id_key").IsUnique();

            entity.HasIndex(e => e.SupplierWhId, "stock_wh_resupply_table_supplier_wh_id_index");

            entity.Property(e => e.SuppliedWhId).HasColumnName("supplied_wh_id");
            entity.Property(e => e.SupplierWhId).HasColumnName("supplier_wh_id");

            entity.HasOne(d => d.SuppliedWh).WithMany()
                .HasForeignKey(d => d.SuppliedWhId)
                .HasConstraintName("stock_wh_resupply_table_supplied_wh_id_fkey");

            entity.HasOne(d => d.SupplierWh).WithMany()
                .HasForeignKey(d => d.SupplierWhId)
                .HasConstraintName("stock_wh_resupply_table_supplier_wh_id_fkey");
        });

        modelBuilder.Entity<TempTab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_tab", tb => tb.HasComment("RELATION BETWEEN hotel_room AND hotel_room_amenities"));

            entity.HasIndex(e => e.RcategId, "temp_tab_rcateg_id_index");

            entity.HasIndex(e => e.RoomAmenities, "temp_tab_room_amenities_index");

            entity.HasIndex(e => new { e.RoomAmenities, e.RcategId }, "temp_tab_room_amenities_rcateg_id_key").IsUnique();

            entity.Property(e => e.RcategId).HasColumnName("rcateg_id");
            entity.Property(e => e.RoomAmenities).HasColumnName("room_amenities");

            entity.HasOne(d => d.Rcateg).WithMany()
                .HasForeignKey(d => d.RcategId)
                .HasConstraintName("temp_tab_rcateg_id_fkey");

            entity.HasOne(d => d.RoomAmenitiesNavigation).WithMany()
                .HasForeignKey(d => d.RoomAmenities)
                .HasConstraintName("temp_tab_room_amenities_fkey");
        });

        modelBuilder.Entity<WizardIrModelMenuCreate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wizard_ir_model_menu_create_pkey");

            entity.ToTable("wizard_ir_model_menu_create", tb => tb.HasComment("wizard.ir.model.menu.create"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.MenuId)
                .HasComment("Parent Menu")
                .HasColumnName("menu_id");
            entity.Property(e => e.Name)
                .HasComment("Menu Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WizardIrModelMenuCreateCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wizard_ir_model_menu_create_create_uid_fkey");

            entity.HasOne(d => d.Menu).WithMany(p => p.WizardIrModelMenuCreates)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wizard_ir_model_menu_create_menu_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WizardIrModelMenuCreateWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wizard_ir_model_menu_create_write_uid_fkey");
        });

        modelBuilder.Entity<Wkf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wkf_pkey");

            entity.ToTable("wkf");

            entity.HasIndex(e => e.OnCreate, "wkf_on_create_index");

            entity.HasIndex(e => e.Osv, "wkf_osv_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.OnCreate)
                .HasDefaultValue(false)
                .HasColumnName("on_create");
            entity.Property(e => e.Osv)
                .HasColumnType("character varying")
                .HasColumnName("osv");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WkfCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_create_uid_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WkfWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_write_uid_fkey");
        });

        modelBuilder.Entity<WkfActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wkf_activity_pkey");

            entity.ToTable("wkf_activity", tb => tb.HasComment("workflow.activity"));

            entity.HasIndex(e => e.WkfId, "wkf_activity_wkf_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Action)
                .HasComment("Python Action")
                .HasColumnName("action");
            entity.Property(e => e.ActionId)
                .HasComment("Server Action")
                .HasColumnName("action_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.FlowStart)
                .HasComment("Flow Start")
                .HasColumnName("flow_start");
            entity.Property(e => e.FlowStop)
                .HasComment("Flow Stop")
                .HasColumnName("flow_stop");
            entity.Property(e => e.JoinMode)
                .HasMaxLength(3)
                .HasComment("Join Mode")
                .HasColumnName("join_mode");
            entity.Property(e => e.Kind)
                .HasComment("Kind")
                .HasColumnType("character varying")
                .HasColumnName("kind");
            entity.Property(e => e.Name)
                .HasComment("Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.SignalSend)
                .HasComment("Signal (subflow.*)")
                .HasColumnType("character varying")
                .HasColumnName("signal_send");
            entity.Property(e => e.SplitMode)
                .HasMaxLength(3)
                .HasComment("Split Mode")
                .HasColumnName("split_mode");
            entity.Property(e => e.SubflowId)
                .HasComment("Subflow")
                .HasColumnName("subflow_id");
            entity.Property(e => e.WkfId)
                .HasComment("Workflow")
                .HasColumnName("wkf_id");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.ActionNavigation).WithMany(p => p.WkfActivities)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_activity_action_id_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WkfActivityCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_activity_create_uid_fkey");

            entity.HasOne(d => d.Subflow).WithMany(p => p.WkfActivitySubflows)
                .HasForeignKey(d => d.SubflowId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_activity_subflow_id_fkey");

            entity.HasOne(d => d.Wkf).WithMany(p => p.WkfActivityWkfs)
                .HasForeignKey(d => d.WkfId)
                .HasConstraintName("wkf_activity_wkf_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WkfActivityWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_activity_write_uid_fkey");
        });

        modelBuilder.Entity<WkfInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wkf_instance_pkey");

            entity.ToTable("wkf_instance", tb => tb.HasComment("workflow.instance"));

            entity.HasIndex(e => new { e.ResId, e.WkfId }, "wkf_instance_res_id_wkf_id_index");

            entity.HasIndex(e => new { e.ResType, e.ResId, e.State }, "wkf_instance_res_type_res_id_state_index");

            entity.HasIndex(e => e.WkfId, "wkf_instance_wkf_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ResId)
                .HasComment("Resource ID")
                .HasColumnName("res_id");
            entity.Property(e => e.ResType)
                .HasComment("Resource Object")
                .HasColumnType("character varying")
                .HasColumnName("res_type");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.Uid)
                .HasComment("User")
                .HasColumnName("uid");
            entity.Property(e => e.WkfId)
                .HasComment("Workflow")
                .HasColumnName("wkf_id");

            entity.HasOne(d => d.Wkf).WithMany(p => p.WkfInstances)
                .HasForeignKey(d => d.WkfId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("wkf_instance_wkf_id_fkey");
        });

        modelBuilder.Entity<WkfTransition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wkf_transition_pkey");

            entity.ToTable("wkf_transition", tb => tb.HasComment("workflow.transition"));

            entity.HasIndex(e => e.ActFrom, "wkf_transition_act_from_index");

            entity.HasIndex(e => e.ActTo, "wkf_transition_act_to_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActFrom)
                .HasComment("Source Activity")
                .HasColumnName("act_from");
            entity.Property(e => e.ActTo)
                .HasComment("Destination Activity")
                .HasColumnName("act_to");
            entity.Property(e => e.Condition)
                .HasComment("Condition")
                .HasColumnType("character varying")
                .HasColumnName("condition");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.GroupId)
                .HasComment("Group Required")
                .HasColumnName("group_id");
            entity.Property(e => e.Sequence)
                .HasComment("Sequence")
                .HasColumnName("sequence");
            entity.Property(e => e.Signal)
                .HasComment("Signal (Button Name)")
                .HasColumnType("character varying")
                .HasColumnName("signal");
            entity.Property(e => e.TriggerExprId)
                .HasComment("Trigger Expression")
                .HasColumnType("character varying")
                .HasColumnName("trigger_expr_id");
            entity.Property(e => e.TriggerModel)
                .HasComment("Trigger Object")
                .HasColumnType("character varying")
                .HasColumnName("trigger_model");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.ActFromNavigation).WithMany(p => p.WkfTransitionActFromNavigations)
                .HasForeignKey(d => d.ActFrom)
                .HasConstraintName("wkf_transition_act_from_fkey");

            entity.HasOne(d => d.ActToNavigation).WithMany(p => p.WkfTransitionActToNavigations)
                .HasForeignKey(d => d.ActTo)
                .HasConstraintName("wkf_transition_act_to_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.WkfTransitionCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_transition_create_uid_fkey");

            entity.HasOne(d => d.Group).WithMany(p => p.WkfTransitions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_transition_group_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.WkfTransitionWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_transition_write_uid_fkey");
        });

        modelBuilder.Entity<WkfTrigger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wkf_triggers_pkey");

            entity.ToTable("wkf_triggers", tb => tb.HasComment("workflow.triggers"));

            entity.HasIndex(e => new { e.ResId, e.Model }, "wkf_triggers_res_id_model_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.InstanceId)
                .HasComment("Destination Instance")
                .HasColumnName("instance_id");
            entity.Property(e => e.Model)
                .HasComment("Object")
                .HasColumnType("character varying")
                .HasColumnName("model");
            entity.Property(e => e.ResId)
                .HasComment("Resource ID")
                .HasColumnName("res_id");
            entity.Property(e => e.WorkitemId)
                .HasComment("Workitem")
                .HasColumnName("workitem_id");

            entity.HasOne(d => d.Instance).WithMany(p => p.WkfTriggers)
                .HasForeignKey(d => d.InstanceId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("wkf_triggers_instance_id_fkey");

            entity.HasOne(d => d.Workitem).WithMany(p => p.WkfTriggers)
                .HasForeignKey(d => d.WorkitemId)
                .HasConstraintName("wkf_triggers_workitem_id_fkey");
        });

        modelBuilder.Entity<WkfWitmTran>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("wkf_witm_trans", tb => tb.HasComment("RELATION BETWEEN wkf_instance AND wkf_transition"));

            entity.HasIndex(e => e.InstId, "wkf_witm_trans_inst_id_index");

            entity.HasIndex(e => new { e.InstId, e.TransId }, "wkf_witm_trans_inst_id_trans_id_key").IsUnique();

            entity.HasIndex(e => e.TransId, "wkf_witm_trans_trans_id_index");

            entity.Property(e => e.InstId).HasColumnName("inst_id");
            entity.Property(e => e.TransId).HasColumnName("trans_id");

            entity.HasOne(d => d.Inst).WithMany()
                .HasForeignKey(d => d.InstId)
                .HasConstraintName("wkf_witm_trans_inst_id_fkey");

            entity.HasOne(d => d.Trans).WithMany()
                .HasForeignKey(d => d.TransId)
                .HasConstraintName("wkf_witm_trans_trans_id_fkey");
        });

        modelBuilder.Entity<WkfWorkitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wkf_workitem_pkey");

            entity.ToTable("wkf_workitem", tb => tb.HasComment("workflow.workitem"));

            entity.HasIndex(e => e.ActId, "wkf_workitem_act_id_index");

            entity.HasIndex(e => e.InstId, "wkf_workitem_inst_id_index");

            entity.HasIndex(e => e.State, "wkf_workitem_state_index");

            entity.HasIndex(e => e.SubflowId, "wkf_workitem_subflow_id_index");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActId)
                .HasComment("Activity")
                .HasColumnName("act_id");
            entity.Property(e => e.InstId)
                .HasComment("Instance")
                .HasColumnName("inst_id");
            entity.Property(e => e.State)
                .HasComment("Status")
                .HasColumnType("character varying")
                .HasColumnName("state");
            entity.Property(e => e.SubflowId)
                .HasComment("Subflow")
                .HasColumnName("subflow_id");

            entity.HasOne(d => d.Act).WithMany(p => p.WkfWorkitems)
                .HasForeignKey(d => d.ActId)
                .HasConstraintName("wkf_workitem_act_id_fkey");

            entity.HasOne(d => d.Inst).WithMany(p => p.WkfWorkitemInsts)
                .HasForeignKey(d => d.InstId)
                .HasConstraintName("wkf_workitem_inst_id_fkey");

            entity.HasOne(d => d.Subflow).WithMany(p => p.WkfWorkitemSubflows)
                .HasForeignKey(d => d.SubflowId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("wkf_workitem_subflow_id_fkey");
        });
        modelBuilder.HasSequence("ir_sequence_001");
        modelBuilder.HasSequence("ir_sequence_002");
        modelBuilder.HasSequence("ir_sequence_003");
        modelBuilder.HasSequence("ir_sequence_004");
        modelBuilder.HasSequence("ir_sequence_005");
        modelBuilder.HasSequence("ir_sequence_006");
        modelBuilder.HasSequence("ir_sequence_007");
        modelBuilder.HasSequence("ir_sequence_008");
        modelBuilder.HasSequence("ir_sequence_009");
        modelBuilder.HasSequence("ir_sequence_010");
        modelBuilder.HasSequence("ir_sequence_011");
        modelBuilder.HasSequence("ir_sequence_012");
        modelBuilder.HasSequence("ir_sequence_013");
        modelBuilder.HasSequence("ir_sequence_014");
        modelBuilder.HasSequence("ir_sequence_015");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
