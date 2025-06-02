using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ProjectProductionSchedule
{
    public string Entityno { get; set; } = null!;

    public string EventType { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? VenueId { get; set; }

    public string? DestinationDetail { get; set; }

    public string? Note { get; set; }

    public DateOnly? StartDateDate { get; set; }

    public string? BackgroundImageFile { get; set; }

    public virtual Glentity EntitynoNavigation { get; set; } = null!;

    public virtual ProductionScheduleEventType EventTypeNavigation { get; set; } = null!;

    public virtual PollstarVenue? Venue { get; set; }
}
