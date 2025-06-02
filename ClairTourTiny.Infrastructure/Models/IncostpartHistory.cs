using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class IncostpartHistory
{
    public string Partno { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public double Lvlmatcost2 { get; set; }

    public double Totmatcost2 { get; set; }

    public double Lvllabcost2 { get; set; }

    public double Totlabcost2 { get; set; }

    public double Lvloutside2 { get; set; }

    public double Totoutside2 { get; set; }

    public double Lvloh1cost2 { get; set; }

    public double Totoh1cost2 { get; set; }

    public double Lvloh2cost2 { get; set; }

    public double Totoh2cost2 { get; set; }

    public double Lvlacq2 { get; set; }

    public double Totacq2 { get; set; }

    public double Lvlmatcost3 { get; set; }

    public double Totmatcost3 { get; set; }

    public double Lvllabcost3 { get; set; }

    public double Totlabcost3 { get; set; }

    public double Lvloutside3 { get; set; }

    public double Totoutside3 { get; set; }

    public double Lvloh1cost3 { get; set; }

    public double Totoh1cost3 { get; set; }

    public double Lvloh2cost3 { get; set; }

    public double Totoh2cost3 { get; set; }

    public double Lvlacq3 { get; set; }

    public double Totacq3 { get; set; }

    public double Lvlmatcost4 { get; set; }

    public double Totmatcost4 { get; set; }

    public double Lvllabcost4 { get; set; }

    public double Totlabcost4 { get; set; }

    public double Lvloutside4 { get; set; }

    public double Totoutside4 { get; set; }

    public double Lvloh1cost4 { get; set; }

    public double Totoh1cost4 { get; set; }

    public double Lvloh2cost4 { get; set; }

    public double Totoh2cost4 { get; set; }

    public double Lvlacq4 { get; set; }

    public double Totacq4 { get; set; }

    public DateTime ValidFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? RemovedBy { get; set; }
}
