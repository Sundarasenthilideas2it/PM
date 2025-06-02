using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oearmove
{
    public string Orderno { get; set; } = null!;

    public int Item { get; set; }

    public string Invno { get; set; } = null!;

    public DateTime Invdate { get; set; }

    public string FobCode { get; set; } = null!;

    public string FobPoint { get; set; } = null!;

    public string ShipviaCode { get; set; } = null!;

    public string Container { get; set; } = null!;

    public int Containercnt { get; set; }

    public double ShipWeight { get; set; }

    public double Pickqty { get; set; }

    public double Shipqty { get; set; }

    public double Coqtyshipped { get; set; }

    public DateTime Shipdate { get; set; }

    public int Aritem { get; set; }

    public string Accttype { get; set; } = null!;

    public string Acctno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string Batchno { get; set; } = null!;

    public string Dept { get; set; } = null!;

    public string Bld { get; set; } = null!;

    public string Area { get; set; } = null!;

    public string Bay { get; set; } = null!;

    public string Row { get; set; } = null!;

    public string Tier { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public double Length { get; set; }

    public double Width { get; set; }

    public double Depth { get; set; }

    public double Pieces { get; set; }

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Labelnote { get; set; } = null!;

    public string Freightbill { get; set; } = null!;

    public string Packinglist { get; set; } = null!;

    public DateTime Enterdate { get; set; }

    public decimal Shipcharge { get; set; }

    public string Frghtmatrix { get; set; } = null!;

    public string Invcopy { get; set; } = null!;

    public string Invcopypid { get; set; } = null!;

    public string Upddt { get; set; } = null!;

    public string OrderCode { get; set; } = null!;

    public string Custno { get; set; } = null!;

    public string Subno { get; set; } = null!;

    public string Shipno { get; set; } = null!;

    public string Entityno { get; set; } = null!;

    public string Catalogno { get; set; } = null!;

    public double RevisedQty { get; set; }

    public double AltUprice { get; set; }

    public double AltUcost { get; set; }

    public string AltDesc { get; set; } = null!;

    public string Salesmancd1 { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public string Paytermscd { get; set; } = null!;

    public int DiscDays { get; set; }

    public int NetDays { get; set; }

    public double DiscRate { get; set; }

    public string DiscFxpc { get; set; } = null!;

    public string EomInd { get; set; } = null!;

    public int Invmonth { get; set; }

    public int Invyear { get; set; }

    public DateTime Discdate { get; set; }

    public DateTime Duedate { get; set; }

    public decimal Discamt { get; set; }

    public string Matrixcd { get; set; } = null!;

    public string Custpo { get; set; } = null!;

    public DateTime Custpodate { get; set; }

    public string Taxable { get; set; } = null!;

    public string TaxCode { get; set; } = null!;

    public double Tax1 { get; set; }

    public double Tax2 { get; set; }

    public double Tax3 { get; set; }

    public double Tax4 { get; set; }

    public DateTime Optdate { get; set; }

    public string Dref1 { get; set; } = null!;

    public string Dref2 { get; set; } = null!;

    public string Dref3 { get; set; } = null!;

    public string Dref4 { get; set; } = null!;

    public string Dref5 { get; set; } = null!;

    public string Dref6 { get; set; } = null!;

    public string Dref7 { get; set; } = null!;

    public string Dref8 { get; set; } = null!;

    public string Dref9 { get; set; } = null!;

    public string Dref10 { get; set; } = null!;

    public string Dref11 { get; set; } = null!;

    public string Taxline { get; set; } = null!;

    public DateTime RevdueDate { get; set; }

    public string UnitMeas { get; set; } = null!;

    public decimal Linetotal { get; set; }

    public string Matrixcd1 { get; set; } = null!;

    public string Matrixcd2 { get; set; } = null!;

    public string Matrixcd3 { get; set; } = null!;

    public string Matrixcd4 { get; set; } = null!;

    public string Taxdesc1 { get; set; } = null!;

    public string Taxdesc2 { get; set; } = null!;

    public string Taxdesc3 { get; set; } = null!;

    public string Taxdesc4 { get; set; } = null!;

    public int Tid { get; set; }
}
