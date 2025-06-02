using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCableTestPath
{
    public string Path { get; set; } = null!;

    public int? SequenceNumber { get; set; }

    public long? ConfidenceLevel { get; set; }

    public string? MostLikelyMatch { get; set; }

    public string? AssessmentOfMostLikelyMatch { get; set; }

    public string? Analysis { get; set; }

    public string? HypotheticalDescription { get; set; }

    public string? AdditionalInformationRequested { get; set; }

    public string? GuessedPartno { get; set; }

    public string? Testers { get; set; }

    public string? FolderGuessedPartno { get; set; }

    public string? FolderGuessedPartno2 { get; set; }
}
