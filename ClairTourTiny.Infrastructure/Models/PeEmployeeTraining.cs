using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeEmployeeTraining
{
    public string Empno { get; set; } = null!;

    public string Topic { get; set; } = null!;

    public DateTime TrainingDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? DateCreated { get; set; }

    public string ModifiedBy { get; set; } = null!;

    public DateTime DateModified { get; set; }

    public DateTime? TrainingDateEnd { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual PeTrainingTopic TopicNavigation { get; set; } = null!;
}
