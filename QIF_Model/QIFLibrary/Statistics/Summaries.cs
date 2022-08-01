/*! \file Summaries.cs
    \brief defines a list of summaries for statistical values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    public abstract class SummariesStatisticsBaseType<T>
    {
        [System.Xml.Serialization.XmlIgnore()]
        public T[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsLinearType : SummariesStatisticsBaseType<SummaryStatisticsLinearType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinearStatsSummary")]
        public SummaryStatisticsLinearType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsAngularType : SummariesStatisticsBaseType<SummaryStatisticsAngularType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AngularStatsSummary")]
        public SummaryStatisticsAngularType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsAreaType : SummariesStatisticsBaseType<SummaryStatisticsAreaType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AreaStatsSummary")]
        public SummaryStatisticsAreaType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsForceType : SummariesStatisticsBaseType<SummaryStatisticsForceType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ForceStatsSummary")]
        public SummaryStatisticsForceType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsMassType : SummariesStatisticsBaseType<SummaryStatisticsMassType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MassStatsSummary")]
        public SummaryStatisticsMassType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsPressureType : SummariesStatisticsBaseType<SummaryStatisticsPressureType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PressureStatsSummary")]
        public SummaryStatisticsPressureType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsSpeedType : SummariesStatisticsBaseType<SummaryStatisticsSpeedType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SpeedStatsSummary")]
        public SummaryStatisticsSpeedType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsTemperatureType : SummariesStatisticsBaseType<SummaryStatisticsTemperatureType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TemperatureStatsSummary")]
        public SummaryStatisticsTemperatureType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsTimeType : SummariesStatisticsBaseType<SummaryStatisticsTimeType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeStatsSummary")]
        public SummaryStatisticsTimeType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummariesStatisticsUserDefinedUnitType : SummariesStatisticsBaseType<SummaryStatisticsUserDefinedUnitType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitStatsSummary")]
        public SummaryStatisticsUserDefinedUnitType[] StatsSummary { get => base.Items; set => base.Items = value; }
    }
}
