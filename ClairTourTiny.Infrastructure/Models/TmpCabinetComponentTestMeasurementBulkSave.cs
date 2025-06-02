using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCabinetComponentTestMeasurementBulkSave
{
    public string? TestStartDate { get; set; }

    public string? UniqueNo { get; set; }

    public string? InputNumber { get; set; }

    public string? CabinetPosition { get; set; }

    public string? Configuration { get; set; }

    public string? Test { get; set; }

    public int? FrequencyVectorId { get; set; }

    public int? ResultCurveFakeId { get; set; }

    public bool? IsPassed { get; set; }

    public bool? IsKnownGood { get; set; }

    public bool? IsUnknown { get; set; }

    public bool? IsKnownFailure { get; set; }

    public string? Purpose { get; set; }

    public string? TestGuid { get; set; }

    public string? StackTestDirectory { get; set; }

    public string? XmlFilePath { get; set; }

    public string? VoltageWavFilePath { get; set; }

    public string? CurrentWavFilePath { get; set; }
}
