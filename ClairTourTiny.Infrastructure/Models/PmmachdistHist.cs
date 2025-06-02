using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class PmmachdistHist
{
    public string Batchno { get; set; } = null!;

    public int Seqno { get; set; }

    public string MachineNo { get; set; } = null!;

    public DateTime Workdate { get; set; }

    public double Hours { get; set; }

    public double Rate { get; set; }

    public double Billrate { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Infoonly { get; set; } = null!;

    public int Acctper { get; set; }

    public int Acctyr { get; set; }

    public DateTime Addtime { get; set; }

    public DateTime Updtime { get; set; }

    public string Pid { get; set; } = null!;

    public int Tidp { get; set; }
}
