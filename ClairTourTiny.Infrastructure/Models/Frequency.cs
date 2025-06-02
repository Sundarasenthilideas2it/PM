using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Frequency
{
    public string FrequencyCode { get; set; } = null!;

    public string FrequencyAdjective { get; set; } = null!;

    public string FrequencyNoun { get; set; } = null!;

    public int? SortOrder { get; set; }

    public virtual ICollection<MyFinesseEmailNotification> MyFinesseEmailNotifications { get; set; } = new List<MyFinesseEmailNotification>();
}
