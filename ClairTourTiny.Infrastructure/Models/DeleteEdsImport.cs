using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class DeleteEdsImport
{
    public string? PartNo { get; set; }

    public string? PartDescription { get; set; }

    public string? Barcode { get; set; }

    public string? SerialNo { get; set; }

    public string? Owner { get; set; }

    public string? Warehouse { get; set; }

    public string? Username { get; set; }

    public string? Reason { get; set; }

    public string? Po { get; set; }
}
