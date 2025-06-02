using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class EmployeeStatus
{
    public string StatusCode { get; set; } = null!;

    public string StatusDesc { get; set; } = null!;

    public byte? DisplayOrder { get; set; }

    public bool IsAvailable { get; set; }

    public bool IsPayable { get; set; }

    public virtual ICollection<Peemployee> Peemployees { get; set; } = new List<Peemployee>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
