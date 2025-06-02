using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjtfrusr
{
    public string UserName { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public string OwnerEntity { get; set; } = null!;

    public string WarehouseEntity { get; set; } = null!;

    public string TourEntity { get; set; } = null!;

    public string StartupProgram { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public int IdLanguage { get; set; }

    public string Unitofweight { get; set; } = null!;

    public string Unitoflength { get; set; } = null!;

    public string DoubleclickProgramProject { get; set; } = null!;

    public string DoubleclickProgramNoProject { get; set; } = null!;

    public int IdMyFinesseUpdate { get; set; }

    public string? Email { get; set; }

    public string DefaultBillingCompany { get; set; } = null!;

    public string DefaultPropType { get; set; } = null!;

    public DateTime? LastGlobalActivity { get; set; }

    public bool VisibleOnInOutBoard { get; set; }

    public string? PhoneExtension { get; set; }

    public string? Initials { get; set; }

    public string Culture { get; set; } = null!;

    public string? BarcodeSequenceType { get; set; }

    public virtual ICollection<AvailMultipartGroup1> AvailMultipartGroup1s { get; set; } = new List<AvailMultipartGroup1>();

    public virtual IdnumberSequenceType? BarcodeSequenceTypeNavigation { get; set; }

    public virtual ICollection<CompanyNewProjectNotification> CompanyNewProjectNotifications { get; set; } = new List<CompanyNewProjectNotification>();

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual Company DefaultBillingCompanyNavigation { get; set; } = null!;

    public virtual Pjproptype DefaultPropTypeNavigation { get; set; } = null!;

    public virtual ICollection<HtmlReportBlocksArchive> HtmlReportBlocksArchives { get; set; } = new List<HtmlReportBlocksArchive>();

    public virtual XlatLanguage IdLanguageNavigation { get; set; } = null!;

    public virtual ICollection<Intran> Intrans { get; set; } = new List<Intran>();

    public virtual ICollection<MyFinesseEmailNotification> MyFinesseEmailNotifications { get; set; } = new List<MyFinesseEmailNotification>();

    public virtual ICollection<MyFinesseMultiGridConfig> MyFinesseMultiGridConfigs { get; set; } = new List<MyFinesseMultiGridConfig>();

    public virtual ICollection<MyFinesseUpdate> MyFinesseUpdates { get; set; } = new List<MyFinesseUpdate>();

    public virtual EquipmentOwner OwnerEntityNavigation { get; set; } = null!;

    public virtual ICollection<PartBidValue> PartBidValues { get; set; } = new List<PartBidValue>();

    public virtual ICollection<PeempReview> PeempReviewUserCreatedNavigations { get; set; } = new List<PeempReview>();

    public virtual ICollection<PeempReview> PeempReviewUserModifiedNavigations { get; set; } = new List<PeempReview>();

    public virtual ICollection<PollstarReaderHideArtistUntil1> PollstarReaderHideArtistUntil1s { get; set; } = new List<PollstarReaderHideArtistUntil1>();

    public virtual ICollection<ProjectChecklistValue> ProjectChecklistValues { get; set; } = new List<ProjectChecklistValue>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1CanceledByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1CreatedByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1ModifiedByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1PaidByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1PayAuthorizedByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1PostedByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1PurchaserNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1RequestedByNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrderInvoice> PurchaseOrderInvoiceCreatedByNavigations { get; set; } = new List<PurchaseOrderInvoice>();

    public virtual ICollection<PurchaseOrderInvoice> PurchaseOrderInvoiceModifiedByNavigations { get; set; } = new List<PurchaseOrderInvoice>();

    public virtual ICollection<PurchaseOrderInvoice> PurchaseOrderInvoicePaidByNavigations { get; set; } = new List<PurchaseOrderInvoice>();

    public virtual ICollection<PurchaseOrderInvoice> PurchaseOrderInvoicePayAuthorizedByNavigations { get; set; } = new List<PurchaseOrderInvoice>();

    public virtual ICollection<PurchaseOrderLineItems> PurchaseOrderLineItemCreatedByNavigations { get; set; } = new List<PurchaseOrderLineItems>();

    public virtual ICollection<PurchaseOrderLineItems> PurchaseOrderLineItemModifiedByNavigations { get; set; } = new List<PurchaseOrderLineItems>();

    public virtual ICollection<PurchaseOrderLineItemsReceipt> PurchaseOrderLineItemsReceipts { get; set; } = new List<PurchaseOrderLineItemsReceipt>();

    public virtual ICollection<QuoteReportTemplate1> QuoteReportTemplate1s { get; set; } = new List<QuoteReportTemplate1>();

    public virtual ICollection<QuoteReportVault> QuoteReportVaults { get; set; } = new List<QuoteReportVault>();

    public virtual ICollection<RepairActivity> RepairActivities { get; set; } = new List<RepairActivity>();

    public virtual ICollection<ShippingRequestForShipmentVault> ShippingRequestForShipmentVaults { get; set; } = new List<ShippingRequestForShipmentVault>();

    public virtual ICollection<TrainingTopicsUser> TrainingTopicsUsers { get; set; } = new List<TrainingTopicsUser>();

    public virtual InUnitOfLength UnitoflengthNavigation { get; set; } = null!;

    public virtual InUnitOfWeight UnitofweightNavigation { get; set; } = null!;

    public virtual ICollection<UserPreference> UserPreferences { get; set; } = new List<UserPreference>();

    public virtual ICollection<UserWarehouseGroup> UserWarehouseGroups { get; set; } = new List<UserWarehouseGroup>();

    public virtual ICollection<UserWarehouseGroupsWarehouse> UserWarehouseGroupsWarehouses { get; set; } = new List<UserWarehouseGroupsWarehouse>();

    public virtual Warehouse WarehouseEntityNavigation { get; set; } = null!;

    public virtual ICollection<Company> CompanyCodes { get; set; } = new List<Company>();

    public virtual ICollection<Company> CompanyCodesNavigation { get; set; } = new List<Company>();

    public virtual ICollection<Glentity> Entitynos { get; set; } = new List<Glentity>();

    public virtual ICollection<ProjectChecklistItem> IdItems { get; set; } = new List<ProjectChecklistItem>();

    public virtual ICollection<MyFinesseQuery> IdQueries { get; set; } = new List<MyFinesseQuery>();

    public virtual ICollection<Mumenu> Mumenus { get; set; } = new List<Mumenu>();

    public virtual ICollection<Warehouse> WarehouseCodes { get; set; } = new List<Warehouse>();
}
