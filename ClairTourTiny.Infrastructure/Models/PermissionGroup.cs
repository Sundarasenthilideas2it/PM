using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PermissionGroup
{
    public string PermissionName { get; set; } = null!;

    public string? Description { get; set; }

    public string? Parent { get; set; }

    public string? Type { get; set; }
}
