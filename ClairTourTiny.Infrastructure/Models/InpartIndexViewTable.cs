using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class InpartIndexViewTable
{
    public string Partno { get; set; } = null!;

    public double RentalValueUsd { get; set; }

    public string Partdesc { get; set; } = null!;

    public string Commmodity { get; set; } = null!;

    public int Locationcd { get; set; }
}
