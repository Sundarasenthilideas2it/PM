using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpInterCompanyShipping
{
    public string? Partno { get; set; }

    public string? PartDescription { get; set; }

    public string? SumOfQty { get; set; }

    public string? AverageOfRentalValueUsd { get; set; }

    public string? AverageOfWeightLbs { get; set; }

    public string? TotalValueShipped { get; set; }

    public string? TotalWeightShipped { get; set; }

    public string? CostOfGroundFrieght { get; set; }

    public string? CostOfUnitOnSeaCan { get; set; }

    public string? CostOfUnitOnAirFreight { get; set; }

    public string? Utilization { get; set; }
}
