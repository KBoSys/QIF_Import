/*! \file StatsWithTolNumericalBaseType.cs
    \brief abstract base type that defines various results of statistical evaluations

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The StatsWithTolNumericalBaseType is the abstract base type that
    /// defines various results of statistical evaluations involving
    /// numerical tolerances or specification limits which includes
    /// statistical values common to numeric and non-numeric
    /// characteristics and statistical values common to non-toleranced numerical charactersitics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolUserDefinedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolTemperatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolSpeedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolPressureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolMassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolForceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolAreaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolAngularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsWithTolLinearType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class StatsWithTolNumericalBaseType
    {
        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks Each NumericCharacteristicWithTolStatsValue element is a
        /// statistical value for a numeric characteristic involving a
        /// tolerance or specification limit which includes any statistical
        /// value common to numeric and non-numeric characteristics and any
        /// statistical value common to non-toleranced numerical charactersitics./>
        [System.Xml.Serialization.XmlElementAttribute("NumberOutOfTolerance", typeof(StatsNonNegativeIntegerWithReferencesType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupNumbersOutOfTolerance", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("NumberOverUpperTolerance", typeof(StatsNonNegativeIntegerWithReferencesType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupNumbersOverUpperTolerance", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("NumberUnderLowerTolerance", typeof(StatsNonNegativeIntegerWithReferencesType))]
        [System.Xml.Serialization.XmlElementAttribute("SubgroupNumbersUnderLowerTolerance", typeof(SubgroupIntegersType))]
        [System.Xml.Serialization.XmlElementAttribute("Cp", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Cpk", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Pp", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Ppk", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Cm", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Cmk", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("Cpm", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeAppraiserVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeEquipmentVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeInteraction", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeGageRandR", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativePartVariation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("RelativeTotalVariation", typeof(StatsMeasuredDecimalType))]
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
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("NumericCharacteristicWithTolItemElementName")]
        public StatsWithReferenceBaseType[] NumericCharacteristicWithTolStatsValues { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceTypeNumericCharacteristicWithTolStatsValue[] NumericCharacteristicWithTolItemElementName { get; set; }
    }

    /// <remarks/>
    // MANEDIT added this class to allow for elements of same type
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ItemChoiceTypeNumericCharacteristicWithTolStatsValue
    {
        /// <remarks/>
        NumberOutOfTolerance,

        /// <remarks/>
        SubgroupNumbersOutOfTolerance,

        /// <remarks/>
        NumberOverUpperTolerance,

        /// <remarks/>
        SubgroupNumbersOverUpperTolerance,

        /// <remarks/>
        NumberUnderLowerTolerance,

        /// <remarks/>
        SubgroupNumbersUnderLowerTolerance,

        /// <remarks/>
        Cp,

        /// <remarks/>
        Cpk,

        /// <remarks/>
        Pp,

        /// <remarks/>
        Ppk,

        /// <remarks/>
        Cm,

        /// <remarks/>
        Cmk,

        /// <remarks/>
        Cpm,

        /// <remarks/>
        RelativeAppraiserVariation,

        /// <remarks/>
        RelativeEquipmentVariation,

        /// <remarks/>
        RelativeInteraction,

        /// <remarks/>
        RelativeGageRandR,

        /// <remarks/>
        RelativePartVariation,

        /// <remarks/>
        RelativeTotalVariation,

        /// <remarks/>
        Average,

        /// <remarks/>
        SubgroupAverages,

        /// <remarks/>
        Difference,

        /// <remarks/>
        SubgroupDifferences,

        /// <remarks/>
        RootMeanSquare,

        /// <remarks/>
        Maximum,

        /// <remarks/>
        SubgroupMaxima,

        /// <remarks/>
        Minimum,

        /// <remarks/>
        SubgroupMinima,

        /// <remarks/>
        Range,

        /// <remarks/>
        SubgroupRanges,

        /// <remarks/>
        AverageRange,

        /// <remarks/>
        StandardDeviation,

        /// <remarks/>
        Skew,

        /// <remarks/>
        Kurtosis,

        /// <remarks/>
        Normality,

        /// <remarks/>
        ProcessVariation,

        /// <remarks/>
        EstimatedStandardDeviation,

        /// <remarks/>
        UpperControlLimit,

        /// <remarks/>
        LowerControlLimit,

        /// <remarks/>
        UpperControlLimitRange,

        /// <remarks/>
        LowerControlLimitRange,

        /// <remarks/>
        NumberOutOfControl,

        /// <remarks/>
        AppraiserVariation,

        /// <remarks/>
        EquipmentVariation,

        /// <remarks/>
        Interaction,

        /// <remarks/>
        GageRandR,

        /// <remarks/>
        PartVariation,

        /// <remarks/>
        TotalVariation,

        /// <remarks/>
        Linearity,

        /// <remarks/>
        Bias,

        /// <remarks/>
        RelativeLinearity,

        /// <remarks/>
        RelativeBias,

        /// <remarks/>
        GoodnessOfFit,

        /// <remarks/>
        RegressionSlope,

        /// <remarks/>
        RegressionIntercept,

        /// <remarks/>
        UpperConfidenceLimit,

        /// <remarks/>
        LowerConfidenceLimit,

        /// <remarks/>
        TDistribution,

        /// <remarks/>
        TotalNumber,

        /// <remarks/>
        SubgroupTotalNumbers,

        /// <remarks/>
        EffectiveNumber,

        /// <remarks/>
        SubgroupEffectiveNumbers,

        /// <remarks/>
        NumberSubgroups,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolLinearType : StatsWithTolNumericalBaseType
    {

        private string linearUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string linearUnit
        {
            get
            {
                return this.linearUnitField;
            }
            set
            {
                this.linearUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolUserDefinedUnitType : StatsWithTolNumericalBaseType
    {

        private string unitNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string unitName
        {
            get
            {
                return this.unitNameField;
            }
            set
            {
                this.unitNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolTimeType : StatsWithTolNumericalBaseType
    {

        private string timeUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string timeUnit
        {
            get
            {
                return this.timeUnitField;
            }
            set
            {
                this.timeUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolTemperatureType : StatsWithTolNumericalBaseType
    {

        private string temperatureUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string temperatureUnit
        {
            get
            {
                return this.temperatureUnitField;
            }
            set
            {
                this.temperatureUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolSpeedType : StatsWithTolNumericalBaseType
    {

        private string speedUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string speedUnit
        {
            get
            {
                return this.speedUnitField;
            }
            set
            {
                this.speedUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolPressureType : StatsWithTolNumericalBaseType
    {

        private string pressureUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string pressureUnit
        {
            get
            {
                return this.pressureUnitField;
            }
            set
            {
                this.pressureUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolMassType : StatsWithTolNumericalBaseType
    {

        private string massUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string massUnit
        {
            get
            {
                return this.massUnitField;
            }
            set
            {
                this.massUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolForceType : StatsWithTolNumericalBaseType
    {

        private string forceUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string forceUnit
        {
            get
            {
                return this.forceUnitField;
            }
            set
            {
                this.forceUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolAreaType : StatsWithTolNumericalBaseType
    {

        private string areaUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string areaUnit
        {
            get
            {
                return this.areaUnitField;
            }
            set
            {
                this.areaUnitField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsWithTolAngularType : StatsWithTolNumericalBaseType
    {

        private string angularUnitField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string angularUnit
        {
            get
            {
                return this.angularUnitField;
            }
            set
            {
                this.angularUnitField = value;
            }
        }
    }

}
