using System;
using System.ComponentModel.DataAnnotations.Schema;

public class AssignedCrewOtDto
{
    [Column("empno")]
    public string EmpNo { get; set; } = string.Empty;

    [Column("entityno")]
    public string EntityNo { get; set; } = string.Empty;

    [Column("jobtype")]
    public string JobType { get; set; } = string.Empty;

    [Column("fromdate")]
    public DateTime FromDate { get; set; }

    [Column("RateType")]
    public string RateType { get; set; } = string.Empty;

    [Column("Hours")]
    public double Hours { get; set; }
}
