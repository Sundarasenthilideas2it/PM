using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Em2EmpReview
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Empno { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Entityno { get; set; }

    public string Rating { get; set; } = null!;

    public string? Notes { get; set; }

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
}
