using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class PartBidValueDto
    {
        [Column("PartNo")]
        public string PartNo { get; set; } = string.Empty;

        [Column("Currency")]
        public string Currency { get; set; } = string.Empty;

        [Column("ValueType")]
        public string ValueType { get; set; } = string.Empty;

        [Column("BidValue")]
        public double BidValue { get; set; }
    }
}
