using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Station
{
    public string StationDescription { get; set; } = null!;

    public string NetworkSaveDirectory { get; set; } = null!;

    public string DanteVirtualSoundcardLicenseKey { get; set; } = null!;

    public virtual ICollection<StackTest> StackTests { get; set; } = new List<StackTest>();

    public virtual ICollection<StationDevice> StationDevices { get; set; } = new List<StationDevice>();

    public virtual ICollection<Dpro> Macaddresses { get; set; } = new List<Dpro>();

    public virtual ICollection<OutputPatching> OutputPatchings { get; set; } = new List<OutputPatching>();
}
