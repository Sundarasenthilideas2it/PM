using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeJobTypeQualificationsCommaList
{
    public string Empno { get; set; } = null!;

    public string? JobTypes { get; set; }

    public string? Qualifications { get; set; }
}
