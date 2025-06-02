using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CostOfInternationalFreightMovement
{
    public string Commmodity { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int? Transferred { get; set; }

    public string Partdesc { get; set; } = null!;

    public string FromWh { get; set; } = null!;

    public string? ToWh { get; set; }

    public double? WeightTransferred { get; set; }

    public double? ValueTransferred { get; set; }

    public int? TransferDays { get; set; }

    public string ShippingMethodDesc { get; set; } = null!;

    public double? PricePerPoundUsd { get; set; }

    public double? CostToShipOneWay { get; set; }

    public double? CostToNotUtilize { get; set; }

    public double? TotalCostToNotPurchase { get; set; }

    public double? CostToPurchase { get; set; }
}
