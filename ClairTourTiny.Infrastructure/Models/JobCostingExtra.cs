using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobCostingExtra
{
    public string Entityno { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public decimal Invoices { get; set; }

    public decimal Crew { get; set; }

    public decimal Expenses { get; set; }

    public decimal EquipmentCost { get; set; }

    public int? Days { get; set; }

    public string Note { get; set; } = null!;

    public string Currency { get; set; } = null!;

    public virtual Glentity EntitynoNavigation { get; set; } = null!;
}
