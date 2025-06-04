using System;
using System.Collections.Generic;
using ClairTourTiny.Infrastructure.Dto.DTOs;

using ClairTourTiny.Infrastructure.Models;


namespace ClairTourTiny.Infrastructure.Dto.DTOs
{
    public class AllProjectData
    {
        public UserPermissions UserPermissions { get; set; }
        public IEnumerable<GUIColumnName> GUIColumnNames { get; set; }
        public CrewBillRatesVisibility CrewBillRatesVisibility { get; set; }
        public UserCompanyInfo UserCompanyInfo { get; set; }
        public IEnumerable<CompanyInfo> Companies { get; set; }
        public IEnumerable<ProjectStatus> ProjectStatuses { get; set; }
        public IEnumerable<WarehouseInfo> Warehouses { get; set; }
        public IEnumerable<RateType> RateTypes { get; set; }
        public IEnumerable<ContactCategoryDto> ContactCategories { get; set; }
        public IEnumerable<ProductionScheduleEventTypeDto> ProductionScheduleEventTypes { get; set; }
        public IEnumerable<BillSchedule> BillSchedules { get; set; }
        public IEnumerable<Commodity> Commodities { get; set; }
        public IEnumerable<BillingAccountDto> BillingAccounts { get; set; }
        public IEnumerable<JobType> JobTypes { get; set; }
        public IEnumerable<CrewBidValueDto> CrewBidValues { get; set; }
        public IEnumerable<EmployeeDto> Employees { get; set; }
        public IEnumerable<EmployeeAssignmentStatusCodeDto> EmployeeAssignmentStatuses { get; set; }
        public IEnumerable<PerDiemStatusType> PayingPerDiemStatusTypes { get; set; }
        public IEnumerable<PerDiemBillableStatusType> PerDiemBillableStatusTypes { get; set; }
        public IEnumerable<EmployeeJobType> EmployeeJobTypes { get; set; }
        public IEnumerable<BudgetCategoryDto> BudgetCategories { get; set; }
        public IEnumerable<ExpenseCodeDto> ExpenseCodes { get; set; }
        public IEnumerable<EquipmentSubhireStatusDto> EquipmentSubhireStatuses { get; set; }
        public IEnumerable<ExpenseCategoryDto> ExpenseCategories { get; set; }
        public IEnumerable<ExpensePeriodTypeDTO> ExpensePeriodTypes { get; set; }
        public IEnumerable<PropertyTypeDTO> PropertyTypes { get; set; }
        public IEnumerable<CurrencyDto> Currencies { get; set; }
        public IEnumerable<ReferralProgramDto> ReferralPrograms { get; set; }
        public IEnumerable<string> FavoriteProjects { get; set; }
        public IEnumerable<TaxCodeDto> TaxCodes { get; set; }
        public IEnumerable<ProjectPriceLevelDto> ProjectPriceLevels { get; set; }
        public IEnumerable<AccountMatrix> AccountMatrix { get; set; }
        public IEnumerable<OvertimeRateDto> OvertimeRates { get; set; }
        public IEnumerable<string> UserMenuInclusions { get; set; }
        public IEnumerable<ShippingRequest> ShippingRequests { get; set; }
    }

    public class UserPermissions
    {
        public bool IsOperations { get; set; }
        public bool IsSales { get; set; }
        public bool CanSeeBids { get; set; }
        public bool CanSeeRFIs { get; set; }
        public bool CanEditPartSubhires { get; set; }
        public bool CanSeePurchaseOrders { get; set; }
        public bool CanEditPurchaseOrders { get; set; }
    }

    public class UserCompanyInfo
    {
        public string warehouse_entity { get; set; }
    public string currency { get; set; }
    public int id_language { get; set; }
    public string SalesForecastGroup { get; set; }
    public string DefaultBillingCompany { get; set; }
    public string DefaultPropType { get; set; }
    public string unitoflength { get; set; }
    public string unitofweight { get; set; }
    public decimal conversionFactorFromInches { get; set; }
    public decimal conversionFactorFromPounds { get; set; }
    public int WeightDecimalPlaces { get; set; }
    public int VolumeDecimalPlaces { get; set; }}

