using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ExchangeRateDaily
{
    public string Currency { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public double Ratetodollars { get; set; }

    public DateTime DateModified { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;
}
