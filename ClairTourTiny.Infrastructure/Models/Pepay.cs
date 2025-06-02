using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pepay
{
    public string Empno { get; set; } = null!;

    public string Paydesc { get; set; } = null!;

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string Payperiod { get; set; } = null!;

    public string Paytype { get; set; } = null!;

    public double Payrate { get; set; }

    public string? Currency { get; set; }
}
