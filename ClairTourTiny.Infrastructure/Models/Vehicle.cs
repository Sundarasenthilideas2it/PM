using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Vehicle
{
    public int IdVehicle { get; set; }

    public string? VehicleType { get; set; }

    public string? Manufacturer { get; set; }

    public string? NumberSign { get; set; }

    public string? ModelYear { get; set; }

    public string? Comment { get; set; }

    public DateTime? LastInspection { get; set; }

    public int TareWeight { get; set; }

    public int Gvw { get; set; }

    public string? EmissionCode { get; set; }

    public string Caption { get; set; } = null!;

    public string? Jobtype { get; set; }

    public DateTime? NextMaintenance { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? NetVolume { get; set; }

    public decimal? AvgSpeed { get; set; }

    public string? Owner { get; set; }

    public string? Warehouse { get; set; }

    public string? ChassisNumber { get; set; }

    public int? OdometerValue { get; set; }

    public string? TyreSize { get; set; }

    public string Status { get; set; } = null!;

    public virtual EquipmentOwner? OwnerNavigation { get; set; }

    public virtual EmployeeStatus StatusNavigation { get; set; } = null!;

    public virtual Warehouse? WarehouseNavigation { get; set; }
}
