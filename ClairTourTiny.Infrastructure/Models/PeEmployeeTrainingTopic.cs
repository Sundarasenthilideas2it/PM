using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeEmployeeTrainingTopic
{
    public string Empno { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public DateTime TrainingDateStart { get; set; }

    public DateTime? TrainingDateEnd { get; set; }

    public string? Instructor { get; set; }

    public string? Classname { get; set; }

    public DateTime? Startdate { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual PeTrainingClass? PeTrainingClass { get; set; }

    public virtual PeTrainingTopic TopicNavigation { get; set; } = null!;
}
