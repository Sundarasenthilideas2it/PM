using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PartsImportedFromPlus420250307
{
    public string Partno { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public double RentalValueUsd { get; set; }

    public int Locationcd { get; set; }

    public double? LengthUom { get; set; }

    public double? DepthUom { get; set; }

    public double? WidthUom { get; set; }

    public double Projpercent { get; set; }

    public string Package { get; set; } = null!;

    public string LeadSource { get; set; } = null!;

    public string? Source { get; set; }

    public string? Sku { get; set; }

    public string? UserCreated { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? UserModified { get; set; }

    public DateTime? ModifiedTime { get; set; }

    public int? IdManufacturer { get; set; }

    public string Commmodity { get; set; } = null!;

    public string? ModelNo { get; set; }

    public string? ItemId { get; set; }
}
