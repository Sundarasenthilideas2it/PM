using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLegacyLimitConversionFactor
{
    public string? LegacyLimitId { get; set; }

    public string? ReferenceSetId { get; set; }

    public string? Cabinet { get; set; }

    public string? Component { get; set; }

    public string? Configuration { get; set; }

    public string? FrequencyHz { get; set; }

    public string? Zap2rst { get; set; }

    public string? CsvFilePath { get; set; }
}
