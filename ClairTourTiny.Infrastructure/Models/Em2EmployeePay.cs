using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Em2EmployeePay
{
    public short SessionId { get; set; }

    public DateTime UpdateTime { get; set; }

    public bool IsInsert { get; set; }

    public bool IsUpdate { get; set; }

    public bool IsDelete { get; set; }

    public string Empno { get; set; } = null!;

    public string Paycode { get; set; } = null!;

    public DateTime Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public double Payrate { get; set; }

    public string? Currency { get; set; }

    public string? Note { get; set; }
}
