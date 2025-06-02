using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ClairTourTiny.Core.Models;
using ClairTourTiny.Core.Services;   
using ClairTourTiny.Infrastructure.Dto.DTOs;
using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Dapper;

namespace ClairTourTiny.API.Controllers
{
    /// <summary>
    /// Controller for managing project data points and related information
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ProjectDataPointsController : ControllerBase
    {
        private readonly IProjectDataPointsService _projectDataService;
        private readonly string _connectionString;

        public ProjectDataPointsController(
            IProjectDataPointsService projectDataService,
            IConfiguration configuration)
        {
            _projectDataService = projectDataService;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Retrieves all project data in a single API call
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/all-data
        ///     GET /api/ProjectDataPoints/all-data?projectNumber=PROJ123
        /// 
        /// Returns all project-related data including:
        /// * Companies
        /// * Project Statuses
        /// * Warehouses
        /// * Rate Types
        /// * Contact Categories
        /// * And more...
        /// </remarks>
        /// <param name="projectNumber">Optional project number to filter the data</param>
        /// <returns>Complete project data including all related information</returns>
        /// <response code="200">Returns the complete project data</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("all-data")]
        [ProducesResponseType(typeof(AllProjectData), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllProjectData([FromQuery] string? projectNumber = null)
        {
            var result = await _projectDataService.GetAllProjectData(projectNumber);
            return Ok(result);
        }

        /// <summary>
        /// Retrieves user permissions and role information for the current user
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/user-permissions
        /// 
        /// Returns the current user's:
        /// * Role information
        /// * Permission flags
        /// * Access levels
        /// * Division information
        /// </remarks>
        /// <returns>User permissions and role details</returns>
        /// <response code="200">Returns the user permissions</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("user-permissions")]
        [ProducesResponseType(typeof(UserPermissions), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserPermissions()
        {
            var permissions = await _projectDataService.GetUserPermissions();
            return Ok(permissions);
        }

        /// <summary>
        /// Retrieves company information for the current user
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/user-company-info
        /// 
        /// Returns the current user's:
        /// * Company code
        /// * Company name
        /// * Division information
        /// * Company settings
        /// </remarks>
        /// <returns>User's company information</returns>
        /// <response code="200">Returns the user's company information</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("user-company-info")]
        [ProducesResponseType(typeof(UserCompanyInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserCompanyInfo()
        {
            var companyInfo = await _projectDataService.GetUserCompanyInfo();
            return Ok(companyInfo);
        }

        /// <summary>
        /// Retrieves a list of all companies in the system
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/companies
        /// 
        /// Returns a list of all companies with:
        /// * Company code
        /// * Company name
        /// * Division information
        /// * Active status
        /// </remarks>
        /// <returns>List of company information</returns>
        /// <response code="200">Returns the list of companies</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("companies")]
        [ProducesResponseType(typeof(IEnumerable<CompanyInfo>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _projectDataService.GetCompanies();
            return Ok(companies);
        }

        /// <summary>
        /// Retrieves all available project statuses
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/project-statuses
        /// 
        /// Returns a list of all project statuses including:
        /// * Status code
        /// * Description
        /// * Color code
        /// * Sort order
        /// * Active status
        /// </remarks>
        /// <returns>List of project statuses</returns>
        /// <response code="200">Returns the list of project statuses</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("project-statuses")]
        [ProducesResponseType(typeof(IEnumerable<ProjectStatus>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProjectStatuses()
        {
            var statuses = await _projectDataService.GetProjectStatuses();
            return Ok(statuses);
        }

        /// <summary>
        /// Retrieves a list of all warehouses
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/warehouses
        /// 
        /// Returns a list of all warehouses with:
        /// * Warehouse code
        /// * Warehouse name
        /// * Location information
        /// * Active status
        /// </remarks>
        /// <returns>List of warehouse information</returns>
        /// <response code="200">Returns the list of warehouses</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("warehouses")]
        [ProducesResponseType(typeof(IEnumerable<WarehouseInfo>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetWarehouses()
        {
            var warehouses = await _projectDataService.GetWarehouses();
            return Ok(warehouses);
        }

        /// <summary>
        /// Retrieves all available rate types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/rate-types
        /// 
        /// Returns a list of all rate types including:
        /// * Rate type code (D=Daily, W=Weekly, M=Monthly)
        /// * Description
        /// * Sort order
        /// * Days per unit
        /// * Type flags (IsDaily, IsWeekly, IsMonthly)
        /// </remarks>
        /// <returns>List of rate types</returns>
        /// <response code="200">Returns the list of rate types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("rate-types")]
        [ProducesResponseType(typeof(IEnumerable<RateType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetRateTypes()
        {
            var rateTypes = await _projectDataService.GetRateTypes();
            return Ok(rateTypes);
        }

        /// <summary>
        /// Retrieves all contact categories
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/contact-categories
        /// 
        /// Returns a list of all contact categories with:
        /// * Category ID
        /// * Category name
        /// * Description
        /// * Sort order
        /// * Active status
        /// </remarks>
        /// <returns>List of contact categories</returns>
        /// <response code="200">Returns the list of contact categories</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("contact-categories")]
        [ProducesResponseType(typeof(IEnumerable<ContactCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContactCategories()
        {
            var categories = await _projectDataService.GetContactCategories();
            return Ok(categories);
        }

        /// <summary>
        /// Retrieves all production schedule event types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/production-schedule-event-types
        /// 
        /// Returns a list of all event types including:
        /// * Event type code
        /// * Description
        /// * Color code
        /// * Sort order
        /// * Active status
        /// </remarks>
        /// <returns>List of production schedule event types</returns>
        /// <response code="200">Returns the list of event types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("production-schedule-event-types")]
        [ProducesResponseType(typeof(IEnumerable<ProductionScheduleEventTypeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProductionScheduleEventTypes()
        {
            var eventTypes = await _projectDataService.GetProductionScheduleEventTypes();
            return Ok(eventTypes);
        }

        /// <summary>
        /// Retrieves all bill schedules
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/bill-schedules
        /// 
        /// Returns a list of all bill schedules with:
        /// * Schedule code
        /// * Description
        /// * Payment terms
        /// * Active status
        /// </remarks>
        /// <returns>List of bill schedules</returns>
        /// <response code="200">Returns the list of bill schedules</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("bill-schedules")]
        [ProducesResponseType(typeof(IEnumerable<BillSchedule>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBillSchedules()
        {
            var schedules = await _projectDataService.GetBillSchedules();
            return Ok(schedules);
        }

        /// <summary>
        /// Retrieves all commodities
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/commodities
        /// 
        /// Returns a list of all commodities including:
        /// * Commodity code
        /// * Description
        /// * Category information
        /// * Active status
        /// </remarks>
        /// <returns>List of commodities</returns>
        /// <response code="200">Returns the list of commodities</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("commodities")]
        [ProducesResponseType(typeof(IEnumerable<Commodity>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCommodities()
        {
            var commodities = await _projectDataService.GetCommodities();
            return Ok(commodities);
        }

        /// <summary>
        /// Retrieves all billing accounts
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/billing-accounts
        /// 
        /// Returns a list of all billing accounts with:
        /// * Account number
        /// * Account name
        /// * Company information
        /// * Active status
        /// * Billing preferences
        /// </remarks>
        /// <returns>List of billing accounts</returns>
        /// <response code="200">Returns the list of billing accounts</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("billing-accounts")]
        [ProducesResponseType(typeof(IEnumerable<BillingAccountDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBillingAccounts()
        {
            var accounts = await _projectDataService.GetBillingAccounts();
            return Ok(accounts);
        }

        /// <summary>
        /// Retrieves all job types in the user's division
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/job-types
        /// 
        /// Returns a list of all job types including:
        /// * Job type code
        /// * Description
        /// * Division information
        /// * Active status
        /// * Rate information
        /// </remarks>
        /// <returns>List of job types</returns>
        /// <response code="200">Returns the list of job types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("job-types")]
        [ProducesResponseType(typeof(IEnumerable<JobType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetJobTypes()
        {
            var jobTypes = await _projectDataService.GetJobTypes();
            return Ok(jobTypes);
        }

        /// <summary>
        /// Retrieves all crew bid values
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/crew-bid-values
        /// 
        /// Returns a list of all crew bid values with:
        /// * Employee information
        /// * Job type
        /// * Bid rate
        /// * Effective date
        /// * Active status
        /// </remarks>
        /// <returns>List of crew bid values</returns>
        /// <response code="200">Returns the list of crew bid values</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("crew-bid-values")]
        [ProducesResponseType(typeof(IEnumerable<CrewBidValueDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCrewBidValues()
        {
            var bidValues = await _projectDataService.GetCrewBidValues();
            return Ok(bidValues);
        }

        /// <summary>
        /// Retrieves all employees in the user's division
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/employees
        /// 
        /// Returns a list of all employees including:
        /// * Employee ID
        /// * Name
        /// * Job title
        /// * Contact information
        /// * Active status
        /// </remarks>
        /// <returns>List of employees</returns>
        /// <response code="200">Returns the list of employees</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("employees")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _projectDataService.GetEmployees();
            return Ok(employees);
        }

        /// <summary>
        /// Retrieves all employee assignment statuses
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/employee-assignment-statuses
        /// 
        /// Returns a list of all assignment statuses including:
        /// * Status code
        /// * Description
        /// * Color code
        /// * Sort order
        /// * Active status
        /// </remarks>
        /// <returns>List of employee assignment statuses</returns>
        /// <response code="200">Returns the list of assignment statuses</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("employee-assignment-statuses")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeAssignmentStatusCodeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmployeeAssignmentStatuses()
        {
            var statuses = await _projectDataService.GetEmployeeAssignmentStatuses();
            return Ok(statuses);
        }

        /// <summary>
        /// Retrieves all paying per diem status types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/paying-per-diem-status-types
        /// 
        /// Returns a list of all per diem status types including:
        /// * Status code
        /// * Description
        /// * Rate information
        /// * Active status
        /// </remarks>
        /// <returns>List of per diem status types</returns>
        /// <response code="200">Returns the list of per diem status types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("paying-per-diem-status-types")]
        [ProducesResponseType(typeof(IEnumerable<PerDiemStatusType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPayingPerDiemStatusTypes()
        {
            var statusTypes = await _projectDataService.GetPayingPerDiemStatusTypes();
            return Ok(statusTypes);
        }

        /// <summary>
        /// Retrieves all per diem billable status types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/per-diem-billable-status-types
        /// 
        /// Returns a list of all billable status types including:
        /// * Status code
        /// * Description
        /// * Billing rules
        /// * Active status
        /// </remarks>
        /// <returns>List of per diem billable status types</returns>
        /// <response code="200">Returns the list of billable status types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("per-diem-billable-status-types")]
        [ProducesResponseType(typeof(IEnumerable<PerDiemBillableStatusType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPerDiemBillableStatusTypes()
        {
            var statusTypes = await _projectDataService.GetPerDiemBillableStatusTypes();
            return Ok(statusTypes);
        }

        /// <summary>
        /// Retrieves all employee job types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/employee-job-types
        /// 
        /// Returns a list of all employee job types including:
        /// * Job type code
        /// * Description
        /// * Rate information
        /// * Active status
        /// </remarks>
        /// <returns>List of employee job types</returns>
        /// <response code="200">Returns the list of employee job types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("employee-job-types")]
        [ProducesResponseType(typeof(IEnumerable<EmployeeJobType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEmployeeJobTypes()
        {
            var jobTypes = await _projectDataService.GetEmployeeJobTypes();
            return Ok(jobTypes);
        }

        /// <summary>
        /// Retrieves all budget categories
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/budget-categories
        /// 
        /// Returns a list of all budget categories including:
        /// * Category code
        /// * Description
        /// * Parent category
        /// * Active status
        /// </remarks>
        /// <returns>List of budget categories</returns>
        /// <response code="200">Returns the list of budget categories</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("budget-categories")]
        [ProducesResponseType(typeof(IEnumerable<BudgetCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetBudgetCategories()
        {
            var categories = await _projectDataService.GetBudgetCategories();
            return Ok(categories);
        }

        /// <summary>
        /// Retrieves all expense codes
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/expense-codes
        /// 
        /// Returns a list of all expense codes including:
        /// * Code
        /// * Description
        /// * Category information
        /// * Active status
        /// </remarks>
        /// <returns>List of expense codes</returns>
        /// <response code="200">Returns the list of expense codes</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("expense-codes")]
        [ProducesResponseType(typeof(IEnumerable<ExpenseCode>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetExpenseCodes()
        {
            var expenseCodes = await _projectDataService.GetExpenseCodes();
            return Ok(expenseCodes);
        }

        /// <summary>
        /// Retrieves all equipment subhire statuses
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/equipment-subhire-statuses
        /// 
        /// Returns a list of all subhire statuses including:
        /// * Status code (P=Pending, A=Active, C=Completed, etc.)
        /// * Description
        /// * Color code
        /// * Sort order
        /// * Status flags (IsCompleted, IsCancelled, IsPending)
        /// </remarks>
        /// <returns>List of equipment subhire statuses</returns>
        /// <response code="200">Returns the list of subhire statuses</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("equipment-subhire-statuses")]
        [ProducesResponseType(typeof(IEnumerable<EquipmentSubhireStatusDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEquipmentSubhireStatuses()
        {
            var statuses = await _projectDataService.GetEquipmentSubhireStatuses();
            return Ok(statuses);
        }

        /// <summary>
        /// Retrieves all expense categories
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/expense-categories
        /// 
        /// Returns a list of all expense categories including:
        /// * Category code
        /// * Description
        /// * Parent category
        /// * Active status
        /// </remarks>
        /// <returns>List of expense categories</returns>
        /// <response code="200">Returns the list of expense categories</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("expense-categories")]
        [ProducesResponseType(typeof(IEnumerable<ExpenseCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetExpenseCategories()
        {
            var categories = await _projectDataService.GetExpenseCategories();
            return Ok(categories);
        }

        /// <summary>
        /// Retrieves all expense period types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/expense-period-types
        /// 
        /// Returns a list of all period types including:
        /// * Period type code
        /// * Description
        /// * Duration
        /// * Active status
        /// </remarks>
        /// <returns>List of expense period types</returns>
        /// <response code="200">Returns the list of period types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("expense-period-types")]
        [ProducesResponseType(typeof(IEnumerable<ExpensePeriodTypeDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetExpensePeriodTypes()
        {
            var periodTypes = await _projectDataService.GetExpensePeriodTypes();
            return Ok(periodTypes);
        }

        /// <summary>
        /// Retrieves all property types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/proposal-types
        /// 
        /// Returns a list of all property types including:
        /// * Type code
        /// * Description
        /// * Category information
        /// * Active status
        /// </remarks>
        /// <returns>List of property types</returns>
        /// <response code="200">Returns the list of property types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("proposal-types")]
        [ProducesResponseType(typeof(IEnumerable<PropertyTypeDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPropertyTypes()
        {
            var propertyTypes = await _projectDataService.GetPropertyTypes();
            return Ok(propertyTypes);
        }

        /// <summary>
        /// Retrieves all currencies
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/currencies
        /// 
        /// Returns a list of all currencies including:
        /// * Currency code (e.g., USD, EUR)
        /// * Description
        /// * Symbol
        /// * Exchange rate
        /// * Active status
        /// </remarks>
        /// <returns>List of currencies</returns>
        /// <response code="200">Returns the list of currencies</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("currencies")]
        [ProducesResponseType(typeof(IEnumerable<CurrencyDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCurrencies()
        {
            var currencies = await _projectDataService.GetCurrencies();
            return Ok(currencies);
        }

        /// <summary>
        /// Retrieves all referral programs
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/referral-programs
        /// 
        /// Returns a list of all referral programs including:
        /// * Program code
        /// * Description
        /// * Commission rate
        /// * Active status
        /// </remarks>
        /// <returns>List of referral programs</returns>
        /// <response code="200">Returns the list of referral programs</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("referral-programs")]
        [ProducesResponseType(typeof(IEnumerable<ReferralProgramDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetReferralPrograms()
        {
            var programs = await _projectDataService.GetReferralPrograms();
            return Ok(programs);
        }

        /// <summary>
        /// Retrieves favorite projects for the current user
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/favorite-projects
        /// 
        /// Returns a list of project numbers that the current user has marked as favorites.
        /// </remarks>
        /// <returns>List of favorite project numbers</returns>
        /// <response code="200">Returns the list of favorite projects</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("favorite-projects")]
        [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetFavoriteProjects()
        {
            var projects = await _projectDataService.GetFavoriteProjects();
            return Ok(projects);
        }

        /// <summary>
        /// Retrieves all tax codes
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/tax-codes
        /// 
        /// Returns a list of all tax codes including:
        /// * Tax code
        /// * Description
        /// * Rate
        /// * Active status
        /// * Applicable regions
        /// </remarks>
        /// <returns>List of tax codes</returns>
        /// <response code="200">Returns the list of tax codes</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("tax-codes")]
        [ProducesResponseType(typeof(IEnumerable<TaxCodeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTaxCodes()
        {
            var taxCodes = await _projectDataService.GetTaxCodes();
            return Ok(taxCodes);
        }

        /// <summary>
        /// Retrieves all project price levels
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/project-price-levels
        /// 
        /// Returns a list of all price levels including:
        /// * Level code
        /// * Description
        /// * Markup rate
        /// * Active status
        /// </remarks>
        /// <returns>List of project price levels</returns>
        /// <response code="200">Returns the list of price levels</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("project-price-levels")]
        [ProducesResponseType(typeof(IEnumerable<ProjectPriceLevelDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProjectPriceLevels()
        {
            var priceLevels = await _projectDataService.GetProjectPriceLevels();
            return Ok(priceLevels);
        }

        /// <summary>
        /// Retrieves the account matrix
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/account-matrix
        /// 
        /// Returns the account matrix including:
        /// * Account codes
        /// * Department mappings
        /// * Cost center information
        /// * Active status
        /// </remarks>
        /// <returns>Account matrix information</returns>
        /// <response code="200">Returns the account matrix</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("account-matrix")]
        [ProducesResponseType(typeof(IEnumerable<AccountMatrix>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAccountMatrix()
        {
            var matrix = await _projectDataService.GetAccountMatrix();
            return Ok(matrix);
        }

        /// <summary>
        /// Retrieves all overtime rates
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/overtime-rates
        /// 
        /// Returns a list of all overtime rates including:
        /// * Rate type
        /// * Description
        /// * Multiplier
        /// * Active status
        /// </remarks>
        /// <returns>List of overtime rates</returns>
        /// <response code="200">Returns the list of overtime rates</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("overtime-rates")]
        [ProducesResponseType(typeof(IEnumerable<OvertimeRateDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetOvertimeRates()
        {
            var rates = await _projectDataService.GetOvertimeRates();
            return Ok(rates);
        }

        /// <summary>
        /// Retrieves all GUI column names
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/gui-column-names
        /// 
        /// Returns a list of all GUI column names including:
        /// * Column ID
        /// * Display name
        /// * Description
        /// * Visibility settings
        /// </remarks>
        /// <returns>List of GUI column names</returns>
        /// <response code="200">Returns the list of column names</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("gui-column-names")]
        [ProducesResponseType(typeof(IEnumerable<GUIColumnName>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetGUIColumnNames()
        {
            var columnNames = await _projectDataService.GetGUIColumnNames();
            return Ok(columnNames);
        }

        /// <summary>
        /// Retrieves crew bill rates visibility settings
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/crew-bill-rates-visibility
        /// 
        /// Returns the visibility settings for crew bill rates including:
        /// * User role permissions
        /// * Display settings
        /// * Access levels
        /// </remarks>
        /// <returns>Crew bill rates visibility information</returns>
        /// <response code="200">Returns the visibility settings</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("crew-bill-rates-visibility")]
        [ProducesResponseType(typeof(CrewBillRatesVisibility), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCrewBillRatesVisibility()
        {
            var visibility = await _projectDataService.GetCrewBillRatesVisibility();
            return Ok(visibility);
        }

        /// <summary>
        /// Retrieves shipping requests for a specific project
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/shipping-requests/PROJ123
        /// 
        /// Returns a list of shipping requests for the specified project including:
        /// * Request ID
        /// * Status
        /// * Shipping details
        /// * Tracking information
        /// </remarks>
        /// <param name="projectNumber">The project number to get shipping requests for</param>
        /// <returns>List of shipping requests</returns>
        /// <response code="200">Returns the list of shipping requests</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("shipping-requests/{projectNumber}")]
        [ProducesResponseType(typeof(IEnumerable<ShippingRequest>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetShippingRequests(string projectNumber)
        {
            var requests = await _projectDataService.GetShippingRequests(projectNumber);
            return Ok(requests);
        }

        /// <summary>
        /// Retrieves user menu inclusions for the current user
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/user-menu-inclusions
        /// 
        /// Returns a list of menu items that the current user has access to.
        /// </remarks>
        /// <returns>List of menu inclusions</returns>
        /// <response code="200">Returns the list of menu inclusions</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("user-menu-inclusions")]
        [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUserMenuInclusions()
        {
            var inclusions = await _projectDataService.GetUserMenuInclusions();
            return Ok(inclusions);
        }

        /// <summary>
        /// Retrieves all Pollstar artists
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/pollstar-artists
        /// </remarks>
        /// <returns>List of Pollstar artists ordered by name</returns>
        /// <response code="200">Returns the list of Pollstar artists</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("pollstar-artists")]
        [ProducesResponseType(typeof(IEnumerable<PollstarArtist>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPollstarArtists()
        {
            try
            {
                var artists = await _projectDataService.GetPollstarArtists();
                return Ok(artists);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving artists");
            }
        }

        /// <summary>
        /// Searches Pollstar artists by name
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/pollstar-artists/search?searchTerm=artistname
        /// </remarks>
        /// <param name="searchTerm">The search term to filter artists by name</param>
        /// <returns>List of matching Pollstar artists ordered by name</returns>
        /// <response code="200">Returns the list of matching artists</response>
        /// <response code="400">If the search term is empty</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("pollstar-artists/search")]
        [ProducesResponseType(typeof(IEnumerable<PollstarArtist>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SearchPollstarArtists([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term cannot be empty");
            }

            try
            {
                var artists = await _projectDataService.SearchPollstarArtists(searchTerm);
                return Ok(artists);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while searching artists");
            }
        }

        /// <summary>
        /// Gets a specific Pollstar artist by ID
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/pollstar-artists/123
        /// </remarks>
        /// <param name="id">The ID of the artist to retrieve</param>
        /// <returns>The requested Pollstar artist</returns>
        /// <response code="200">Returns the requested artist</response>
        /// <response code="404">If the artist is not found</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("pollstar-artists/{id}")]
        [ProducesResponseType(typeof(PollstarArtist), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetPollstarArtist(int id)
        {
            try
            {
                var artist = await _projectDataService.GetPollstarArtistById(id);
                if (artist == null)
                {
                    return NotFound($"Artist with ID {id} not found");
                }
                return Ok(artist);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving the artist");
            }
        }

        /// <summary>
        /// Gets contacts based on category ID
        /// </summary>
        /// <param name="categoryId">The contact category ID</param>
        /// <returns>List of contacts in the specified category</returns>
        /// <response code="200">Returns the list of contacts</response>
        /// <response code="404">If no contacts are found for the category</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("contacts/by-category/{categoryId}")]
        [ProducesResponseType(typeof(IEnumerable<Contact>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContactsByCategory(int categoryId)
        {
            var contacts = await _projectDataService.GetContactsByCategory(categoryId);
            if (!contacts.Any())
            {
                return NotFound($"No contacts found for category ID {categoryId}");
            }
            return Ok(contacts);
        }

        /// <summary>
        /// Searches contacts by name, email, or phone
        /// </summary>
        /// <param name="searchTerm">The search term</param>
        /// <returns>List of matching contacts</returns>
        /// <response code="200">Returns the list of matching contacts</response>
        /// <response code="400">If the search term is empty</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("contacts/search")]
        [ProducesResponseType(typeof(IEnumerable<Contact>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchContacts([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term is required");
            }

            var contacts = await _projectDataService.SearchContacts(searchTerm);
            return Ok(contacts);
        }

        /// <summary>
        /// Gets all customers
        /// </summary>
        /// <returns>List of customers</returns>
        /// <response code="200">Returns the list of customers</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("customers")]
        [ProducesResponseType(typeof(IEnumerable<Oecustomer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCustomers()
        {
            var customers = await _projectDataService.GetCustomers();
            return Ok(customers);
        }

        /// <summary>
        /// Searches customers by name or customer number
        /// </summary>
        /// <param name="searchTerm">The search term</param>
        /// <returns>List of matching customers</returns>
        /// <response code="200">Returns the list of matching customers</response>
        /// <response code="400">If the search term is empty</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("customers/search")]
        [ProducesResponseType(typeof(IEnumerable<Oecustomer>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchCustomers([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term is required");
            }

            var customers = await _projectDataService.SearchCustomers(searchTerm);
            return Ok(customers);
        }

        /// <summary>
        /// Gets billing addresses for a customer
        /// </summary>
        /// <param name="customerNo">The customer number</param>
        /// <returns>List of billing addresses for the customer</returns>
        /// <response code="200">Returns the list of billing addresses</response>
        /// <response code="404">If no billing addresses are found for the customer</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("customers/{customerNo}/billing-addresses")]
        [ProducesResponseType(typeof(IEnumerable<Oecustbill>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCustomerBillingAddresses(string customerNo)
        {
            var billingAddresses = await _projectDataService.GetCustomerBillingAddresses(customerNo);
            if (!billingAddresses.Any())
            {
                return NotFound($"No billing addresses found for customer {customerNo}");
            }
            return Ok(billingAddresses);
        }

        /// <summary>
        /// Gets all trucking companies
        /// </summary>
        /// <returns>List of trucking companies</returns>
        /// <response code="200">Returns the list of trucking companies</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("trucking-companies")]
        [ProducesResponseType(typeof(IEnumerable<TruckingCompany>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTruckingCompanies()
        {
            try
            {
                var companies = await _projectDataService.GetTruckingCompanies();
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving trucking companies");
            }
        }

        /// <summary>
        /// Searches trucking companies by name or company number
        /// </summary>
        /// <param name="searchTerm">The search term to filter companies by name or number</param>
        /// <returns>List of matching trucking companies</returns>
        /// <response code="200">Returns the list of matching companies</response>
        /// <response code="400">If the search term is empty</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("trucking-companies/search")]
        [ProducesResponseType(typeof(IEnumerable<TruckingCompany>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> SearchTruckingCompanies([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term is required");
            }

            try
            {
                var companies = await _projectDataService.SearchTruckingCompanies(searchTerm);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while searching trucking companies");
            }
        }

        /// <summary>
        /// Gets all production schedule event types
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/production-schedule-event-types/all
        /// 
        /// Returns a list of all production schedule event types ordered by display order.
        /// </remarks>
        /// <returns>List of production schedule event types</returns>
        /// <response code="200">Returns the list of production schedule event types</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("production-schedule-event-types/all")]
        [ProducesResponseType(typeof(IEnumerable<ClairTourTiny.Infrastructure.Models.ProductionScheduleEventType>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllProductionScheduleEventTypes()
        {
            try
            {
                var eventTypes = await _projectDataService.GetAllProductionScheduleEventTypes();
                return Ok(eventTypes);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving production schedule event types");
            }
        }

        /// <summary>
        /// Gets all shipping destinations
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/shipping-destinations
        /// 
        /// Returns a list of all shipping destinations ordered by destination name.
        /// </remarks>
        /// <returns>List of shipping destinations</returns>
        /// <response code="200">Returns the list of shipping destinations</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("shipping-destinations")]
        [ProducesResponseType(typeof(IEnumerable<ShippingDestination>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllShippingDestinations()
        {
            try
            {
                var destinations = await _projectDataService.GetAllShippingDestinations();
                return Ok(destinations);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving shipping destinations");
            }
        }

        /// <summary>
        /// Searches shipping destinations by name, city, or address
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/shipping-destinations/search?searchTerm=destination
        /// 
        /// Searches for destinations where the search term matches:
        /// - Destination name
        /// - City
        /// - Address
        /// 
        /// Results are ordered by destination name.
        /// </remarks>
        /// <param name="searchTerm">The search term to filter destinations</param>
        /// <returns>List of matching shipping destinations</returns>
        /// <response code="200">Returns the list of matching destinations</response>
        /// <response code="400">If the search term is empty</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("shipping-destinations/search")]
        [ProducesResponseType(typeof(IEnumerable<ShippingDestination>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SearchShippingDestinations([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term is required");
            }

            try
            {
                var destinations = await _projectDataService.SearchShippingDestinations(searchTerm);
                return Ok(destinations);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while searching shipping destinations");
            }
        }

        /// <summary>
        /// Gets all Pollstar venues
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/pollstar-venues
        /// 
        /// Returns a list of all Pollstar venues ordered by venue name.
        /// </remarks>
        /// <returns>List of Pollstar venues</returns>
        /// <response code="200">Returns the list of Pollstar venues</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("pollstar-venues")]
        [ProducesResponseType(typeof(IEnumerable<PollstarVenue>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> GetAllPollstarVenues()
        {
            try
            {
                var venues = await _projectDataService.GetAllPollstarVenues();
                return Ok(venues);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while retrieving Pollstar venues");
            }
        }

        /// <summary>
        /// Searches Pollstar venues by name, city, state, or address
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /api/ProjectDataPoints/pollstar-venues/search?searchTerm=venue
        /// 
        /// Searches for venues where the search term matches:
        /// - Venue name
        /// - City
        /// - State
        /// - Address
        /// 
        /// Results are ordered by venue name.
        /// </remarks>
        /// <param name="searchTerm">The search term to filter venues</param>
        /// <returns>List of matching Pollstar venues</returns>
        /// <response code="200">Returns the list of matching venues</response>
        /// <response code="400">If the search term is empty</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("pollstar-venues/search")]
        [ProducesResponseType(typeof(IEnumerable<PollstarVenue>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesDefaultResponseType]
        public async Task<IActionResult> SearchPollstarVenues([FromQuery] string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return BadRequest("Search term is required");
            }

            try
            {
                var venues = await _projectDataService.SearchPollstarVenues(searchTerm);
                return Ok(venues);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while searching Pollstar venues");
            }
        }

        /// <summary>
        /// Search for parts based on various criteria
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /api/ProjectDataPoints/parts/search
        ///     {
        ///         "searchText": "part description",
        ///         "category": "ELECTRICAL",
        ///         "subCategory": "CABLE",
        ///         "hideUnusedParts": true,
        ///         "onlyMyWarehouses": false,
        ///         "myPartsOnly": false,
        ///         "searchForBarcode": false
        ///     }
        /// 
        /// The search supports the following features:
        /// * Text search in part description and part number
        /// * Barcode (SKU) search
        /// * Filtering by category and subcategory
        /// * Filtering out unused parts
        /// * Filtering by user's warehouses
        /// * Filtering for parts in multipart groups
        /// </remarks>
        /// <param name="request">Search parameters including text, category, and filters</param>
        /// <returns>List of matching parts with their details</returns>
        /// <response code="200">Returns the list of parts matching the search criteria</response>
        /// <response code="400">If the request is invalid or malformed</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpPost("parts/search")]
        [ProducesResponseType(typeof(List<PartSearchResultDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult<List<PartSearchResultDto>>> SearchParts([FromBody] PartSearchRequestDto request)
        {
            if (request == null)
            {
                return BadRequest("Search request cannot be null");
            }

            try
            {
                var results = await _projectDataService.SearchPartsAsync(request);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Get all available part categories
        /// </summary>
        /// <remarks>
        /// Returns a list of all part categories in the system, including an "(All)" option.
        /// Categories are ordered by description.
        /// 
        /// Sample response:
        /// 
        ///     [
        ///         {
        ///             "code": "(All)",
        ///             "description": "(All)"
        ///         },
        ///         {
        ///             "code": "ELECTRICAL",
        ///             "description": "Electrical Equipment"
        ///         },
        ///         {
        ///             "code": "MECHANICAL",
        ///             "description": "Mechanical Equipment"
        ///         }
        ///     ]
        /// </remarks>
        /// <returns>List of part categories with their codes and descriptions</returns>
        /// <response code="200">Returns the list of categories</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("parts/categories")]
        [ProducesResponseType(typeof(List<PartCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult<List<PartCategoryDto>>> GetPartCategories()
        {
            try
            {
                var categories = await _projectDataService.GetPartCategoriesAsync();
                return Ok(categories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Get subcategories for a specific part category
        /// </summary>
        /// <remarks>
        /// Returns a list of subcategories for the specified category, including an "(All)" option.
        /// Subcategories are ordered by description.
        /// 
        /// Sample request:
        ///     GET /api/ProjectDataPoints/parts/subcategories/ELECTRICAL
        /// 
        /// Sample response:
        /// 
        ///     [
        ///         {
        ///             "code": "(All)",
        ///             "description": "(All)",
        ///             "commodity": "ELECTRICAL"
        ///         },
        ///         {
        ///             "code": "CABLE",
        ///             "description": "Cables and Wires",
        ///             "commodity": "ELECTRICAL"
        ///         },
        ///         {
        ///             "code": "LIGHT",
        ///             "description": "Lighting Equipment",
        ///             "commodity": "ELECTRICAL"
        ///         }
        ///     ]
        /// </remarks>
        /// <param name="categoryCode">The category code to get subcategories for (e.g., "ELECTRICAL")</param>
        /// <returns>List of subcategories with their codes, descriptions, and parent category</returns>
        /// <response code="200">Returns the list of subcategories</response>
        /// <response code="400">If the category code is invalid</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("parts/subcategories/{categoryCode}")]
        [ProducesResponseType(typeof(List<PartSubCategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult<List<PartSubCategoryDto>>> GetPartSubCategories(string categoryCode)
        {
            if (string.IsNullOrWhiteSpace(categoryCode))
            {
                return BadRequest("Category code cannot be empty");
            }

            try
            {
                var subCategories = await _projectDataService.GetPartSubCategoriesAsync(categoryCode);
                return Ok(subCategories);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        /// <summary>
        /// Gets the default project settings for a user
        /// </summary>
        /// <remarks>
        /// This endpoint retrieves the default project settings for a specific user or the current user if no username is provided.
        /// 
        /// Sample request:
        ///     GET /api/ProjectDataPoints/default-project-settings
        ///     GET /api/ProjectDataPoints/default-project-settings?username=john.doe
        /// 
        /// Sample response:
        ///     {
        ///         "defaultWarehouse": "WH001",
        ///         "defaultCurrency": "USD",
        ///         "defaultLanguage": "en",
        ///         "defaultBillingCompany": "COMP001",
        ///         "defaultPropType": "TYPE1",
        ///         "unitOfLength": "ft",
        ///         "unitOfWeight": "lbs",
        ///         "conversionFactorFromInches": 0.0833333,
        ///         "conversionFactorFromPounds": 1.0,
        ///         "weightDecimalPlaces": 2,
        ///         "volumeDecimalPlaces": 2,
        ///         "salesForecastGroup": "GROUP1",
        ///         "defaultCrewOps": "EMP001",
        ///         "defaultBidMarkup": 1.25
        ///     }
        /// </remarks>
        /// <param name="username">Optional username to get settings for. If not provided, uses the current user.</param>
        /// <returns>Default project settings for the specified user</returns>
        /// <response code="200">Returns the default project settings</response>
        /// <response code="404">If the user settings are not found</response>
        /// <response code="500">If there was an internal server error</response>
        [HttpGet("default-project-settings")]
        [ProducesResponseType(typeof(DefaultProjectSettingsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult<DefaultProjectSettingsDto>> GetDefaultProjectSettings([FromQuery] string username = null)
        {
            try
            {
                var settings = await _projectDataService.GetDefaultProjectSettingsAsync(username);
                return Ok(settings);
            }
            catch (ApplicationException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
     }
} 