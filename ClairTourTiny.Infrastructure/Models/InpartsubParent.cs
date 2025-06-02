using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartsubParent
{
    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public int? ChildCount { get; set; }

    public long? CBig { get; set; }
}
