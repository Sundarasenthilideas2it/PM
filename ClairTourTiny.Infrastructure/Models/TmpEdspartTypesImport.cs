using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpEdspartTypesImport
{
    public long? Inviid { get; set; }

    public string? Sku { get; set; }

    public short? Type { get; set; }

    public string? Partno { get; set; }

    public string? Partdesc { get; set; }

    public string Commodity { get; set; } = null!;

    public string LeadSource { get; set; } = null!;

    public string Package { get; set; } = null!;

    public int Locationcd { get; set; }

    public double? Length { get; set; }

    public double? Height { get; set; }

    public double? Width { get; set; }

    public string Acctno { get; set; } = null!;

    public string Commodity2 { get; set; } = null!;

    public string? MaterialDesc { get; set; }

    public string? MaterialSpecs { get; set; }

    public double Projpercent { get; set; }

    public string? Madein { get; set; }

    public double Replacementcost { get; set; }

    public string Needkanbancard { get; set; } = null!;

    public string Needcompletionreport { get; set; } = null!;

    public int? Soundchecksequence { get; set; }

    public string? Usercreated { get; set; }

    public DateTime? Createdtime { get; set; }

    public string? Usermodified { get; set; }

    public DateTime ModifiedTime { get; set; }

    public string? Ru { get; set; }

    public int HideOnQuotes { get; set; }

    public int? IdManufacturer { get; set; }

    public string? Model { get; set; }

    public string? SkuFinesse { get; set; }

    public double? Cost { get; set; }

    public string PrimaryCategoryCode { get; set; } = null!;

    public string? SecondaryCategoryCode { get; set; }

    public string? AlternateDesc { get; set; }
}
