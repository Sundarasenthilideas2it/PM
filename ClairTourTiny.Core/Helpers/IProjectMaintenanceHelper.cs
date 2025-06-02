using AutoMapper;
using ClairTourTiny.Infrastructure;
using ClairTourTiny.Infrastructure.Models.ProjectMaintenance;

namespace ClairTourTiny.Core.Helpers
{
    public interface IProjectMaintenanceHelper
    {
        Task ProcessAllBulkSaves(ProjectSaveModel model, IMapper mapper, ClairTourTinyContext context);
    }
}
