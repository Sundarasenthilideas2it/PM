using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class SoundcheckLogging
{
    public string Partno { get; set; } = null!;

    public string UniqueNo { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public DateTime TestDate { get; set; }

    public bool PassedTest { get; set; }
}
