using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AppConfig
{
    public string Cmndsel { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public object? Value { get; set; }
}
