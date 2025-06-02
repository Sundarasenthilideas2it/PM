using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeEmployeeTrainingTopicsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Empno { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public DateTime TrainingDateStart { get; set; }

    public DateTime? TrainingDateEnd { get; set; }

    public string? Instructor { get; set; }

    public string? Classname { get; set; }

    public DateTime? Startdate { get; set; }
}
