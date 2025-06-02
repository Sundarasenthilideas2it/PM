using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class OetaxCode
{
    public string TaxCode { get; set; } = null!;

    public string Taxdesc1 { get; set; } = null!;

    public double Tax1 { get; set; }

    public string Matrixcd1 { get; set; } = null!;

    public string Taxdesc2 { get; set; } = null!;

    public double Tax2 { get; set; }

    public string Matrixcd2 { get; set; } = null!;

    public string Taxdesc3 { get; set; } = null!;

    public double Tax3 { get; set; }

    public string Matrixcd3 { get; set; } = null!;

    public string Taxdesc4 { get; set; } = null!;

    public double Tax4 { get; set; }

    public string Matrixcd4 { get; set; } = null!;

    public string Taxdesc5 { get; set; } = null!;

    public double Tax5 { get; set; }

    public string Matrixcd5 { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
