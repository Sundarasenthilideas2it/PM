using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using ClairTourTiny.Core.Models;
using ClairTourTiny.Infrastructure.Dto.DTOs;
using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ClairTourTiny.Infrastructure;

namespace ClairTourTiny.Core.Services
{
    /// <summary>
    /// Implementation of IProjectDataService for managing project data and related information
    /// </summary>
    public class ProjectDataPointsService : IProjectDataPointsService
    {
        private readonly string _connectionString;
        private readonly ILogger<ProjectDataPointsService> _logger;
        private readonly ClairTourTinyContext _context;

        public ProjectDataPointsService(
            IConfiguration configuration, 
            ILogger<ProjectDataPointsService> logger, 
            ClairTourTinyContext context)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            _logger = logger;
            _context = context;
        }

        public async Task<AllProjectData> GetAllProjectData(string? projectNumber = null)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = new AllProjectData();

                // User Permissions
                var permissionsSql = @"
                    SELECT 
                        isOperations = is_member('Operations'),
                        isSales = is_member('Sales/Admin'),
                        can_see_bids = dbo.can_see_bids(),
                        can_see_RFIs = dbo.can_see_RFIs(),
                        can_edit_part_subhires = dbo.can_edit_part_subhires(),
                        can_see_purchase_orders = dbo.can_see_purchase_orders(),
                        can_edit_purchase_orders = dbo.can_edit_purchase_orders()";
                result.UserPermissions = await connection.QueryFirstOrDefaultAsync<UserPermissions>(permissionsSql);

                // GUI Column Names
                result.GUIColumnNames = await connection.QueryAsync<GUIColumnName>("SELECT * FROM dbo.GUIColumnNamesFromSQLFields");

                // Crew Bill Rates Visibility
                var crewBillRatesSql = @"
                    SELECT ShowCrewBillRatesOnNonBidProjects = ISNULL(ShowCrewBillRatesOnNonBidProjects, 0) 
                    FROM dbo.pjtfrusr u 
                    JOIN dbo.Company c ON c.CompanyCode = u.DefaultBillingCompany 
                    WHERE user_name = SUSER_NAME()";
                result.CrewBillRatesVisibility = await connection.QueryFirstOrDefaultAsync<CrewBillRatesVisibility>(crewBillRatesSql);

