using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingTopicsDevice
{
    public string Topic { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public virtual PeTrainingTopic TopicNavigation { get; set; } = null!;
}
