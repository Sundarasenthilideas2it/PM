using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetComponentTestMeasurementBulkSave
{
    public int SessionId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public int InputNumber { get; set; }

    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int CabinetPosition { get; set; }

    public string Configuration { get; set; } = null!;

    public string Test { get; set; } = null!;

    public int FrequencyVectorId { get; set; }

    public int ResultCurveFakeId { get; set; }

    public int? BestMatchCurveId { get; set; }

    public string? VoltageWavFilePath { get; set; }

    public string? CurrentWavFilePath { get; set; }

    public bool IsKnownGood { get; set; }

    public bool IsUnknown { get; set; }

    public bool IsKnownFailure { get; set; }

    public string Purpose { get; set; } = null!;

    public string? UserCabinetNote { get; set; }

    public string? UserComponentNote { get; set; }

    public double? KnownGoodTotalCurveMatchScore { get; set; }

    public double? KnownGoodMaxBinMatchScore { get; set; }

    public double? KnownGoodWholeCurveBadness { get; set; }

    public double? KnownGoodWorstBinBadness { get; set; }

    public double? BestMatchWholeCurveBadness { get; set; }

    public double? BestMatchWorstBinBadness { get; set; }

    public double? MaxImpedanceMagnitude { get; set; }

    public string? PolarityWavFilePath { get; set; }

    public int? PolarityAbsoluteExtremumIndex { get; set; }

    public double? PolarityAbsoluteExtremumValue { get; set; }

    public int? PolarityRelativeOpposingExtremumIndex { get; set; }

    public double? PolarityRelativeOpposingExtremumValue { get; set; }

    public double? PolarityRmsvalue { get; set; }

    public double? VoltageXcorrAbsoluteExtremum { get; set; }

    public double? VoltageNdiffFractionOfIdeal { get; set; }

    public int? RecordingAttemptNumber { get; set; }

    public int? DroppedPacketCount { get; set; }

    public long? BufferUnderrunTickValue { get; set; }

    public int? BufferUnderrunTickIndex { get; set; }

    public long? BufferOverrunTickValue { get; set; }

    public int? BufferOverrunTickIndex { get; set; }

    public int? PolarityXcorrLeadingSpikeIndex { get; set; }

    public double? PolarityXcorrLeadingSpikeValue { get; set; }
}
