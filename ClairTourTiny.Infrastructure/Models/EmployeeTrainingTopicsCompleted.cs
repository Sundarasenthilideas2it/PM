using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeTrainingTopicsCompleted
{
    public string Empno { get; set; } = null!;

    public string Jobtype { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public DateTime? TrainingDate { get; set; }

    public DateTime? TrainingDateEnd { get; set; }

    public bool Inactive { get; set; }
}
