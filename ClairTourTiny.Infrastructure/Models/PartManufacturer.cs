using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartManufacturer
{
    public string PartNo { get; set; } = null!;

    public string ManufacturerNo { get; set; } = null!;

    public string? Note { get; set; }

    public string UserCreated { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateChanged { get; set; }

    public string UserChanged { get; set; } = null!;

    public string PreferredManufacturer { get; set; } = null!;

    public string QualifiedManufacturer { get; set; } = null!;

    public DateTime Rowversion { get; set; }

    public string Rowkey { get; set; } = null!;
}
