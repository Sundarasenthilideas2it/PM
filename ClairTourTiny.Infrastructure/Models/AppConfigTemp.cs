using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AppConfigTemp
{
    public string Cmndsel { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Tag { get; set; } = null!;

    public object? Value { get; set; }

    public bool Resolved { get; set; }
}
