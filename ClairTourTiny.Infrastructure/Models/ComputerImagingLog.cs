using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ComputerImagingLog
{
    public string ServerName { get; set; } = null!;

    public DateTimeOffset RunDateTime { get; set; }

    public string? Bld { get; set; }

    public string? UniqueNo { get; set; }

    public string? Partno { get; set; }

    public string? HardwareReportedModelNo { get; set; }

    public string? HardwareReportedSerialNo { get; set; }

    public string? HardwareReportedUuid { get; set; }

    public string? ImageName { get; set; }

    public string? PrevEntityno { get; set; }

    public string? Ipaddress { get; set; }

    public double? DriveSizeGiB { get; set; }

    public string? DriveName { get; set; }

    public string? CommitId { get; set; }

    public string? BootVersion { get; set; }

    public bool? NewImage { get; set; }

    public bool? FailureDetected { get; set; }

    public string LogSource { get; set; } = null!;

    public string ImagingScriptName { get; set; } = null!;

    public bool? HasBattery { get; set; }

    public double? BatteryHealth { get; set; }

    public int? TaskDurationInSeconds { get; set; }

    public string? TaskChoice { get; set; }

    public string? WavesOfflineInstaller { get; set; }

    public string? FxComputerType { get; set; }

    public string? ReloadVersion { get; set; }

    public string? ReloadPackageType { get; set; }

    public string? ReloadPackageVersion { get; set; }

    public string? LakeBuild { get; set; }
}
