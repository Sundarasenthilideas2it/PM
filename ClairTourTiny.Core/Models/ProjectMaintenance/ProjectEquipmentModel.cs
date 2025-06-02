namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectEquipmentModel
    {
        public string Entityno { get; set; } = string.Empty;
        public int Seqno { get; set; }
        public string PartDescription { get; set; } = string.Empty;
        public string Partno { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string MfgNo { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
        public int? Bottleneck { get; set; }
        public int CheckedOut { get; set; }
        public double Markup { get; set; }
        public int? QuantityToSubhire { get; set; }
        public string Category { get; set; } = string.Empty;
        public string NoteInternal { get; set; } = string.Empty;
        public double? PriceLevelValue { get; set; }
        public double Totmatcost4 { get; set; }
        public string? MatrixCd { get; set; }
    }
}
