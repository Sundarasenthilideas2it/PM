using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class EquipmentSubhireDto
{
    public int Id { get; set; }
    public string EntityNo { get; set; }
    public string PartNo { get; set; }
    public string Description { get; set; }
    public string VendorNo { get; set; }
    public string VendorSiteNo { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal DailyRate { get; set; }
    public decimal WeeklyRate { get; set; }
    public string Status { get; set; }
    public string Notes { get; set; }
} 