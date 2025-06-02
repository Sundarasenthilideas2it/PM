using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeLocation
{
    public string Location { get; set; } = null!;

    public string? LocationParent { get; set; }

    public int? Id { get; set; }
}
