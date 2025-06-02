using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class BillingPeriodItemDto
    {
        [Column("bid_entityno")]
        public string BidEntityNo { get; set; } = string.Empty;

        [Column("periodno")]
        public short PeriodNo { get; set; }

        [Column("itemno")]
        public short ItemNo { get; set; }

        [Column("StartDate")]
        public DateTime? StartDate { get; set; }

        [Column("EndDate")]
        public DateTime? EndDate { get; set; }

        [Column("ActualDailyRate")]
        public double ActualDailyRate { get; set; }

        [Column("IsActive")]
        public bool IsActive { get; set; }

        [Column("billingDays")]
        public double? BillingDays { get; set; }
    }
}
