using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingClassStudent
{
    public string Classname { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public string Empno { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? Termination { get; set; }

    public string? FirstTour { get; set; }

    public string? FinalGrade { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual PeTrainingClass PeTrainingClass { get; set; } = null!;
}
