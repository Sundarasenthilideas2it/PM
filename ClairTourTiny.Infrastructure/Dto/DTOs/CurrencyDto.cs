using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for currency information
/// </summary>
public class CurrencyDto
{
    /// <summary>
    /// The unique identifier of the currency
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this currency is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The currency code
    /// </summary>
    public string CurrencyCode { get; set; } = null!;

    /// <summary>
    /// The description of the currency
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// The symbol of the currency
    /// </summary>
    public string Symbol { get; set; } = null!;

    /// <summary>
    /// Whether this currency is active
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// The exchange rate against the base currency
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// The date of the exchange rate
    /// </summary>
    public DateTime? ExchangeRateDate { get; set; }

    /// <summary>
    /// Whether this is the base currency
    /// </summary>
    public bool IsBaseCurrency { get; set; }

    /// <summary>
    /// The number of decimal places for this currency
    /// </summary>
    public int DecimalPlaces { get; set; }

    /// <summary>
    /// The sort order for this currency
    /// </summary>
    public int? SortOrder { get; set; }

    /// <summary>
    /// Any notes about the currency
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this currency was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this currency
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 