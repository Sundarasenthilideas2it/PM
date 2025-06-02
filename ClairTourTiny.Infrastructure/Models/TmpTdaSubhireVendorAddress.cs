using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpTdaSubhireVendorAddress
{
    public string? VendorCode { get; set; }

    public int Siteno { get; set; }

    public string? Adddress1 { get; set; }

    public string Add2 { get; set; } = null!;

    public string Add3 { get; set; } = null!;

    public string? City { get; set; }

    public string State { get; set; } = null!;

    public string? Zip { get; set; }

    public string? Isocode { get; set; }

    public string Phone { get; set; } = null!;

    public string? Contact { get; set; }

    public string Ext { get; set; } = null!;

    public string Telex { get; set; } = null!;

    public string Usenet { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Voicemail { get; set; } = null!;

    public int Activeind { get; set; }

    public int IdLanguage { get; set; }

    public string? VatId { get; set; }

    public string VatStatus { get; set; } = null!;

    public string? Abnnumber { get; set; }

    public long? R { get; set; }

    public int IdAddress { get; set; }
}
