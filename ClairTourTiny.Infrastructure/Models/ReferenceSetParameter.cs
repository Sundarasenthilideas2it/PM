using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ReferenceSetParameter
{
    public int MetaDataVersionNumberValidFrom { get; set; }

    public int? MetaDataVersionNumberValidTo { get; set; }

    public int ReferenceSetId { get; set; }

    public int BinWeightId { get; set; }

    public double AvgConstituentTotalCurveMatchScore { get; set; }

    public double StdDevConstituentTotalCurveMatchScore { get; set; }

    public double AvgConstituentMaxBinMatchScore { get; set; }

    public double StdDevConstituentMaxBinMatchScore { get; set; }

    public int DefaultNumStdDevsToPlot { get; set; }

    public double StdDevConstituentAllBinMatchScore { get; set; }

    public double AvgConstituentAllBinMatchScore { get; set; }

    public virtual ICollection<BinWeightValue> BinWeightValues { get; set; } = new List<BinWeightValue>();

    public virtual MetaDataVersion MetaDataVersionNumberValidFromNavigation { get; set; } = null!;

    public virtual MetaDataVersion? MetaDataVersionNumberValidToNavigation { get; set; }

    public virtual ReferenceSet1 ReferenceSet { get; set; } = null!;
}
