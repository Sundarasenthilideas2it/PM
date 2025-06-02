using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BrpDataImportPartTypeMatch
{
    public int? Type { get; set; }

    public string? Description { get; set; }

    public string? FPartNo { get; set; }

    public string? FDesription { get; set; }

    public string? Category { get; set; }

    public string? FCategory { get; set; }

    public double? Length { get; set; }

    public double? FLength { get; set; }

    public double? Height { get; set; }

    public double? FHeight { get; set; }

    public double? Width { get; set; }

    public double? FWidth { get; set; }

    public double? Weight { get; set; }

    public double? FWeight { get; set; }

    public string? Country { get; set; }

    public string? FCountry { get; set; }

    public double? Cost { get; set; }

    public double? FValue { get; set; }

    public double? UsdvalueBrp { get; set; }

    public double? UsdvalueClair { get; set; }

    public string? GbpvalueBrp { get; set; }

    public double? GbpvalueClair { get; set; }
}
