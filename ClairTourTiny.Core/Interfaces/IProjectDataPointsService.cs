using ClairTourTiny.Core.Models.ProjectMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClairTourTiny.Infrastructure.Dto.DTOs;
using ClairTourTiny.Infrastructure.Models;

namespace ClairTourTiny.Core.Interfaces
{
    /// <summary>
    /// Interface for managing project data and related information
    /// </summary>
    public interface IProjectDataPointsService
    {
        /// <summary>
        /// Gets all project data in a single call
        /// </summary>
        Task<AllProjectData> GetAllProjectData(string? projectNumber = null);

        /// <summary>
        /// Gets user permissions and role information
        /// </summary>
        Task<UserPermissions> GetUserPermissions();

        /// <summary>
        /// Gets user company information
        /// </summary>
        Task<UserCompanyInfo> GetUserCompanyInfo();

        /// <summary>
        /// Gets list of companies
        /// </summary>
        Task<IEnumerable<CompanyInfo>> GetCompanies();

        /// <summary>
        /// Gets project statuses
        /// </summary>
        Task<IEnumerable<ProjectStatus>> GetProjectStatuses();

        /// <summary>
        /// Gets warehouses
        /// </summary>
        Task<IEnumerable<WarehouseInfo>> GetWarehouses();

        /// <summary>
        /// Gets rate types
        /// </summary>
        Task<IEnumerable<RateType>> GetRateTypes();

        /// <summary>
        /// Gets contact categories
        /// </summary>
        Task<IEnumerable<ContactCategoryDto>> GetContactCategories();

        /// <summary>
        /// Gets production schedule event types
        /// </summary>
        Task<IEnumerable<ProductionScheduleEventTypeDto>> GetProductionScheduleEventTypes();

        /// <summary>
        /// Gets bill schedules
        /// </summary>
        Task<IEnumerable<BillSchedule>> GetBillSchedules();

        /// <summary>
        /// Gets commodities
        /// </summary>
        Task<IEnumerable<Commodity>> GetCommodities();

        /// <summary>
        /// Gets billing accounts
        /// </summary>
        Task<IEnumerable<BillingAccountDto>> GetBillingAccounts();

        /// <summary>
        /// Gets job types in user's division
        /// </summary>
        Task<IEnumerable<JobType>> GetJobTypes();

        /// <summary>
        /// Gets crew bid values
        /// </summary>
        Task<IEnumerable<CrewBidValueDto>> GetCrewBidValues();

        /// <summary>
        /// Gets employees in user's division
        /// </summary>
        Task<IEnumerable<EmployeeDto>> GetEmployees();

        /// <summary>
        /// Gets employee assignment statuses
        /// </summary>
        Task<IEnumerable<EmployeeAssignmentStatusCodeDto>> GetEmployeeAssignmentStatuses();

        /// <summary>
        /// Gets paying per diem status types
        /// </summary>
        Task<IEnumerable<PerDiemStatusType>> GetPayingPerDiemStatusTypes();

        /// <summary>
        /// Gets per diem billable status types
        /// </summary>
        Task<IEnumerable<PerDiemBillableStatusType>> GetPerDiemBillableStatusTypes();

        /// <summary>
        /// Gets employee job types
        /// </summary>
        Task<IEnumerable<EmployeeJobType>> GetEmployeeJobTypes();

        /// <summary>
        /// Gets budget categories
        /// </summary>
        Task<IEnumerable<BudgetCategoryDto>> GetBudgetCategories();

        /// <summary>
        /// Gets expense codes
        /// </summary>
        Task<IEnumerable<ExpenseCode>> GetExpenseCodes();

        /// <summary>
        /// Gets equipment subhire statuses
        /// </summary>
        Task<IEnumerable<EquipmentSubhireStatusDto>> GetEquipmentSubhireStatuses();

        /// <summary>
        /// Gets expense categories
        /// </summary>
        Task<IEnumerable<ExpenseCategoryDto>> GetExpenseCategories();

        /// <summary>
        /// Gets expense period types
        /// </summary>
        Task<IEnumerable<ExpensePeriodTypeDTO>> GetExpensePeriodTypes();

        /// <summary>
        /// Gets property types
        /// </summary>
        Task<IEnumerable<PropertyTypeDTO>> GetPropertyTypes();

        /// <summary>
        /// Gets currencies
        /// </summary>
        Task<IEnumerable<CurrencyDto>> GetCurrencies();

        /// <summary>
        /// Gets referral programs
        /// </summary>
        Task<IEnumerable<ReferralProgramDto>> GetReferralPrograms();

        /// <summary>
        /// Gets favorite projects for current user
        /// </summary>
        Task<IEnumerable<string>> GetFavoriteProjects();

        /// <summary>
        /// Gets tax codes
        /// </summary>
        Task<IEnumerable<TaxCodeDto>> GetTaxCodes();

        /// <summary>
        /// Gets project price levels
        /// </summary>
        Task<IEnumerable<ProjectPriceLevelDto>> GetProjectPriceLevels();

        /// <summary>
        /// Gets account matrix
        /// </summary>
        Task<IEnumerable<AccountMatrix>> GetAccountMatrix();

        /// <summary>
        /// Gets overtime rates
        /// </summary>
        Task<IEnumerable<OvertimeRateDto>> GetOvertimeRates();

        /// <summary>
        /// Gets GUI column names
        /// </summary>
        Task<IEnumerable<GUIColumnName>> GetGUIColumnNames();

