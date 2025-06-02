using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetComponentTestMeasurementUserEnteredFailure
{
    public int StackTestId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public int InputNumber { get; set; }

    public string FailureDescription { get; set; } = null!;

    public string? Description { get; set; }

    public virtual CabinetComponentTestMeasurement CabinetComponentTestMeasurement { get; set; } = null!;
}
