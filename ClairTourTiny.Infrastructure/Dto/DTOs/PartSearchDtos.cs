using System.ComponentModel.DataAnnotations;

namespace ClairTourTiny.Infrastructure.Dto.DTOs
{
    public class PartSearchRequestDto
    {
        public string SearchText { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public bool HideUnusedParts { get; set; }
        public bool OnlyMyWarehouses { get; set; }
        public bool MyPartsOnly { get; set; }
        public bool SearchForBarcode { get; set; }
    }

    public class PartSearchResultDto
    {
        public string PartNumber { get; set; }
        public string PartDescription { get; set; }
        public string Commodity { get; set; }
        public string PartGroup { get; set; }
        public int PartSequence { get; set; }
    }

    public class PartCategoryDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class PartSubCategoryDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Commodity { get; set; }
    }
} 