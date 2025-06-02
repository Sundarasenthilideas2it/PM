using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeEmail
{
    public string EmployeeId { get; set; } = null!;

    public string? EmailAddress { get; set; }

    public string Type { get; set; } = null!;
}
