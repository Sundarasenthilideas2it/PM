using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjjobbudgetum
{
    public string? Entityno { get; set; }

    public int? ChangeNo { get; set; }

    public DateTime? ChangeDate { get; set; }

    public int? Seqno { get; set; }

    public string? Jobtype { get; set; }

    public string? Jobdesc { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public double? OpBegTime { get; set; }

    public int? CrewSize { get; set; }

    public double? EstHours { get; set; }

    public double? EstRate { get; set; }

    public decimal? EstTotal { get; set; }

    public double? EstRevRate { get; set; }

    public decimal? EstRevTotal { get; set; }

    public Guid? Primekey { get; set; }

    public int? EmplineNo { get; set; }

    public Guid? MsreplTranVersion { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
