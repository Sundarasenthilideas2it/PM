using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanDevicePropertiesBulkUpdate
{
    public string? Barcode { get; set; }

    public string? Rev { get; set; }

    public string? FirmwareVersion { get; set; }

    public string? DanteVersion { get; set; }

    public string? ConfigFile { get; set; }

    public string? SoftwareVersion { get; set; }

    public string? PrimaryIp { get; set; }

    public string? SecondaryIp { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }
}
