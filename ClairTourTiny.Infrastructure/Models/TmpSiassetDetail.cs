using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSiassetDetail
{
    public string? Asset { get; set; }

    public string? PropertyDescription { get; set; }

    public DateTime? DateInService { get; set; }

    public decimal? BookCost { get; set; }

    public int? ModelId { get; set; }
}
