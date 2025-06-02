using System;
using System.Collections.Generic;

namespace ClairTourTiny.Infrastructure.Models;

public partial class JobCostingHighLevelDataTbl
{
    public string Project { get; set; } = null!;

    public string ProjectDescription { get; set; } = null!;

    public string? Company { get; set; }

    public string HomeWarehouse { get; set; } = null!;

    public string AccountManager { get; set; } = null!;

    public string AccountExecutive { get; set; } = null!;

    public string? PropType { get; set; }

    public double QuoteEquipmentBenchmark { get; set; }

    public double QuoteEquipmentActual { get; set; }

    public double BidEquipmentProposal { get; set; }

    public decimal BidEquipmentBenchmark { get; set; }

    public double ActualEquipment { get; set; }

    public double ActualEquipmentOrdered { get; set; }

    public double ActualEquipmentShoptime { get; set; }

    public double ActualUsaEquipment { get; set; }

    public double ActualNonUsaEquipment { get; set; }

    public decimal ExtraEquipmentCost { get; set; }

    public double InvoicedEquipment { get; set; }

    public double InvoicedEquipmentNonUsa { get; set; }

    public decimal ExtraInvoices { get; set; }

    public double QuoteCrew { get; set; }

    public double BidCrew { get; set; }

    public double ActualCrew { get; set; }

    public double CrewCost { get; set; }

    public decimal ExtraCrew { get; set; }

    public double InvoicedLabor { get; set; }

    public double InvoicedLaborNonUsa { get; set; }

    public double QuoteExpenses { get; set; }

    public double BidExpenses { get; set; }

    public decimal ActualExpenses { get; set; }

    public decimal SubrentedEquipment { get; set; }

    public decimal ExtraExpenses { get; set; }

    public double InvoicedOther { get; set; }

    public double InvoicedOtherNonUsa { get; set; }
}
