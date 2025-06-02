using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class PartDto
{
    public string PartNo { get; set; }
    public string EntityNo { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string SubCategory { get; set; }
    public decimal Quantity { get; set; }
    public string UnitOfMeasure { get; set; }
    public decimal UnitCost { get; set; }
    public decimal TotalCost { get; set; }
    public string Status { get; set; }
    public string Location { get; set; }
    public string Notes { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }
} 