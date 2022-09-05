/*! \file AngularCharacteristicStatsEvalType.cs
    \brief 
        base type that defines the results of a statistical evaluation of measured values
        with angular units or their deviations from nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The AngularCharacteristicStatsEvalType is the base type that
    /// defines the results of a statistical evaluation of measured values
    /// with angular units or their deviations from nominal. The type
    /// itself can be used to accumulate summary statistics over different
    /// types of angular characteristics.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleBetweenCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleFromCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCoordinateCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularCharacteristicStatsEvalType : CharacteristicStatsEvalBaseType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("DeviationStats", typeof(StatsWithTolAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDeviationStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValueStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDeviationStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValueStats", typeof(StatsAngularType))]
        [System.Xml.Serialization.XmlElementAttribute("ValueStats", typeof(StatsWithTolAngularType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsUnitsItemsChoiceType[]? ItemsElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleBetweenCharacteristicStatsEvalType : AngularCharacteristicStatsEvalType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleFromCharacteristicStatsEvalType : AngularCharacteristicStatsEvalType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngleCharacteristicStatsEvalType : AngularCharacteristicStatsEvalType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularCoordinateCharacteristicStatsEvalType : AngularCharacteristicStatsEvalType
    {
    }
}
