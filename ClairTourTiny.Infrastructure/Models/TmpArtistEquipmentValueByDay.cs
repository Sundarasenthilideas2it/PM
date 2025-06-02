using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArtistEquipmentValueByDay
{
    public int? PollstarArtistId { get; set; }

    public DateTime? Dt { get; set; }

    public double? Value { get; set; }
}