    public class CompanyInfo
    {
        public string CompanyCode { get; set; }
        public string CompanyDesc { get; set; }
        public bool Visible { get; set; }
        public bool IncludeInProjectMaintenance { get; set; }
        public string DefaultCrewOpsEmpno { get; set; }
    }

    public class WarehouseInfo
    {
        public string WarehouseCode { get; set; }
        public string WarehouseDesc { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
    }

    public class RateType
    {
        public string RateTypeCode { get; set; }
        public string RateDesc { get; set; }
        public int PeriodDays { get; set; }
        public string ShortRateDesc { get; set; }
    }

    public class ContactCategory
    {
        public int IdContactCategory { get; set; }
        public string ContactCategoryName { get; set; }
        public int SortOrder { get; set; }
    }

    public class ProductionScheduleEventType
    {
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsFirstLoadIn { get; set; }
    }

    public class BillSchedule
    {
        public string BillScheduleCode { get; set; }
        public string ScheduleName { get; set; }
    }

    public class Commodity
    {
        public string CommodityCode { get; set; }
        public string CommodityDesc { get; set; }
    }

    public class BillingAccountDto
    {
        public string CompanyNo { get; set; }
        public string AcctCd { get; set; }
        public string FriendlyName { get; set; }
        public bool Visible { get; set; }
        public bool IsLabor { get; set; }
        public bool IsEquipment { get; set; }
        public bool IsExpense { get; set; }
        public bool IsPerDiem { get; set; }
        public string ExpCd { get; set; }
    }

    public class JobType
    {
        public string JobTypeCode { get; set; }
        public string JobDesc { get; set; }
        public decimal Hours { get; set; }
        public bool IsActive { get; set; }
        public string InMyDivision { get; set; }
    }

    public class CrewBidValue
    {
        public string JobType { get; set; }
        public string Currency { get; set; }
        public decimal BidRate { get; set; }
    }

    public class Employee
    {
        public string EmpNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpName { get; set; }
        public string GroupStatus { get; set; }
        public int DisplayOrder { get; set; }
        public bool InMyDivision { get; set; }
    }

    public class PerDiemStatusType
    {
        public string PayingPerDiemStatusCode { get; set; }
        public string PayingPerDiemStatusDesc { get; set; }
    }

    public class PerDiemBillableStatusType
    {
        public string IsPerDiemBillableStatusCode { get; set; }
        public string IsPerDiemBillableStatusDesc { get; set; }
    }

    public class EmployeeJobType
    {
    public string empno { get; set; }
    public string firstname { get; set; }
    public string lastname { get; set; }
    public string empname { get; set; }
    public string GroupStatus { get; set; }
    public int DisplayOrder { get; set; }
    public bool InMyDivision { get; set; }
    public string jobtype { get; set; }
    }

    public class BudgetCategory
    {
        public string CategoryCode { get; set; }
        public string CategoryDesc { get; set; }
    }

    public class ExpenseCode
    {
        public string ExpCd { get; set; }
        public string Description { get; set; }
        public string BudgetCategoryCode { get; set; }
    }

    public class EquipmentSubhireStatus
    {
        public string StatusCode { get; set; }
        public int SortOrder { get; set; }
    }

    public class ExpenseCategoryDto
    {
        public string CategoryCode { get; set; }
        public string CategoryDesc { get; set; }
    }

    public class ExpensePeriodTypeDTO
    {
        public string PeriodTypeCode { get; set; }
        public string PeriodTypeDesc { get; set; }
    }

    public class PropertyTypeDTO
    {
        public string PropType { get; set; }
        public string TypeDesc { get; set; }
        public decimal BidFactor { get; set; }
        public string BidValueType { get; set; }
        public string DefaultBillSchedule { get; set; }
        public bool IsSalesOrderPropType { get; set; }
    }

    public class Currency
    {
        public string CurrencyCode { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }
        public string Culture { get; set; }
        public bool SymbolOnLeft { get; set; }
        public int RFIEnforcedGranularity { get; set; }
        public int RFIDefaultGranularity { get; set; }
        public string DefaultTaxType { get; set; }
        public int CurrencyPositivePattern { get; set; }
    }

