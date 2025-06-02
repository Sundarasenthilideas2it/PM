using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AvailMultipartGroup
{
    public string Partgroup { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public int Partseq { get; set; }

    public bool Partactive { get; set; }
}
