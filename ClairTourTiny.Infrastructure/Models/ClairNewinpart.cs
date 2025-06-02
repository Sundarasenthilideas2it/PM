using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class ClairNewinpart
{
    public string Partno { get; set; } = null!;

    public string Partentityno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public string Bomind { get; set; } = null!;

    public string Rtgind { get; set; } = null!;

    public string Class { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string DrawInd { get; set; } = null!;

    public string Commmodity { get; set; } = null!;

    public string LeadSource { get; set; } = null!;

    public int Purchaselt { get; set; }

    public int Mfglt { get; set; }

    public int Accumlt { get; set; }

    public DateTime Lastactivity { get; set; }

    public string Planner { get; set; } = null!;

    public string Package { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string LengthUom { get; set; } = null!;

    public string DepthUom { get; set; } = null!;

    public string WidthUom { get; set; } = null!;

    public string Purchaseuom { get; set; } = null!;

    public string Accttype { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string Qcaccttp { get; set; } = null!;

    public string Qcacctno { get; set; } = null!;

    public string Cstaccttp { get; set; } = null!;

    public string Cstacctno { get; set; } = null!;

    public string Chglevel { get; set; } = null!;

    public string Chgno { get; set; } = null!;

    public string? Drawref { get; set; }

    public string Drawsize { get; set; } = null!;

    public string Estpriceflag { get; set; } = null!;

    public double ScrapValue { get; set; }

    public double Unitprice { get; set; }

    public double Onhand { get; set; }

    public double Orderpurch { get; set; }

    public double Ordermfg { get; set; }

    public double Ordersched { get; set; }

    public double Orderreqstn { get; set; }

    public double Ordercust { get; set; }

    public double Inqc { get; set; }

    public double Scrapped { get; set; }

    public double Rejected { get; set; }

    public double Allocated { get; set; }

    public double Reserved { get; set; }

    public double Backorder { get; set; }

    public double Planned { get; set; }

    public double Shortqty { get; set; }

    public string Freeze { get; set; } = null!;

    public string Commodity1 { get; set; } = null!;

    public string Commodity2 { get; set; } = null!;

    public string SecureClass { get; set; } = null!;

    public string FscmCode { get; set; } = null!;

    public string Cyclecd { get; set; } = null!;

    public int Cycleper { get; set; }

    public DateTime Lastcount { get; set; }

    public DateTime Nextcount { get; set; }

    public double Lastcountvar { get; set; }

    public double Countamt { get; set; }

    public double Begperonhand { get; set; }

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

    public double Lyservice { get; set; }

    public DateTime Invactdate { get; set; }

    public int LowLevel { get; set; }

    public string LotTrackCd { get; set; } = null!;

    public string SerialFlag { get; set; } = null!;

    public string DmsRating { get; set; } = null!;

    public string ClassifyCd { get; set; } = null!;

    public string FedStockNo { get; set; } = null!;

    public string MaterialDesc { get; set; } = null!;

    public string MaterialSpecs { get; set; } = null!;

    public string StockSize { get; set; } = null!;

    public double Ordersize { get; set; }

    public double Setupcost { get; set; }

    public double Movequeue { get; set; }

    public double Setuptime { get; set; }

    public double Runtime { get; set; }

    public double Projpercent { get; set; }

    public double Carrying { get; set; }

    public string Orderpolcd { get; set; } = null!;

    public int Maxdays { get; set; }

    public double Safetystk { get; set; }

    public double Orderpoint { get; set; }

    public DateTime Tripdate { get; set; }

    public double Lotsize { get; set; }

    public double Stndorderqty { get; set; }

    public double Minorder { get; set; }

    public double Maxorder { get; set; }

    public double Multorder { get; set; }

    public double Shrinkage { get; set; }

    public int Actcutoff { get; set; }

    public DateTime Mrpdate { get; set; }

    public string Grossprojind { get; set; } = null!;

    public double Grossprojfac { get; set; }

    public string Toolfunction { get; set; } = null!;

    public string Eoqcategory { get; set; } = null!;

    public DateTime Custsubmit { get; set; }

    public DateTime Custapproval { get; set; }

    public string Source { get; set; } = null!;

    public string Supersedes { get; set; } = null!;

    public string Supersededby { get; set; } = null!;

    public string Prodplangrp { get; set; } = null!;

    public double Resistance { get; set; }

    public string Tradename { get; set; } = null!;

    public string Msds { get; set; } = null!;

    public string Profile { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public double Lvlmatcost1 { get; set; }

    public double Totmatcost1 { get; set; }

    public double Lvllabcost1 { get; set; }

    public double Totlabcost1 { get; set; }

    public double Lvloutside1 { get; set; }

    public double Totoutside1 { get; set; }

    public double Lvloh1cost1 { get; set; }

    public double Totoh1cost1 { get; set; }

    public double Lvloh2cost1 { get; set; }

    public double Totoh2cost1 { get; set; }

    public double Lvlacq1 { get; set; }

    public double Totacq1 { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public string Kanbanuom { get; set; } = null!;

    public string Kanbanloc { get; set; } = null!;

    public string Kanbanprevloc { get; set; } = null!;

    public int Kanbanboard { get; set; }

    public string Needkanbancard { get; set; } = null!;

    public string Needcompletionreport { get; set; } = null!;

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

    public double Tot1 { get; set; }

    public double Tot2 { get; set; }

    public double Tot3 { get; set; }

    public double Tot4 { get; set; }

    public double Lvl1 { get; set; }

    public double Lvl2 { get; set; }

    public double Lvl3 { get; set; }

    public double Lvl4 { get; set; }

    public double? PctOfRentalValue { get; set; }

    public bool BindRentalValue { get; set; }

    public string FreezeCosts { get; set; } = null!;
}
