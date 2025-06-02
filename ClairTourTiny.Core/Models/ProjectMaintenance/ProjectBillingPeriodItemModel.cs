namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectBillingPeriodItemModel
    {
        public string BidEntityNo { get; set; } = string.Empty;
        public short PeriodNo { get; set; }
        public short ItemNo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public double ActualDailyRate { get; set; }
        public bool IsActive { get; set; }
        public double? BillingDays { get; set; }
    }
}
