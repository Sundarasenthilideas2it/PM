using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Company
{
    public string CompanyCode { get; set; } = null!;

    public string CompanyDesc { get; set; } = null!;

    public string ParentCompanyCode { get; set; } = null!;

    public string CountryCode { get; set; } = null!;

    public bool IncludeInSalesForecast { get; set; }

    public int? DefaultInvoicingTaxGroup { get; set; }

    public string SalesForecastGroup { get; set; } = null!;

    public string InternalOrg { get; set; } = null!;

    public string? Locationcd { get; set; }

    public bool DoRevRec { get; set; }

    public string DefaultPrinterPaperSize { get; set; } = null!;

    public string? VatidentificationNumber { get; set; }

    public string? Abbreviation { get; set; }

    public string? IntercompanyBillingLessorOverride { get; set; }

    public string? IntercompanyBillingLesseeOverride { get; set; }

    public bool EnableInpartsubRefChildLinking { get; set; }

    public string CrewPaymentSchedulePeriodStartDays { get; set; } = null!;

    public string CrewPaymentScheduleDueDays { get; set; } = null!;

    public bool HasUsedGearStorePage { get; set; }

    public bool HasFedExMasterAccount { get; set; }

    public string? Unitofweight { get; set; }

    public string DefaultPayTermsCd { get; set; } = null!;

    public string? ProformaInvoiceSequenceType { get; set; }

    public bool IsRentalCompany { get; set; }

    public string? SysproCompanyCode { get; set; }

    public bool IsUsingSyspro { get; set; }

    public string? RoadPayExportFolder { get; set; }

    public bool DoRoadPayExport { get; set; }

    public bool SysproInvoiceAutoDeferRevenue { get; set; }

    public bool AutoPostSysproInvoices { get; set; }

    public string? Eorinumber { get; set; }

    public bool UseParentCompanyReportHeader { get; set; }

    public string QuoteReportGreetingText { get; set; } = null!;

    public bool IsClairTouring { get; set; }

    public string? DefaultCrewOpsEmpno { get; set; }

    public string? TouringRevenueGroup { get; set; }

    public string? IfscompanyCd { get; set; }

    public bool? ShowCrewBillRatesOnNonBidProjects { get; set; }

    public bool Active { get; set; }

    public bool IncludeInProjectMaintenance { get; set; }

    public string? IfscompanyCodeForInvoicing { get; set; }

    public virtual ICollection<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();

    public virtual ICollection<BillingAccount> BillingAccounts { get; set; } = new List<BillingAccount>();

    public virtual ICollection<BillingDaysBenchmark> BillingDaysBenchmarks { get; set; } = new List<BillingDaysBenchmark>();

    public virtual ICollection<ClairTourTaxCodesToSyproTaxCodesMapping> ClairTourTaxCodesToSyproTaxCodesMappings { get; set; } = new List<ClairTourTaxCodesToSyproTaxCodesMapping>();

    public virtual CompanyNewProjectNotification? CompanyNewProjectNotification { get; set; }

    public virtual ICollection<CompanyShippingServiceType> CompanyShippingServiceTypes { get; set; } = new List<CompanyShippingServiceType>();

    public virtual Country CountryCodeNavigation { get; set; } = null!;

    public virtual Peemployee? DefaultCrewOpsEmpnoNavigation { get; set; }

    public virtual ICollection<DryHireBillingDaysRate> DryHireBillingDaysRates { get; set; } = new List<DryHireBillingDaysRate>();

    public virtual ICollection<EquipmentOwner> EquipmentOwners { get; set; } = new List<EquipmentOwner>();

    public virtual FedExLinkedAccountsNumber? FedExLinkedAccountsNumber { get; set; }

    public virtual ICollection<FinesseCategoriesShopifyCollection> FinesseCategoriesShopifyCollections { get; set; } = new List<FinesseCategoriesShopifyCollection>();

    public virtual ICollection<Glentity> Glentities { get; set; } = new List<Glentity>();

    public virtual ICollection<InpartUsedGearSalesInfo> InpartUsedGearSalesInfos { get; set; } = new List<InpartUsedGearSalesInfo>();

    public virtual IntercompanyBillingEquipValueAdjust? IntercompanyBillingEquipValueAdjust { get; set; }

    public virtual Pedivision InternalOrgNavigation { get; set; } = null!;

    public virtual ICollection<Company> InverseParentCompanyCodeNavigation { get; set; } = new List<Company>();

    public virtual Oelocation? LocationcdNavigation { get; set; }

    public virtual Company ParentCompanyCodeNavigation { get; set; } = null!;

    public virtual ICollection<Pedivision> Pedivisions { get; set; } = new List<Pedivision>();

    public virtual ICollection<Pjtfrusr> Pjtfrusrs { get; set; } = new List<Pjtfrusr>();

    public virtual IdnumberSequenceType? ProformaInvoiceSequenceTypeNavigation { get; set; }

    public virtual ICollection<PurchaseOrder1> PurchaseOrders1 { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchasingAccount> PurchasingAccounts { get; set; } = new List<PurchasingAccount>();

    public virtual ICollection<RevRecActualInvoiceHistory> RevRecActualInvoiceHistories { get; set; } = new List<RevRecActualInvoiceHistory>();

    public virtual ICollection<RevRecCategoryMapping> RevRecCategoryMappings { get; set; } = new List<RevRecCategoryMapping>();

    public virtual ICollection<RevRecInvoicingDetail> RevRecInvoicingDetails { get; set; } = new List<RevRecInvoicingDetail>();

    public virtual ICollection<RevRecProjectAccountBalance> RevRecProjectAccountBalances { get; set; } = new List<RevRecProjectAccountBalance>();

    public virtual ICollection<RevRecProjectHistory> RevRecProjectHistories { get; set; } = new List<RevRecProjectHistory>();

    public virtual ICollection<RevRecTempCurrentProject> RevRecTempCurrentProjects { get; set; } = new List<RevRecTempCurrentProject>();

    public virtual ICollection<RevRecTempProjectAccountBalance> RevRecTempProjectAccountBalances { get; set; } = new List<RevRecTempProjectAccountBalance>();

    public virtual ICollection<RevRecTempProjectCategoryValueBreakdown> RevRecTempProjectCategoryValueBreakdowns { get; set; } = new List<RevRecTempProjectCategoryValueBreakdown>();

    public virtual ICollection<RevRecTempProjectRevenueSummaryToCategorySummary> RevRecTempProjectRevenueSummaryToCategorySummaries { get; set; } = new List<RevRecTempProjectRevenueSummaryToCategorySummary>();

    public virtual ICollection<RevRecTempProjectSummaryToCategorySummary> RevRecTempProjectSummaryToCategorySummaries { get; set; } = new List<RevRecTempProjectSummaryToCategorySummary>();

    public virtual ICollection<Rfi> Rfis { get; set; } = new List<Rfi>();

    public virtual SalesForecastGroup SalesForecastGroupNavigation { get; set; } = null!;

    public virtual ICollection<SalesForecastGroupOverride> SalesForecastGroupOverrides { get; set; } = new List<SalesForecastGroupOverride>();

    public virtual ICollection<ShopifyApiInfo> ShopifyApiInfos { get; set; } = new List<ShopifyApiInfo>();

    public virtual SysproCompany? SysproCompanyCodeNavigation { get; set; }

    public virtual ICollection<TaxAccount> TaxAccounts { get; set; } = new List<TaxAccount>();

    public virtual TouringRevenueGroup? TouringRevenueGroupNavigation { get; set; }

    public virtual InUnitOfWeight? UnitofweightNavigation { get; set; }

    public virtual ICollection<UsedGearSalesCollection> UsedGearSalesCollections { get; set; } = new List<UsedGearSalesCollection>();

    public virtual ICollection<UsedGearSalesPartCollection> UsedGearSalesPartCollections { get; set; } = new List<UsedGearSalesPartCollection>();

    public virtual ICollection<Warehouse> Warehouses { get; set; } = new List<Warehouse>();

    public virtual ICollection<Pjtfrusr> UserNames { get; set; } = new List<Pjtfrusr>();

    public virtual ICollection<Pjtfrusr> UserNamesNavigation { get; set; } = new List<Pjtfrusr>();
}
