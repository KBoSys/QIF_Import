/*! \file StatsNumericalBaseType.cs
    \brief abstract base type that defines various results of statistical evaluations with numerical characteristics

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The StatsNumericalBaseType is the abstract base type that defines
    /// various results of statistical evaluations with numerical
    /// characteristics but not involving tolerances or specification
    /// limits which includes statistical values common to numeric and non-numeric characteristics.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsUserDefinedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsTemperatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsSpeedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsPressureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsMassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsForceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsAreaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsAngularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsLinearType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class StatsNumericalBaseType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType? Attributes { get; set; }

        /// <remarks> Each NumericCharacteristicStatsValue element is a statistical
        /// value for a numeric characteristic that doesn't involve a
        /// tolerance or specification limit which includes any statistical
        /// value common to numeric and non-numeric characteristics.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Average", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupAverages", typeof(SubgroupDecimalsType))]
        [System.Xml.Serialization.XmlElementAttribute("Difference", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupDifferences", typeof(SubgroupDecimalsType))]
        [System.Xml.Serialization.XmlElementAttribute("RootMeanSquare", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Maximum", typeof(StatsMeasuredDecimalWithReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupMaxima", typeof(SubgroupDecimalsType))]
        [System.Xml.Serialization.XmlElementAttribute("Minimum", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupMinima", typeof(StatsMeasuredDecimalWithReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("Range", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupRanges", typeof(SubgroupDecimalsType))]
        [System.Xml.Serialization.XmlElementAttribute("AverageRange", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("StandardDeviation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Skew", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Kurtosis", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Normality", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("ProcessVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("EstimatedStandardDeviation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("UpperControlLimit", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("LowerControlLimit", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("UpperControlLimitRange", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("LowerControlLimitRange", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("NumberOutOfControl", typeof(StatsNonNegativeIntegerWithReferencesType))]
        [System.Xml.Serialization.XmlElementAttribute("AppraiserVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("EquipmentVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Interaction", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("GageRandR", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("PartVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Linearity", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Bias", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeLinearity", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeBias", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("GoodnessOfFit", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RegressionSlope", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RegressionIntercept", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("UpperConfidenceLimit", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("LowerConfidenceLimit", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("TDistribution", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("TotalNumber", typeof(StatsNonNegativeIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupTotalNumbers", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("EffectiveNumber", typeof(StatsNonNegativeIntegerType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupEffectiveNumbers", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("NumberSubgroups", typeof(StatsNonNegativeIntegerType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("StatsValueItemElementName")]
        public StatsWithReferenceBaseType[]? NumericCharacteristicStatsValue { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceTypeNumericCharacteristicStatsValue[]? StatsValueItemElementName { get; set; }
    }

    /// <remarks></remarks>
    // MANEDIT added this class to allow for elements of same type
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ItemChoiceTypeNumericCharacteristicStatsValue
    {
        /// <remarks></remarks>
        Average,

        /// <remarks></remarks>
        SubgroupAverages,

        /// <remarks></remarks>
        Difference,

        /// <remarks></remarks>
        SubgroupDifferences,

        /// <remarks></remarks>
        RootMeanSquare,

        /// <remarks></remarks>
        Maximum,

        /// <remarks></remarks>
        SubgroupMaxima,

        /// <remarks></remarks>
        Minimum,

        /// <remarks></remarks>
        SubgroupMinima,

        /// <remarks></remarks>
        Range,

        /// <remarks></remarks>
        SubgroupRanges,

        /// <remarks></remarks>
        AverageRange,

        /// <remarks></remarks>
        StandardDeviation,

        /// <remarks></remarks>
        Skew,

        /// <remarks></remarks>
        Kurtosis,

        /// <remarks></remarks>
        Normality,

        /// <remarks></remarks>
        ProcessVariation,

        /// <remarks></remarks>
        EstimatedStandardDeviation,

        /// <remarks></remarks>
        UpperControlLimit,

        /// <remarks></remarks>
        LowerControlLimit,

        /// <remarks></remarks>
        UpperControlLimitRange,

        /// <remarks></remarks>
        LowerControlLimitRange,

        /// <remarks></remarks>
        NumberOutOfControl,

        /// <remarks></remarks>
        AppraiserVariation,

        /// <remarks></remarks>
        EquipmentVariation,

        /// <remarks></remarks>
        Interaction,

        /// <remarks></remarks>
        GageRandR,

        /// <remarks></remarks>
        PartVariation,

        /// <remarks></remarks>
        TotalVariation,

        /// <remarks></remarks>
        Linearity,

        /// <remarks></remarks>
        Bias,

        /// <remarks></remarks>
        RelativeLinearity,

        /// <remarks></remarks>
        RelativeBias,

        /// <remarks></remarks>
        GoodnessOfFit,

        /// <remarks></remarks>
        RegressionSlope,

        /// <remarks></remarks>
        RegressionIntercept,

        /// <remarks></remarks>
        UpperConfidenceLimit,

        /// <remarks></remarks>
        LowerConfidenceLimit,

        /// <remarks></remarks>
        TDistribution,

        /// <remarks></remarks>
        TotalNumber,

        /// <remarks></remarks>
        SubgroupTotalNumbers,

        /// <remarks></remarks>
        EffectiveNumber,

        /// <remarks></remarks>
        SubgroupEffectiveNumbers,

        /// <remarks></remarks>
        NumberSubgroups,
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsLinearType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("linearUnit", DataType = "token")]
        public string? LinearUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsUserDefinedUnitType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("unitName", DataType = "token")]
        public string? UnitName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsTimeType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("timeUnit", DataType = "token")]
        public string? TimeUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsTemperatureType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("temperatureUnit", DataType = "token")]
        public string? TemperatureUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsSpeedType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("speedUnit", DataType = "token")]
        public string? SpeedUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsPressureType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("pressureUnit", DataType = "token")]
        public string? PressureUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsMassType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("massUnit", DataType = "token")]
        public string? MassUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsForceType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("forceUnit", DataType = "token")]
        public string? ForceUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsAreaType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("areaUnit", DataType = "token")]
        public string? AreaUnit { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsAngularType : StatsNumericalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("angularUnit", DataType = "token")]
        public string? AngularUnit { get; set; }
    }
}
