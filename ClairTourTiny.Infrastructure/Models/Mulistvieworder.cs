using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Mulistvieworder
{
    public string Formname { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Itemname { get; set; } = null!;

    public int Position { get; set; }
}
