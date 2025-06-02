using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CabinetInput
{
    public int CabinetInputNumber { get; set; }

    public virtual ICollection<AudioDeviceOutputPatchingMap> AudioDeviceOutputPatchingMaps { get; set; } = new List<AudioDeviceOutputPatchingMap>();
}
