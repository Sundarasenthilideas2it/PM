using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpJpjItem
{
    public string? Partno { get; set; }

    public string? SalesDescription { get; set; }

    public string? AdditionalTechnicalSpecificationsNotes { get; set; }

    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? LocationCode { get; set; }

    public string? Package { get; set; }

    public decimal? UnitValue { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Weight { get; set; }

    public string? RackUnits { get; set; }

    public string? RackBays { get; set; }

    public string? Country { get; set; }

    public string? PartImageFilePath { get; set; }

    public double? WeeklyPrice { get; set; }

    public double? DailyPrice { get; set; }
}
