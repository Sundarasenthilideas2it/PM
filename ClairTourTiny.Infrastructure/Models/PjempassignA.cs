using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PjempassignA
{
    public string? Empno { get; set; }

    public string? Entityno { get; set; }

    public int? ChangeNo { get; set; }

    public string? Jobtype { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public double? EstHours { get; set; }

    public string? RaId { get; set; }

    public int? EmplineNo { get; set; }

    public string? StatusCode { get; set; }

    public string? RfiEntityno { get; set; }

    public int? RfiSeqno { get; set; }

    public string? PdRfiEntityno { get; set; }

    public int? PdRfiSeqno { get; set; }

    public int? GigMeAvailabilityRequestId { get; set; }

    public string? GigMeAvailabilityRequester { get; set; }

    public int? Ponumber { get; set; }

    public string? PayingPerDiemStatusCode { get; set; }

    public string? IsPerDiemBillableStatusCode { get; set; }

    public string? Note { get; set; }

    public double? PerDiemRate { get; set; }

    public string? SubInvoiceNumber { get; set; }

    public DateTime? SubInvoiceDate { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
