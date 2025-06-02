using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class AllocatedNewRequisitionNumber
{
    public string ServerName { get; set; } = null!;

    public int Reqno { get; set; }

    public int? OwningSessionId { get; set; }
}
