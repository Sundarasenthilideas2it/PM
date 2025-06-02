using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ExchangeRateBook
{
    public string Currency { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public double Ratetodollars { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime DateModified { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;
}
