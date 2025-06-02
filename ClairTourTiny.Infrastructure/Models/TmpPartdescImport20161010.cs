using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPartdescImport20161010
{
    public int IdCategory { get; set; }

    public int IdSubcategory { get; set; }

    public string Description { get; set; } = null!;

    public int? Qty { get; set; }

    public string? IdPartVarchar { get; set; }

    public string? IdPart { get; set; }
}
