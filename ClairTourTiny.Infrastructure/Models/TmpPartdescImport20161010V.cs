using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPartdescImport20161010V
{
    public int IdPart { get; set; }

    public string? Category { get; set; }

    public string? Subcategory { get; set; }

    public string Description { get; set; } = null!;

    public int? Qty { get; set; }
}
