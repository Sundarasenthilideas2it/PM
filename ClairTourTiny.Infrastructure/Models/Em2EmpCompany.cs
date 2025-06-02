using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Em2EmpCompany
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Companyno { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public string Companyname2 { get; set; } = null!;

    public string Contactfirstname { get; set; } = null!;

    public string Contactlastname { get; set; } = null!;

    public string Contactofficephone { get; set; } = null!;

    public string Contactcellphone { get; set; } = null!;

    public string Contactfax { get; set; } = null!;

    public string Contactemail { get; set; } = null!;

    public string Contactother1 { get; set; } = null!;

    public string Contactother2 { get; set; } = null!;

    public string Companystatus { get; set; } = null!;

    public string Addr1 { get; set; } = null!;

    public string Addr2 { get; set; } = null!;

    public string Addr3 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Companyphone { get; set; } = null!;

    public string Companyfax { get; set; } = null!;

    public string Companywebaddress { get; set; } = null!;

    public string Companynotes { get; set; } = null!;

    public string Defaultproptype { get; set; } = null!;

    public string Country { get; set; } = null!;

    public float? Qty { get; set; }
}
