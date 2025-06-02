using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobTypesInMyDivision
{
    public string Jobtype { get; set; } = null!;

    public string Jobdesc { get; set; } = null!;

    public double Hours { get; set; }

    public string Abraearningscodeprefix { get; set; } = null!;

    public bool IsQualification { get; set; }

    public bool IsActive { get; set; }

    public string InMyDivision { get; set; } = null!;
}
