using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Oeacctmatrix
{
    public string Matrixcd { get; set; } = null!;

    public string Matrixdesc { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public double Price { get; set; }

    public string Salegl { get; set; } = null!;

    public string Saleacctcr { get; set; } = null!;

    public string Saleacctdb { get; set; } = null!;

    public string Discacctcd { get; set; } = null!;

    public string Fcacctcd { get; set; } = null!;

    public double Cost { get; set; }

    public string Costgl { get; set; } = null!;

    public string Costacctcr { get; set; } = null!;

    public string Costacctlabcr { get; set; } = null!;

    public string Costacctoutcr { get; set; } = null!;

    public string Costacctoh1cr { get; set; } = null!;

    public string Costacctoh2cr { get; set; } = null!;

    public string Costacctacqcr { get; set; } = null!;

    public string Costacctdb { get; set; } = null!;

    public string Costacctlab { get; set; } = null!;

    public string Costacctout { get; set; } = null!;

    public string Costacctoh1 { get; set; } = null!;

    public string Costacctoh2 { get; set; } = null!;

    public string Costacctacq { get; set; } = null!;

    public string Saleind { get; set; } = null!;

    public string Activeind { get; set; } = null!;

    public string Ref1 { get; set; } = null!;

    public string Ref2 { get; set; } = null!;

    public string Ref3 { get; set; } = null!;

    public string Ref4 { get; set; } = null!;

    public string Ref5 { get; set; } = null!;

    public string Ref6 { get; set; } = null!;

    public string Ref7 { get; set; } = null!;

    public string Ref8 { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }

    public string? Entityno { get; set; }

    public virtual ICollection<Pjjobbudexp> Pjjobbudexps { get; set; } = new List<Pjjobbudexp>();
}
