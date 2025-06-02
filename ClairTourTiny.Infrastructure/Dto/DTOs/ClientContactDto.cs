using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

public class ClientContactDto
{
    public int Id { get; set; }
    public string EntityNo { get; set; }
    public string ContactName { get; set; }
    public string Role { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Country { get; set; }
    public bool IsPrimary { get; set; }
    public string Notes { get; set; }
} 