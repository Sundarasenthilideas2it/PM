using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ComponentTest
{
    public string Component { get; set; } = null!;

    public string Test { get; set; } = null!;

    public double OutputVoltageVrms { get; set; }

    public virtual Component ComponentNavigation { get; set; } = null!;

    public virtual Test TestNavigation { get; set; } = null!;
}
