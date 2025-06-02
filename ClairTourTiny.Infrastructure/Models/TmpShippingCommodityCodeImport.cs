using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpShippingCommodityCodeImport
{
    public string? CommodityCode { get; set; }

    public string? CountryOfMfg { get; set; }

    public string? Description { get; set; }

    public string? PartNum { get; set; }

    public string? MarkNum { get; set; }

    public string? HmnzdCode { get; set; }

    public string? UnitOfMeasure { get; set; }

    public string? CurrencyCode { get; set; }

    public string? UnitValue { get; set; }

    public string? SkuItemUpc { get; set; }
}
