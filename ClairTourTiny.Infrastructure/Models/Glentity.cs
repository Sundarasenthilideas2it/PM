using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Glentity
{
    public string Entityno { get; set; } = null!;

    public string Entitydesc { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string? Custno { get; set; }

    public string? Subno { get; set; }

    public string Shipno { get; set; } = null!;

    public string Agency { get; set; } = null!;

    public string Subcontract { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string? Industry { get; set; }

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public string? Respempno { get; set; }

    public string Entitytype { get; set; } = null!;

    public int Probability { get; set; }

    public DateTime Propduedate { get; set; }

    public string? Proptype { get; set; }

    public string Country { get; set; } = null!;

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public double? Bidmarkup { get; set; }

    public string? Locationcd { get; set; }

    public string? BillingCompany { get; set; }

    public int? DefaultTaxGroup { get; set; }

    public string? Bidroot { get; set; }

    public string? Currency { get; set; }

    public DateOnly? ExchangeRateDate { get; set; }

    public DateTime? LoadOut { get; set; }

    public DateTime? CrewPrep { get; set; }

    public DateTime? FirstShow { get; set; }

    public DateTime? LastShow { get; set; }

    public short Readytopack { get; set; }

    public string? EngrEmpno { get; set; }

    public string? AcctExecEmpno { get; set; }

    public bool? PayingPerDiem { get; set; }

    public string? RootEntityno { get; set; }

    public byte? ReferralProgramId { get; set; }

    public bool? TruckingConfirmed { get; set; }

    public string? TruckingVendNo { get; set; }

    public string? Rfplempno { get; set; }

    public int? PollstarArtistId { get; set; }

    public string? CrmleadUrl { get; set; }

    public Guid Guid { get; set; }

    public double? PriceLevelValue { get; set; }

    public string? TaxTypeKey { get; set; }

    public string? OeOrderno { get; set; }

    public string? LeadTime { get; set; }

    public string? Matrixcd { get; set; }

    public string? TaxCode { get; set; }

    public string? CrewOpsEmpno { get; set; }

    public string? SecondaryOpsEmpno { get; set; }

    public string? InvoiceVsBidNote { get; set; }

    public string? Note { get; set; }

    public string? SecondaryCrewOpsEmpno { get; set; }

    public virtual Peemployee? AcctExecEmpnoNavigation { get; set; }

    public virtual Warehouse AgencyNavigation { get; set; } = null!;

    public virtual Company? BillingCompanyNavigation { get; set; }

    public virtual ICollection<CloudFileStorageFolderRenameRequest> CloudFileStorageFolderRenameRequests { get; set; } = new List<CloudFileStorageFolderRenameRequest>();

    public virtual ICollection<CloudFileStorageShareRequest> CloudFileStorageShareRequests { get; set; } = new List<CloudFileStorageShareRequest>();

    public virtual ICollection<CloudFileStorageUploadedFile> CloudFileStorageUploadedFiles { get; set; } = new List<CloudFileStorageUploadedFile>();

    public virtual Peemployee? CrewOpsEmpnoNavigation { get; set; }

    public virtual Currency? CurrencyNavigation { get; set; }

    public virtual ProjectStatus EngactivecdNavigation { get; set; } = null!;

    public virtual Peemployee? EngrEmpnoNavigation { get; set; }

    public virtual Glentitytype EntitytypeNavigation { get; set; } = null!;

    public virtual ICollection<EquipmentSubhire> EquipmentSubhires { get; set; } = new List<EquipmentSubhire>();

    public virtual ICollection<FileAttachmentIndex> FileAttachmentIndices { get; set; } = new List<FileAttachmentIndex>();

    public virtual FileStorageEntityNumbersToRollup? FileStorageEntityNumbersToRollup { get; set; }

    public virtual ICollection<Glentitynote> Glentitynotes { get; set; } = new List<Glentitynote>();

    public virtual ICollection<Inpartsub> Inpartsubs { get; set; } = new List<Inpartsub>();

    public virtual ICollection<InvoiceSeries> InvoiceSeries { get; set; } = new List<InvoiceSeries>();

    public virtual ICollection<InvoiceSplit> InvoiceSplits { get; set; } = new List<InvoiceSplit>();

    public virtual ICollection<JobCostingExtra> JobCostingExtras { get; set; } = new List<JobCostingExtra>();

    public virtual Oelocation? LocationcdNavigation { get; set; }

    public virtual Peemployee? OpsmgrNavigation { get; set; }

    public virtual ICollection<PartCheckinNotification> PartCheckinNotifications { get; set; } = new List<PartCheckinNotification>();

    public virtual ICollection<PeempReview> PeempReviews { get; set; } = new List<PeempReview>();

    public virtual ICollection<Pjjobbudexp> Pjjobbudexps { get; set; } = new List<Pjjobbudexp>();

    public virtual ICollection<Pjjobbudget> Pjjobbudgets { get; set; } = new List<Pjjobbudget>();

    public virtual ICollection<Pjjobexpense> Pjjobexpenses { get; set; } = new List<Pjjobexpense>();

    public virtual ICollection<Pjjobrevenue> Pjjobrevenues { get; set; } = new List<Pjjobrevenue>();

    public virtual PollstarArtist? PollstarArtist { get; set; }

    public virtual ICollection<ProjCalNotesProj> ProjCalNotesProjs { get; set; } = new List<ProjCalNotesProj>();

    public virtual ICollection<ProjectBillingItem> ProjectBillingItemBidEntitynoNavigations { get; set; } = new List<ProjectBillingItem>();

    public virtual ICollection<ProjectBillingItem> ProjectBillingItemEquipmentEntitynoNavigations { get; set; } = new List<ProjectBillingItem>();

    public virtual ICollection<ProjectBillingPeriod> ProjectBillingPeriods { get; set; } = new List<ProjectBillingPeriod>();

    public virtual ICollection<ProjectChecklistValue> ProjectChecklistValues { get; set; } = new List<ProjectChecklistValue>();

    public virtual ICollection<ProjectClientContact> ProjectClientContacts { get; set; } = new List<ProjectClientContact>();

    public virtual ICollection<ProjectProductionSchedule> ProjectProductionSchedules { get; set; } = new List<ProjectProductionSchedule>();

    public virtual ICollection<ProjectsAttachmentTypesToCloudStorageFolder> ProjectsAttachmentTypesToCloudStorageFolders { get; set; } = new List<ProjectsAttachmentTypesToCloudStorageFolder>();

    public virtual ProjectsExceedingInsuranceThresholdAlreadyReported? ProjectsExceedingInsuranceThresholdAlreadyReported { get; set; }

    public virtual ICollection<ProjectsUsersFoldersToCloudStorageFolder> ProjectsUsersFoldersToCloudStorageFolders { get; set; } = new List<ProjectsUsersFoldersToCloudStorageFolder>();

    public virtual Pjproptype? ProptypeNavigation { get; set; }

    public virtual ICollection<PurchaseOrder1> PurchaseOrders1 { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<QuoteReportVaultExpenseResponsibility> QuoteReportVaultExpenseResponsibilities { get; set; } = new List<QuoteReportVaultExpenseResponsibility>();

    public virtual ICollection<QuoteReportVaultHtmlelement> QuoteReportVaultHtmlelements { get; set; } = new List<QuoteReportVaultHtmlelement>();

    public virtual ICollection<QuoteReportVault> QuoteReportVaults { get; set; } = new List<QuoteReportVault>();

    public virtual RackConfiguratorPhaseDetail? RackConfiguratorPhaseDetail { get; set; }

    public virtual ICollection<RackConfigurator> RackConfigurators { get; set; } = new List<RackConfigurator>();

    public virtual ReferralProgram? ReferralProgram { get; set; }

    public virtual ICollection<RepairTicket> RepairTickets { get; set; } = new List<RepairTicket>();

    public virtual Peemployee? RespempnoNavigation { get; set; }

    public virtual ICollection<RevRecActualInvoiceHistory> RevRecActualInvoiceHistories { get; set; } = new List<RevRecActualInvoiceHistory>();

    public virtual ICollection<RevRecInvoicingDetail> RevRecInvoicingDetails { get; set; } = new List<RevRecInvoicingDetail>();

    public virtual RevRecLocked? RevRecLocked { get; set; }

    public virtual ICollection<RevRecProjectAccountBalance> RevRecProjectAccountBalances { get; set; } = new List<RevRecProjectAccountBalance>();

    public virtual ICollection<RevRecProjectHistory> RevRecProjectHistories { get; set; } = new List<RevRecProjectHistory>();

    public virtual ICollection<RevRecRevenueAccountBalance> RevRecRevenueAccountBalances { get; set; } = new List<RevRecRevenueAccountBalance>();

    public virtual ICollection<RevRecTempCurrentProject> RevRecTempCurrentProjects { get; set; } = new List<RevRecTempCurrentProject>();

    public virtual ICollection<RevRecTempProjectAccountBalance> RevRecTempProjectAccountBalances { get; set; } = new List<RevRecTempProjectAccountBalance>();

    public virtual ICollection<RevRecTempProjectCategoryValueBreakdown> RevRecTempProjectCategoryValueBreakdowns { get; set; } = new List<RevRecTempProjectCategoryValueBreakdown>();

    public virtual ICollection<RevRecTempProjectRevenueSummaryToCategorySummary> RevRecTempProjectRevenueSummaryToCategorySummaries { get; set; } = new List<RevRecTempProjectRevenueSummaryToCategorySummary>();

    public virtual ICollection<RevRecTempProjectSummaryToCategorySummary> RevRecTempProjectSummaryToCategorySummaries { get; set; } = new List<RevRecTempProjectSummaryToCategorySummary>();

    public virtual ICollection<Rfi> RfiEntitynoNavigations { get; set; } = new List<Rfi>();

    public virtual ICollection<Rfi> RfiInvEntitynoNavigations { get; set; } = new List<Rfi>();

    public virtual Peemployee? RfplempnoNavigation { get; set; }

    public virtual Peemployee? SecondaryOpsEmpnoNavigation { get; set; }

    public virtual ICollection<ShippingRequestForShipmentVault> ShippingRequestForShipmentVaults { get; set; } = new List<ShippingRequestForShipmentVault>();

    public virtual ICollection<StorageLocationNotificationRecipient> StorageLocationNotificationRecipients { get; set; } = new List<StorageLocationNotificationRecipient>();

    public virtual InvoicingTaxType? TaxTypeKeyNavigation { get; set; }

    public virtual ICollection<Pjtfrusr> UserNames { get; set; } = new List<Pjtfrusr>();
}
