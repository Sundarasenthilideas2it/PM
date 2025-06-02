using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Month
{
    public short Year { get; set; }

    public byte Month1 { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }
}
