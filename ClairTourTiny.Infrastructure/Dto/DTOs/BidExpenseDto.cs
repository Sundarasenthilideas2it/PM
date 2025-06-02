using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs;

/// <summary>
/// Data transfer object for bid expense information
/// </summary>
public class BidExpenseDto
{
    /// <summary>
    /// The unique identifier of the bid expense
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The entity number this bid expense is associated with
    /// </summary>
    public string EntityNo { get; set; } = null!;

    /// <summary>
    /// The expense code
    /// </summary>
    public string ExpenseCode { get; set; } = null!;

    /// <summary>
    /// The description of the expense
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// The quantity of the expense
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// The unit price of the expense
    /// </summary>
    public decimal UnitPrice { get; set; }

    /// <summary>
    /// The total amount of the expense
    /// </summary>
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// The currency of the expense
    /// </summary>
    public string Currency { get; set; } = null!;

    /// <summary>
    /// The exchange rate used
    /// </summary>
    public decimal? ExchangeRate { get; set; }

    /// <summary>
    /// The date of the exchange rate
    /// </summary>
    public DateTime? ExchangeRateDate { get; set; }

    /// <summary>
    /// The budget category of the expense
    /// </summary>
    public string BudgetCategory { get; set; } = null!;

    /// <summary>
    /// Any notes about the expense
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// The date this expense was last modified
    /// </summary>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// The user who last modified this expense
    /// </summary>
    public string? LastModifiedBy { get; set; }
} 