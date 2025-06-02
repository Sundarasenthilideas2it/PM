using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeePayRateHistory
{
    public DateTime ValidFromUtc { get; set; }

    public DateTime? ValidToUtc { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }

    public string Empno { get; set; } = null!;

    public string JobType { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double HourlyRate { get; set; }

    public string? Currency { get; set; }
}
