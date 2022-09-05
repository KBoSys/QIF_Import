/*! \file SummaryStatsValuesListType.cs
    \brief collects a list of summary stats values.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The SummaryStatsValuesListType collects a list of summary stats values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatsValuesListType : ArrayBaseType<SummaryStatsValuesType>
    {
        /// <remarks> Each SummaryStatsValues element in the list defines the summary values to be accumulated for a statistical value.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SummaryStatsValues")]
        public SummaryStatsValuesType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The SummaryStatsValuesType defines the summary values to be
    /// accumulated for a statistical value.For example, the average Cpk
    /// and the worst(minimum) Cpk value over all characteristics may be summarized.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SummaryStatsValuesType
    {
        /// <remarks> The SummaryType element defines the type of summary value to
        /// which the list of accumulated statistics applies.</remarks>
        public SummaryStatsValuesEnumType SummaryType { get; set; }

        /// <remarks> The SummaryStats element defines a list of statistical values
        /// to be included in the summary of a statistical value.</remarks>
        public ListSummaryStatsValuesType SummaryStats { get; set; }
    }

    /// <remarks> The SummaryStatsValuesEnumType enumerates the various statistical values that can be accumulated on statistical values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SummaryStatsValuesEnumType
    {

        /// <remarks></remarks>
        AVG,

        /// <remarks></remarks>
        MAX,

        /// <remarks></remarks>
        MIN,

        /// <remarks></remarks>
        RANGE,

        /// <remarks></remarks>
        STDDEV,
    }
}
