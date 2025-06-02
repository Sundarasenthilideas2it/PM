namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectAssignedCrewModel
    {
        public string EntityNo { get; set; } = string.Empty;
        public string EmpNo { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public double EstHours { get; set; }
        public int EmpLineNo { get; set; }
        public string StatusCode { get; set; } = string.Empty;
        public string? RfiEntityNo { get; set; }
        public int? RfiSeqNo { get; set; }
        public string? PdRfiEntityNo { get; set; }
        public int? PdRfiSeqNo { get; set; }
        public int? PONumber { get; set; }
        public string? PayingPerDiemStatusCode { get; set; }
        public string? IsPerDiemBillableStatusCode { get; set; }
        public string? Note { get; set; }
        public double? PerDiemRate { get; set; }
        public string? SubInvoiceNumber { get; set; }
        public DateTime? SubInvoiceDate { get; set; }
    }
}
