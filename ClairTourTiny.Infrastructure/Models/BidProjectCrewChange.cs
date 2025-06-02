using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class BidProjectCrewChange
{
    public string Entityno { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string Empname { get; set; } = null!;

    public DateTime? OldStartDate { get; set; }

    public DateTime? OldEndDate { get; set; }

    public int? OldEstHours { get; set; }

    public string? OldStatusCode { get; set; }

    public int? OldHoursPerDay { get; set; }

    public string? OldJobType { get; set; }

    public DateTime? NewStartDate { get; set; }

    public DateTime? NewEndDate { get; set; }

    public int? NewEstHours { get; set; }

    public string? NewStatusCode { get; set; }

    public int? NewHoursPerDay { get; set; }

    public string? NewJobType { get; set; }

    public string Userid { get; set; } = null!;

    public string ProjectWarehouse { get; set; } = null!;

    public DateTime ProjectStartdate { get; set; }

    public DateTime ProjectEnddate { get; set; }

    public DateTime? DisplayStartDate { get; set; }

    public DateTime? DisplayEndDate { get; set; }

    public DateTime ChangeDate { get; set; }
}
