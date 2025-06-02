using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class TmpBbmJobPart
{
    public int? IdJobPart { get; set; }

    public int? IdJob { get; set; }

    public int? IdJobPartType { get; set; }

    public string? Caption { get; set; }

    public DateTime? DateTime { get; set; }

    public int? Checked { get; set; }

    public DateTime? AvblDateTime { get; set; }

    public int? IdJobProgressItem { get; set; }

    public int? IdJobPartSiteSubRental { get; set; }

    public int? IdJobPartFollow { get; set; }

    public int? IdJobTransfer { get; set; }

    public int? Sequence { get; set; }

    public int? ShowAlwaysInLoadSession { get; set; }

    public int? IdJobStateReason { get; set; }

    public int? IdJobAppointment { get; set; }

    public int? ChargeLastDay { get; set; }

    public int? PolicyFlag { get; set; }
}
