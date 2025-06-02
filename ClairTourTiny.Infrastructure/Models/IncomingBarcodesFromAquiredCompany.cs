using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IncomingBarcodesFromAquiredCompany
{
    public Guid BarcodeId { get; set; }

    public string SourceCompany { get; set; } = null!;

    public string SourceSystem { get; set; } = null!;

    public string SourceSystemBarcode { get; set; } = null!;

    public string? SourceSystemPartIdentifier { get; set; }

    public string? SourceSystemPartDescription { get; set; }

    public DateTime DateTimeAddedUtc { get; set; }
}
