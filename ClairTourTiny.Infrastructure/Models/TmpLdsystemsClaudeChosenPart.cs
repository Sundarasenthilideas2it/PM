using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLdsystemsClaudeChosenPart
{
    public string Id { get; set; } = null!;

    public string? Partno { get; set; }

    public byte Confidence { get; set; }

    public string SimilaritiesAndDifferences { get; set; } = null!;

    public string MatchAssessment { get; set; } = null!;

    public string AdditionalInformationWanted { get; set; } = null!;

    public virtual Inpart? PartnoNavigation { get; set; }
}
