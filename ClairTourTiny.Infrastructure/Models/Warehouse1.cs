using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Warehouse1
{
    public string WarehouseCode { get; set; } = null!;

    public string WarehouseDescription { get; set; } = null!;

    public string SalesForecastGroup { get; set; } = null!;

    public short? TimezoneHoursDelta { get; set; }

    public bool IsCheckoutInWarehouse { get; set; }

    public bool RequireShippingCostOnFedex { get; set; }

    public bool? IsDefault { get; set; }
}
