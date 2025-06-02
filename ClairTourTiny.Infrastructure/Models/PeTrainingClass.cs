using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingClass
{
    public string Classname { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Note { get; set; }

    public string? Instructor { get; set; }

    public virtual ICollection<PeEmployeeTrainingTopic> PeEmployeeTrainingTopics { get; set; } = new List<PeEmployeeTrainingTopic>();

    public virtual ICollection<PeTrainingClassStudent> PeTrainingClassStudents { get; set; } = new List<PeTrainingClassStudent>();

    public virtual ICollection<PeTrainingClassTopic> PeTrainingClassTopics { get; set; } = new List<PeTrainingClassTopic>();
}
