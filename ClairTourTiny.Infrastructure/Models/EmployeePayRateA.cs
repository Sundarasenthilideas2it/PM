using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeePayRateA
{
    public string? Empno { get; set; }

    public string? JobType { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? HourlyRate { get; set; }

    public string? Currency { get; set; }

    public string? Note { get; set; }

    public DateTime AdateTime { get; set; }

    public string? AuserId { get; set; }

    public int ArecordAction { get; set; }

    public Guid AtransactionId { get; set; }

    public long? Atransaction { get; set; }
}
