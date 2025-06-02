using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class BillingItemDto
    {
        [Column("bid_entityno")]
        public string BidEntityNo { get; set; } = string.Empty;

        [Column("itemno")]
        public short ItemNo { get; set; }

        [Column("equipment_entityno")]
        public string? EquipmentEntityNo { get; set; }

        [Column("expense_entityno")]
        public string? ExpenseEntityNo { get; set; }

        [Column("expense_seqno")]
        public int? ExpenseSeqNo { get; set; }

        [Column("crew_entityno")]
        public string? CrewEntityNo { get; set; }

        [Column("crew_empline_no")]
        public int? CrewEmpLineNo { get; set; }

        [Column("NominalDailyRate")]
        public double NominalDailyRate { get; set; }
    }
}
