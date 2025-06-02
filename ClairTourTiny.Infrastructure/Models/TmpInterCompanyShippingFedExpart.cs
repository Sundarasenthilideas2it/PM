using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpInterCompanyShippingFedExpart
{
    public string? Partno { get; set; }

    public string? PartDescription { get; set; }

    public string? SumOfQty { get; set; }

    public string? AverageOfRentalValueUsd { get; set; }

    public string? AverageOfWeightLbs { get; set; }

    public string? TotalValueShipped { get; set; }

    public string? TotalWeightShipped { get; set; }

    public string? FedexPriorityOvernight { get; set; }

    public string? FedexInt { get; set; }

    public string? Utilization { get; set; }
}
