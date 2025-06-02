using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Murunbatch
{
    public string RecSessionId { get; set; } = null!;

    public string SendSessionId { get; set; } = null!;

    public int Batchtime { get; set; }

    public int Seqno { get; set; }

    public string Batchname { get; set; } = null!;

    public string Pgmname { get; set; } = null!;

    public string JobType { get; set; } = null!;

    public string Parm1 { get; set; } = null!;

    public string Parm2 { get; set; } = null!;

    public string Parm3 { get; set; } = null!;

    public string Parm4 { get; set; } = null!;

    public string Parm5 { get; set; } = null!;

    public string Parm6 { get; set; } = null!;

    public string Parm7 { get; set; } = null!;

    public string Parm8 { get; set; } = null!;

    public string Parm9 { get; set; } = null!;

    public string Parm10 { get; set; } = null!;

    public string Parm11 { get; set; } = null!;

    public string Parm12 { get; set; } = null!;

    public string Parm13 { get; set; } = null!;

    public string Parm14 { get; set; } = null!;

    public string Parm15 { get; set; } = null!;

    public string Runflags { get; set; } = null!;

    public string Cmndline { get; set; } = null!;

    public string Outputfilename { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string ExcludeFormfeed { get; set; } = null!;

    public int LinesPerPage { get; set; }

    public int NumberOfCopies { get; set; }

    public DateTime Runtime { get; set; }

    public int Priority { get; set; }

    public int Status { get; set; }

    public string EncryptUser { get; set; } = null!;

    public Guid Primekey { get; set; }

    public Guid MsreplTranVersion { get; set; }
}
