using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oecustbill
{
    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string BillToName { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Attention { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Ext { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string? Addr3 { get; set; }

    public string City { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Country { get; set; } = null!;

    public int Discount { get; set; }

    public decimal Creditlmt { get; set; }

    public decimal Arcurr { get; set; }

    public decimal Arover30 { get; set; }

    public decimal Arover60 { get; set; }

    public decimal Arover90 { get; set; }

    public decimal Arover120 { get; set; }

    public decimal Highbal { get; set; }

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

    public decimal Oeused { get; set; }

    public string Credithold { get; set; } = null!;

    public string DBRating { get; set; } = null!;

    public string CompRating { get; set; } = null!;

    public DateTime? LastDunning { get; set; }

    public int Dunningcnt { get; set; }

    public DateTime? Lastcollection { get; set; }

    public DateTime? Nextcollection { get; set; }

    public string Correspondence { get; set; } = null!;

    public string FscmCage { get; set; } = null!;

    public string Custclass { get; set; } = null!;

    public string Telmktrepcd { get; set; } = null!;

    public string Telmktreploc { get; set; } = null!;

    public int Invoicecopies { get; set; }

    public int Priority { get; set; }

    public string Taxexempt { get; set; } = null!;

    public string TaxexemptNo { get; set; } = null!;

    public string Currencycd { get; set; } = null!;

    public string Telex { get; set; } = null!;

    public string Usenet { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Voicemail { get; set; } = null!;

    public string Lastfeeearnedcd { get; set; } = null!;

    public string DealNo { get; set; } = null!;

    public string Paytermscd { get; set; } = null!;

    public string LastInvoice { get; set; } = null!;

    public string Email2 { get; set; } = null!;

    public string? Notes { get; set; }

    public string Accountno { get; set; } = null!;

    public int Activeind { get; set; }

    public int IdLanguage { get; set; }

    public string? VatidentificationNumber { get; set; }

    public string Vatstatus { get; set; } = null!;

    public string? Abnnumber { get; set; }

    public string InvoiceFolder { get; set; } = null!;
}
