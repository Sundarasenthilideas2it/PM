using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StackTest
{
    public int StackTestId { get; set; }

    public string StationDescription { get; set; } = null!;

    public DateTimeOffset TestStartDate { get; set; }

    public DateTimeOffset TestSaveDate { get; set; }

    public string? TestGuid { get; set; }

    public string? TestDirectory { get; set; }

    public string? XmlFilePath { get; set; }

    public string? Hostname { get; set; }

    public bool IsDeleted { get; set; }

    public string? LoginName { get; set; }

    public Guid? GroupGuid { get; set; }

    public virtual ICollection<CabinetTestMeasurementUserEnteredFailure> CabinetTestMeasurementUserEnteredFailures { get; set; } = new List<CabinetTestMeasurementUserEnteredFailure>();

    public virtual ICollection<StackTestDevice> StackTestDevices { get; set; } = new List<StackTestDevice>();

    public virtual Station StationDescriptionNavigation { get; set; } = null!;
}
