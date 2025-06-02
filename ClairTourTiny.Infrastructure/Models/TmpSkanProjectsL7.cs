using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSkanProjectsL7
{
    public string? Entityno { get; set; }

    public int Ordinal { get; set; }

    public string? Entitydesc { get; set; }

    public DateOnly? PlanStartdate { get; set; }

    public DateOnly? CalcStartdate { get; set; }

    public DateOnly? PlanEnddate { get; set; }

    public DateOnly? CalcEnddate { get; set; }

    public short IsOpen { get; set; }

    public string Engactivecd { get; set; } = null!;

    public string? ProjectStatus { get; set; }

    public string? WorkflowState { get; set; }

    public string ElementType { get; set; } = null!;

    public string Currencycd { get; set; } = null!;

    public string Probability { get; set; } = null!;

    public string Id { get; set; } = null!;

    public string? ParentId { get; set; }
}
