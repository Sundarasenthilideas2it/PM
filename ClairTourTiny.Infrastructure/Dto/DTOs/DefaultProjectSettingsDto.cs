using System;

namespace ClairTourTiny.Infrastructure.Dto.DTOs
{
    /// <summary>
    /// DTO representing default project settings based on user information
    /// </summary>
    public class DefaultProjectSettingsDto
    {
        /// <summary>
        /// Default warehouse entity for the user
        /// </summary>
        public string DefaultWarehouse { get; set; }

        /// <summary>
        /// Default currency for the user
        /// </summary>
        public string DefaultCurrency { get; set; }

        /// <summary>
        /// Default language ID for the user
        /// </summary>
        public string DefaultLanguage { get; set; }

        /// <summary>
        /// Default billing company for the user
        /// </summary>
        public string DefaultBillingCompany { get; set; }

        /// <summary>
        /// Default property type for the user
        /// </summary>
        public string DefaultPropType { get; set; }

        /// <summary>
        /// Unit of length for measurements
        /// </summary>
        public string UnitOfLength { get; set; }

        /// <summary>
        /// Unit of weight for measurements
        /// </summary>
        public string UnitOfWeight { get; set; }

        /// <summary>
        /// Conversion factor from inches to preferred length unit
        /// </summary>
        public decimal ConversionFactorFromInches { get; set; }

        /// <summary>
        /// Conversion factor from pounds to preferred weight unit
        /// </summary>
        public decimal ConversionFactorFromPounds { get; set; }

        /// <summary>
        /// Number of decimal places for weight values
        /// </summary>
        public int WeightDecimalPlaces { get; set; }

        /// <summary>
        /// Number of decimal places for volume values
        /// </summary>
        public int VolumeDecimalPlaces { get; set; }

        /// <summary>
        /// Sales forecast group for the user
        /// </summary>
        public string SalesForecastGroup { get; set; }

        /// <summary>
        /// Default crew operations employee number
        /// </summary>
        public string DefaultCrewOps { get; set; }

        /// <summary>
        /// Default bid markup factor for the property type
        /// </summary>
        public decimal DefaultBidMarkup { get; set; }
    }
} 