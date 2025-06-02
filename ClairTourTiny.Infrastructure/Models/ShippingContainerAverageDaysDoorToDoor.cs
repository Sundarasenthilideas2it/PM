using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ShippingContainerAverageDaysDoorToDoor
{
    public string FromWh { get; set; } = null!;

    public string? ToWh { get; set; }

    public int? AvgDays { get; set; }

    public int? MinDays { get; set; }

    public int? MaxDays { get; set; }
}
