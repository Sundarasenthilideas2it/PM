using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpArContact
{
    public int IdContact { get; set; }

    public int? IdAddress { get; set; }

    public string? Surname { get; set; }

    public string? FirstName { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public string? Mobile { get; set; }

    public string? Jobname { get; set; }

    public string? Email { get; set; }

    public string? Department { get; set; }

    public string? Number { get; set; }

    public int? IdSalutation { get; set; }

    public string? Custom1 { get; set; }

    public string? Custom2 { get; set; }

    public string? MiddleName { get; set; }

    public int? IdUserCreated { get; set; }

    public int? IdUserUpdated { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? UpdateTime { get; set; }
}
