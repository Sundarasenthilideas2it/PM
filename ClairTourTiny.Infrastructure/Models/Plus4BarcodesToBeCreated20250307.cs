using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Plus4BarcodesToBeCreated20250307
{
    public string Partno { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Row { get; set; } = null!;

    public int Onhand { get; set; }

    public string Acctno { get; set; } = null!;

    public string? Ref4 { get; set; }

    public string? Ref5 { get; set; }

    public bool? RemoveNonCoded { get; set; }

    public string? Ponumber { get; set; }

    public bool ShouldLinkChildParts { get; set; }

    public string? ProjectElementId { get; set; }

    public string SerialId { get; set; } = null!;
}
