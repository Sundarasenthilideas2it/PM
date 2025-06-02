using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeTrainingTreeStructureCategory
{
    public string NodeDescription { get; set; } = null!;

    public string? ParentNodeDescription { get; set; }

    public virtual ICollection<PeTrainingTopic> PeTrainingTopics { get; set; } = new List<PeTrainingTopic>();
}
