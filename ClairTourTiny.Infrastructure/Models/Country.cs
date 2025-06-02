using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Country
{
    public string Countrycode { get; set; } = null!;

    public string Countrydesc { get; set; } = null!;

    public string? Region { get; set; }

    public string? CallingCode { get; set; }

    public bool? SongkickQueryable { get; set; }

    public DateTime? LastSongkickQueryTime { get; set; }

    public int SongkickRowsUpdatedSoFar { get; set; }

    public int SongkickMetroAreas { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual CountryFedExCountryCode? CountryFedExCountryCode { get; set; }

    public virtual ICollection<Inpart> Inparts { get; set; } = new List<Inpart>();

    public virtual ICollection<Manufacturer> Manufacturers { get; set; } = new List<Manufacturer>();

    public virtual ICollection<Oelocation> OelocationCountrycodeNavigations { get; set; } = new List<Oelocation>();

    public virtual ICollection<Oelocation> OelocationShippingCountrycodeNavigations { get; set; } = new List<Oelocation>();

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();

    public virtual ICollection<PollstarStateProvince> PollstarStateProvinces { get; set; } = new List<PollstarStateProvince>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1CollCountryCdNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1DelCountryCdNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual ICollection<PurchaseOrder1> PurchaseOrder1VendcountrycdNavigations { get; set; } = new List<PurchaseOrder1>();

    public virtual Region? RegionNavigation { get; set; }

    public virtual ICollection<TmpAngelfishPartsMapping> TmpAngelfishPartsMappings { get; set; } = new List<TmpAngelfishPartsMapping>();

    public virtual ICollection<TmpLdsystemsPartsMapping> TmpLdsystemsPartsMappings { get; set; } = new List<TmpLdsystemsPartsMapping>();
}
