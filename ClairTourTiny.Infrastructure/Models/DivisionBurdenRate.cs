using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DivisionBurdenRate
{
    public string Division { get; set; } = null!;

    public DateOnly ValidFrom { get; set; }

    public DateOnly? ValidThrough { get; set; }

    public decimal EmployeeBurdenRatePercent { get; set; }

    public decimal SubcontractorBurdenRatePercent { get; set; }

    public decimal? EmployeeBurdenRate { get; set; }

    public decimal? SubcontractorBurdenRate { get; set; }

    public virtual Pedivision DivisionNavigation { get; set; } = null!;
}
