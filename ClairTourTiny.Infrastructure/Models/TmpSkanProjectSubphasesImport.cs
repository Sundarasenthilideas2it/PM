using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanProjectSubphasesImport
{
    public string? Subphase { get; set; }

    public string? Subphasedesc { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Agency { get; set; } = null!;

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public string? Respempno { get; set; }

    public string Entitytype { get; set; } = null!;

    public int Probability { get; set; }

    public string? Proptype { get; set; }

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public double? Bidmarkup { get; set; }

    public string? BillingCompany { get; set; }

    public string? Currency { get; set; }

    public DateTime? ExchangeRateDate { get; set; }

    public DateTime? LoadOut { get; set; }

    public DateTime? CrewPrep { get; set; }

    public DateTime? FirstShow { get; set; }

    public DateTime? LastShow { get; set; }

    public string? SecondaryOpsEmpno { get; set; }
}
