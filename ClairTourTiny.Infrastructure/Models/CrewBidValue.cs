using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CrewBidValue
{
    public string Jobtype { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public double BidRate { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual Pejob JobtypeNavigation { get; set; } = null!;
}
