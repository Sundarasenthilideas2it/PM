namespace ClairTourTiny.Core.Models.ProjectMaintenance
{
    public class ProjectPartBidValueModel
    {
        public string PartNo { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string ValueType { get; set; } = string.Empty;
        public double BidValue { get; set; }
    }
}
