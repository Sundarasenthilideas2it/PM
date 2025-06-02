using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WarehouseTransVolume
{
    public DateOnly TransactionDate { get; set; }

    public string WarehouseCode { get; set; } = null!;

    public decimal? CheckoutCount { get; set; }

    public decimal? CheckoutValueUsd { get; set; }

    public decimal? CheckinCount { get; set; }

    public decimal? CheckinValueUsd { get; set; }
}
