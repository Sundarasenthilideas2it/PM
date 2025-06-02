using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaPartsList
{
    public string Partno { get; set; } = null!;

    public string Parentpartno { get; set; } = null!;

    public decimal Factor { get; set; }

    public int IdReferenctype { get; set; }
}
