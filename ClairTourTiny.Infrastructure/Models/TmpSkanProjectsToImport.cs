using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanProjectsToImport
{
    public string? Entityno { get; set; }

    public string? Entitydesc { get; set; }

    public DateOnly PlanStartdate { get; set; }

    public DateOnly? PlanEnddate { get; set; }

    public string Agency { get; set; } = null!;

    public string Engactivecd { get; set; } = null!;

    public string Finactivecd { get; set; } = null!;

    public string? Respemno { get; set; }

    public string Entitytype { get; set; } = null!;

    public string Probability { get; set; } = null!;

    public string Proptype { get; set; } = null!;

    public string Plactivecd { get; set; } = null!;

    public string Sfactivecd { get; set; } = null!;

    public string? Opsmgr { get; set; }

    public string Bidmarkup { get; set; } = null!;

    public string BillingCompany { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public DateOnly ExchangeRateDate { get; set; }

    public int Ordinal { get; set; }

    public short IsOpen { get; set; }

    public string? ProjectStatus { get; set; }

    public string? WorkflowState { get; set; }

    public string ElementType { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? ParentId { get; set; }
}
