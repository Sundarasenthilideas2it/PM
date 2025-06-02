using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PatTestResult
{
    public int IdPatTestResult { get; set; }

    public string? Partno { get; set; }

    public string? UniqueNo { get; set; }

    public DateTime TestDate { get; set; }

    public string TestUserid { get; set; } = null!;

    public string TestType { get; set; } = null!;

    public string TestDevice { get; set; } = null!;

    public bool TestResult { get; set; }

    public string? Description { get; set; }

    public string? VisualInspection { get; set; }

    public string? ProtectionClass { get; set; }

    public double? RealPower { get; set; }

    public double? ApparentPower { get; set; }

    public double? GroundWireResistance { get; set; }

    public double? GroundWireResistanceLimit { get; set; }

    public double? GroundWireResidualCurrent { get; set; }

    public double? GroundWireResidualCurrentLimit { get; set; }

    public double? InsulationResistance { get; set; }

    public double? InsulationResistanceLimit { get; set; }

    public double? VoltageInsulationResistance { get; set; }

    public double? VoltageInsulationResistanceLimit { get; set; }

    public double? FrameLeakageCurrent { get; set; }

    public double? FrameLeakageCurrentLimit { get; set; }

    public double? SubLeakage { get; set; }

    public bool? GroundWireResistancePass { get; set; }

    public bool? GroundWireResidualCurrentPass { get; set; }

    public bool? InsulationResistancePass { get; set; }

    public bool? VoltageInsulationResistancePass { get; set; }

    public bool? FrameLeakageCurrentPass { get; set; }

    public bool? SubLeakagePass { get; set; }

    public virtual PatTestDevice TestDeviceNavigation { get; set; } = null!;

    public virtual PatTestType TestTypeNavigation { get; set; } = null!;
}