                // User Company Info
                result.UserCompanyInfo = await connection.QueryFirstOrDefaultAsync<UserCompanyInfo>(@"
                    SELECT 
                        warehouse_entity, currency, id_language,
                        SalesForecastGroup, DefaultBillingCompany, DefaultPropType,
                        unitoflength, unitofweight,
                        conversionFactorFromInches, conversionFactorFromPounds,
                        WeightDecimalPlaces, VolumeDecimalPlaces
                    FROM dbo.my_user_info mui");

                // Companies
                result.Companies = await connection.QueryAsync<CompanyInfo>(@"
                    SELECT 
                        c.CompanyCode, c.CompanyDesc, 
                        Visible = convert(bit, case when mcv.CompanyCode is null then 0 else 1 end),
                        IncludeInProjectMaintenance, c.DefaultCrewOpsEmpno
                    FROM dbo.Company c
                    LEFT OUTER JOIN dbo.my_company_visible mcv ON c.CompanyCode = mcv.CompanyCode");

                // Project Statuses
                result.ProjectStatuses = await connection.QueryAsync<ProjectStatus>("SELECT StatusCode, StatusDesc, DisplayOrder FROM dbo.ProjectStatus");

                // Warehouses
                result.Warehouses = await connection.QueryAsync<WarehouseInfo>(@"
                    SELECT 
                        w.WarehouseCode, w.WarehouseDesc,
                        IsActive = w.isVisible,
                        IsVisible = convert(bit, case when mwv.WarehouseCode is null then 0 else 1 end)
                    FROM dbo.Warehouse w
                    LEFT OUTER JOIN dbo.my_warehouse_visible mwv ON w.WarehouseCode = mwv.WarehouseCode
                    WHERE w.isVisible = 1");

                // Rate Types
                result.RateTypes = await connection.QueryAsync<RateType>("SELECT ratetype, ratedesc, perioddays, ShortRateDesc FROM dbo.pjinvratetype");

                // Contact Categories
                result.ContactCategories = await connection.QueryAsync<ContactCategoryDto>(@"
                    SELECT id_ContactCategory, ContactCategory, SortOrder 
                    FROM dbo.ContactCategory 
                    WHERE isProjectClientContact = 1 
                    ORDER BY SortOrder");

                // Production Schedule Event Types
                result.ProductionScheduleEventTypes = await connection.QueryAsync<ProductionScheduleEventTypeDto>(@"
                    SELECT TypeCode, TypeDescription, DisplayOrder, isFirstLoadIn 
                    FROM dbo.ProductionScheduleEventType 
                    ORDER BY DisplayOrder");

                // Bill Schedules
                result.BillSchedules = await connection.QueryAsync<BillSchedule>("SELECT billschedule, ScheduleName FROM dbo.pjBillSchedules");

                // Commodities
                result.Commodities = await connection.QueryAsync<Commodity>(@"
                    SELECT DISTINCT c.commodity, c.commoditydesc
                    FROM dbo.inpart p
                    JOIN dbo.incommodity c ON p.commmodity = c.commodity");

                // Billing Accounts
                var billingAccountsSql = @"
                    SELECT companyno, acctcd, FriendlyName, Visible, 
                           IsLabor, IsEquipment, IsExpense, IsPerDiem, expcd 
                    FROM dbo.BillingAccounts";
                var billingAccounts = await connection.QueryAsync<BillingAccount>(billingAccountsSql);
                result.BillingAccounts = billingAccounts.Select(ba => new BillingAccountDto
                {
                    CompanyNo = ba.Companyno,
                    AcctCd = ba.Acctcd,
                    FriendlyName = ba.FriendlyName,
                    Visible = ba.Visible,
                    IsLabor = ba.IsLabor,
                    IsEquipment = ba.IsEquipment,
                    IsExpense = ba.IsExpense,
                    IsPerDiem = ba.IsPerDiem,
                    ExpCd = ba.Expcd
                });

                // Job Types
                result.JobTypes = await connection.QueryAsync<JobType>(@"
                    SELECT jobtype, jobdesc, hours, isActive, InMyDivision 
                    FROM JobTypes_In_My_Division 
                    ORDER BY InMyDivision");

                // Crew Bid Values
                result.CrewBidValues = await connection.QueryAsync<CrewBidValueDto>("SELECT jobtype, currency, BidRate FROM dbo.CrewBidValues");

                // Employees
                result.Employees = await connection.QueryAsync<EmployeeDto>(@"
                    SELECT empno, firstname, lastname, empname, GroupStatus, DisplayOrder, InMyDivision 
                    FROM Employees_In_My_Division 
                    ORDER BY DisplayOrder, InMyDivision DESC");

                // Employee Assignment Statuses
                result.EmployeeAssignmentStatuses = await connection.QueryAsync<EmployeeAssignmentStatusCodeDto>("SELECT StatusCode, StatusDesc, DisplayOrder FROM dbo.EmployeeAssignmentStatus");

                // Per Diem Status Types
                result.PayingPerDiemStatusTypes = await connection.QueryAsync<PerDiemStatusType>("SELECT PayingPerDiemStatusCode, PayingPerDiemStatusDesc FROM dbo.PayingPerDiemStatusTypes");
                result.PerDiemBillableStatusTypes = await connection.QueryAsync<PerDiemBillableStatusType>("SELECT IsPerDiemBillableStatusCode, IsPerDiemBillableStatusDesc FROM dbo.IsPerDiemBillableStatusTypes");

                // Employee Job Types
                result.EmployeeJobTypes = await connection.QueryAsync<EmployeeJobType>(@"
                    SELECT jt.empno, jt.jobtype 
                    FROM dbo.peEmployeeJobTypes jt
                    JOIN dbo.peemployee e ON e.empno = jt.empno
                    WHERE jt.jobtype in ('ACCTEXEC','OPERATIONS','ENGR','CRFPLENGR', 'CREWOPS') 
                    AND (e.empstatus = 'A' OR e.empstatus = 'R')");

                // Budget Categories
                result.BudgetCategories = await connection.QueryAsync<BudgetCategoryDto>("SELECT CategoryCode, CategoryDesc FROM dbo.BudgetCategories");

                // Expense Codes
                result.ExpenseCodes = await connection.QueryAsync<ExpenseCodeDto>("SELECT expcd, Description = expdesc, BudgetCategoryCode FROM dbo.apexpcode");

                // Equipment Subhire Statuses
                result.EquipmentSubhireStatuses = await GetEquipmentSubhireStatuses();

                // Expense Categories
                result.ExpenseCategories = await connection.QueryAsync<ExpenseCategoryDto>("SELECT CategoryCode, CategoryDesc FROM dbo.ExpenseCategories");

                // Expense Period Types
                result.ExpensePeriodTypes = await connection.QueryAsync<ExpensePeriodTypeDTO>("SELECT PeriodTypeCode, PeriodTypeDesc FROM dbo.ExpensePeriodTypes");

                // Property Types
                result.PropertyTypes = await connection.QueryAsync<PropertyTypeDTO>(@"
                    SELECT proptype, typedesc, BidFactor, BidValueType, 
                           DefaultBillSchedule, isSalesOrderPropType 
                    FROM dbo.pjproptype");

                // Currencies
                result.Currencies = await connection.QueryAsync<CurrencyDto>(@"
                    SELECT currency, description, symbol, culture, SymbolOnLeft, 
                           RFIEnforcedGranularity, RFIDefaultGranularity, 
                           DefaultTaxType, CurrencyPositivePattern 
                    FROM dbo.currency");

                // Referral Programs
                result.ReferralPrograms = await connection.QueryAsync<ReferralProgramDto>("SELECT ID = ReferralProgramID, Description = ReferralProgramDesc FROM dbo.ReferralProgram");

                // Favorite Projects
                result.FavoriteProjects = await connection.QueryAsync<string>("SELECT entityno FROM dbo.FavoriteProjects WHERE user_name = suser_sname()");

                // Tax Codes
                result.TaxCodes = await connection.QueryAsync<TaxCodeDto>(@"
                    SELECT tax_code, taxdesc1, tax1, matrixcd1, 
                           taxdesc2, tax2, matrixcd2, 
                           taxdesc3, tax3, matrixcd3, 
                           taxdesc4, tax4, matrixcd4, 
                           taxdesc5, tax5, matrixcd5,
                           CONCAT(taxdesc2, ', ', taxdesc3, ', ', taxdesc4) AS ConcatTaxDesc 
                    FROM dbo.oetax_codes");

                // Project Price Levels
                var priceLevelsSql = "SELECT PriceLevelValue, isDefault, isVisible FROM dbo.ProjectPriceLevels ORDER BY PriceLevelValue";
                var priceLevels = await connection.QueryAsync<ProjectPriceLevel>(priceLevelsSql);
                result.ProjectPriceLevels = priceLevels.Select(pl => new ProjectPriceLevelDto
                {
                    PriceLevelValue = pl.PriceLevelValue.ToString(),
                    IsDefault = pl.IsDefault,
                    IsVisible = pl.IsVisible
                });

                // Account Matrix
                result.AccountMatrix = await connection.QueryAsync<AccountMatrix>(@"
                    SELECT matrixcd, matrixdesc, uom, price, salegl, saleacctcr, saleacctdb,
                           discacctcd, fcacctcd, cost, costgl, costacctcr, costacctlabcr,
                           costacctoutcr, costacctoh1cr, costacctoh2cr, costacctacqcr,
                           costacctdb, costacctlab, costacctout, costacctoh1, costacctoh2,
                           costacctacq, saleind, activeind, ref1, ref2, ref3, ref4, ref5,
                           ref6, ref7, ref8, entityno
                    FROM dbo.oeacctmatrix");

                // Overtime Rates
                result.OvertimeRates = await GetOvertimeRates();

                // User Menu Inclusions
                result.UserMenuInclusions = await connection.QueryAsync<string>(@"
                    SELECT x.appexe
                    FROM dbo.user_menu_inclusions umi
                    JOIN dbo.mumenus m ON umi.packagecd = m.packagecd AND umi.cmndsel = m.cmndsel
                    CROSS APPLY (SELECT appexe = replace(m.appexec,'%ESSVBDir%\','') + m.appframe) x
                    WHERE x.appexe IN (
                        'ProjectCalendar', 'prjpjlistinq', 'SalesForecast', 'Project Checklist',
                        'TransferInquiryTools', 'prjpjunavl', 'Rack Configurator', 'Query Tools',
                        'Batch Pick Report', 'Project Storyboard', 'Crew Tools', 'Employee Maintenance',
                        'Shipping Tools', 'prjpjinvcal', 'Scheduling Board', 'Part Maintenance',
                        'Part Attachments Maintenance', 'Cycle Count', 'Utilization', 'BidReport',
                        'ProposalReport', 'Dry Hire Report', 'Certifications Report', 'Hidden',
                        'TouringInvoicing', 'Contact Maintenance'
                    )");

                // Shipping Requests (if project number provided)
                if (!string.IsNullOrEmpty(projectNumber))
                {
                    var shippingRequestsSql = @"
                        DECLARE @p varchar(50) = '%-[0-9]%-%'
                        SELECT 
                            substring(s.entityno,0,patindex(@p,s.entityno) + patindex('%-%',substring(s.entityno,patindex(@p,s.entityno)+1,100))) as ProjectLegNo,
                            s.entityno, g.entitydesc, s.ShipDate, s.DestinationName as Destination, 
                            s.City, s.State, p.MasterTrackingNumber, s.Amount as EstimatedCost, 
                            (s.Amount * 1.25) as Cost, s.idShippingRequest as ShippingRequestID, 
                            s.ServiceTypeDisplayName as ServiceType
                        FROM dbo.ShippingRequestForShipmentVault s
                        LEFT JOIN dbo.glentities g ON g.entityno = s.entityno
                        LEFT JOIN dbo.ShippingPackages p ON p.idShippingRequest = s.idShippingRequest
                        WHERE s.entityno LIKE @ProjectNumber + '-%'";
                    result.ShippingRequests = await connection.QueryAsync<ShippingRequest>(shippingRequestsSql, new { ProjectNumber = projectNumber });
                }

                return result;
            }
        }

        public async Task<UserPermissions> GetUserPermissions()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT 
                        isOperations = is_member('Operations'),
                        isSales = is_member('Sales/Admin'),
                        can_see_bids = dbo.can_see_bids(),
                        can_see_RFIs = dbo.can_see_RFIs(),
                        can_edit_part_subhires = dbo.can_edit_part_subhires(),
                        can_see_purchase_orders = dbo.can_see_purchase_orders(),
                        can_edit_purchase_orders = dbo.can_edit_purchase_orders()";

                return await connection.QueryFirstOrDefaultAsync<UserPermissions>(sql);
            }
        }

        public async Task<UserCompanyInfo> GetUserCompanyInfo()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT 
                        warehouse_entity, currency, id_language,
                        SalesForecastGroup, DefaultBillingCompany, DefaultPropType,
                        unitoflength, unitofweight,
                        conversionFactorFromInches, conversionFactorFromPounds,
                        WeightDecimalPlaces, VolumeDecimalPlaces
                    FROM dbo.my_user_info mui";

                return await connection.QueryFirstOrDefaultAsync<UserCompanyInfo>(sql);
            }
        }

        public async Task<IEnumerable<CompanyInfo>> GetCompanies()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT 
                        c.CompanyCode, c.CompanyDesc, 
                        Visible = convert(bit, case when mcv.CompanyCode is null then 0 else 1 end),
                        IncludeInProjectMaintenance, c.DefaultCrewOpsEmpno
                    FROM dbo.Company c
                    LEFT OUTER JOIN dbo.my_company_visible mcv ON c.CompanyCode = mcv.CompanyCode";

                return await connection.QueryAsync<CompanyInfo>(sql);
            }
        }

        public async Task<IEnumerable<ProjectStatus>> GetProjectStatuses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT StatusCode, StatusDesc, DisplayOrder FROM dbo.ProjectStatus";
                return await connection.QueryAsync<ProjectStatus>(sql);
            }
        }

        public async Task<IEnumerable<WarehouseInfo>> GetWarehouses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT 
                        w.WarehouseCode, w.WarehouseDesc,
                        IsActive = w.isVisible,
                        IsVisible = convert(bit, case when mwv.WarehouseCode is null then 0 else 1 end)
                    FROM dbo.Warehouse w
                    LEFT OUTER JOIN dbo.my_warehouse_visible mwv ON w.WarehouseCode = mwv.WarehouseCode
                    WHERE w.isVisible = 1";

                return await connection.QueryAsync<WarehouseInfo>(sql);
            }
        }

        public async Task<IEnumerable<RateType>> GetRateTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT ratetype, ratedesc, perioddays, ShortRateDesc FROM dbo.pjinvratetype";
                return await connection.QueryAsync<RateType>(sql);
            }
        }

        public async Task<IEnumerable<ContactCategoryDto>> GetContactCategories()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT id_ContactCategory, ContactCategory, SortOrder 
                    FROM dbo.ContactCategory 
                    WHERE isProjectClientContact = 1 
                    ORDER BY SortOrder";
                return await connection.QueryAsync<ContactCategoryDto>(sql);
            }
        }

