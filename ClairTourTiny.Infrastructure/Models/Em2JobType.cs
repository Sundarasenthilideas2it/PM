using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Em2JobType
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Jobtype { get; set; } = null!;

    public string Jobdesc { get; set; } = null!;

    public float Hours { get; set; }

    public string? Abraearningscodeprefix { get; set; }

    public float? Qty { get; set; }

    public float? Bidratehourly { get; set; }

    public string? AbraHourlyPayCodePrefix { get; set; }

    public string? AbraHourlyPayCode { get; set; }

    public float? OvertimeHours { get; set; }

    public bool? IsQualification { get; set; }

    public bool? IsActive { get; set; }
}
