using AutoMapper;
using ClairTourTiny.Core.Helpers;
using ClairTourTiny.Core.Interfaces;
using ClairTourTiny.Core.Models.ProjectMaintenance;
using ClairTourTiny.Infrastructure;
using ClairTourTiny.Infrastructure.Dto.ProjectMaintenance;
using ClairTourTiny.Infrastructure.Models.ProjectMaintenance;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ClairTourTiny.Core.Services
{
    public class ProjectMaintenanceService : IProjectMaintenanceService
    {
        private readonly ClairTourTinyContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IProjectMaintenanceHelper _pjtHelper;

        public ProjectMaintenanceService(ClairTourTinyContext clairTourTinyContext, IMapper mapper, IProjectMaintenanceHelper pjtHelper)
        {
            _dbContext = clairTourTinyContext;
            _mapper = mapper;
            _pjtHelper = pjtHelper;
        }

        public async Task<int> GetNextAvailableProjectNumber()
        {
            var param = new SqlParameter("@nextProjectNumber", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output,
            };
            await _dbContext.ExecuteStoredProcedureNonQueryOutputParamAsync("get_next_project_number", param);
            return Convert.ToInt32(param.Value ?? 0);
        }

        public async Task<List<PhaseModel>> GetPhases(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var phasesDtos = await _dbContext.ExecuteStoredProcedureAsync<PhaseDto>("pm2_get_phases", param);
            return _mapper.Map<List<PhaseModel>>(phasesDtos);
        }

        public async Task<List<ProjectEquipmentModel>> GetEquipments(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var equipmentDtos = await _dbContext.ExecuteStoredProcedureAsync<EquipmentDto>("pm2_get_equipment", param);
            return _mapper.Map<List<ProjectEquipmentModel>>(equipmentDtos);
        }

        public async Task<List<ProjectEquipmentSubhireModel>> GetEquipmentSubhires(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var equipmentDtos = await _dbContext.ExecuteStoredProcedureAsync<EquipmentSubhireDto>("pm2_get_equipment_subhires", param);
            return _mapper.Map<List<ProjectEquipmentSubhireModel>>(equipmentDtos);
        }

        public async Task<List<ProjectBidExpenseModel>> GetBidExpenses(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var bidExpenseDtos = await _dbContext.ExecuteStoredProcedureAsync<BidExpenseDto>("pm2_get_bid_expenses", param);
            return _mapper.Map<List<ProjectBidExpenseModel>>(bidExpenseDtos);
        }

        public async Task<List<ProjectRfiModel>> GetRfis(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var rfiDtos = await _dbContext.ExecuteStoredProcedureAsync<RfiDto>("pm2_get_RFIs", param);
            return _mapper.Map<List<ProjectRfiModel>>(rfiDtos);
        }

        public async Task<List<ProjectNoteModel>> GetNotes(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var noteDtos = await _dbContext.ExecuteStoredProcedureAsync<NoteDto>("pm2_get_notes", param);
            return _mapper.Map<List<ProjectNoteModel>>(noteDtos);
        }

        public async Task<List<ProjectAssignedCrewOtModel>> GetAssignedCrewOtData(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var assignedCrewOtDtos = await _dbContext.ExecuteStoredProcedureAsync<AssignedCrewOtDto>("pm2_get_assigned_crew_OT_data", param);
            return _mapper.Map<List<ProjectAssignedCrewOtModel>>(assignedCrewOtDtos);
        }

        public async Task<List<ProjectBillingItemModel>> GetBillingItems(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var billingItemDtos = await _dbContext.ExecuteStoredProcedureAsync<BillingItemDto>("pm2_get_project_billing_items", param);
            return _mapper.Map<List<ProjectBillingItemModel>>(billingItemDtos);
        }

        public async Task<List<ProjectPartBidValueModel>> GetPartBids(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var partBidDtos = await _dbContext.ExecuteStoredProcedureAsync<PartBidValueDto>("pm2_get_part_bid_values_on_project", param);
            return _mapper.Map<List<ProjectPartBidValueModel>>(partBidDtos);
        }

        public async Task<List<ProjectProductionScheduleModel>> GetProductionSchedules(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var productionScheduleDtos = await _dbContext.ExecuteStoredProcedureAsync<ProductionScheduleDto>("pm2_get_project_production_schedule", param);
            return _mapper.Map<List<ProjectProductionScheduleModel>>(productionScheduleDtos);
        }

        public async Task<List<ProjectAssignedCrewModel>> GetAssignedCrews(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var assignedCrewDtos = await _dbContext.ExecuteStoredProcedureAsync<AssignedCrewDto>("pm2_get_assigned_crew", param);
            return _mapper.Map<List<ProjectAssignedCrewModel>>(assignedCrewDtos);
        }

        public async Task<List<ProjectCrewModel>> GetCrews(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var crewDtos = await _dbContext.ExecuteStoredProcedureAsync<CrewDto>("pm2_get_crew", param);
            return _mapper.Map<List<ProjectCrewModel>>(crewDtos);
        }

        public async Task<List<ProjectBillingPeriodModel>> GetBillingPeriods(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var billingPeriodDtos = await _dbContext.ExecuteStoredProcedureAsync<BillingPeriodDto>("pm2_get_project_billing_periods", param);
            return _mapper.Map<List<ProjectBillingPeriodModel>>(billingPeriodDtos);
        }

        public async Task<List<ProjectBillingPeriodItemModel>> GetBillingPeriodItems(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var billingPeriodItemDtos = await _dbContext.ExecuteStoredProcedureAsync<BillingPeriodItemDto>("pm2_get_project_billing_period_items", param);
            return _mapper.Map<List<ProjectBillingPeriodItemModel>>(billingPeriodItemDtos);
        }

        public async Task<List<ProjectClientShippingAddressModel>> GetClientShippingAddresses(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var clientAddressDtos = await _dbContext.ExecuteStoredProcedureAsync<ClientShippingAddressDto>("pm2_get_project_client_shipping_addresses", param);
            return _mapper.Map<List<ProjectClientShippingAddressModel>>(clientAddressDtos);
        }

        public async Task<List<ProjectPartModel>> GetParts(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var partDtos = await _dbContext.ExecuteStoredProcedureAsync<PartDto>("pm2_get_parts_on_project", param);
            return _mapper.Map<List<ProjectPartModel>>(partDtos);
        }

        public async Task<List<ProjectClientContactModel>> GetClientContacts(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var clientContactDtos = await _dbContext.ExecuteStoredProcedureAsync<ClientContactDto>("pm2_get_project_client_contacts", param);
            return _mapper.Map<List<ProjectClientContactModel>>(clientContactDtos);
        }

        public async Task<List<ProjectClientAddressModel>> GetClientAddresses(string entityNo)
        {
            var param = new SqlParameter("@entityno", entityNo);
            var clientAddressDtos = await _dbContext.ExecuteStoredProcedureAsync<ClientAddressDto>("pm2_get_project_client_addresses", param);
            return _mapper.Map<List<ProjectClientAddressModel>>(clientAddressDtos);
        }
        public async Task<bool> SubmitPhases(string entityNo, ProjectSaveModel model)
        {
            bool result = false;
            using var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                await _dbContext.ExecuteStoredProcedureNonQueryAsync("clear_pm2_temp_tables", []);
                await _pjtHelper.ProcessAllBulkSaves(model, _mapper, _dbContext);
                await _dbContext.ExecuteStoredProcedureNonQueryAsync("commit_project_maintenance", []);
                await transaction.CommitAsync();
                result = true;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync();
                throw;
            }
            return result;
        }
    }
}
