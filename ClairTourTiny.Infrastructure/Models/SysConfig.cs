using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SysConfig
{
    public string Tag { get; set; } = null!;

    public string? Description { get; set; }

    public object? Value { get; set; }
}
