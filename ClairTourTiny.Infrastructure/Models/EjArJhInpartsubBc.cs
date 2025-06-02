using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EjArJhInpartsubBc
{
    public string? Partno { get; set; }

    public int Onhand { get; set; }

    public DateTime? Receipt { get; set; }

    public string Batchno { get; set; } = null!;

    public int Groupno { get; set; }

    public string? UniqueNo { get; set; }

    public string? SerialNo { get; set; }

    public string? Dept { get; set; }

    public string? Bld { get; set; }
}