        /// <summary>
        /// Gets crew bill rates visibility
        /// </summary>
        Task<CrewBillRatesVisibility> GetCrewBillRatesVisibility();

        /// <summary>
        /// Gets shipping requests for a project
        /// </summary>
        Task<IEnumerable<ShippingRequest>> GetShippingRequests(string projectNumber);

        /// <summary>
        /// Gets user menu inclusions
        /// </summary>
        Task<IEnumerable<string>> GetUserMenuInclusions();

        /// <summary>
        /// Gets all Pollstar artists
        /// </summary>
        /// <returns>List of Pollstar artists</returns>
        Task<IEnumerable<PollstarArtist>> GetPollstarArtists();

        /// <summary>
        /// Searches Pollstar artists by name
        /// </summary>
        /// <param name="searchTerm">The search term to filter artists by name</param>
        /// <returns>List of matching Pollstar artists</returns>
        Task<IEnumerable<PollstarArtist>> SearchPollstarArtists(string searchTerm);

        /// <summary>
        /// Gets a specific Pollstar artist by ID
        /// </summary>
        /// <param name="id">The ID of the artist to retrieve</param>
        /// <returns>The requested Pollstar artist</returns>
        Task<PollstarArtist?> GetPollstarArtistById(int id);

        /// <summary>
        /// Gets contacts based on category ID
        /// </summary>
        /// <param name="categoryId">The contact category ID</param>
        /// <returns>List of contacts in the specified category</returns>
        Task<IEnumerable<Contact>> GetContactsByCategory(int categoryId);

        /// <summary>
        /// Searches contacts by name, email, or phone
        /// </summary>
        /// <param name="searchTerm">The search term</param>
        /// <returns>List of matching contacts</returns>
        Task<IEnumerable<Contact>> SearchContacts(string searchTerm);

        /// <summary>
        /// Gets all customers
        /// </summary>
        /// <returns>List of customers</returns>
        Task<IEnumerable<Oecustomer>> GetCustomers();

        /// <summary>
        /// Searches customers by name or customer number
        /// </summary>
        /// <param name="searchTerm">The search term</param>
        /// <returns>List of matching customers</returns>
        Task<IEnumerable<Oecustomer>> SearchCustomers(string searchTerm);

        /// <summary>
        /// Gets billing addresses for a customer
        /// </summary>
        /// <param name="customerNo">The customer number</param>
        /// <returns>List of billing addresses for the customer</returns>
        Task<IEnumerable<Oecustbill>> GetCustomerBillingAddresses(string customerNo);

        /// <summary>
        /// Gets all trucking companies
        /// </summary>
        /// <returns>List of trucking companies</returns>
        Task<IEnumerable<TruckingCompany>> GetTruckingCompanies();

        /// <summary>
        /// Searches trucking companies by name or company number
        /// </summary>
        /// <param name="searchTerm">The search term to filter companies by name or number</param>
        /// <returns>List of matching trucking companies</returns>
        Task<IEnumerable<TruckingCompany>> SearchTruckingCompanies(string searchTerm);

        /// <summary>
        /// Gets all production schedule event types
        /// </summary>
        /// <returns>List of production schedule event types</returns>
        Task<IEnumerable<ClairTourTiny.Infrastructure.Models.ProductionScheduleEventType>> GetAllProductionScheduleEventTypes();

        /// <summary>
        /// Gets all shipping destinations
        /// </summary>
        /// <returns>List of shipping destinations</returns>
        Task<IEnumerable<ShippingDestination>> GetAllShippingDestinations();

        /// <summary>
        /// Searches shipping destinations by name, city, or address
        /// </summary>
        /// <param name="searchTerm">The search term to filter destinations</param>
        /// <returns>List of matching shipping destinations</returns>
        Task<IEnumerable<ShippingDestination>> SearchShippingDestinations(string searchTerm);

        /// <summary>
        /// Gets all Pollstar venues
        /// </summary>
        /// <returns>List of Pollstar venues</returns>
        Task<IEnumerable<PollstarVenue>> GetAllPollstarVenues();

        /// <summary>
        /// Searches Pollstar venues by name or location
        /// </summary>
        /// <param name="searchTerm">The search term to filter venues by name or location</param>
        /// <returns>List of matching Pollstar venues</returns>
        Task<IEnumerable<PollstarVenue>> SearchPollstarVenues(string searchTerm);

         /// <summary>
        /// Search for parts based on various criteria
        /// </summary>
        /// <param name="request">Search parameters including text, category, and filters</param>
        /// <returns>List of matching parts</returns>
        Task<List<PartSearchResultDto>> SearchPartsAsync(PartSearchRequestDto request);

        /// <summary>
        /// Get all available part categories
        /// </summary>
        /// <returns>List of part categories</returns>
        Task<List<PartCategoryDto>> GetPartCategoriesAsync();

        /// <summary>
        /// Get subcategories for a specific part category
        /// </summary>
        /// <param name="categoryCode">The category code to get subcategories for</param>
        /// <returns>List of subcategories</returns>
        Task<List<PartSubCategoryDto>> GetPartSubCategoriesAsync(string categoryCode);

        /// <summary>
        /// Gets default project settings for the current user
        /// </summary>
        /// <returns>Default project settings including warehouse, currency, units, and other user preferences</returns>
        Task<ClairTourTiny.Infrastructure.Dto.DTOs.DefaultProjectSettingsDto> GetDefaultProjectSettingsAsync(string username = null);
    }
} 