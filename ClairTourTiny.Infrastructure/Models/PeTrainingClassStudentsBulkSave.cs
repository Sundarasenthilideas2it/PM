using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingClassStudentsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Classname { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public string Empno { get; set; } = null!;

    public string? Notes { get; set; }

    public DateTime? Termination { get; set; }

    public string? FirstTour { get; set; }

    public string? FinalGrade { get; set; }
}