    public class ReferralProgram
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class TaxCodeDto
    {
        public string TaxCode { get; set; }
        public string TaxDesc1 { get; set; }
        public decimal Tax1 { get; set; }
        public string MatrixCd1 { get; set; }
        public string TaxDesc2 { get; set; }
        public decimal Tax2 { get; set; }
        public string MatrixCd2 { get; set; }
        public string TaxDesc3 { get; set; }
        public decimal Tax3 { get; set; }
        public string MatrixCd3 { get; set; }
        public string TaxDesc4 { get; set; }
        public decimal Tax4 { get; set; }
        public string MatrixCd4 { get; set; }
        public string TaxDesc5 { get; set; }
        public decimal Tax5 { get; set; }
        public string MatrixCd5 { get; set; }
        public string ConcatTaxDesc { get; set; }
    }

    public class ProjectPriceLevelDto
    {
        public string PriceLevelValue { get; set; }
        public bool IsDefault { get; set; }
        public bool IsVisible { get; set; }
    }

    public class AccountMatrix
    {
        public string MatrixCd { get; set; }
        public string MatrixDesc { get; set; }
        public string Uom { get; set; }
        public decimal Price { get; set; }
        public string SaleGl { get; set; }
        public string SaleAcctCr { get; set; }
        public string SaleAcctDb { get; set; }
        public string DiscAcctCd { get; set; }
        public string FcAcctCd { get; set; }
        public decimal Cost { get; set; }
        public string CostGl { get; set; }
        public string CostAcctCr { get; set; }
        public string CostAcctLabCr { get; set; }
        public string CostAcctOutCr { get; set; }
        public string CostAcctOh1Cr { get; set; }
        public string CostAcctOh2Cr { get; set; }
        public string CostAcctAcqCr { get; set; }
        public string CostAcctDb { get; set; }
        public string CostAcctLab { get; set; }
        public string CostAcctOut { get; set; }
        public string CostAcctOh1 { get; set; }
        public string CostAcctOh2 { get; set; }
        public string CostAcctAcq { get; set; }
        public string SaleInd { get; set; }
        public string ActiveInd { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }
        public string Ref3 { get; set; }
        public string Ref4 { get; set; }
        public string Ref5 { get; set; }
        public string Ref6 { get; set; }
        public string Ref7 { get; set; }
        public string Ref8 { get; set; }
        public string EntityNo { get; set; }
    }

    public class OvertimeRate
    {
        public string RateType { get; set; }
        public string RateDesc { get; set; }
        public decimal Rate { get; set; }
    }

    public class GUIColumnName
    {
        public string SQLField { get; set; }
        public string ColumnName { get; set; }
        public string TableName { get; set; }
        public string Description { get; set; }
        public bool IsVisible { get; set; }
        public int DisplayOrder { get; set; }
        public string DataType { get; set; }
        public int Width { get; set; }
        public string Format { get; set; }
        public bool IsRequired { get; set; }
        public bool IsReadOnly { get; set; }
        public string DefaultValue { get; set; }
        public string ValidationRule { get; set; }
        public string ValidationMessage { get; set; }
        public string ToolTip { get; set; }
        public string HelpText { get; set; }
        public string Category { get; set; }
        public string Group { get; set; }
        public string SubGroup { get; set; }
        public bool IsSystem { get; set; }
        public bool IsCustom { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }

    public class CrewBillRatesVisibility
    {
        public bool ShowCrewBillRatesOnNonBidProjects { get; set; }
    }

    public class ShippingRequest
    {
        public string ProjectLegNo { get; set; }
        public string EntityNo { get; set; }
        public string EntityDesc { get; set; }
        public DateTime ShipDate { get; set; }
        public string Destination { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string MasterTrackingNumber { get; set; }
        public decimal EstimatedCost { get; set; }
        public decimal Cost { get; set; }
        public int ShippingRequestID { get; set; }
        public string ServiceType { get; set; }
    }

