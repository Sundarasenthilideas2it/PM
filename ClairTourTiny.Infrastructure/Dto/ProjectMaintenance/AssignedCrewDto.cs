using System.ComponentModel.DataAnnotations.Schema;

namespace ClairTourTiny.Infrastructure.Dto.ProjectMaintenance
{
    public class AssignedCrewDto
    {
        [Column("entityno")]
        public string EntityNo { get; set; } = string.Empty;

        [Column("empno")]
        public string EmpNo { get; set; } = string.Empty;

        [Column("jobtype")]
        public string JobType { get; set; } = string.Empty;

        [Column("fromdate")]
        public DateTime FromDate { get; set; }

        [Column("todate")]
        public DateTime ToDate { get; set; }

        [Column("est_hours")]
        public double EstHours { get; set; }

        [Column("empline_no")]
        public int EmpLineNo { get; set; }

        [Column("StatusCode")]
        public string StatusCode { get; set; } = string.Empty;

        [Column("rfi_entityno")]
        public string? RfiEntityNo { get; set; }

        [Column("rfi_seqno")]
        public int? RfiSeqNo { get; set; }

        [Column("pd_rfi_entityno")]
        public string? PdRfiEntityNo { get; set; }

        [Column("pd_rfi_seqno")]
        public int? PdRfiSeqNo { get; set; }

        [Column("PONumber")]
        public int? PONumber { get; set; }

        [Column("PayingPerDiemStatusCode")]
        public string? PayingPerDiemStatusCode { get; set; }

        [Column("IsPerDiemBillableStatusCode")]
        public string? IsPerDiemBillableStatusCode { get; set; }

        [Column("Note")]
        public string? Note { get; set; }

        [Column("PerDiemRate")]
        public double? PerDiemRate { get; set; }

        [Column("SubInvoiceNumber")]
        public string? SubInvoiceNumber { get; set; }

        [Column("SubInvoiceDate")]
        public DateTime? SubInvoiceDate { get; set; }
    }
}
