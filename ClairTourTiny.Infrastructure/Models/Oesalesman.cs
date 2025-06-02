using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oesalesman
{
    public string Salesmancd { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string InOutFlag { get; set; } = null!;

    public string TaxId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string Telex { get; set; } = null!;

    public string Usenet { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Voicemail { get; set; } = null!;

    public string CommCode { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public decimal Mtdsales { get; set; }

    public decimal Mtdrtrn { get; set; }

    public decimal Mtdother { get; set; }

    public decimal Mtdcosts { get; set; }

    public decimal Ytdsales { get; set; }

    public decimal Ytdrtrn { get; set; }

    public decimal Ytdother { get; set; }

    public decimal Ytdcosts { get; set; }

    public decimal Lastyrsales { get; set; }

    public decimal Lastyrrtrn { get; set; }

    public decimal Lastyrother { get; set; }

    public decimal Lastyrcosts { get; set; }

    public double Commission { get; set; }

    public string HowPaid { get; set; } = null!;

    public string CashOnly { get; set; } = null!;

    public string WhenPaid { get; set; } = null!;
}
