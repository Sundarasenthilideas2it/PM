using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class FrequencyVectorValueBulkSave
{
    public int FrequencyVectorId { get; set; }

    public int BinIndex { get; set; }

    public double FrequencyHz { get; set; }
}
