using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllSpeakerMeasurement
{
    public int StackTestId { get; set; }

    public string StationDescription { get; set; } = null!;

    public DateTimeOffset TestStartDate { get; set; }

    public DateTimeOffset TestSaveDate { get; set; }

    public string? TestGuid { get; set; }

    public string? TestDirectory { get; set; }

    public string? XmlFilePath { get; set; }

    public string? Hostname { get; set; }

    public bool IsDeleted { get; set; }

    public string? LoginName { get; set; }

    public Guid? GroupGuid { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int CabinetPosition { get; set; }

    public string Configuration { get; set; } = null!;

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

    public double? TotalCurveMatchScore { get; set; }

    public double? MaxBinMatchScore { get; set; }

    public double? KnownGoodRelativeWholeCurveBadness { get; set; }

    public double? KnownGoodRelativeWorstBinBadness { get; set; }

    public double? BestMatchRelativeWholeCurveBadness { get; set; }

    public double? BestMatchRelativeWorstBinBadness { get; set; }

    public double? KnownGoodRelativeMaxBadness { get; set; }

    public double? BestMatchRelativeMaxBadness { get; set; }

    public double? MaxImpedanceMagnitude { get; set; }

    public int IsPassed { get; set; }

    public int IsDisconnected { get; set; }

    public int IsUncertainResult { get; set; }

    public int IsUnknownFailure { get; set; }

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
}
