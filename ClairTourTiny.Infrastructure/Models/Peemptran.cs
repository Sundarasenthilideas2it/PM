using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peemptran
{
    public string Transcd { get; set; } = null!;

    public DateTime Transdate { get; set; }

    public string Ssn { get; set; } = null!;

    public string Empno { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Midname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public DateTime Hiredate { get; set; }

    public string Filestat { get; set; } = null!;

    public int Exemptions { get; set; }

    public string Autodeposit { get; set; } = null!;

    public string Bankid { get; set; } = null!;

    public string Acctid { get; set; } = null!;

    public string Locationcd { get; set; } = null!;

    public string Groupno { get; set; } = null!;

    public string Gradecd { get; set; } = null!;

    public string Empstatus { get; set; } = null!;

    public double Billgoal { get; set; }

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Eref1 { get; set; } = null!;

    public string Eref2 { get; set; } = null!;

    public string Eref3 { get; set; } = null!;

    public string Eref4 { get; set; } = null!;

    public string Eref5 { get; set; } = null!;

    public string Shiftno { get; set; } = null!;

    public string Sunoff { get; set; } = null!;

    public string Monoff { get; set; } = null!;

    public string Tueoff { get; set; } = null!;

    public string Wedoff { get; set; } = null!;

    public string Thuroff { get; set; } = null!;

    public string Frioff { get; set; } = null!;

    public string Satoff { get; set; } = null!;

    public int Payseq { get; set; }

    public string Paydesc { get; set; } = null!;

    public string Posno { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Payperiod { get; set; } = null!;

    public double Distrate { get; set; }

    public double Billrate { get; set; }

    public string Distind { get; set; } = null!;

    public string Distacctcd { get; set; } = null!;

    public string Credacctcd { get; set; } = null!;

    public double Payrate { get; set; }

    public string Paytype { get; set; } = null!;

    public decimal Guarantee { get; set; }

    public string Payacctcd { get; set; } = null!;

    public string Bankno { get; set; } = null!;

    public double Othour { get; set; }

    public double Otrate { get; set; }

    public string Pref1 { get; set; } = null!;

    public string Pref2 { get; set; } = null!;

    public string Pref3 { get; set; } = null!;

    public string Pref4 { get; set; } = null!;

    public string Pref5 { get; set; } = null!;

    public string Pref6 { get; set; } = null!;

    public DateTime Updtime { get; set; }

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
