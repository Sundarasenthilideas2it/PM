using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for company information
/// </summary>
public class CompanyDto
{
    /// <summary>
    /// The unique identifier of the company
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this company is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The company code
    /// </summary>
    public string CompanyCode { get; set; } = null!;

    /// <summary>
    /// The company name
    /// </summary>
    public string CompanyName { get; set; } = null!;

    /// <summary>
    /// Whether this company is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The company's tax ID
    /// </summary>
    public string? TaxId { get; set; }

    /// <summary>
    /// The company's registration number
    /// </summary>
    public string? RegistrationNumber { get; set; }

    /// <summary>
    /// The company's website
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// The company's phone number
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The company's email address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// The company's address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// The company's city
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// The company's state/province
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// The company's postal code
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// The company's country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// The company's default currency
    /// </summary>
    public string? DefaultCurrency { get; set; }

    /// <summary>
    /// The company's default tax code
    /// </summary>
    public string? DefaultTaxCode { get; set; }

    /// <summary>
    /// Any notes about the company
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this company was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this company
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 