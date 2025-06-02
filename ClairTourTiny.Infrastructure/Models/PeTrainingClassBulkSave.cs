using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingClassBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Classname { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Note { get; set; }

    public string? Instructor { get; set; }
}
