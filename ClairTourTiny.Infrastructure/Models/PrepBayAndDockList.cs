using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PrepBayAndDockList
{
    public int Id { get; set; }

    public string? Warehouse { get; set; }

    public string? Location { get; set; }

    public int? Sortorder { get; set; }
}
