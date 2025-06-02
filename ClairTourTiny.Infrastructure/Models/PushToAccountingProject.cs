using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PushToAccountingProject
{
    public string Company { get; set; } = null!;

    public string ProjectId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateOnly ValidFrom { get; set; }

    public DateOnly ValidUntil { get; set; }

    public DateTimeOffset? DateCreated { get; set; }

    public DateTimeOffset? DatePushed { get; set; }

    public string? ProjectLeader { get; set; }
}
