using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeTrainingTopic
{
    public string Topic { get; set; } = null!;

    public string? Jobtype { get; set; }

    public string? Note { get; set; }

    public bool Inactive { get; set; }

    public Guid? FileStorageGuid { get; set; }

    public string? ParentNodeDescription { get; set; }

    public virtual Pejob? JobtypeNavigation { get; set; }

    public virtual EmployeeTrainingTreeStructureCategory? ParentNodeDescriptionNavigation { get; set; }

    public virtual ICollection<PeEmployeeTrainingTopic> PeEmployeeTrainingTopics { get; set; } = new List<PeEmployeeTrainingTopic>();

    public virtual ICollection<PeEmployeeTraining> PeEmployeeTrainings { get; set; } = new List<PeEmployeeTraining>();

    public virtual ICollection<PeTrainingClassTopic> PeTrainingClassTopics { get; set; } = new List<PeTrainingClassTopic>();

    public virtual ICollection<PeTrainingTopicsDevice> PeTrainingTopicsDevices { get; set; } = new List<PeTrainingTopicsDevice>();

    public virtual ICollection<TrainingTopicsUser> TrainingTopicsUsers { get; set; } = new List<TrainingTopicsUser>();
}
