using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpAedpartPricingImport
{
    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string? Bidvalue { get; set; }

    public string? BidValueType { get; set; }

    public string? Currency { get; set; }

    public string? NewbidvalueAed { get; set; }

    public string? NewbidvalueAedrounded { get; set; }

    public string? NewbidvalueSar { get; set; }

    public string? NewbidvalueSarrounded { get; set; }
}
