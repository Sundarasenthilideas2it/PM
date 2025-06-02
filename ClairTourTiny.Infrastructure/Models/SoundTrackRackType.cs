using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SoundTrackRackType
{
    public string? IRackTypeId { get; set; }

    public string? SRackType { get; set; }

    public string? SDescription { get; set; }

    public string? HasAttachedContentsInSt { get; set; }

    public string? ShouldHaveFinesseAttachments { get; set; }
}
