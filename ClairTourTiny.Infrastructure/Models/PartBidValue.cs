using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartBidValue
{
    public string Partno { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public double Bidvalue { get; set; }

    public string Valuetype { get; set; } = null!;

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual Currency CurrencyNavigation { get; set; } = null!;

    public virtual Inpart PartnoNavigation { get; set; } = null!;

    public virtual Pjtfrusr? UpdatedByNavigation { get; set; }

    public virtual PartBidValueType ValuetypeNavigation { get; set; } = null!;
}
