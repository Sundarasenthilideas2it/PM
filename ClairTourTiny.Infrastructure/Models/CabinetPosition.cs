using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetPosition
{
    public int CabinetPosition1 { get; set; }

    public virtual ICollection<AudioDeviceOutputPatchingMap> AudioDeviceOutputPatchingMaps { get; set; } = new List<AudioDeviceOutputPatchingMap>();
}
