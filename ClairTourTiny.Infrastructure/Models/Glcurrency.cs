using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Glcurrency
{
    public string Currencycd { get; set; } = null!;

    public string Currencydesc { get; set; } = null!;

    public double ConvFactor { get; set; }

    public DateTime Begindate { get; set; }

    public DateTime Enddate { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
