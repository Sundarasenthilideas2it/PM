using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetTestMeasurementUserEnteredFailureBulkSave
{
    public int SessionId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string FailureDescription { get; set; } = null!;
}
