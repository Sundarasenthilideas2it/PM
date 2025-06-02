using ClairTourTiny.Core.Models.ProjectMaintenance;
using ClairTourTiny.Infrastructure.Models.ProjectMaintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClairTourTiny.Core.Interfaces
{
    public interface IProjectMaintenanceService
    {
        Task<int> GetNextAvailableProjectNumber();

        Task<List<PhaseModel>> GetPhases(string entityNo);

        Task<List<ProjectEquipmentModel>> GetEquipments(string entityNo);

        Task<List<ProjectEquipmentSubhireModel>> GetEquipmentSubhires(string entityNo);

        Task<List<ProjectBidExpenseModel>> GetBidExpenses(string entityNo);

        Task<List<ProjectRfiModel>> GetRfis(string entityNo);

        Task<List<ProjectNoteModel>> GetNotes(string entityNo);

        Task<List<ProjectAssignedCrewOtModel>> GetAssignedCrewOtData(string entityNo);

        Task<List<ProjectBillingItemModel>> GetBillingItems(string entityNo);

        Task<List<ProjectPartBidValueModel>> GetPartBids(string entityNo);

        Task<List<ProjectProductionScheduleModel>> GetProductionSchedules(string entityNo);

        Task<List<ProjectAssignedCrewModel>> GetAssignedCrews(string entityNo);

        Task<List<ProjectCrewModel>> GetCrews(string entityNo);

        Task<List<ProjectBillingPeriodModel>> GetBillingPeriods(string entityNo);

        Task<List<ProjectBillingPeriodItemModel>> GetBillingPeriodItems(string entityNo);

        Task<List<ProjectClientShippingAddressModel>> GetClientShippingAddresses(string entityNo);

        Task<List<ProjectPartModel>> GetParts(string entityNo);

        Task<List<ProjectClientContactModel>> GetClientContacts(string entityNo);

        Task<List<ProjectClientAddressModel>> GetClientAddresses(string entityNo);

        Task<bool> SubmitPhases(string entityNo, ProjectSaveModel model);
    }
}
