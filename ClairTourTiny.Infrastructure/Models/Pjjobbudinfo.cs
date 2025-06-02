using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Pjjobbudinfo
{
    public string Entityno { get; set; } = null!;

    public int ChangeNo { get; set; }

    public string Notetype { get; set; } = null!;

    public string NoteVal1 { get; set; } = null!;

    public string NoteVal2 { get; set; } = null!;

    public string NoteVal3 { get; set; } = null!;

    public string Displayind { get; set; } = null!;

    public int Seqno { get; set; }
}
