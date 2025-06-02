using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TransferToolsMobileDisplayMode
{
    public string DisplayCode { get; set; } = null!;

    public string DisplayName { get; set; } = null!;

    public string? Description { get; set; }

    public bool _242x322SizeOption { get; set; }

    public bool _480x640SizeOption { get; set; }
}
