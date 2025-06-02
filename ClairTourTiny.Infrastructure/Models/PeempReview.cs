using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PeempReview
{
    public string Empno { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Entityno { get; set; }

    public string Rating { get; set; } = null!;

    public string? Notes { get; set; }

    public string UserCreated { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public string UserModified { get; set; } = null!;

    public DateTime ModifiedTime { get; set; }

    public string? TechnicalSkillsRating { get; set; }

    public string? TechnicalSkillsNotes { get; set; }

    public string? AttitudeRating { get; set; }

    public string? AttitudeNotes { get; set; }

    public string? ResponsibilityRating { get; set; }

    public string? ResponsibilityNotes { get; set; }

    public string? CommunicationSkillsRating { get; set; }

    public string? CommunicationSkillsNotes { get; set; }

    public string? SafetyConscientiousnessRating { get; set; }

    public string? SafetyConscientiousnessNotes { get; set; }

    public virtual Peemployee EmpnoNavigation { get; set; } = null!;

    public virtual Glentity? EntitynoNavigation { get; set; }

    public virtual Pjtfrusr UserCreatedNavigation { get; set; } = null!;

    public virtual Pjtfrusr UserModifiedNavigation { get; set; } = null!;
}
