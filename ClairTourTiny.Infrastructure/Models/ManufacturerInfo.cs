using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ManufacturerInfo
{
    public string ManufacturerId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public string? AssociationNo { get; set; }

    public string Party { get; set; } = null!;

    public string DefaultDomain { get; set; } = null!;

    public string? DefaultLanguage { get; set; }

    public string? Country { get; set; }

    public string PartyType { get; set; } = null!;

    public double Rowversion { get; set; }

    public string Rowkey { get; set; } = null!;
}
