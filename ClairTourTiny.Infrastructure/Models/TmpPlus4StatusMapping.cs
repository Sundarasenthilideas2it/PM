using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpPlus4StatusMapping
{
    public Guid StatusId { get; set; }

    public string StatusCode { get; set; } = null!;
}
