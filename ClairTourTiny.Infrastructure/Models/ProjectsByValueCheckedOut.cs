using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectsByValueCheckedOut
{
    public string CompanyDesc { get; set; } = null!;

    public string? RootProject { get; set; }

    public string Entitydesc { get; set; } = null!;

    public double? TotalValue { get; set; }

    public int IsLate { get; set; }
}
