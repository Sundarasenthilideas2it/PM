using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpWexlerVideoAssetListValuation
{
    public int? ItemNo { get; set; }

    public int? Cat { get; set; }

    public int? Qty { get; set; }

    public string? EquipNo { get; set; }

    public string? Make { get; set; }

    public string? Description { get; set; }

    public double? OrderlyLiquidationValue { get; set; }

    public double? FairMarketValueE { get; set; }

    public double? UnitOlv { get; set; }

    public double? UnitFmv { get; set; }
}
