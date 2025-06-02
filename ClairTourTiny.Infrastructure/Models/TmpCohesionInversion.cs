using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCohesionInversion
{
    public int? Id { get; set; }

    public int? StackTestId { get; set; }

    public int? ResultCurveId { get; set; }

    public string? Partno { get; set; }

    public string? Configuration { get; set; }

    public string? Test { get; set; }

    public int? FrequencyVectorId { get; set; }

    public int? CabinetPosition { get; set; }

    public string? Cabinet { get; set; }

    public int? InputNumber { get; set; }

    public string? Component { get; set; }

    public string? Description { get; set; }

    public string? VoltageWavFilePath { get; set; }

    public string? CurrentWavFilePath { get; set; }

    public string? PolarityWavFilePath { get; set; }
}
