/*! \file StatsValuesType.cs
    \brief defines the set of measurement values used in a statistical evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The StatsValuesType defines the set of measurement values used in a
    /// statistical evaluation. The type and units of the values are
    /// determined by the type of the characteristic evaluation, e.g.
    /// linear, angular, etc.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsValuesType
    {
        /// <remarks> The Values element is a list of measurement values.</remarks>
        public ListTokenType Values { get; set; }

        /// <remarks> The optional Exclusions element defines a list of indexes of
        /// measured values in the Values list that is to be excluded from a
        /// statistical evaluation with reasons.</remarks>
        public ExclusionsIndexType Exclusions { get; set; }
    }

    /// <remarks> The ExclusionsIndexType defines a list of measured value indexes exlusions.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionsIndexType
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Exclusion")]
        public ExclusionIndexType[] Exclusions { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Exclusions.Length;
            set { }
        }
    }

    /// <remarks> The ExclusionIndexType defines the index of a measured value in a
    /// list to be excluded from a statistical evaluation and the reason
    /// for that exclusion.Index values start at 1.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionIndexType
    {
        /// <remarks> The Index element is the index of the measuremed value to be excluded.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint Index { get; set; }

        /// <remarks> Each Reason element gives the reason why this measurement is being excluded.</remarks>
        public ExclusionReasonType Reason { get; set; }
    }

    /// <remarks> The SubgroupsType defines a list of measured value subgroups.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupValuesType
    {
        /// <remarks> Each Subgroup element contains a list of the characteristic
        /// measurement values used in a subgroup in this statistical evaluation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("Subgroup")]
        public StatsValuesType[] Subgroups { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Subgroups.Length;
            set { }
        }
    }
}
