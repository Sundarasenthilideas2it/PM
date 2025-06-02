using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArCountry
{
    public int IdCountry { get; set; }

    public string? Caption { get; set; }

    public string? Isocode { get; set; }

    public bool? InnerEu { get; set; }

    public string? PhonePrefix { get; set; }

    public int? IdAddressFormat { get; set; }
}
