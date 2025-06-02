using ClairTourTiny.Core.Models.ProjectMaintenance.Save;

namespace ClairTourTiny.Infrastructure.Models.ProjectMaintenance;

public class ProjectSaveModel
{
    public List<ProjectModel> Projects { get; set; } = new();
    public List<Equipment> Equipment { get; set; } = new();
    public List<Crew> Crew { get; set; } = new();
    public List<AssignedCrew> AssignedCrew { get; set; } = new();
    public List<RfiModel> RFIs { get; set; } = new();
    public List<BidExpense> BidExpenses { get; set; } = new();
    public List<BidRevenue> BidRevenue { get; set; } = new();
    public List<ProjectNote> ProjectNotes { get; set; } = new();
    public List<Core.Models.ProjectMaintenance.Save.ProjectBillingPeriod> ProjectBillingPeriods { get; set; } = new();
    public List<Core.Models.ProjectMaintenance.Save.ProjectClientContact> ProjectClientContacts { get; set; } = new();
    public List<Core.Models.ProjectMaintenance.Save.ProjectEmployeeOvertimeRate> ProjectEmployeeOvertimeRates { get; set; } = new();
    public List<Core.Models.ProjectMaintenance.Save.ProjectProductionSchedule> ProjectProductionSchedule { get; set; } = new();
    public List<Core.Models.ProjectMaintenance.Save.ProjectBillingPeriodItem> ProjectBillingPeriodItems { get; set; } = new();
    public List<Core.Models.ProjectMaintenance.Save.ProjectBillingItem> ProjectBillingItems { get; set; } = new();
    public List<FavoriteProject> FavoriteProjects { get; set; } = new();
    public List<ProjectEquipmentSubhireModel> EquipmentSubhires { get; set; } = new();
} 