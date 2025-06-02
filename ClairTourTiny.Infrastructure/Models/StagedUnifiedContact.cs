using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class StagedUnifiedContact
{
    public int? UnifiedContactId { get; set; }

    public string? Name { get; set; }

    public string? Title { get; set; }

    public string? Department { get; set; }

    public string? Organization { get; set; }

    public string? Location { get; set; }

    public string? Status { get; set; }

    public string? PictureFilePath { get; set; }
}
