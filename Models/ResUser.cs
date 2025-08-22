using System;
using System.Collections.Generic;

namespace Anandashram.Models;

public partial class ResUser
{
    public int Id { get; set; }

    public bool? Active { get; set; }

    public string Login { get; set; } = null!;

    public string? Password { get; set; }

    public int CompanyId { get; set; }

    public int PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Latest connection
    /// </summary>
    public DateOnly? LoginDate { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Signature
    /// </summary>
    public string? Signature { get; set; }

    /// <summary>
    /// Home Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Encrypted Password
    /// </summary>
    public string? PasswordCrypt { get; set; }

    /// <summary>
    /// Alias
    /// </summary>
    public int AliasId { get; set; }

    /// <summary>
    /// Display Groups Suggestions
    /// </summary>
    public bool? DisplayGroupsSuggestions { get; set; }

    /// <summary>
    /// Display Employees Suggestions
    /// </summary>
    public bool? DisplayEmployeesSuggestions { get; set; }

    /// <summary>
    /// Default Sales Team
    /// </summary>
    public int? DefaultSectionId { get; set; }

    /// <summary>
    /// Share User
    /// </summary>
    public bool? Share { get; set; }

    public virtual MailAlias Alias { get; set; } = null!;

    public virtual ICollection<DevoteeCategory> AshramDevoteeCategoryCreateUs { get; set; } = new List<DevoteeCategory>();

    public virtual ICollection<DevoteeCategory> AshramDevoteeCategoryWriteUs { get; set; } = new List<DevoteeCategory>();

    public virtual ICollection<AshramDevotee> AshramDevoteeCreateUs { get; set; } = new List<AshramDevotee>();

    public virtual ICollection<AshramDevoteeSubCategory> AshramDevoteeSubCategoryCreateUs { get; set; } = new List<AshramDevoteeSubCategory>();

    public virtual ICollection<AshramDevoteeSubCategory> AshramDevoteeSubCategoryWriteUs { get; set; } = new List<AshramDevoteeSubCategory>();

    public virtual ICollection<AshramDevotee> AshramDevoteeWriteUs { get; set; } = new List<AshramDevotee>();

    public virtual ICollection<BaseConfigSetting> BaseConfigSettingAuthSignupTemplateUsers { get; set; } = new List<BaseConfigSetting>();

    public virtual ICollection<BaseConfigSetting> BaseConfigSettingCreateUs { get; set; } = new List<BaseConfigSetting>();

    public virtual ICollection<BaseConfigSetting> BaseConfigSettingWriteUs { get; set; } = new List<BaseConfigSetting>();

    public virtual ICollection<BaseImportImport> BaseImportImportCreateUs { get; set; } = new List<BaseImportImport>();

    public virtual ICollection<BaseImportImport> BaseImportImportWriteUs { get; set; } = new List<BaseImportImport>();

    public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharCreateUs { get; set; } = new List<BaseImportTestsModelsChar>();

    public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyCreateUs { get; set; } = new List<BaseImportTestsModelsCharNoreadonly>();

    public virtual ICollection<BaseImportTestsModelsCharNoreadonly> BaseImportTestsModelsCharNoreadonlyWriteUs { get; set; } = new List<BaseImportTestsModelsCharNoreadonly>();

    public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyCreateUs { get; set; } = new List<BaseImportTestsModelsCharReadonly>();

    public virtual ICollection<BaseImportTestsModelsCharReadonly> BaseImportTestsModelsCharReadonlyWriteUs { get; set; } = new List<BaseImportTestsModelsCharReadonly>();

    public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredCreateUs { get; set; } = new List<BaseImportTestsModelsCharRequired>();

    public virtual ICollection<BaseImportTestsModelsCharRequired> BaseImportTestsModelsCharRequiredWriteUs { get; set; } = new List<BaseImportTestsModelsCharRequired>();

    public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateCreateUs { get; set; } = new List<BaseImportTestsModelsCharState>();

    public virtual ICollection<BaseImportTestsModelsCharState> BaseImportTestsModelsCharStateWriteUs { get; set; } = new List<BaseImportTestsModelsCharState>();

    public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyCreateUs { get; set; } = new List<BaseImportTestsModelsCharStillreadonly>();

    public virtual ICollection<BaseImportTestsModelsCharStillreadonly> BaseImportTestsModelsCharStillreadonlyWriteUs { get; set; } = new List<BaseImportTestsModelsCharStillreadonly>();

    public virtual ICollection<BaseImportTestsModelsChar> BaseImportTestsModelsCharWriteUs { get; set; } = new List<BaseImportTestsModelsChar>();

    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oCreateUs { get; set; } = new List<BaseImportTestsModelsM2o>();

    public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedCreateUs { get; set; } = new List<BaseImportTestsModelsM2oRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRelated> BaseImportTestsModelsM2oRelatedWriteUs { get; set; } = new List<BaseImportTestsModelsM2oRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredCreateUs { get; set; } = new List<BaseImportTestsModelsM2oRequired>();

    public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedCreateUs { get; set; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRequiredRelated> BaseImportTestsModelsM2oRequiredRelatedWriteUs { get; set; } = new List<BaseImportTestsModelsM2oRequiredRelated>();

    public virtual ICollection<BaseImportTestsModelsM2oRequired> BaseImportTestsModelsM2oRequiredWriteUs { get; set; } = new List<BaseImportTestsModelsM2oRequired>();

    public virtual ICollection<BaseImportTestsModelsM2o> BaseImportTestsModelsM2oWriteUs { get; set; } = new List<BaseImportTestsModelsM2o>();

    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildCreateUs { get; set; } = new List<BaseImportTestsModelsO2mChild>();

    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildWriteUs { get; set; } = new List<BaseImportTestsModelsO2mChild>();

    public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mCreateUs { get; set; } = new List<BaseImportTestsModelsO2m>();

    public virtual ICollection<BaseImportTestsModelsO2m> BaseImportTestsModelsO2mWriteUs { get; set; } = new List<BaseImportTestsModelsO2m>();

    public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewCreateUs { get; set; } = new List<BaseImportTestsModelsPreview>();

    public virtual ICollection<BaseImportTestsModelsPreview> BaseImportTestsModelsPreviewWriteUs { get; set; } = new List<BaseImportTestsModelsPreview>();

    public virtual ICollection<BaseLanguageExport> BaseLanguageExportCreateUs { get; set; } = new List<BaseLanguageExport>();

    public virtual ICollection<BaseLanguageExport> BaseLanguageExportWriteUs { get; set; } = new List<BaseLanguageExport>();

    public virtual ICollection<BaseLanguageImport> BaseLanguageImportCreateUs { get; set; } = new List<BaseLanguageImport>();

    public virtual ICollection<BaseLanguageImport> BaseLanguageImportWriteUs { get; set; } = new List<BaseLanguageImport>();

    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallCreateUs { get; set; } = new List<BaseLanguageInstall>();

    public virtual ICollection<BaseLanguageInstall> BaseLanguageInstallWriteUs { get; set; } = new List<BaseLanguageInstall>();

    public virtual ICollection<BaseModuleConfiguration> BaseModuleConfigurationCreateUs { get; set; } = new List<BaseModuleConfiguration>();

    public virtual ICollection<BaseModuleConfiguration> BaseModuleConfigurationWriteUs { get; set; } = new List<BaseModuleConfiguration>();

    public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateCreateUs { get; set; } = new List<BaseModuleUpdate>();

    public virtual ICollection<BaseModuleUpdate> BaseModuleUpdateWriteUs { get; set; } = new List<BaseModuleUpdate>();

    public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeCreateUs { get; set; } = new List<BaseModuleUpgrade>();

    public virtual ICollection<BaseModuleUpgrade> BaseModuleUpgradeWriteUs { get; set; } = new List<BaseModuleUpgrade>();

    public virtual ICollection<BaseSetupTerminology> BaseSetupTerminologyCreateUs { get; set; } = new List<BaseSetupTerminology>();

    public virtual ICollection<BaseSetupTerminology> BaseSetupTerminologyWriteUs { get; set; } = new List<BaseSetupTerminology>();

    public virtual ICollection<BaseUpdateTranslation> BaseUpdateTranslationCreateUs { get; set; } = new List<BaseUpdateTranslation>();

    public virtual ICollection<BaseUpdateTranslation> BaseUpdateTranslationWriteUs { get; set; } = new List<BaseUpdateTranslation>();

    public virtual ICollection<BoardCreate> BoardCreateCreateUs { get; set; } = new List<BoardCreate>();

    public virtual ICollection<BoardCreate> BoardCreateWriteUs { get; set; } = new List<BoardCreate>();

    public virtual ICollection<BusBu> BusBuCreateUs { get; set; } = new List<BusBu>();

    public virtual ICollection<BusBu> BusBuWriteUs { get; set; } = new List<BusBu>();

    public virtual ICollection<ChangePasswordUser> ChangePasswordUserCreateUs { get; set; } = new List<ChangePasswordUser>();

    public virtual ICollection<ChangePasswordUser> ChangePasswordUserUsers { get; set; } = new List<ChangePasswordUser>();

    public virtual ICollection<ChangePasswordUser> ChangePasswordUserWriteUs { get; set; } = new List<ChangePasswordUser>();

    public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardCreateUs { get; set; } = new List<ChangePasswordWizard>();

    public virtual ICollection<ChangePasswordWizard> ChangePasswordWizardWriteUs { get; set; } = new List<ChangePasswordWizard>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmCaseSection> CrmCaseSectionCreateUs { get; set; } = new List<CrmCaseSection>();

    public virtual ICollection<CrmCaseSection> CrmCaseSectionUsers { get; set; } = new List<CrmCaseSection>();

    public virtual ICollection<CrmCaseSection> CrmCaseSectionWriteUs { get; set; } = new List<CrmCaseSection>();

    public virtual ICollection<CurrencyExchange> CurrencyExchangeCreateUs { get; set; } = new List<CurrencyExchange>();

    public virtual ICollection<CurrencyExchange> CurrencyExchangeWriteUs { get; set; } = new List<CurrencyExchange>();

    public virtual ICollection<DbBackup> DbBackupCreateUs { get; set; } = new List<DbBackup>();

    public virtual ICollection<DbBackup> DbBackupWriteUs { get; set; } = new List<DbBackup>();

    public virtual ICollection<DecimalPrecision> DecimalPrecisionCreateUs { get; set; } = new List<DecimalPrecision>();

    public virtual ICollection<DecimalPrecisionTest> DecimalPrecisionTestCreateUs { get; set; } = new List<DecimalPrecisionTest>();

    public virtual ICollection<DecimalPrecisionTest> DecimalPrecisionTestWriteUs { get; set; } = new List<DecimalPrecisionTest>();

    public virtual ICollection<DecimalPrecision> DecimalPrecisionWriteUs { get; set; } = new List<DecimalPrecision>();

    public virtual CrmCaseSection? DefaultSection { get; set; }

    public virtual ICollection<DocumentConfiguration> DocumentConfigurationCreateUs { get; set; } = new List<DocumentConfiguration>();

    public virtual ICollection<DocumentConfiguration> DocumentConfigurationWriteUs { get; set; } = new List<DocumentConfiguration>();

    public virtual ICollection<DocumentDirectoryContent> DocumentDirectoryContentCreateUs { get; set; } = new List<DocumentDirectoryContent>();

    public virtual ICollection<DocumentDirectoryContentType> DocumentDirectoryContentTypeCreateUs { get; set; } = new List<DocumentDirectoryContentType>();

    public virtual ICollection<DocumentDirectoryContentType> DocumentDirectoryContentTypeWriteUs { get; set; } = new List<DocumentDirectoryContentType>();

    public virtual ICollection<DocumentDirectoryContent> DocumentDirectoryContentWriteUs { get; set; } = new List<DocumentDirectoryContent>();

    public virtual ICollection<DocumentDirectory> DocumentDirectoryCreateUs { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<DocumentDirectoryDctx> DocumentDirectoryDctxCreateUs { get; set; } = new List<DocumentDirectoryDctx>();

    public virtual ICollection<DocumentDirectoryDctx> DocumentDirectoryDctxWriteUs { get; set; } = new List<DocumentDirectoryDctx>();

    public virtual ICollection<DocumentDirectory> DocumentDirectoryUsers { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<DocumentDirectory> DocumentDirectoryWriteUs { get; set; } = new List<DocumentDirectory>();

    public virtual ICollection<DocumentStorage> DocumentStorageCreateUs { get; set; } = new List<DocumentStorage>();

    public virtual ICollection<DocumentStorage> DocumentStorageWriteUs { get; set; } = new List<DocumentStorage>();

    public virtual ICollection<EmailTemplate> EmailTemplateCreateUs { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviewCreateUs { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplatePreview> EmailTemplatePreviewWriteUs { get; set; } = new List<EmailTemplatePreview>();

    public virtual ICollection<EmailTemplate> EmailTemplateWriteUs { get; set; } = new List<EmailTemplate>();

    public virtual ICollection<FetchmailConfigSetting> FetchmailConfigSettingCreateUs { get; set; } = new List<FetchmailConfigSetting>();

    public virtual ICollection<FetchmailConfigSetting> FetchmailConfigSettingWriteUs { get; set; } = new List<FetchmailConfigSetting>();

    public virtual ICollection<FetchmailServer> FetchmailServerCreateUs { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<FetchmailServer> FetchmailServerWriteUs { get; set; } = new List<FetchmailServer>();

    public virtual ICollection<FolioRoomLine> FolioRoomLineCreateUs { get; set; } = new List<FolioRoomLine>();

    public virtual ICollection<FolioRoomLine> FolioRoomLineWriteUs { get; set; } = new List<FolioRoomLine>();

    public virtual ICollection<Block> HotelBlockCreateUs { get; set; } = new List<Block>();

    public virtual ICollection<Block> HotelBlockWriteUs { get; set; } = new List<Block>();

    public virtual ICollection<Building> HotelBuildingCreateUs { get; set; } = new List<Building>();

    public virtual ICollection<Building> HotelBuildingWriteUs { get; set; } = new List<Building>();

    public virtual ICollection<Floor> HotelFloorCreateUs { get; set; } = new List<Floor>();

    public virtual ICollection<Floor> HotelFloorWriteUs { get; set; } = new List<Floor>();

    public virtual ICollection<HotelReservation> HotelReservationCreateUs { get; set; } = new List<HotelReservation>();

    public virtual ICollection<HotelReservationLine> HotelReservationLineCreateUs { get; set; } = new List<HotelReservationLine>();

    public virtual ICollection<HotelReservationLine> HotelReservationLineWriteUs { get; set; } = new List<HotelReservationLine>();

    public virtual ICollection<HotelReservation> HotelReservationWriteUs { get; set; } = new List<HotelReservation>();

    public virtual ICollection<HotelRoomAmenitiesType> HotelRoomAmenitiesTypeCreateUs { get; set; } = new List<HotelRoomAmenitiesType>();

    public virtual ICollection<HotelRoomAmenitiesType> HotelRoomAmenitiesTypeWriteUs { get; set; } = new List<HotelRoomAmenitiesType>();

    public virtual ICollection<HotelRoomAmenity> HotelRoomAmenityCreateUs { get; set; } = new List<HotelRoomAmenity>();

    public virtual ICollection<HotelRoomAmenity> HotelRoomAmenityWriteUs { get; set; } = new List<HotelRoomAmenity>();

    public virtual ICollection<Room> HotelRoomCreateUs { get; set; } = new List<Room>();

    public virtual ICollection<HotelRoomReservationLine> HotelRoomReservationLineCreateUs { get; set; } = new List<HotelRoomReservationLine>();

    public virtual ICollection<HotelRoomReservationLine> HotelRoomReservationLineWriteUs { get; set; } = new List<HotelRoomReservationLine>();

    public virtual ICollection<HotelRoomType> HotelRoomTypeCreateUs { get; set; } = new List<HotelRoomType>();

    public virtual ICollection<HotelRoomType> HotelRoomTypeWriteUs { get; set; } = new List<HotelRoomType>();

    public virtual ICollection<Room> HotelRoomWriteUs { get; set; } = new List<Room>();

    public virtual ICollection<HotelService> HotelServiceCreateUs { get; set; } = new List<HotelService>();

    public virtual ICollection<HotelServiceType> HotelServiceTypeCreateUs { get; set; } = new List<HotelServiceType>();

    public virtual ICollection<HotelServiceType> HotelServiceTypeWriteUs { get; set; } = new List<HotelServiceType>();

    public virtual ICollection<HotelService> HotelServiceWriteUs { get; set; } = new List<HotelService>();

    public virtual ICollection<HrActionReason> HrActionReasonCreateUs { get; set; } = new List<HrActionReason>();

    public virtual ICollection<HrActionReason> HrActionReasonWriteUs { get; set; } = new List<HrActionReason>();

    public virtual ICollection<HrAttendance> HrAttendanceCreateUs { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrAttendanceError> HrAttendanceErrorCreateUs { get; set; } = new List<HrAttendanceError>();

    public virtual ICollection<HrAttendanceError> HrAttendanceErrorWriteUs { get; set; } = new List<HrAttendanceError>();

    public virtual ICollection<HrAttendance> HrAttendanceWriteUs { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrConfigSetting> HrConfigSettingCreateUs { get; set; } = new List<HrConfigSetting>();

    public virtual ICollection<HrConfigSetting> HrConfigSettingWriteUs { get; set; } = new List<HrConfigSetting>();

    public virtual ICollection<HrDepartment> HrDepartmentCreateUs { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartment> HrDepartmentWriteUs { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryCreateUs { get; set; } = new List<HrEmployeeCategory>();

    public virtual ICollection<HrEmployeeCategory> HrEmployeeCategoryWriteUs { get; set; } = new List<HrEmployeeCategory>();

    public virtual ICollection<HrEmployee> HrEmployeeCreateUs { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> HrEmployeeWriteUs { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrJob> HrJobCreateUs { get; set; } = new List<HrJob>();

    public virtual ICollection<HrJob> HrJobWriteUs { get; set; } = new List<HrJob>();

    public virtual ICollection<ImChatMessage> ImChatMessageCreateUs { get; set; } = new List<ImChatMessage>();

    public virtual ICollection<ImChatMessage> ImChatMessageFroms { get; set; } = new List<ImChatMessage>();

    public virtual ICollection<ImChatMessage> ImChatMessageWriteUs { get; set; } = new List<ImChatMessage>();

    public virtual ICollection<ImChatPresence> ImChatPresenceCreateUs { get; set; } = new List<ImChatPresence>();

    public virtual ImChatPresence? ImChatPresenceUser { get; set; }

    public virtual ICollection<ImChatPresence> ImChatPresenceWriteUs { get; set; } = new List<ImChatPresence>();

    public virtual ICollection<ImChatSession> ImChatSessionCreateUs { get; set; } = new List<ImChatSession>();

    public virtual ICollection<ImChatSessionResUsersRel> ImChatSessionResUsersRelCreateUs { get; set; } = new List<ImChatSessionResUsersRel>();

    public virtual ICollection<ImChatSessionResUsersRel> ImChatSessionResUsersRelUsers { get; set; } = new List<ImChatSessionResUsersRel>();

    public virtual ICollection<ImChatSessionResUsersRel> ImChatSessionResUsersRelWriteUs { get; set; } = new List<ImChatSessionResUsersRel>();

    public virtual ICollection<ImChatSession> ImChatSessionWriteUs { get; set; } = new List<ImChatSession>();

    public virtual ICollection<ResUser> InverseCreateU { get; set; } = new List<ResUser>();

    public virtual ICollection<ResUser> InverseWriteU { get; set; } = new List<ResUser>();

    public virtual ICollection<IrActClient> IrActClientCreateUs { get; set; } = new List<IrActClient>();

    public virtual ICollection<IrActClient> IrActClientWriteUs { get; set; } = new List<IrActClient>();

    public virtual ICollection<IrActReportXml> IrActReportXmlCreateUs { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<IrActReportXml> IrActReportXmlWriteUs { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<IrActServer> IrActServerCreateUs { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActServer> IrActServerWriteUs { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrActUrl> IrActUrlCreateUs { get; set; } = new List<IrActUrl>();

    public virtual ICollection<IrActUrl> IrActUrlWriteUs { get; set; } = new List<IrActUrl>();

    public virtual ICollection<IrActWindow> IrActWindowCreateUs { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrActWindowView> IrActWindowViewCreateUs { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<IrActWindowView> IrActWindowViewWriteUs { get; set; } = new List<IrActWindowView>();

    public virtual ICollection<IrActWindow> IrActWindowWriteUs { get; set; } = new List<IrActWindow>();

    public virtual ICollection<IrAction> IrActionCreateUs { get; set; } = new List<IrAction>();

    public virtual ICollection<IrAction> IrActionWriteUs { get; set; } = new List<IrAction>();

    public virtual ICollection<IrActionsTodo> IrActionsTodoCreateUs { get; set; } = new List<IrActionsTodo>();

    public virtual ICollection<IrActionsTodo> IrActionsTodoWriteUs { get; set; } = new List<IrActionsTodo>();

    public virtual ICollection<IrAttachment> IrAttachmentCreateUs { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrAttachment> IrAttachmentUsers { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrAttachment> IrAttachmentWriteUs { get; set; } = new List<IrAttachment>();

    public virtual ICollection<IrConfigParameter> IrConfigParameterCreateUs { get; set; } = new List<IrConfigParameter>();

    public virtual ICollection<IrConfigParameter> IrConfigParameterWriteUs { get; set; } = new List<IrConfigParameter>();

    public virtual ICollection<IrCron> IrCronCreateUs { get; set; } = new List<IrCron>();

    public virtual ICollection<IrCron> IrCronUsers { get; set; } = new List<IrCron>();

    public virtual ICollection<IrCron> IrCronWriteUs { get; set; } = new List<IrCron>();

    public virtual ICollection<IrDefault> IrDefaultCreateUs { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrDefault> IrDefaultUidNavigations { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrDefault> IrDefaultWriteUs { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrExport> IrExportCreateUs { get; set; } = new List<IrExport>();

    public virtual ICollection<IrExport> IrExportWriteUs { get; set; } = new List<IrExport>();

    public virtual ICollection<IrExportsLine> IrExportsLineCreateUs { get; set; } = new List<IrExportsLine>();

    public virtual ICollection<IrExportsLine> IrExportsLineWriteUs { get; set; } = new List<IrExportsLine>();

    public virtual ICollection<IrFieldsConverter> IrFieldsConverterCreateUs { get; set; } = new List<IrFieldsConverter>();

    public virtual ICollection<IrFieldsConverter> IrFieldsConverterWriteUs { get; set; } = new List<IrFieldsConverter>();

    public virtual ICollection<IrFilter> IrFilterCreateUs { get; set; } = new List<IrFilter>();

    public virtual ICollection<IrFilter> IrFilterUsers { get; set; } = new List<IrFilter>();

    public virtual ICollection<IrFilter> IrFilterWriteUs { get; set; } = new List<IrFilter>();

    public virtual ICollection<IrLogging> IrLoggings { get; set; } = new List<IrLogging>();

    public virtual ICollection<IrMailServer> IrMailServerCreateUs { get; set; } = new List<IrMailServer>();

    public virtual ICollection<IrMailServer> IrMailServerWriteUs { get; set; } = new List<IrMailServer>();

    public virtual ICollection<IrModelAccess> IrModelAccessCreateUs { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<IrModelAccess> IrModelAccessWriteUs { get; set; } = new List<IrModelAccess>();

    public virtual ICollection<IrModelConstraint> IrModelConstraintCreateUs { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModelConstraint> IrModelConstraintWriteUs { get; set; } = new List<IrModelConstraint>();

    public virtual ICollection<IrModel> IrModelCreateUs { get; set; } = new List<IrModel>();

    public virtual ICollection<IrModelDatum> IrModelDatumCreateUs { get; set; } = new List<IrModelDatum>();

    public virtual ICollection<IrModelDatum> IrModelDatumWriteUs { get; set; } = new List<IrModelDatum>();

    public virtual ICollection<IrModelField> IrModelFieldCreateUs { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelField> IrModelFieldWriteUs { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelRelation> IrModelRelationCreateUs { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrModelRelation> IrModelRelationWriteUs { get; set; } = new List<IrModelRelation>();

    public virtual ICollection<IrModel> IrModelWriteUs { get; set; } = new List<IrModel>();

    public virtual ICollection<IrModuleCategory> IrModuleCategoryCreateUs { get; set; } = new List<IrModuleCategory>();

    public virtual ICollection<IrModuleCategory> IrModuleCategoryWriteUs { get; set; } = new List<IrModuleCategory>();

    public virtual ICollection<IrModuleModule> IrModuleModuleCreateUs { get; set; } = new List<IrModuleModule>();

    public virtual ICollection<IrModuleModuleDependency> IrModuleModuleDependencyCreateUs { get; set; } = new List<IrModuleModuleDependency>();

    public virtual ICollection<IrModuleModuleDependency> IrModuleModuleDependencyWriteUs { get; set; } = new List<IrModuleModuleDependency>();

    public virtual ICollection<IrModuleModule> IrModuleModuleWriteUs { get; set; } = new List<IrModuleModule>();

    public virtual ICollection<IrProperty> IrPropertyCreateUs { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrProperty> IrPropertyWriteUs { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrRule> IrRuleCreateUs { get; set; } = new List<IrRule>();

    public virtual ICollection<IrRule> IrRuleWriteUs { get; set; } = new List<IrRule>();

    public virtual ICollection<IrSequence> IrSequenceCreateUs { get; set; } = new List<IrSequence>();

    public virtual ICollection<IrSequenceType> IrSequenceTypeCreateUs { get; set; } = new List<IrSequenceType>();

    public virtual ICollection<IrSequenceType> IrSequenceTypeWriteUs { get; set; } = new List<IrSequenceType>();

    public virtual ICollection<IrSequence> IrSequenceWriteUs { get; set; } = new List<IrSequence>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLineCreateUs { get; set; } = new List<IrServerObjectLine>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLineWriteUs { get; set; } = new List<IrServerObjectLine>();

    public virtual ICollection<IrUiMenu> IrUiMenuCreateUs { get; set; } = new List<IrUiMenu>();

    public virtual ICollection<IrUiMenu> IrUiMenuWriteUs { get; set; } = new List<IrUiMenu>();

    public virtual ICollection<IrUiView> IrUiViewCreateUs { get; set; } = new List<IrUiView>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustomCreateUs { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustomUsers { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<IrUiViewCustom> IrUiViewCustomWriteUs { get; set; } = new List<IrUiViewCustom>();

    public virtual ICollection<IrUiView> IrUiViewWriteUs { get; set; } = new List<IrUiView>();

    public virtual ICollection<IrValue> IrValueCreateUs { get; set; } = new List<IrValue>();

    public virtual ICollection<IrValue> IrValueUsers { get; set; } = new List<IrValue>();

    public virtual ICollection<IrValue> IrValueWriteUs { get; set; } = new List<IrValue>();

    public virtual ICollection<KnowledgeConfigSetting> KnowledgeConfigSettingCreateUs { get; set; } = new List<KnowledgeConfigSetting>();

    public virtual ICollection<KnowledgeConfigSetting> KnowledgeConfigSettingWriteUs { get; set; } = new List<KnowledgeConfigSetting>();

    public virtual ICollection<MailAlias> MailAliasAliasUsers { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailAlias> MailAliasCreateUs { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailAlias> MailAliasWriteUs { get; set; } = new List<MailAlias>();

    public virtual ICollection<MailComposeMessage> MailComposeMessageCreateUs { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailComposeMessage> MailComposeMessageWriteUs { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailGroup> MailGroupCreateUs { get; set; } = new List<MailGroup>();

    public virtual ICollection<MailGroup> MailGroupWriteUs { get; set; } = new List<MailGroup>();

    public virtual ICollection<MailMail> MailMailCreateUs { get; set; } = new List<MailMail>();

    public virtual ICollection<MailMail> MailMailWriteUs { get; set; } = new List<MailMail>();

    public virtual ICollection<MailMessage> MailMessageCreateUs { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailMessageSubtype> MailMessageSubtypeCreateUs { get; set; } = new List<MailMessageSubtype>();

    public virtual ICollection<MailMessageSubtype> MailMessageSubtypeWriteUs { get; set; } = new List<MailMessageSubtype>();

    public virtual ICollection<MailMessage> MailMessageWriteUs { get; set; } = new List<MailMessage>();

    public virtual ICollection<MailWizardInvite> MailWizardInviteCreateUs { get; set; } = new List<MailWizardInvite>();

    public virtual ICollection<MailWizardInvite> MailWizardInviteWriteUs { get; set; } = new List<MailWizardInvite>();

    public virtual ICollection<MakeProcurement> MakeProcurementCreateUs { get; set; } = new List<MakeProcurement>();

    public virtual ICollection<MakeProcurement> MakeProcurementWriteUs { get; set; } = new List<MakeProcurement>();

    public virtual ICollection<MealReservation> MealReservationCreateUs { get; set; } = new List<MealReservation>();

    public virtual ICollection<MealReservation> MealReservationWriteUs { get; set; } = new List<MealReservation>();

    public virtual ICollection<MealType> MealTypeCreateUs { get; set; } = new List<MealType>();

    public virtual ICollection<MealType> MealTypeWriteUs { get; set; } = new List<MealType>();

    public virtual ICollection<MultiCompanyDefault> MultiCompanyDefaultCreateUs { get; set; } = new List<MultiCompanyDefault>();

    public virtual ICollection<MultiCompanyDefault> MultiCompanyDefaultWriteUs { get; set; } = new List<MultiCompanyDefault>();

    public virtual ICollection<OsvMemoryAutovacuum> OsvMemoryAutovacuumCreateUs { get; set; } = new List<OsvMemoryAutovacuum>();

    public virtual ICollection<OsvMemoryAutovacuum> OsvMemoryAutovacuumWriteUs { get; set; } = new List<OsvMemoryAutovacuum>();

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<PortalWizard> PortalWizardCreateUs { get; set; } = new List<PortalWizard>();

    public virtual ICollection<PortalWizardUser> PortalWizardUserCreateUs { get; set; } = new List<PortalWizardUser>();

    public virtual ICollection<PortalWizardUser> PortalWizardUserWriteUs { get; set; } = new List<PortalWizardUser>();

    public virtual ICollection<PortalWizard> PortalWizardWriteUs { get; set; } = new List<PortalWizard>();

    public virtual ICollection<PricelistPartnerinfo> PricelistPartnerinfoCreateUs { get; set; } = new List<PricelistPartnerinfo>();

    public virtual ICollection<PricelistPartnerinfo> PricelistPartnerinfoWriteUs { get; set; } = new List<PricelistPartnerinfo>();

    public virtual ICollection<ProcurementGroup> ProcurementGroupCreateUs { get; set; } = new List<ProcurementGroup>();

    public virtual ICollection<ProcurementGroup> ProcurementGroupWriteUs { get; set; } = new List<ProcurementGroup>();

    public virtual ICollection<ProcurementOrderComputeAll> ProcurementOrderComputeAllCreateUs { get; set; } = new List<ProcurementOrderComputeAll>();

    public virtual ICollection<ProcurementOrderComputeAll> ProcurementOrderComputeAllWriteUs { get; set; } = new List<ProcurementOrderComputeAll>();

    public virtual ICollection<ProcurementOrder> ProcurementOrderCreateUs { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementOrder> ProcurementOrderWriteUs { get; set; } = new List<ProcurementOrder>();

    public virtual ICollection<ProcurementOrderpointCompute> ProcurementOrderpointComputeCreateUs { get; set; } = new List<ProcurementOrderpointCompute>();

    public virtual ICollection<ProcurementOrderpointCompute> ProcurementOrderpointComputeWriteUs { get; set; } = new List<ProcurementOrderpointCompute>();

    public virtual ICollection<ProcurementRule> ProcurementRuleCreateUs { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<ProcurementRule> ProcurementRuleWriteUs { get; set; } = new List<ProcurementRule>();

    public virtual ICollection<ProductAttribute> ProductAttributeCreateUs { get; set; } = new List<ProductAttribute>();

    public virtual ICollection<ProductAttributeLine> ProductAttributeLineCreateUs { get; set; } = new List<ProductAttributeLine>();

    public virtual ICollection<ProductAttributeLine> ProductAttributeLineWriteUs { get; set; } = new List<ProductAttributeLine>();

    public virtual ICollection<ProductAttributePrice> ProductAttributePriceCreateUs { get; set; } = new List<ProductAttributePrice>();

    public virtual ICollection<ProductAttributePrice> ProductAttributePriceWriteUs { get; set; } = new List<ProductAttributePrice>();

    public virtual ICollection<ProductAttributeValue> ProductAttributeValueCreateUs { get; set; } = new List<ProductAttributeValue>();

    public virtual ICollection<ProductAttributeValue> ProductAttributeValueWriteUs { get; set; } = new List<ProductAttributeValue>();

    public virtual ICollection<ProductAttribute> ProductAttributeWriteUs { get; set; } = new List<ProductAttribute>();

    public virtual ICollection<ProductCategory> ProductCategoryCreateUs { get; set; } = new List<ProductCategory>();

    public virtual ICollection<ProductCategory> ProductCategoryWriteUs { get; set; } = new List<ProductCategory>();

    public virtual ICollection<ProductPackaging> ProductPackagingCreateUs { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPackaging> ProductPackagingWriteUs { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<ProductPriceHistory> ProductPriceHistoryCreateUs { get; set; } = new List<ProductPriceHistory>();

    public virtual ICollection<ProductPriceHistory> ProductPriceHistoryWriteUs { get; set; } = new List<ProductPriceHistory>();

    public virtual ICollection<ProductPriceList> ProductPriceListCreateUs { get; set; } = new List<ProductPriceList>();

    public virtual ICollection<ProductPriceList> ProductPriceListWriteUs { get; set; } = new List<ProductPriceList>();

    public virtual ICollection<ProductPriceType> ProductPriceTypeCreateUs { get; set; } = new List<ProductPriceType>();

    public virtual ICollection<ProductPriceType> ProductPriceTypeWriteUs { get; set; } = new List<ProductPriceType>();

    public virtual ICollection<ProductPricelist1> ProductPricelist1CreateUs { get; set; } = new List<ProductPricelist1>();

    public virtual ICollection<ProductPricelist1> ProductPricelist1WriteUs { get; set; } = new List<ProductPricelist1>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemCreateUs { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItemWriteUs { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelistType> ProductPricelistTypeCreateUs { get; set; } = new List<ProductPricelistType>();

    public virtual ICollection<ProductPricelistType> ProductPricelistTypeWriteUs { get; set; } = new List<ProductPricelistType>();

    public virtual ICollection<ProductPricelistVersion> ProductPricelistVersionCreateUs { get; set; } = new List<ProductPricelistVersion>();

    public virtual ICollection<ProductPricelistVersion> ProductPricelistVersionWriteUs { get; set; } = new List<ProductPricelistVersion>();

    public virtual ICollection<ProductProduct> ProductProductCreateUs { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductProduct> ProductProductWriteUs { get; set; } = new List<ProductProduct>();

    public virtual ICollection<ProductPutaway> ProductPutawayCreateUs { get; set; } = new List<ProductPutaway>();

    public virtual ICollection<ProductPutaway> ProductPutawayWriteUs { get; set; } = new List<ProductPutaway>();

    public virtual ICollection<ProductRemoval> ProductRemovalCreateUs { get; set; } = new List<ProductRemoval>();

    public virtual ICollection<ProductRemoval> ProductRemovalWriteUs { get; set; } = new List<ProductRemoval>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoCreateUs { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfoWriteUs { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<ProductTemplate> ProductTemplateCreateUs { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProductTemplateProductManagerNavigations { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProductTemplateWriteUs { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductUl> ProductUlCreateUs { get; set; } = new List<ProductUl>();

    public virtual ICollection<ProductUl> ProductUlWriteUs { get; set; } = new List<ProductUl>();

    public virtual ICollection<ProductUomCateg> ProductUomCategCreateUs { get; set; } = new List<ProductUomCateg>();

    public virtual ICollection<ProductUomCateg> ProductUomCategWriteUs { get; set; } = new List<ProductUomCateg>();

    public virtual ICollection<ProductUom> ProductUomCreateUs { get; set; } = new List<ProductUom>();

    public virtual ICollection<ProductUom> ProductUomWriteUs { get; set; } = new List<ProductUom>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservationCreateUs { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<QuickRoomReservation> QuickRoomReservationWriteUs { get; set; } = new List<QuickRoomReservation>();

    public virtual ICollection<Report> ReportCreateUs { get; set; } = new List<Report>();

    public virtual ICollection<ReportPaperformat> ReportPaperformatCreateUs { get; set; } = new List<ReportPaperformat>();

    public virtual ICollection<ReportPaperformat> ReportPaperformatWriteUs { get; set; } = new List<ReportPaperformat>();

    public virtual ICollection<Report> ReportWriteUs { get; set; } = new List<Report>();

    public virtual ICollection<ResBank> ResBankCreateUs { get; set; } = new List<ResBank>();

    public virtual ICollection<ResBank> ResBankWriteUs { get; set; } = new List<ResBank>();

    public virtual ICollection<ResCompany> ResCompanyCreateUs { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyWriteUs { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResConfig> ResConfigCreateUs { get; set; } = new List<ResConfig>();

    public virtual ICollection<ResConfigInstaller> ResConfigInstallerCreateUs { get; set; } = new List<ResConfigInstaller>();

    public virtual ICollection<ResConfigInstaller> ResConfigInstallerWriteUs { get; set; } = new List<ResConfigInstaller>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingCreateUs { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingWriteUs { get; set; } = new List<ResConfigSetting>();

    public virtual ICollection<ResConfig> ResConfigWriteUs { get; set; } = new List<ResConfig>();

    public virtual ICollection<ResCountry> ResCountryCreateUs { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCountryGroup> ResCountryGroupCreateUs { get; set; } = new List<ResCountryGroup>();

    public virtual ICollection<ResCountryGroup> ResCountryGroupWriteUs { get; set; } = new List<ResCountryGroup>();

    public virtual ICollection<ResCountryState> ResCountryStateCreateUs { get; set; } = new List<ResCountryState>();

    public virtual ICollection<ResCountryState> ResCountryStateWriteUs { get; set; } = new List<ResCountryState>();

    public virtual ICollection<ResCountry> ResCountryWriteUs { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCurrency> ResCurrencyCreateUs { get; set; } = new List<ResCurrency>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRateCreateUs { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRateWriteUs { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<ResCurrency> ResCurrencyWriteUs { get; set; } = new List<ResCurrency>();

    public virtual ICollection<ResFont> ResFontCreateUs { get; set; } = new List<ResFont>();

    public virtual ICollection<ResFont> ResFontWriteUs { get; set; } = new List<ResFont>();

    public virtual ICollection<ResGroup> ResGroupCreateUs { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResGroup> ResGroupWriteUs { get; set; } = new List<ResGroup>();

    public virtual ICollection<ResLang> ResLangCreateUs { get; set; } = new List<ResLang>();

    public virtual ICollection<ResLang> ResLangWriteUs { get; set; } = new List<ResLang>();

    public virtual ICollection<ResPartnerBank> ResPartnerBankCreateUs { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartnerBankType> ResPartnerBankTypeCreateUs { get; set; } = new List<ResPartnerBankType>();

    public virtual ICollection<ResPartnerBankTypeField> ResPartnerBankTypeFieldCreateUs { get; set; } = new List<ResPartnerBankTypeField>();

    public virtual ICollection<ResPartnerBankTypeField> ResPartnerBankTypeFieldWriteUs { get; set; } = new List<ResPartnerBankTypeField>();

    public virtual ICollection<ResPartnerBankType> ResPartnerBankTypeWriteUs { get; set; } = new List<ResPartnerBankType>();

    public virtual ICollection<ResPartnerBank> ResPartnerBankWriteUs { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<ResPartnerCategory> ResPartnerCategoryCreateUs { get; set; } = new List<ResPartnerCategory>();

    public virtual ICollection<ResPartnerCategory> ResPartnerCategoryWriteUs { get; set; } = new List<ResPartnerCategory>();

    public virtual ICollection<ResPartner> ResPartnerCreateUs { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartnerTitle> ResPartnerTitleCreateUs { get; set; } = new List<ResPartnerTitle>();

    public virtual ICollection<ResPartnerTitle> ResPartnerTitleWriteUs { get; set; } = new List<ResPartnerTitle>();

    public virtual ICollection<ResPartner> ResPartnerUsers { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResPartner> ResPartnerWriteUs { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResRequestLink> ResRequestLinkCreateUs { get; set; } = new List<ResRequestLink>();

    public virtual ICollection<ResRequestLink> ResRequestLinkWriteUs { get; set; } = new List<ResRequestLink>();

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceCreateUs { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendarAttendance> ResourceCalendarAttendanceWriteUs { get; set; } = new List<ResourceCalendarAttendance>();

    public virtual ICollection<ResourceCalendar> ResourceCalendarCreateUs { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafCreateUs { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceCalendarLeaf> ResourceCalendarLeafWriteUs { get; set; } = new List<ResourceCalendarLeaf>();

    public virtual ICollection<ResourceCalendar> ResourceCalendarManagerNavigations { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceCalendar> ResourceCalendarWriteUs { get; set; } = new List<ResourceCalendar>();

    public virtual ICollection<ResourceResource> ResourceResourceCreateUs { get; set; } = new List<ResourceResource>();

    public virtual ICollection<ResourceResource> ResourceResourceUsers { get; set; } = new List<ResourceResource>();

    public virtual ICollection<ResourceResource> ResourceResourceWriteUs { get; set; } = new List<ResourceResource>();

    public virtual ICollection<RoomReservationSummary> RoomReservationSummaryCreateUs { get; set; } = new List<RoomReservationSummary>();

    public virtual ICollection<RoomReservationSummary> RoomReservationSummaryWriteUs { get; set; } = new List<RoomReservationSummary>();

    public virtual ICollection<SaleConfigSetting> SaleConfigSettingCreateUs { get; set; } = new List<SaleConfigSetting>();

    public virtual ICollection<SaleConfigSetting> SaleConfigSettingWriteUs { get; set; } = new List<SaleConfigSetting>();

    public virtual ICollection<ShareWizard> ShareWizardCreateUs { get; set; } = new List<ShareWizard>();

    public virtual ICollection<ShareWizardResultLine> ShareWizardResultLineCreateUs { get; set; } = new List<ShareWizardResultLine>();

    public virtual ICollection<ShareWizardResultLine> ShareWizardResultLineUsers { get; set; } = new List<ShareWizardResultLine>();

    public virtual ICollection<ShareWizardResultLine> ShareWizardResultLineWriteUs { get; set; } = new List<ShareWizardResultLine>();

    public virtual ICollection<ShareWizard> ShareWizardWriteUs { get; set; } = new List<ShareWizard>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQtyCreateUs { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockChangeProductQty> StockChangeProductQtyWriteUs { get; set; } = new List<StockChangeProductQty>();

    public virtual ICollection<StockConfigSetting> StockConfigSettingCreateUs { get; set; } = new List<StockConfigSetting>();

    public virtual ICollection<StockConfigSetting> StockConfigSettingWriteUs { get; set; } = new List<StockConfigSetting>();

    public virtual ICollection<StockFixedPutawayStrat> StockFixedPutawayStratCreateUs { get; set; } = new List<StockFixedPutawayStrat>();

    public virtual ICollection<StockFixedPutawayStrat> StockFixedPutawayStratWriteUs { get; set; } = new List<StockFixedPutawayStrat>();

    public virtual ICollection<StockIncoterm> StockIncotermCreateUs { get; set; } = new List<StockIncoterm>();

    public virtual ICollection<StockIncoterm> StockIncotermWriteUs { get; set; } = new List<StockIncoterm>();

    public virtual ICollection<StockInventory> StockInventoryCreateUs { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockInventoryLine> StockInventoryLineCreateUs { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockInventoryLine> StockInventoryLineWriteUs { get; set; } = new List<StockInventoryLine>();

    public virtual ICollection<StockInventory> StockInventoryWriteUs { get; set; } = new List<StockInventory>();

    public virtual ICollection<StockLocation> StockLocationCreateUs { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockLocationPath> StockLocationPathCreateUs { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockLocationPath> StockLocationPathWriteUs { get; set; } = new List<StockLocationPath>();

    public virtual ICollection<StockLocationRoute> StockLocationRouteCreateUs { get; set; } = new List<StockLocationRoute>();

    public virtual ICollection<StockLocationRoute> StockLocationRouteWriteUs { get; set; } = new List<StockLocationRoute>();

    public virtual ICollection<StockLocation> StockLocationWriteUs { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockMove> StockMoveCreateUs { get; set; } = new List<StockMove>();

    public virtual ICollection<StockMoveOperationLink> StockMoveOperationLinkCreateUs { get; set; } = new List<StockMoveOperationLink>();

    public virtual ICollection<StockMoveOperationLink> StockMoveOperationLinkWriteUs { get; set; } = new List<StockMoveOperationLink>();

    public virtual ICollection<StockMoveScrap> StockMoveScrapCreateUs { get; set; } = new List<StockMoveScrap>();

    public virtual ICollection<StockMoveScrap> StockMoveScrapWriteUs { get; set; } = new List<StockMoveScrap>();

    public virtual ICollection<StockMove> StockMoveWriteUs { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackOperation> StockPackOperationCreateUs { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockPackOperation> StockPackOperationWriteUs { get; set; } = new List<StockPackOperation>();

    public virtual ICollection<StockPicking> StockPickingCreateUs { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockPickingType> StockPickingTypeCreateUs { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPickingType> StockPickingTypeWriteUs { get; set; } = new List<StockPickingType>();

    public virtual ICollection<StockPicking> StockPickingWriteUs { get; set; } = new List<StockPicking>();

    public virtual ICollection<StockProductionLot> StockProductionLotCreateUs { get; set; } = new List<StockProductionLot>();

    public virtual ICollection<StockProductionLot> StockProductionLotWriteUs { get; set; } = new List<StockProductionLot>();

    public virtual ICollection<StockQuant> StockQuantCreateUs { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockQuantPackage> StockQuantPackageCreateUs { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuantPackage> StockQuantPackageWriteUs { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockQuant> StockQuantWriteUs { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingCreateUs { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineCreateUs { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockReturnPickingLine> StockReturnPickingLineWriteUs { get; set; } = new List<StockReturnPickingLine>();

    public virtual ICollection<StockReturnPicking> StockReturnPickingWriteUs { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockTransferDetail> StockTransferDetailCreateUs { get; set; } = new List<StockTransferDetail>();

    public virtual ICollection<StockTransferDetail> StockTransferDetailWriteUs { get; set; } = new List<StockTransferDetail>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItemCreateUs { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockTransferDetailsItem> StockTransferDetailsItemWriteUs { get; set; } = new List<StockTransferDetailsItem>();

    public virtual ICollection<StockWarehouse> StockWarehouseCreateUs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointCreateUs { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpointWriteUs { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ICollection<StockWarehouse> StockWarehouseWriteUs { get; set; } = new List<StockWarehouse>();

    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateCreateUs { get; set; } = new List<WizardIrModelMenuCreate>();

    public virtual ICollection<WizardIrModelMenuCreate> WizardIrModelMenuCreateWriteUs { get; set; } = new List<WizardIrModelMenuCreate>();

    public virtual ICollection<WkfActivity> WkfActivityCreateUs { get; set; } = new List<WkfActivity>();

    public virtual ICollection<WkfActivity> WkfActivityWriteUs { get; set; } = new List<WkfActivity>();

    public virtual ICollection<Wkf> WkfCreateUs { get; set; } = new List<Wkf>();

    public virtual ICollection<WkfTransition> WkfTransitionCreateUs { get; set; } = new List<WkfTransition>();

    public virtual ICollection<WkfTransition> WkfTransitionWriteUs { get; set; } = new List<WkfTransition>();

    public virtual ICollection<Wkf> WkfWriteUs { get; set; } = new List<Wkf>();

    public virtual ResUser? WriteU { get; set; }
}
