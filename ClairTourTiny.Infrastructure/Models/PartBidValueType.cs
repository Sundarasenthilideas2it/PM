using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartBidValueType
{
    public string BidValueType { get; set; } = null!;

    public int BidFactorTimePeriodDays { get; set; }

    public virtual ICollection<PartBidValue> PartBidValues { get; set; } = new List<PartBidValue>();

    public virtual ICollection<Pjproptype> Pjproptypes { get; set; } = new List<Pjproptype>();
}
