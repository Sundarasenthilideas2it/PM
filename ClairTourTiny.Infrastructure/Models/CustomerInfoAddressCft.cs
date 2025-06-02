using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class CustomerInfoAddressCft
{
    public string Rowkey { get; set; } = null!;

    public string? CfNotes { get; set; }
}
