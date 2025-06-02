using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingClassTopic
{
    public string Classname { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public string Topic { get; set; } = null!;

    public DateTime? TopicStartDate { get; set; }

    public DateTime? TopicEndDate { get; set; }

    public string? Notes { get; set; }

    public bool TopicCovered { get; set; }

    public virtual PeTrainingClass PeTrainingClass { get; set; } = null!;

    public virtual PeTrainingTopic TopicNavigation { get; set; } = null!;
}
