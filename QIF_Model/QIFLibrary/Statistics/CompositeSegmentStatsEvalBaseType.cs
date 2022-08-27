/*! \file CompositeSegmentStatsEvalBaseType.cs
    \brief abstract base type that defines the results of a statistical evaluation of a measurement composite segment.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The CompositeSegmentStatsEvalBaseType is the abstract base type
    /// that defines the results of a statistical evaluation of a measurement composite segment.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSegmentSymmetryStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSegmentProfileStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeSegmentPositionStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CompositeSegmentStatsEvalBaseType
    {
        /// <remarks> The optional ValueStats element is the result of a statistical
        /// evaluation of measured values.</remarks>
        public StatsWithTolLinearType ValueStats { get; set; }

        /// <remarks> The optional MaxValueStats element is the result of a
        /// statistical evaluation of the maxima of the measured values.</remarks>
        public StatsLinearType MaxValueStats { get; set; }

        /// <remarks> The optional MinValueStats element is the result of a
        /// statistical evaluation of the minima of the measured values.</remarks>
        public StatsLinearType MinValueStats { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentProfileStatsEvalType : CompositeSegmentStatsEvalBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentSymmetryStatsEvalType : CompositeSegmentStatsEvalBaseType
    {
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentPositionStatsEvalType : CompositeSegmentStatsEvalBaseType
    {
    }

}
