using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllPolarityMetrics20220901
{
    public string? StationDescription { get; set; }

    public string? StackTestId { get; set; }

    public int? ResultCurveId { get; set; }

    public string? PolarityWavFilePath { get; set; }

    public string? Cabinet { get; set; }

    public string? CabinetPosition { get; set; }

    public string? Configuration { get; set; }

    public string? Component { get; set; }

    public string? InputNumber { get; set; }

    public string? PolaritySign { get; set; }

    public string? ExpectedPolaritySign { get; set; }

    public int? PolarityXcorrTrailingSpikeIndex { get; set; }

    public float? PolarityXcorrTrailingSpikeValue { get; set; }
}
