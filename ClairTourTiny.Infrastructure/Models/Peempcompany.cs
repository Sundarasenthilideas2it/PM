using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Peempcompany
{
    public string Companyno { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public string Companyname2 { get; set; } = null!;

    public string Contactfirstname { get; set; } = null!;

    public string Contactlastname { get; set; } = null!;

    public string? Contactofficephone { get; set; }

    public string? Contactcellphone { get; set; }

    public string? Contactfax { get; set; }

    public string? Contactemail { get; set; }

    public string Contactother1 { get; set; } = null!;

    public string Contactother2 { get; set; } = null!;

    public string Companystatus { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string? Companyphone { get; set; }

    public string Companyfax { get; set; } = null!;

    public string Companywebaddress { get; set; } = null!;

    public string? Companynotes { get; set; }

    public string Defaultproptype { get; set; } = null!;

    public string Country { get; set; } = null!;

    public virtual Pjproptype DefaultproptypeNavigation { get; set; } = null!;

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();
}
