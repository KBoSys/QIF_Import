/*! \file OrientationCharacteristicStatsEvalType.cs
    \brief base type that defines the results of a statistical evaluation of measured orientation characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The OrientationCharacteristicStatsEvalType is the base type that
    /// defines the results of a statistical evaluation of measured
    /// orientation characteristics. The type itself can be used to
    /// accumulate summary statistics over different types of orientation characteristics.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelismCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerpendicularityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OrientationCharacteristicStatsEvalType : GeometricCharacteristicStatsEvalType
    {
        /// <remarks> The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance.</remarks>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks> </remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }

        /// <remarks> The optional DatumsOkStats element is the result of a statistical evaluation of DatumsOk flags.</remarks>
        public StatsPassFailType DatumsOkStats { get; set; }

        /// <remarks> The optional BonusStats element is the result of a statistical evaluation of the applied bonus.</remarks>
        public StatsLinearType BonusStats { get; set; }

        /// <remarks> The optional ReferenceLengthStats element is the result of
        /// a statistical evaluation of the measured length of the applied tolerance zone.</remarks>
        public StatsLinearType ReferenceLengthStats { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelismCharacteristicStatsEvalType : OrientationCharacteristicStatsEvalType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PerpendicularityCharacteristicStatsEvalType : OrientationCharacteristicStatsEvalType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularityCharacteristicStatsEvalType : OrientationCharacteristicStatsEvalType
    {
    }

}
