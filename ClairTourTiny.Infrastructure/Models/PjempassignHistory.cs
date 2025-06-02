using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjempassignHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Entityno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public int ChangeNo { get; set; }

    public DateTime Todate { get; set; }

    public double EstHours { get; set; }

    public string RaId { get; set; } = null!;

    public int EmplineNo { get; set; }

    public string StatusCode { get; set; } = null!;

    public string? RfiEntityno { get; set; }

    public int? RfiSeqno { get; set; }

    public string? PdRfiEntityno { get; set; }

    public int? PdRfiSeqno { get; set; }

    public double? HoursPerDay { get; set; }

    public int? GigMeAvailabilityRequestId { get; set; }

    public string? GigMeAvailabilityRequester { get; set; }

    public int? Ponumber { get; set; }

    public string? PayingPerDiemStatusCode { get; set; }

    public string? IsPerDiemBillableStatusCode { get; set; }

    public string? Note { get; set; }

    public double? PerDiemRate { get; set; }
}
