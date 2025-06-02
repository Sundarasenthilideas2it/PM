using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetComponentTestMeasurementUserEnteredFailureBulkSave
{
    public int SessionId { get; set; }

    public int CurveFakeId { get; set; }

    public string FailureDescription { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public int InputNumber { get; set; }
}
