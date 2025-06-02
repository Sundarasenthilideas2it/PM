using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetComponentTestMeasurement
{
    public int StackTestId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public int InputNumber { get; set; }

    public string Test { get; set; } = null!;

    public int FrequencyVectorId { get; set; }

    public int ResultCurveId { get; set; }

    public int? BestMatchCurveId { get; set; }

    public DateTimeOffset? DateCorrected { get; set; }

    public string? VoltageWavFilePath { get; set; }

    public string? CurrentWavFilePath { get; set; }

    public bool IsUnknown { get; set; }

    public bool IsKnownGood { get; set; }

    public string Purpose { get; set; } = null!;

    public bool IsKnownFailure { get; set; }

    public string? UserCabinetNote { get; set; }

    public string? UserComponentNote { get; set; }

    public double? KnownGoodTotalCurveMatchScore { get; set; }

    public double? KnownGoodMaxBinMatchScore { get; set; }

    public double? KnownGoodWholeCurveBadness { get; set; }

    public double? KnownGoodWorstBinBadness { get; set; }

    public double? BestMatchWholeCurveBadness { get; set; }

    public double? BestMatchWorstBinBadness { get; set; }

    public double? MaxImpedanceMagnitude { get; set; }

    public int IsDisconnected { get; set; }

    public string? PolarityWavFilePath { get; set; }

    public int? PolarityAbsoluteExtremumIndex { get; set; }

    public double? PolarityAbsoluteExtremumValue { get; set; }

    public int? PolarityRelativeOpposingExtremumIndex { get; set; }

    public double? PolarityRelativeOpposingExtremumValue { get; set; }

    public double? PolarityRmsvalue { get; set; }

    public double? PolarityRelativeOpposingExtremaToAbsoluteExtremaRatio { get; set; }

    public double? PolarityAbsoluteExtremaToRmsvalueRatio { get; set; }

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

    public double? PolaritySign { get; set; }

    public double? KnownGoodMaxBadness { get; set; }

    public double? BestMatchMaxBadness { get; set; }

    public int IsPassed { get; set; }

    public int IsUncertainResult { get; set; }

    public int IsUnknownFailure { get; set; }

    public virtual CabinetComponentTestMeasurementUserEnteredFailure? CabinetComponentTestMeasurementUserEnteredFailure { get; set; }

    public virtual FrequencyVector FrequencyVector { get; set; } = null!;

    public virtual MeasurementPurpose PurposeNavigation { get; set; } = null!;

    public virtual ComplexCurve ResultCurve { get; set; } = null!;

    public virtual StackTestDevice StackTestDevice { get; set; } = null!;

    public virtual Test TestNavigation { get; set; } = null!;
}
