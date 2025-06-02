using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OutputPatching
{
    public string OutputPatching1 { get; set; } = null!;

    public virtual ICollection<AudioDeviceOutputPatchingMap> AudioDeviceOutputPatchingMaps { get; set; } = new List<AudioDeviceOutputPatchingMap>();

    public virtual ICollection<Station> StationDescriptions { get; set; } = new List<Station>();
}
