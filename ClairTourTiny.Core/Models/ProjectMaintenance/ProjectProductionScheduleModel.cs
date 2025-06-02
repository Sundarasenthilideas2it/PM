namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectProductionScheduleModel
    {
        public string EntityNo { get; set; } = string.Empty;
        public string EventType { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VenueID { get; set; }
        public string? DestinationDetail { get; set; }
        public string? Note { get; set; }
        public string? LocationName { get; set; }
        public int DisplayOrder { get; set; }
    }
}
