namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectBillingItemModel
    {
        public string BidEntityNo { get; set; } = string.Empty;
        public short ItemNo { get; set; }
        public string? EquipmentEntityNo { get; set; }
        public string? ExpenseEntityNo { get; set; }
        public int? ExpenseSeqNo { get; set; }
        public string? CrewEntityNo { get; set; }
        public int? CrewEmpLineNo { get; set; }
        public double NominalDailyRate { get; set; }
    }
}
