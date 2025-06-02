using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pedivision
{
    public string Division { get; set; } = null!;

    public string Divdesc { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Pool { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public string? InternalOrg { get; set; }

    public bool DoIntercompanyLabor { get; set; }

    public virtual ICollection<Company> Companies { get; set; } = new List<Company>();

    public virtual ICollection<DivisionBurdenRate> DivisionBurdenRates { get; set; } = new List<DivisionBurdenRate>();

    public virtual ICollection<DivisionPayrollTypeBurdenRate> DivisionPayrollTypeBurdenRates { get; set; } = new List<DivisionPayrollTypeBurdenRate>();

    public virtual Company? InternalOrgNavigation { get; set; }

    public virtual ICollection<PeemVisibleDivision> PeemVisibleDivisions { get; set; } = new List<PeemVisibleDivision>();

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();
}
