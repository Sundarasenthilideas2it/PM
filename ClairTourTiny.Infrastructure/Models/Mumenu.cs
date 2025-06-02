using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Mumenu
{
    public string Packagecd { get; set; } = null!;

    public string Menuname { get; set; } = null!;

    public int Menuseqno { get; set; }

    public string Cmndsel { get; set; } = null!;

    public string Menudesc { get; set; } = null!;

    public string Menuverify { get; set; } = null!;

    public string Menutype { get; set; } = null!;

    public string Cmndline { get; set; } = null!;

    public string CExecPath { get; set; } = null!;

    public string Appexec { get; set; } = null!;

    public string Appframe { get; set; } = null!;

    public string Qbfframe { get; set; } = null!;

    public string Qbfmode { get; set; } = null!;

    public string Rptname { get; set; } = null!;

    public string ExcludeFormfeed { get; set; } = null!;

    public string Menutitle { get; set; } = null!;

    public string Prevmenu { get; set; } = null!;

    public virtual ICollection<MyFinesseUpdate> MyFinesseUpdates { get; set; } = new List<MyFinesseUpdate>();

    public virtual ICollection<Pjtfrusr> Users { get; set; } = new List<Pjtfrusr>();
}
