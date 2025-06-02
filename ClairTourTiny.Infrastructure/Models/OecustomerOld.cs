using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OecustomerOld
{
    public string Custno { get; set; } = null!;

    public string? Name { get; set; }

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

    public DateTime Lastactivity { get; set; }

    public string Activeind { get; set; } = null!;

    public string FscmCage { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public string Misc { get; set; } = null!;

    public string ReferredBy { get; set; } = null!;

    public string NextObjective { get; set; } = null!;

    public string IndustryType { get; set; } = null!;

    public int Probability { get; set; }

    public decimal LastYrSale { get; set; }

    public decimal PrevYrSale { get; set; }

    public string CompanySize { get; set; } = null!;

    public string Reminder { get; set; } = null!;

    public string Rptform { get; set; } = null!;

    public DateTime LastContact { get; set; }

    public DateTime NextContact { get; set; }

    public string Custclass { get; set; } = null!;

    public decimal Oeused { get; set; }

    public string Credithold { get; set; } = null!;

    public string DBRating { get; set; } = null!;

    public string CompRating { get; set; } = null!;

    public DateTime LastDunning { get; set; }

    public int Dunningcnt { get; set; }

    public DateTime Enterdate { get; set; }

    public string BoAllow { get; set; } = null!;

    public string Matrixcd { get; set; } = null!;

    public bool HideFromReceivablesReport { get; set; }

    public Guid? FileStorageGuid { get; set; }

    public string? CustName { get; set; }
}
