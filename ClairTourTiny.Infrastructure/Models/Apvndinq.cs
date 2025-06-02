using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Apvndinq
{
    public string Vendno { get; set; } = null!;

    public string VendorAbbr { get; set; } = null!;

    public string VendorName { get; set; } = null!;

    public string PublicInd { get; set; } = null!;

    public string CorporationInd { get; set; } = null!;

    public string Ap1099Ind { get; set; } = null!;

    public decimal LastYrSale { get; set; }

    public decimal PrevYrSale { get; set; }

    public string PrimUnion { get; set; } = null!;

    public string SecondUnion { get; set; } = null!;

    public DateTime Unioncontend { get; set; }

    public DateTime EeocCertify { get; set; }

    public string Parent { get; set; } = null!;

    public string DBRating { get; set; } = null!;

    public string CompRating { get; set; } = null!;

    public decimal CurYrPo { get; set; }

    public decimal LastYrPo { get; set; }

    public string EeocType { get; set; } = null!;

    public string BusinessCd { get; set; } = null!;

    public string LaborSurplus { get; set; } = null!;

    public DateTime CompCertify { get; set; }

    public DateTime InsrCertify { get; set; }

    public string Caseregister { get; set; } = null!;

    public string QcApproval { get; set; } = null!;

    public string Commodity1 { get; set; } = null!;

    public string Commodity2 { get; set; } = null!;

    public string Paytermscd { get; set; } = null!;

    public string BuyerCode { get; set; } = null!;

    public int Employeecnt { get; set; }

    public string YearFormed { get; set; } = null!;

    public int VendReprom { get; set; }

    public string ApproveStat { get; set; } = null!;

    public DateTime LastSurvey { get; set; }

    public decimal YtdAp { get; set; }

    public decimal MtdAp { get; set; }

    public decimal YtdDisc { get; set; }

    public decimal MtdDisc { get; set; }

    public decimal LastYrAp { get; set; }

    public decimal LastYrDisc { get; set; }

    public string Bank { get; set; } = null!;

    public string? Employeeind { get; set; }

    public string Taxid { get; set; } = null!;

    public string Activeind { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public DateTime Lastactivity { get; set; }

    public string VendCustno { get; set; } = null!;

    public string Problemcd { get; set; } = null!;

    public string AchYn { get; set; } = null!;

    public string Bankid { get; set; } = null!;

    public string Bankname { get; set; } = null!;

    public string Acctid { get; set; } = null!;

    public string ChkSavCd { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public decimal? Ytdnet { get; set; }

    public decimal? Mtdnet { get; set; }

    public decimal? Lastyrnet { get; set; }
}
