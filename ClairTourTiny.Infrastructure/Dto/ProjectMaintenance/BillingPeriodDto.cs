using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class BillingPeriodDto
    {
        [Column("bid_entityno")]
        public string BidEntityNo { get; set; } = string.Empty;

        [Column("periodno")]
        public short PeriodNo { get; set; }

        [Column("StartDate")]
        public DateTime StartDate { get; set; }

        [Column("EndDate")]
        public DateTime EndDate { get; set; }

        [Column("PeriodTitle")]
        public string PeriodTitle { get; set; } = string.Empty;

        [Column("isActive")]
        public bool IsActive { get; set; }

        [Column("ShowOnQuoteReport")]
        public bool ShowOnQuoteReport { get; set; }

        [Column("DisplayOrder")]
        public int? DisplayOrder { get; set; }
    }
}
