using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class RackConfiguratorPhaseDetail
{
    public string Entityno { get; set; } = null!;

    public string? MixingconsolePartno { get; set; }

    public string? RackNotes { get; set; }

    public string? PhaseNotes1 { get; set; }

    public string? PhaseNotes2 { get; set; }

    public string? PhaseNotes3 { get; set; }

    public string? PhaseNotes4 { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
