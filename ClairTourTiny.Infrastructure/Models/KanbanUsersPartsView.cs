using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class KanbanUsersPartsView
{
    public string Userid { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public bool? Partactive { get; set; }
}
