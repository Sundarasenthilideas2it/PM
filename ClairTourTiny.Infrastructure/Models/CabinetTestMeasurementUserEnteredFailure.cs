using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetTestMeasurementUserEnteredFailure
{
    public int StackTestId { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string FailureDescription { get; set; } = null!;

    public string? Description { get; set; }

    public virtual StackTest StackTest { get; set; } = null!;
}
