/*! \file SummariesStatisticsType.cs
    \brief defines a list of summaries for dimensionless statistical values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The SummariesStatisticsType defines a list of summaries for dimensionless statistical values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsType
    {
        /// <remarks> Each StatsSummary element is a summary of a single dimensionless statistical value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("StatsSummary")]
        public SummaryStatisticsType[] StatsSummary { get; set; }

        /// <remarks> The required n attribute is the number of summaries in the list.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.StatsSummary.Length;
            set { }
        }
    }

    /// <remarks> The SummaryStatisticsType defines a summary of a single unitless
    /// statistical value and is the base class for summary values with units.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsUserDefinedUnitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsTemperatureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsSpeedType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsPressureType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsMassType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsForceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsAreaType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsAngularType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SummaryStatisticsLinearType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsType
    {
        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> The TypeOfSummary element is the type of statistical value being summarized.</remarks>
        public StatsValuesEnumType TypeOfSummary { get; set; }

        /// <remarks> Each SummaryStatsValue element is a summary statistical value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SummaryAverage", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SummaryMaximum", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SummaryMinimum", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SummaryRange", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlElementAttribute("SummaryStandardDeviation", typeof(StatsMeasuredDecimalType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public StatsWithReferenceBaseType[] SummaryStatsValue { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceTypeSummaryStatsValue[] ItemElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum ItemChoiceTypeSummaryStatsValue
    {
        /// <remarks></remarks>
        SummaryAverage,

        /// <remarks></remarks>
        SummaryMaximum,

        /// <remarks></remarks>
        SummaryMinimum,

        /// <remarks></remarks>
        SummaryRange,

        /// <remarks></remarks>
        SummaryStandardDeviation,
    }

    /// <remarks> The SummaryStatisticsUserDefinedUnitType defines a summary of a
    /// single user-defined unit statistical value.This type is not to be
    /// used for units available in another user-defined summary statistics
    /// type. In particular this type is not to be used with linear units,
    /// angular units, or units of temperature, area, force, mass,
    /// pressure, speed, or time. The information can be common to more
    /// than one user-defined characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsUserDefinedUnitType : SummaryStatisticsType
    {
        /// <remarks> The required unitName attribute defines the unit name for the SummaryStatisticsUserDefinedUnitType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("unitName", DataType = "token")]
        public string UnitName { get; set; }
    }

    /// <remarks> The SummaryStatisticsTimeType defines a summary of a single time statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsTimeType : SummaryStatisticsType
    {
        /// <remarks> The optional timeUnit attribute defines the unit name for the SummaryStatisticsTimeType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("timeUnit", DataType = "token")]
        public string TimeUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsTemperatureType defines a summary of a single temperature statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsTemperatureType : SummaryStatisticsType
    {
        /// <remarks> The optional temperatureUnit attribute defines the unit name for the SummaryStatisticsTemperatureType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("temperatureUnit", DataType = "token")]
        public string TemperatureUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsSpeedType defines a summary of a single speed statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsSpeedType : SummaryStatisticsType
    {
        /// <remarks> The optional speedUnit attribute defines the unit name for the SummaryStatisticsSpeedType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("speedUnit", DataType = "token")]
        public string SpeedUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsPressureType defines a summary of a single pressure statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsPressureType : SummaryStatisticsType
    {
        /// <remarks> The optional pressureUnit attribute defines the unit name for the SummaryStatisticsPressureType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("pressureUnit", DataType = "token")]
        public string PressureUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsMassType defines a summary of a single mass statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsMassType : SummaryStatisticsType
    {
        /// <remarks> The optional massUnit attribute defines the unit name for the SummaryStatisticsMassType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("massUnit", DataType = "token")]
        public string MassUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsForceType defines a summary of a single force statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsForceType : SummaryStatisticsType
    {
        /// <remarks> The optional forceUnit attribute defines the unit name for the SummaryStatisticsForceType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("forceUnit", DataType = "token")]
        public string ForceUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsAreaType defines a summary of a single area statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsAreaType : SummaryStatisticsType
    {
        /// <remarks> The optional areaUnit attribute defines the unit name for the SummaryStatisticsAreaType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("areaUnit", DataType = "token")]
        public string AreaUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsAngularType defines a summary of a single angular statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsAngularType : SummaryStatisticsType
    {
        /// <remarks> The optional angularUnit attribute defines the unit name for the SummaryStatisticsAngularType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("angularUnit", DataType = "token")]
        public string AngularUnit { get; set; }
    }

    /// <remarks> The SummaryStatisticsLinearType defines a summary of a single linear statistical value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatisticsLinearType : SummaryStatisticsType
    {
        /// <remarks> The optional linearUnit attribute defines the unit name for the SummaryStatisticsLinearType.</remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("linearUnit", DataType = "token")]
        public string LinearUnit { get; set; }
    }
}
