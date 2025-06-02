using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpLdsystemsPartsMapping
{
    public string Id { get; set; } = null!;

    public string? CheckedBy { get; set; }

    public DateTimeOffset? CheckedDate { get; set; }

    public string? MappedPartno { get; set; }

    public string? NewPartDesc { get; set; }

    public string? NewCommmodity { get; set; }

    public int? NewIdManufacturer { get; set; }

    public double? NewRentalValueUsd { get; set; }

    public string? NewPackage { get; set; }

    public string? NewModelNo { get; set; }

    public string? Notes { get; set; }

    public string? NewCountryCode { get; set; }

    public virtual Incommodity? NewCommmodityNavigation { get; set; }

    public virtual Country? NewCountryCodeNavigation { get; set; }

    public virtual Manufacturer? NewIdManufacturerNavigation { get; set; }
}
