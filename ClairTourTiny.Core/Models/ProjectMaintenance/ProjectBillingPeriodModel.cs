namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectBillingPeriodModel
    {
        public string BidEntityNo { get; set; } = string.Empty;
        public short PeriodNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PeriodTitle { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public bool ShowOnQuoteReport { get; set; }
        public int? DisplayOrder { get; set; }
    }
}
