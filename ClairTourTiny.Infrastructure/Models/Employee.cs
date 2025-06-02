using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class Employee
{
    public string Empno { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string Empstatus { get; set; } = null!;

    public DateTime Hiredate { get; set; }

    public string ToName { get; set; } = null!;

    public string Nickname { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public string Cellphone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public Guid Guid { get; set; }
}
