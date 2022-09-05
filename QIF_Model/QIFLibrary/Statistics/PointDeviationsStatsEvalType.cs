/*! \file PointDeviationsStatsEvalType.cs
    \brief defines a list of the results of statistical evaluations of vector deviations of individual measurement points from nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The PointDeviationsStatsEvalType defines a list of the results of
    /// statistical evaluations of vector deviations of individual
    /// measurement points from nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDeviationsStatsEvalType : ArrayBaseType<PointDeviationStatsEvalType>
    {
        /// <remarks> Each PointDeviationStats element gives the results of a
        /// statistical evaluation of vector deviation of an individual measurement point from nominal.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("PointDeviationStats")]
        public PointDeviationStatsEvalType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The PointDeviationStatsEvalType defines the results of a
    /// statistical evaluation of the deviation of a measurement point from nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointDeviationStatsEvalType
    {
        /// <remarks> The MeasuredPointIds element contains a list of ids of
        /// points used in the evaluation and an optional set of exclusions from the list.</remarks>
        public StatsArrayIdType MeasuredPointIds { get; set; }

        /// <remarks> The MeasurePointIdsKey collects all QIF ids of measure points being evaluated.</remarks>
        public StatsLinearType DeviationStats { get; set; }
    }
}
