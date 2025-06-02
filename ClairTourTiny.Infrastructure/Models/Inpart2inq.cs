using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Inpart2inq
{
    public string Partno { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Drawref { get; set; }

    public string Drawsize { get; set; } = null!;

    public string Cstaccttp { get; set; } = null!;

    public string Cstacctno { get; set; } = null!;

    public double Mtdadj { get; set; }

    public double Mtdrec { get; set; }

    public double Mtddemands { get; set; }

    public double Mtdbackorder { get; set; }

    public double Mtdissue { get; set; }

    public double Ytdadj { get; set; }

    public double Ytdrec { get; set; }

    public double Ytddemands { get; set; }

    public double Ytdbackorder { get; set; }

    public double Ytdissues { get; set; }

    public double Lyradj { get; set; }

    public double Lyrrec { get; set; }

    public double Lyrdemands { get; set; }

    public double Lyrbackorder { get; set; }

    public double Lyrissue { get; set; }

    public double Stndorderqty { get; set; }

    public double Minorder { get; set; }

    public double Maxorder { get; set; }

    public double Multorder { get; set; }

    public double Setuptime { get; set; }

    public double Movequeue { get; set; }

    public double Runtime { get; set; }

    public int Maxdays { get; set; }

    public double Projpercent { get; set; }

    public double Lyservice { get; set; }

    public double? Ytdservice { get; set; }

    public double Shrinkage { get; set; }

    public int Actcutoff { get; set; }
}
