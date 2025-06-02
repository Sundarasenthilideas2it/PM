using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBrpcrewRates20220430
{
    public string? Empno { get; set; }

    public string? Lastname { get; set; }

    public string? Firstname { get; set; }

    public string? Jobtype { get; set; }

    public double? LastRate { get; set; }

    public double? LastDate { get; set; }

    public double? LastBillDays { get; set; }

    public double? LongestRate { get; set; }

    public double? LongestBillDays { get; set; }

    public double? Year { get; set; }
}
