using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmStockTypePrice
{
    public double? IdStockTypePrice { get; set; }

    public double? IdStockType { get; set; }

    public double? IdCurrency { get; set; }

    public double? Rental { get; set; }

    public double? SubRental { get; set; }

    public double? Purchase { get; set; }

    public double? Sales { get; set; }

    public double? Minimum { get; set; }

    public double? RentalBase { get; set; }

    public string? WorkshopCosts { get; set; }

    public double? CheckInOutCosts { get; set; }

    public double? StorageCosts { get; set; }

    public string? AdditionalCosts { get; set; }

    public string? DailyRevenue { get; set; }

    public double? Loss { get; set; }

    public string? Scale { get; set; }

    public double? SalesUsed { get; set; }

    public double? SalesBase { get; set; }

    public double? PurchaseBase { get; set; }
}
