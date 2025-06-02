namespace ClairTourTiny.Core.Models.ProjectMaintenance.Save;

public class AssignedCrew
{
    public DateTime UpdateTime { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
    public bool IsDelete { get; set; }
    public string Entityno { get; set; } = null!;
    public string Jobtype { get; set; } = null!;
    public string EmpnoOld { get; set; } = null!;
    public string EmpnoNew { get; set; } = null!;
    public DateTime FromdateOld { get; set; }
    public DateTime FromdateNew { get; set; }
    public DateTime Todate { get; set; }
    public double EstHours { get; set; }
    public int EmplineNo { get; set; }
    public string? StatusCode { get; set; }
    public string? RfiEntityno { get; set; }
    public int? RfiSeqno { get; set; }
    public string? PdRfiEntityno { get; set; }
    public int? PdRfiSeqno { get; set; }
    public int? Ponumber { get; set; }
    public string? PayingPerDiemStatusCode { get; set; }
    public string? IsPerDiemBillableStatusCode { get; set; }
    public string? Note { get; set; }
    public double? PerDiemRate { get; set; }
    public string? SubInvoiceNumber { get; set; }
    public DateTime? SubInvoiceDate { get; set; }
} 