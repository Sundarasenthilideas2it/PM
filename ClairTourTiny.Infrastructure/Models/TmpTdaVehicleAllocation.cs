using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaVehicleAllocation
{
    public int IdResourceAllocation { get; set; }

    public int IdResourceFunctionAllocation { get; set; }

    public int? IdResourceAllocationState { get; set; }

    public int? Factor { get; set; }

    public string? Custom1 { get; set; }

    public decimal? PirealCosts { get; set; }

    public decimal? Costs { get; set; }

    public int? IdVehicle { get; set; }

    public string? Empno { get; set; }

    public string? Firstname { get; set; }

    public string Lastname { get; set; } = null!;

    public string? Street { get; set; }

    public string City { get; set; } = null!;

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? PhoneCompany { get; set; }

    public string? Email { get; set; }

    public string CountryCode { get; set; } = null!;

    public string? PhoneMobile { get; set; }

    public string? Fax { get; set; }

    public string Locationcde { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string? Gradecd { get; set; }

    public DateOnly? Hiredate { get; set; }

    public string? Notes { get; set; }

    public int IdResourceFunction { get; set; }
}
