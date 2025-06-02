using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpGoldfishPartsWithoutTheirPartNumber
{
    public string? Category { get; set; }

    public string? Manufacturer { get; set; }

    public string? ModelName { get; set; }

    public string? Description { get; set; }

    public string? Partno { get; set; }

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public string? CheckComment { get; set; }

    public string? FakePartNo { get; set; }

    public int? ModelId { get; set; }

    public string? MappedPartno { get; set; }

    public virtual Pjtfrusr? CheckedByNavigation { get; set; }
}
