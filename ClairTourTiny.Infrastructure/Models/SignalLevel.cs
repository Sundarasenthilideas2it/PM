using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SignalLevel
{
    public string SignalLevel1 { get; set; } = null!;

    public virtual ICollection<AudioDeviceOutputChannel> AudioDeviceOutputChannels { get; set; } = new List<AudioDeviceOutputChannel>();

    public virtual ICollection<CabinetComponent> CabinetComponents { get; set; } = new List<CabinetComponent>();

    public virtual ICollection<Cabinet> Cabinets { get; set; } = new List<Cabinet>();
}
