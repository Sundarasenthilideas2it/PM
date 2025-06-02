using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oeshipaddr
{
    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string? ShipToName { get; set; }

    public string Contact { get; set; } = null!;

    public string Attention { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Ext { get; set; } = null!;

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? Addr3 { get; set; }

    public string? City { get; set; }

    public string? County { get; set; }

    public string? State { get; set; }

    public string Zip { get; set; } = null!;

    public string? Country { get; set; }

    public string ShipviaCode { get; set; } = null!;

    public DateTime LastShipped { get; set; }

    public string TaxCode { get; set; } = null!;

    public string Shipcomplete { get; set; } = null!;

    public string Correspondence { get; set; } = null!;

    public string FscmCage { get; set; } = null!;

    public int Invoicecopies { get; set; }

    public int Priority { get; set; }

    public double Tax1 { get; set; }

    public double Tax2 { get; set; }

    public double Tax3 { get; set; }

    public double Tax4 { get; set; }

    public double Tax5 { get; set; }

    public string Custclass { get; set; } = null!;

    public string Matrixcd { get; set; } = null!;

    public double Discount { get; set; }

    public string Telex { get; set; } = null!;

    public string Usenet { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Voicemail { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Currencycd { get; set; } = null!;

    public string Salutation { get; set; } = null!;

    public string Salesmancd { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public string DealNo { get; set; } = null!;

    public string? Email2 { get; set; }
}
