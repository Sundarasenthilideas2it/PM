using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpSoundImagePartMappingHey
{
    public string? PartId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? Partno { get; set; }

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public string? CheckComment { get; set; }

    public int? IdManufacturer { get; set; }
}
