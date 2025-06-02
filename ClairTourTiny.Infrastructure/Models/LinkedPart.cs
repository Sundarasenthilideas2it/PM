using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class LinkedPart
{
    public string Partno { get; set; } = null!;

    public double Factor { get; set; }

    public string Parentpartno { get; set; } = null!;

    public string ParentuniqueNo { get; set; } = null!;

    public string ParentSerialNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public int? ParentQty { get; set; }

    public double? LinkedQty { get; set; }

    public DateTime Receipt { get; set; }
}
