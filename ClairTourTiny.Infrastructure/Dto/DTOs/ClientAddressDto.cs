using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class ClientAddressDto
{
    public int Id { get; set; }
    public string EntityNo { get; set; }
    public string AddressType { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public bool IsPrimary { get; set; }
    public string Notes { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }
} 