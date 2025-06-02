using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class WavStat
{
    public string StationDescription { get; set; } = null!;

    public int StackTestId { get; set; }

    public int ResultCurveId { get; set; }

    public string ShortName { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public int CabinetPosition { get; set; }

    public string Configuration { get; set; } = null!;

    public string Test { get; set; } = null!;

    public int InputNumber { get; set; }

    public string WavType { get; set; } = null!;

    public string WavPath { get; set; } = null!;

    public int SamplesRead { get; set; }

    public double LengthSeconds { get; set; }

    public double ScaledBy { get; set; }

    public double MaximumAmplitude { get; set; }

    public double MinimumAmplitude { get; set; }

    public double MidlineAmplitude { get; set; }

    public double MeanNorm { get; set; }

    public double MeanAmplitude { get; set; }

    public double Rmsamplitude { get; set; }

    public double MaximumDelta { get; set; }

    public double MinimumDelta { get; set; }

    public double MeanDelta { get; set; }

    public double Rmsdelta { get; set; }

    public int RoughFrequency { get; set; }

    public double? VolumeAdjustment { get; set; }

    public bool HasSoxstats { get; set; }
}
