using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Intransinq
{
    public string Trantype { get; set; } = null!;

    public string Partno { get; set; } = null!;

    public double Onhand { get; set; }

    public double Qty { get; set; }

    public DateTime Trandate { get; set; }

    public string Orderno { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string? Ref5 { get; set; }

    public string UniqueNo { get; set; } = null!;

    public string? Batchno { get; set; }

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public DateTime Enterdate { get; set; }

    public string Userid { get; set; } = null!;

    public int HeldInWarehouse { get; set; }

    public int HiwmoveQty { get; set; }

    public string Trandesc { get; set; } = null!;

    public string Partdesc { get; set; } = null!;

    public int Viewtidp { get; set; }

    public int Totcost { get; set; }

    public int Receiveqty { get; set; }

    public int OrderCostPer { get; set; }

    public string Partentityno { get; set; } = null!;

    public string Partrev { get; set; } = null!;

    public string Paccttype { get; set; } = null!;

    public string Pacctno { get; set; } = null!;

    public int Billamt { get; set; }

    public int Partcost { get; set; }

    public int Matcost { get; set; }

    public int Labcost { get; set; }

    public int Oh1cost { get; set; }

    public int Oh2cost { get; set; }

    public int Acqcost { get; set; }

    public int Outsidecost { get; set; }

    public int AvgUcost { get; set; }

    public string Ordercd { get; set; } = null!;

    public int Itemno { get; set; }

    public int ReceiptNo { get; set; }

    public string SerialInd { get; set; } = null!;

    public string Lot { get; set; } = null!;

    public string RejectCode { get; set; } = null!;

    public int Release { get; set; }

    public int Seqno { get; set; }

    public string OperationNo { get; set; } = null!;

    public int OpExtendNo { get; set; }

    public string Locationcd { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Accttype { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string Labaccttype { get; set; } = null!;

    public string Labacctno { get; set; } = null!;

    public string Oh1accttype { get; set; } = null!;

    public string Oh1acctno { get; set; } = null!;

    public string Oh2accttype { get; set; } = null!;

    public string Oh2acctno { get; set; } = null!;

    public string Acqaccttype { get; set; } = null!;

    public string Acqacctno { get; set; } = null!;

    public string Outsideaccttype { get; set; } = null!;

    public string Outsideacctno { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Bay { get; set; } = null!;

    public string Tier { get; set; } = null!;

    public int Length { get; set; }

    public int Width { get; set; }

    public int Depth { get; set; }

    public int Pieces { get; set; }

    public string ShipviaCode { get; set; } = null!;

    public string Inspector { get; set; } = null!;

    public string Glind { get; set; } = null!;

    public string Billind { get; set; } = null!;

    public string Arinvno { get; set; } = null!;

    public string Pid { get; set; } = null!;

    public string Datetime { get; set; } = null!;

    public int Tid { get; set; }

    public int Acctper { get; set; }

    public int Acctyr { get; set; }
}
