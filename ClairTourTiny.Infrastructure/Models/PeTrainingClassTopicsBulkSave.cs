using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingClassTopicsBulkSave
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Classname { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public string Topic { get; set; } = null!;

    public DateTime? TopicStartDate { get; set; }

    public DateTime? TopicEndDate { get; set; }

    public string? Notes { get; set; }

    public bool TopicCovered { get; set; }
}
