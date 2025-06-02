using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Manufacturer
{
    public int IdManufacturer { get; set; }

    public string ManufacturerDesc { get; set; } = null!;

    public string? DefaultCountryOfOrigin { get; set; }

    public Guid FileStorageGuid { get; set; }

    public virtual Country? DefaultCountryOfOriginNavigation { get; set; }

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();

    public virtual ICollection<TmpAngelfishPartsMapping> TmpAngelfishPartsMappings { get; set; } = new List<TmpAngelfishPartsMapping>();

    public virtual ICollection<TmpLdsystemsPartsMapping> TmpLdsystemsPartsMappings { get; set; } = new List<TmpLdsystemsPartsMapping>();
}
