using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpAngelfishClaudeChosenPart
{
    public string ItemId { get; set; } = null!;

    public string? GuessedPartno { get; set; }

    public string? GuessedPartno2 { get; set; }

    public byte GuessedPartConfidence { get; set; }

    public byte? GuessedPart2Confidence { get; set; }

    public string MatchAssessment { get; set; } = null!;

    public virtual Inpart? GuessedPartno2Navigation { get; set; }

    public virtual Inpart? GuessedPartnoNavigation { get; set; }
}
