using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeesInMyDivision
{
    public string Empno { get; set; } = null!;

    public string? Empname { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string GroupStatus { get; set; } = null!;

    public byte? DisplayOrder { get; set; }

    public string? InMyDivision { get; set; }
}
