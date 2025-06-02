using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSipartValueUpdate
{
    public string? PartNo { get; set; }

    public string? Partdesc { get; set; }

    public string? Commmodity { get; set; }

    public string? RentalValueUsd { get; set; }

    public string? TotalPartValueAdded { get; set; }

    public string? MergeRemainderCanidate { get; set; }

    public string? FinessePtNo { get; set; }

    public string? FinessePtDesc { get; set; }

    public string? FinesseParentValue { get; set; }

    public string? NewProposedSiparentValue { get; set; }

    public string? SourceOfNewProposedSiValue { get; set; }
}