        public async Task<IEnumerable<ProductionScheduleEventTypeDto>> GetProductionScheduleEventTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT TypeCode, TypeDescription, DisplayOrder, isFirstLoadIn 
                    FROM dbo.ProductionScheduleEventType 
                    ORDER BY DisplayOrder";
                return await connection.QueryAsync<ProductionScheduleEventTypeDto>(sql);
            }
        }

        public async Task<IEnumerable<BillSchedule>> GetBillSchedules()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT billschedule, ScheduleName FROM dbo.pjBillSchedules";
                return await connection.QueryAsync<BillSchedule>(sql);
            }
        }

        public async Task<IEnumerable<Commodity>> GetCommodities()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT DISTINCT c.commodity, c.commoditydesc
                    FROM dbo.inpart p
                    JOIN dbo.incommodity c ON p.commmodity = c.commodity";
                return await connection.QueryAsync<Commodity>(sql);
            }
        }

        public async Task<IEnumerable<BillingAccountDto>> GetBillingAccounts()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT companyno, acctcd, FriendlyName, Visible, 
                           IsLabor, IsEquipment, IsExpense, IsPerDiem, expcd 
                    FROM dbo.BillingAccounts";
                return await connection.QueryAsync<BillingAccountDto>(sql);
            }
        }

        public async Task<IEnumerable<JobType>> GetJobTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT jobtype, jobdesc, hours, isActive, InMyDivision 
                    FROM JobTypes_In_My_Division 
                    ORDER BY InMyDivision";
                return await connection.QueryAsync<JobType>(sql);
            }
        }

        public async Task<IEnumerable<CrewBidValueDto>> GetCrewBidValues()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT jobtype, currency, BidRate FROM dbo.CrewBidValues";
                return await connection.QueryAsync<CrewBidValueDto>(sql);
            }
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT empno, firstname, lastname, empname, GroupStatus, DisplayOrder, InMyDivision 
                    FROM Employees_In_My_Division 
                    ORDER BY DisplayOrder, InMyDivision DESC";
                return await connection.QueryAsync<EmployeeDto>(sql);
            }
        }

        public async Task<IEnumerable<EmployeeAssignmentStatusCodeDto>> GetEmployeeAssignmentStatuses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT StatusCode, StatusDesc, DisplayOrder FROM dbo.EmployeeAssignmentStatus";
                return await connection.QueryAsync<EmployeeAssignmentStatusCodeDto>(sql);
            }
        }

        public async Task<IEnumerable<PerDiemStatusType>> GetPayingPerDiemStatusTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT PayingPerDiemStatusCode, PayingPerDiemStatusDesc FROM dbo.PayingPerDiemStatusTypes";
                return await connection.QueryAsync<PerDiemStatusType>(sql);
            }
        }

        public async Task<IEnumerable<PerDiemBillableStatusType>> GetPerDiemBillableStatusTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT IsPerDiemBillableStatusCode, IsPerDiemBillableStatusDesc FROM dbo.IsPerDiemBillableStatusTypes";
                return await connection.QueryAsync<PerDiemBillableStatusType>(sql);
            }
        }

        public async Task<IEnumerable<EmployeeJobType>> GetEmployeeJobTypes()
        {

        
            using (var connection = new SqlConnection(_connectionString))
            {
               
          var sql = @"
        SELECT 
            d.empno,
            d.firstname,
            d.lastname,
            d.empname,
            d.GroupStatus,
            d.DisplayOrder,
            d.InMyDivision,
            jt.jobtype
        FROM Employees_In_My_Division d
        JOIN peEmployee e ON d.empno = e.empno
        JOIN peEmployeeJobTypes jt ON e.empno = jt.empno
        WHERE jt.jobtype IN ('ACCTEXEC','OPERATIONS','ENGR','CRFPLENGR','CREWOPS')
          AND (e.empstatus = 'A' OR e.empstatus = 'R')
        ORDER BY d.DisplayOrder, d.InMyDivision DESC";
                return await connection.QueryAsync<EmployeeJobType>(sql);
            }
        }

        public async Task<IEnumerable<BudgetCategoryDto>> GetBudgetCategories()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT CategoryCode, CategoryDesc FROM dbo.BudgetCategories";
                return await connection.QueryAsync<BudgetCategoryDto>(sql);
            }
        }

        public async Task<IEnumerable<ExpenseCode>> GetExpenseCodes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT expcd, Description = expdesc, BudgetCategoryCode FROM dbo.apexpcode";
                return await connection.QueryAsync<ExpenseCode>(sql);
            }
        }

        public async Task<IEnumerable<EquipmentSubhireStatusDto>> GetEquipmentSubhireStatuses()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT 
                        StatusCode,
                        SortOrder = CAST(SortOrder as int),
                        Description = CASE 
                            WHEN StatusCode = 'P' THEN 'Pending'
                            WHEN StatusCode = 'A' THEN 'Active'
                            WHEN StatusCode = 'C' THEN 'Completed'
                            WHEN StatusCode = 'X' THEN 'Cancelled'
                            WHEN StatusCode = 'H' THEN 'On Hold'
                            WHEN StatusCode = 'R' THEN 'Returned'
                            ELSE 'Status ' + StatusCode
                        END,
                        IsActive = 1,
                        ColorCode = CASE 
                            WHEN StatusCode = 'P' THEN '#FFA500'  -- Orange
                            WHEN StatusCode = 'A' THEN '#008000'  -- Green
                            WHEN StatusCode = 'C' THEN '#0000FF'  -- Blue
                            WHEN StatusCode = 'X' THEN '#FF0000'  -- Red
                            WHEN StatusCode = 'H' THEN '#FFFF00'  -- Yellow
                            WHEN StatusCode = 'R' THEN '#800080'  -- Purple
                            ELSE '#808080'                        -- Gray
                        END,
                        IsCompleted = CASE WHEN StatusCode = 'C' THEN 1 ELSE 0 END,
                        IsCancelled = CASE WHEN StatusCode = 'X' THEN 1 ELSE 0 END,
                        IsPending = CASE WHEN StatusCode = 'P' THEN 1 ELSE 0 END
                    FROM dbo.EquipmentSubhireStatus
                    ORDER BY SortOrder";

                return await connection.QueryAsync<EquipmentSubhireStatusDto>(sql);
            }
        }

        public async Task<IEnumerable<ExpenseCategoryDto>> GetExpenseCategories()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT CategoryCode, CategoryDesc FROM dbo.ExpenseCategories";
                return await connection.QueryAsync<ExpenseCategoryDto>(sql);
            }
        }

        public async Task<IEnumerable<ExpensePeriodTypeDTO>> GetExpensePeriodTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT PeriodTypeCode, PeriodTypeDesc FROM dbo.ExpensePeriodTypes";
                return await connection.QueryAsync<ExpensePeriodTypeDTO>(sql);
            }
        }

        public async Task<IEnumerable<PropertyTypeDTO>> GetPropertyTypes()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT proptype, typedesc, BidFactor, BidValueType, 
                           DefaultBillSchedule, isSalesOrderPropType 
                    FROM dbo.pjproptype";
                return await connection.QueryAsync<PropertyTypeDTO>(sql);
            }
        }

        public async Task<IEnumerable<CurrencyDto>> GetCurrencies()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT currency, description, symbol, culture, SymbolOnLeft, 
                           RFIEnforcedGranularity, RFIDefaultGranularity, 
                           DefaultTaxType, CurrencyPositivePattern 
                    FROM dbo.currency";
                return await connection.QueryAsync<CurrencyDto>(sql);
            }
        }

        public async Task<IEnumerable<ReferralProgramDto>> GetReferralPrograms()
        {
            return await _context.ReferralPrograms
                .Select(rp => new ReferralProgramDto
                {
                    Id = rp.ReferralProgramId,
                    Description = rp.ReferralProgramDesc
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> GetFavoriteProjects()
        {
            return await _context.Pm2FavoriteProjects
                .Where(fp => fp.Username == _context.Database.SqlQuery<string>($"SELECT SUSER_SNAME()").FirstOrDefault())
                .Select(fp => fp.Entityno)
                .ToListAsync();
        }

        public async Task<IEnumerable<TaxCodeDto>> GetTaxCodes()
        {
            return await _context.OetaxCodes
                .Select(tc => new TaxCodeDto
                {
                    TaxCode = tc.TaxCode,
                    TaxDesc1 = tc.Taxdesc1,
                    Tax1 = (decimal)tc.Tax1,
                    MatrixCd1 = tc.Matrixcd1,
                    TaxDesc2 = tc.Taxdesc2,
                    Tax2 = (decimal)tc.Tax2,
                    MatrixCd2 = tc.Matrixcd2,
                    TaxDesc3 = tc.Taxdesc3,
                    Tax3 = (decimal)tc.Tax3,
                    MatrixCd3 = tc.Matrixcd3,
                    TaxDesc4 = tc.Taxdesc4,
                    Tax4 = (decimal)tc.Tax4,
                    MatrixCd4 = tc.Matrixcd4,
                    TaxDesc5 = tc.Taxdesc5,
                    Tax5 = (decimal)tc.Tax5,
                    MatrixCd5 = tc.Matrixcd5,
                    ConcatTaxDesc = tc.Taxdesc2 + ", " + tc.Taxdesc3 + ", " + tc.Taxdesc4
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProjectPriceLevelDto>> GetProjectPriceLevels()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT PriceLevelValue, isDefault, isVisible FROM dbo.ProjectPriceLevels ORDER BY PriceLevelValue";
                var priceLevels = await connection.QueryAsync<ProjectPriceLevel>(sql);
                return priceLevels.Select(pl => new ProjectPriceLevelDto
                {
                    PriceLevelValue = pl.PriceLevelValue.ToString(),
                    IsDefault = pl.IsDefault,
                    IsVisible = pl.IsVisible
                });
            }
        }

        public async Task<IEnumerable<AccountMatrix>> GetAccountMatrix()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT matrixcd, matrixdesc, uom, price, salegl, saleacctcr, saleacctdb,
                           discacctcd, fcacctcd, cost, costgl, costacctcr, costacctlabcr,
                           costacctoutcr, costacctoh1cr, costacctoh2cr, costacctacqcr,
                           costacctdb, costacctlab, costacctout, costacctoh1, costacctoh2,
                           costacctacq, saleind, activeind, ref1, ref2, ref3, ref4, ref5,
                           ref6, ref7, ref8, entityno
                    FROM dbo.oeacctmatrix";
                return await connection.QueryAsync<AccountMatrix>(sql);
            }
        }

        public async Task<IEnumerable<OvertimeRateDto>> GetOvertimeRates()
        {
            return await _context.OvertimeRates
                .Select(rate => new OvertimeRateDto
                {
                    RateCode = rate.RateType,
                    Description = rate.RateDesc,
                    Multiplier = (decimal)rate.Rate,
                    SortOrder = rate.DisplayOrder
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<GUIColumnName>> GetGUIColumnNames()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = "SELECT * FROM dbo.GUIColumnNamesFromSQLFields";
                return await connection.QueryAsync<GUIColumnName>(sql);
            }
        }

        public async Task<CrewBillRatesVisibility> GetCrewBillRatesVisibility()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT ShowCrewBillRatesOnNonBidProjects = ISNULL(ShowCrewBillRatesOnNonBidProjects, 0) 
                    FROM dbo.pjtfrusr u 
                    JOIN dbo.Company c ON c.CompanyCode = u.DefaultBillingCompany 
                    WHERE user_name = SUSER_NAME()";
                return await connection.QueryFirstOrDefaultAsync<CrewBillRatesVisibility>(sql);
            }
        }

        public async Task<IEnumerable<ShippingRequest>> GetShippingRequests(string projectNumber)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    DECLARE @p varchar(50) = '%-[0-9]%-%'
                    SELECT 
                        substring(s.entityno,0,patindex(@p,s.entityno) + patindex('%-%',substring(s.entityno,patindex(@p,s.entityno)+1,100))) as ProjectLegNo,
                        s.entityno, g.entitydesc, s.ShipDate, s.DestinationName as Destination, 
                        s.City, s.State, p.MasterTrackingNumber, s.Amount as EstimatedCost, 
                        (s.Amount * 1.25) as Cost, s.idShippingRequest as ShippingRequestID, 
                        s.ServiceTypeDisplayName as ServiceType
                    FROM dbo.ShippingRequestForShipmentVault s
                    LEFT JOIN dbo.glentities g ON g.entityno = s.entityno
                    LEFT JOIN dbo.ShippingPackages p ON p.idShippingRequest = s.idShippingRequest
                    WHERE s.entityno LIKE @ProjectNumber + '-%'";

                return await connection.QueryAsync<ShippingRequest>(sql, new { ProjectNumber = projectNumber });
            }
        }

        public async Task<IEnumerable<string>> GetUserMenuInclusions()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var sql = @"
                    SELECT x.appexe
                    FROM dbo.user_menu_inclusions umi
                    JOIN dbo.mumenus m ON umi.packagecd = m.packagecd AND umi.cmndsel = m.cmndsel
                    CROSS APPLY (SELECT appexe = replace(m.appexec,'%ESSVBDir%\','') + m.appframe) x
                    WHERE x.appexe IN (
                        'ProjectCalendar', 'prjpjlistinq', 'SalesForecast', 'Project Checklist',
                        'TransferInquiryTools', 'prjpjunavl', 'Rack Configurator', 'Query Tools',
                        'Batch Pick Report', 'Project Storyboard', 'Crew Tools', 'Employee Maintenance',
                        'Shipping Tools', 'prjpjinvcal', 'Scheduling Board', 'Part Maintenance',
                        'Part Attachments Maintenance', 'Cycle Count', 'Utilization', 'BidReport',
                        'ProposalReport', 'Dry Hire Report', 'Certifications Report', 'Hidden',
                        'TouringInvoicing', 'Contact Maintenance'
                    )";
                return await connection.QueryAsync<string>(sql);
            }
        }

        public async Task<IEnumerable<PollstarArtist>> GetPollstarArtists()
        {
            try
            {
                return await _context.PollstarArtists
                    .OrderBy(a => a.ArtistName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Pollstar artists");
                throw;
            }
        }

        public async Task<IEnumerable<PollstarArtist>> SearchPollstarArtists(string searchTerm)
        {
            try
            {
                return await _context.PollstarArtists
                    .Where(a => a.ArtistName.Contains(searchTerm))
                    .OrderBy(a => a.ArtistName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching Pollstar artists with term: {SearchTerm}", searchTerm);
                throw;
            }
        }

        public async Task<PollstarArtist?> GetPollstarArtistById(int id)
        {
            try
            {
                return await _context.PollstarArtists.FindAsync(id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Pollstar artist with ID: {ArtistId}", id);
                throw;
            }
        }

        public async Task<IEnumerable<Contact>> GetContactsByCategory(int categoryId)
        {
            try
            {
                var contacts =await (from contact in _context.Contacts
                       join ccc in _context.CustomersContactCategories
                         on contact.Contactno equals ccc.Custno
                       where ccc.IdContactCategory == categoryId
                       select contact).ToListAsync();


                return contacts;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving contacts for category ID {CategoryId}", categoryId);
                throw;
            }
        }

        public async Task<IEnumerable<Contact>> SearchContacts(string searchTerm)
        {
            try
            {
                var searchTermLower = searchTerm.ToLower();
                var contacts = await _context.Contacts
                    .Where(c => 
                    
                        c.Contactname.ToLower().Contains(searchTermLower))
                       
                    .OrderBy(c => c.Contactname)
                    .ToListAsync();

                return contacts;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching contacts with term {SearchTerm}", searchTerm);
                throw;
            }
        }

        public async Task<IEnumerable<Oecustomer>> GetCustomers()
        {
            try
            {
                var customers = await _context.Oecustomers
                    .OrderBy(c => c.CustName)
                    .ToListAsync();

                return customers;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving customers");
                throw;
            }
        }

        public async Task<IEnumerable<Oecustomer>> SearchCustomers(string searchTerm)
        {
            try
            {
                var searchTermLower = searchTerm.ToLower();
                var customers = await _context.Oecustomers
                    .Where(c => 
                        c.CustName.ToLower().Contains(searchTermLower) ||
                        c.Custno.ToLower().Contains(searchTermLower))
                    .OrderBy(c => c.CustName)
                    .ToListAsync();

                return customers;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching customers with term {SearchTerm}", searchTerm);
                throw;
            }
        }

        public async Task<IEnumerable<Oecustbill>> GetCustomerBillingAddresses(string customerNo)
        {
            try
            {
                return await _context.Oecustbills
                    .Where(b => b.Custno == customerNo)
                    .OrderByDescending(b => b.Activeind) // Using Activeind for is_default
                    .ThenBy(b => b.BillToName)
                    .Select(b => new Oecustbill
                    {
                        Custno = b.Custno,
                        BillToName = b.BillToName,
                        Addr1 = b.Addr1,
                        Addr2 = b.Addr2,
                        City = b.City,
                        State = b.State,
                        Zip = b.Zip,
                        Country = b.Country,
                        Phone = b.Phone,
                        Fax = b.Fax,
                        Email2 = b.Email2,
                        Activeind = b.Activeind,
                        Notes = b.Notes
                    })
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving billing addresses for customer {CustomerNo}", customerNo);
                throw;
            }
        }

        public async Task<IEnumerable<TruckingCompany>> GetTruckingCompanies()
        {
            try
            {
                return await _context.TruckingCompanies
                    .OrderBy(tc => tc.VendorName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving trucking companies");
                throw;
            }
        }

        public async Task<IEnumerable<TruckingCompany>> SearchTruckingCompanies(string searchTerm)
        {
            try
            {
                var searchTermLower = searchTerm.ToLower();
                return await _context.TruckingCompanies
                    .Where(tc => (
                        tc.VendorName.ToLower().Contains(searchTermLower) ||
                        tc.Vendno.ToLower().Contains(searchTermLower) ||
                        //tc.ContactName.ToLower().Contains(searchTermLower) ||
                        tc.Phone.ToLower().Contains(searchTermLower) ||
                        tc.Email.ToLower().Contains(searchTermLower)
                    ))
                    .OrderBy(tc => tc.VendorName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching trucking companies with term: {SearchTerm}", searchTerm);
                throw;
            }
        }

        public async Task<IEnumerable<ClairTourTiny.Infrastructure.Models.ProductionScheduleEventType>> GetAllProductionScheduleEventTypes()
        {
            return await _context.ProductionScheduleEventTypes
                .OrderBy(x => x.DisplayOrder)
                .ToListAsync();
        }

        public async Task<IEnumerable<ShippingDestination>> GetAllShippingDestinations()
        {
            return await _context.ShippingDestinations
                .OrderBy(x => x.DestinationName)
                .ToListAsync();
        }

        public async Task<IEnumerable<ShippingDestination>> SearchShippingDestinations(string searchTerm)
        {
            try
            {
                var searchTermLower = searchTerm.ToLower();
                return await _context.ShippingDestinations
                    .Where(sd => 
                        (sd.DestinationName != null && sd.DestinationName.ToLower().Contains(searchTermLower)) ||
                        (sd.City != null && sd.City.ToLower().Contains(searchTermLower)) ||
                        (sd.State != null && sd.State.ToLower().Contains(searchTermLower)) ||
                        (sd.Addr1 != null && sd.Addr1.ToLower().Contains(searchTermLower)) ||
                        (sd.Addr2 != null && sd.Addr2.ToLower().Contains(searchTermLower)))
                    .OrderBy(sd => sd.DestinationName)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching shipping destinations with term: {SearchTerm}", searchTerm);
                throw;
            }
        }

        public async Task<IEnumerable<PollstarVenue>> GetAllPollstarVenues()
        {
            return await _context.PollstarVenues
                .OrderBy(x => x.VenueName)
                .ToListAsync();
        }

        public async Task<IEnumerable<PollstarVenue>> SearchPollstarVenues(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetAllPollstarVenues();

            searchTerm = searchTerm.ToLower();
            return await _context.PollstarVenues
                .Where(x =>(
                    x.VenueName.ToLower().Contains(searchTerm) ||
                    x.City.ToLower().Contains(searchTerm) ||
                    x.StateName.ToLower().Contains(searchTerm) ||
                    x.Address1.ToLower().Contains(searchTerm)
                ))
                .OrderBy(x => x.VenueName)
                .ToListAsync();
        }
  
  
    public async Task<List<PartSearchResultDto>> SearchPartsAsync(PartSearchRequestDto request)
        {
            try
            {
                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request));
                }

                var query = _context.Inparts
                    .Include(p => p.CommmodityNavigation)
                   // .Include(p => p.PartSecondaryCategories)
                    .Include(p => p.AvailMultipartGroup1s)
                    .Include(p => p.Inpartsubs)
                    .AsQueryable();

                // Apply search text filter
                if (!string.IsNullOrWhiteSpace(request.SearchText))
                {
                    var searchTerms = request.SearchText.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(term => term.ToLower())
                        .Distinct()
                        .ToArray();

                    if (request.SearchForBarcode)
                    {
                        // Search by barcode (SKU)
                        query = query.Where(p => searchTerms.Any(term => 
                            p.Sku != null && p.Sku.ToLower().Contains(term)));
                    }
                    else
                    {
                        // Search by part description, part number, or tags
                        query = query.Where(p => searchTerms.All(term =>
                            (p.Partdesc != null && p.Partdesc.ToLower().Contains(term)) ||
                            (p.Partno != null && p.Partno.ToLower().Contains(term))));
                    }
                }

                // Apply category filter
                if (!string.IsNullOrEmpty(request.Category) && request.Category != "(All)")
                {
                    query = query.Where(p => p.Commmodity == request.Category);
                }

                // Apply subcategory filter
                if (!string.IsNullOrEmpty(request.SubCategory) && request.SubCategory != "(All)")
                {
                    query = query.Where(p => p.SecondaryCategoryCode == request.SubCategory);
                }

                // Apply warehouse filter
                if (request.OnlyMyWarehouses)
                {
                //    // var userName = _httpContextAccessor.HttpContext?.User?.Identity?.Name;
                //     if (string.IsNullOrEmpty(userName))
                //     {
                //         _logger.LogWarning("User identity not found when filtering by warehouses");
                //         return new List<PartSearchResultDto>();
                //     }

                    var userWarehouses = await _context.Pjtfrusrs
                       // .Where(u => u.UserName == userName)
                        .Select(u => u.WarehouseEntity)
                        .ToListAsync();

                    if (!userWarehouses.Any())
                    {
                        return new List<PartSearchResultDto>();
                    }

                    query = query.Where(p => p.Inpartsubs.Any(ips => 
                        userWarehouses.Contains(ips.Bld)));
                }

                // Apply unused parts filter
                if (request.HideUnusedParts)
                {
                    query = query.Where(p => p.Commmodity != "UNUSED");
                }

                // Apply my parts only filter
                if (request.MyPartsOnly)
                {
                    query = query.Where(p => p.AvailMultipartGroup1s.Any());
                }

                // Execute query and map results
                var results = await query
                    .Select(p => new PartSearchResultDto
                    {
                        PartNumber = p.Partno ?? string.Empty,
                        PartDescription = p.Partdesc ?? string.Empty,
                        Commodity = p.Commmodity ?? string.Empty,
                        PartGroup = p.AvailMultipartGroup1s
                            .OrderBy(g => g.Partgroup)
                            .Select(g => g.Partgroup)
                            .FirstOrDefault() ?? "!Barcode",
                        PartSequence = p.AvailMultipartGroup1s
                            .OrderBy(g => g.Partseq)
                            .Select(g => (int?)g.Partseq)
                            .FirstOrDefault() ?? 0
                    })
                    .OrderBy(p => p.PartGroup)
                    .ThenBy(p => p.PartSequence)
                    .ThenBy(p => p.PartDescription)
                    .ToListAsync();
                    
                    

                return results;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while searching parts. Please try again later.", ex);
            }
        }

        public async Task<List<PartCategoryDto>> GetPartCategoriesAsync()
        {
            try
            {
                var categories = await _context.Incommodities
                    .Select(c => new PartCategoryDto
                    {
                        Code = c.Commodity,
                        Description = c.Commoditydesc
                    })
                    .OrderBy(c => c.Description)
                    .ToListAsync();

                // Add "(All)" option at the beginning
                categories.Insert(0, new PartCategoryDto { Code = "(All)", Description = "(All)" });

                return categories;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<PartSubCategoryDto>> GetPartSubCategoriesAsync(string categoryCode)
        {
            try
            {
                var query = _context.PartSecondaryCategories.AsQueryable();

                if (categoryCode != "(All)")
                {
                    query = query.Where(sc => sc.Commodity == categoryCode);
                }

                var subCategories = await query
                    .Select(sc => new PartSubCategoryDto
                    {
                        Code = sc.SecondaryCategoryCode,
                        Description = sc.SecondaryCategoryDesc,
                        Commodity = sc.Commodity
                    })
                    .OrderBy(sc => sc.Description)
                    .ToListAsync();

                // Add "(All)" option at the beginning
                subCategories.Insert(0, new PartSubCategoryDto 
                { 
                    Code = "(All)", 
                    Description = "(All)",
                    Commodity = categoryCode
                });

                return subCategories;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
  
        /// <summary>
        /// Gets the default project settings for a user (or the first user if username is not provided)
        /// </summary>
        /// <param name="username">The username to get settings for. If null or empty, the first user is used.</param>
        /// <returns>Default project settings for the user</returns>
       public async Task<ClairTourTiny.Infrastructure.Dto.DTOs.DefaultProjectSettingsDto> GetDefaultProjectSettingsAsync(string username = null)
        {
            try
            {
                Console.WriteLine("usernamexxxxxxxxxxxxxxxxxxxxxxxxxx: " + username);
                // Find user (by username or first)
                var user = string.IsNullOrEmpty(username)
                    ? await _context.MyUserInfos.FirstOrDefaultAsync()
                    : await _context.MyUserInfos.FirstOrDefaultAsync(u => u.UserName == username);

              
//                Console.WriteLine("user.DefaultBillingCompany: " + user.DefaultBillingCompany);
                var company = user.DefaultBillingCompany != null 
                    ? await _context.Companies.FirstOrDefaultAsync(c => c.CompanyCode == user.DefaultBillingCompany)
                    : null;

               // Console.WriteLine("user.DefaultPropType: " + user.DefaultPropType);
                var propType = user.DefaultPropType != null
                    ? await _context.Pjproptypes.FirstOrDefaultAsync(p => p.Proptype == user.DefaultPropType)
                    : null;

                var dto = new ClairTourTiny.Infrastructure.Dto.DTOs.DefaultProjectSettingsDto
                {
                    DefaultWarehouse = user.WarehouseEntity ?? string.Empty,
                    DefaultCurrency = user.Currency ?? string.Empty,
                    DefaultLanguage = user.IdLanguage.ToString(),
                    //.HasValue ? user.IdLanguage.Value.ToString() : string.Empty,
                    SalesForecastGroup = user.SalesForecastGroup ?? string.Empty,
                    DefaultBillingCompany = user.DefaultBillingCompany ?? string.Empty,
                    DefaultPropType = user.DefaultPropType ?? string.Empty,
                    UnitOfLength = user.Unitoflength ?? string.Empty,
                    UnitOfWeight = user.Unitofweight ?? string.Empty,
                    ConversionFactorFromInches = (decimal)user.ConversionFactorFromInches,
                    //.HasValue ? (decimal)user.ConversionFactorFromInches.Value : 0m,
                    ConversionFactorFromPounds = (decimal)user.ConversionFactorFromPounds,
                    //.HasValue ? (decimal)user.ConversionFactorFromPounds.Value : 0m,
                    WeightDecimalPlaces = user.WeightDecimalPlaces,
                    //.HasValue ? user.WeightDecimalPlaces.Value : 0,
                    VolumeDecimalPlaces = user.VolumeDecimalPlaces,
                    //.HasValue ? user.VolumeDecimalPlaces.Value : 0,
                    DefaultCrewOps = company?.DefaultCrewOpsEmpno ?? string.Empty,
                    DefaultBidMarkup = (decimal)propType?.BidFactor,
                    //.HasValue == true ? (decimal)propType.BidFactor.Value : 0m
                };

                return dto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving default project settings for user");
                throw;
            }
        }
   
   
    }
} 