    public class ProjectDataDto
    {
        public string EntityNumber { get; set; }
        public string EntityDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HomeWarehouse { get; set; }
        public string ReturnWarehouse { get; set; }
        public double TotalVolume { get; set; }
        public double TotalWeight { get; set; }
        public string ProjectStatus { get; set; }
        public string BillingCompany { get; set; }
        public string CustomerNumber { get; set; }
        public string SubNumber { get; set; }
        public string ShipNumber { get; set; }
        public string InternalOrg { get; set; }
        public string EngineeringActiveCode { get; set; }
        public string FinancialActiveCode { get; set; }
        public string ProjectListActiveCode { get; set; }
        public string SalesForecastActiveCode { get; set; }
        public string OperationsManager { get; set; }
        public string Engineer { get; set; }
        public string AccountExecutive { get; set; }
        public string RFPLConsultant { get; set; }
        public double BidMarkup { get; set; }
        public int Probability { get; set; }
        public string Currency { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public DateTime LoadOut { get; set; }
        public DateTime CrewPrep { get; set; }
        public DateTime FirstShow { get; set; }
        public DateTime LastShow { get; set; }
        public double TotalEquipmentCost { get; set; }
        public string EquipmentItemCount { get; set; }
    }

    public class CreateProjectDataDto
    {
        public string EntityDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string HomeWarehouse { get; set; }
        public string ReturnWarehouse { get; set; }
        public string BillingCompany { get; set; }
        public string CustomerNumber { get; set; }
        public string SubNumber { get; set; }
        public string ShipNumber { get; set; }
        public string InternalOrg { get; set; }
        public string EngineeringActiveCode { get; set; }
        public string FinancialActiveCode { get; set; }
        public string ProjectListActiveCode { get; set; }
        public string SalesForecastActiveCode { get; set; }
        public string OperationsManager { get; set; }
        public string Engineer { get; set; }
        public string AccountExecutive { get; set; }
        public string RFPLConsultant { get; set; }
        public double BidMarkup { get; set; }
        public int Probability { get; set; }
        public string Currency { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public DateTime LoadOut { get; set; }
        public DateTime CrewPrep { get; set; }
        public DateTime FirstShow { get; set; }
        public DateTime LastShow { get; set; }
    }

    public class UpdateProjectDataDto
    {
        public string EntityDescription { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string HomeWarehouse { get; set; }
        public string ReturnWarehouse { get; set; }
        public string BillingCompany { get; set; }
        public string CustomerNumber { get; set; }
        public string SubNumber { get; set; }
        public string ShipNumber { get; set; }
        public string InternalOrg { get; set; }
        public string EngineeringActiveCode { get; set; }
        public string FinancialActiveCode { get; set; }
        public string ProjectListActiveCode { get; set; }
        public string SalesForecastActiveCode { get; set; }
        public string OperationsManager { get; set; }
        public string Engineer { get; set; }
        public string AccountExecutive { get; set; }
        public string RFPLConsultant { get; set; }
        public double? BidMarkup { get; set; }
        public int? Probability { get; set; }
        public string Currency { get; set; }
        public DateTime? ExchangeRateDate { get; set; }
        public DateTime? LoadOut { get; set; }
        public DateTime? CrewPrep { get; set; }
        public DateTime? FirstShow { get; set; }
        public DateTime? LastShow { get; set; }
    }

    public class ProjectDataFilterDto
    {
        public string EntityNumber { get; set; }
        public string EntityDescription { get; set; }
        public DateTime? StartDateFrom { get; set; }
        public DateTime? StartDateTo { get; set; }
        public DateTime? EndDateFrom { get; set; }
        public DateTime? EndDateTo { get; set; }
        public string HomeWarehouse { get; set; }
        public string ReturnWarehouse { get; set; }
        public string ProjectStatus { get; set; }
        public string BillingCompany { get; set; }
        public string CustomerNumber { get; set; }
        public string OperationsManager { get; set; }
        public string Engineer { get; set; }
        public string AccountExecutive { get; set; }
        public int? Probability { get; set; }
        public string Currency { get; set; }
    }
} 