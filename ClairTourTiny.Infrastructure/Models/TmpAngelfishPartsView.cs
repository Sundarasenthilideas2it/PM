using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpAngelfishPartsView
{
    public string ItemId { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public double? PurchasePrice { get; set; }

    public int Inventory { get; set; }

    public string? ClaudeDescription { get; set; }

    public string? GuessedPartno { get; set; }

    public string? GuessedPartno2 { get; set; }

    public byte? GuessedPartConfidence { get; set; }

    public byte? GuessedPart2Confidence { get; set; }

    public string? MatchAssessment { get; set; }

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public string? MappedPartno { get; set; }

    public string? NewPartDesc { get; set; }

    public string? NewCommmodity { get; set; }

    public int? NewIdManufacturer { get; set; }

    public double? NewRentalValueUsd { get; set; }

    public string? NewPackage { get; set; }

    public string? NewModelNo { get; set; }

    public string? Notes { get; set; }

    public string? NewCountryCode { get; set; }
}
