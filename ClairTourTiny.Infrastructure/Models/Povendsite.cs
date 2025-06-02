using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Povendsite
{
    public string Vendno { get; set; } = null!;

    public string SiteNo { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zipcode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string Telex { get; set; } = null!;

    public string Usenet { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Voicemail { get; set; } = null!;

    public int TransTime { get; set; }

    public DateTime Startshut { get; set; }

    public DateTime Endshut { get; set; }

    public string Currencycd { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public string Commodity1 { get; set; } = null!;

    public string Commodity2 { get; set; } = null!;

    public string? Email2 { get; set; }

    public string? Notes { get; set; }

    public string? County { get; set; }

    public bool Activeind { get; set; }

    public int? IdLanguage { get; set; }

    public string? VatidentificationNumber { get; set; }

    public string? Vatstatus { get; set; }

    public string? Abnnumber { get; set; }

    public virtual XlatLanguage? IdLanguageNavigation { get; set; }

    public virtual Vatstatus? VatstatusNavigation { get; set; }
}
