using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpCableTestPathsPartsMapping
{
    public string Path { get; set; } = null!;

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public string? MappedPartno { get; set; }

    public string? Notes { get; set; }
}
