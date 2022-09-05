/*! \file StatsWithReferenceBaseType.cs
    \brief abstract base type for statistical types that include a reference to an algorithm, software or standard.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System.Collections.Generic;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks> The StatsEnumType enumerates the various statistical values that can be accumulated.</remarks>
    public enum StatsValuesEnumType
    {
        TOTNUM,
        EFFNUM,
        NUMSUB,
        AVG,
        DIFF,
        RMS,
        MAX,
        MIN,
        RANGE,
        AVGRNG,
        STDDEV,
        SKEW,
        KURT,
        NORM,
        PROVAR,
        ESTSTDV,
        UCL,
        LCL,
        UCLRNG,
        LCLRNG,
        NUMOOC,
        NUMOOT,
        NOOTHI,
        NOOTLO,
        CP,
        CPK,
        PP,
        PPK,
        CM,
        CMK,
        CPM,
        AV,
        REL_AV,
        EV,
        REL_EV,
        INTERACTION,
        REL_INTERACTION,
        RANDR,
        REL_RANDR,
        PV,
        REL_PV,
        TV,
        REL_TV,
        LNRTY,
        BIAS,
        REL_LNRTY,
        REL_BIAS,
        R_SQR,
        SLOPE,
        INTCPT,
        UPRCONFLIM,
        LWRCONFLIM,
        TDIST,
    }

    /// <remarks> The ListSummaryStatsValuesListType defines a list of the statistical values to be used in a summary.</remarks>
    public class ListSummaryStatsValuesListType : List<StatsValuesEnumType>
    {
    }

    /// <remarks> The ListAccumulatedStatsValuesListType defines a list of the statistical values to be accumulated.</remarks>
    public class ListAccumulatedStatsValuesListType : List<StatsValuesEnumType>
    {
    }

    /// <remarks> The SubgroupStatsValuesEnumType enumerates the various statistical values that can be accumulated on a per-subgroup basis.</remarks>
    public enum SubgroupStatsValuesEnumType
    {
        TOTNUM,
        EFFNUM,
        AVG,
        DIFF,
        MAX,
        MIN,
        RANGE,
        NUMOOT,
        NOOTHI,
        NOOTLO,
    }

    /// <remarks> The ListSubgroupStatsValuesListType defines a list of the statistical values to be accumulated on a per-subgroup basis.</remarks>
    public class ListSubgroupStatsValuesListType : List<StatsValuesEnumType>
    {
    }

    /// <remarks> A StatsWithReferenceBaseType is the abstract base type for
    /// statistical types that include a reference to an algorithm, software or standard.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListSummaryStatsValuesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubgroupIntegersType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsNonNegativeIntegerType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsNonNegativeIntegerWithReferencesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SubgroupDecimalsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsMeasuredDecimalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsMeasuredDecimalWithReferenceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListSubgroupStatsValuesType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ListAccumulatedStatsValuesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class StatsWithReferenceBaseType
    {
        /// <remarks> This optional compositor provides a choice between a reference to software, a particular algorithm, or a standard.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AlgorithmId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("StandardId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public QIFReferenceType? ReferenceId { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsReferenceEnum ItemElementName { get; set; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum StatsReferenceEnum
    {
        /// <remarks></remarks>
        AlgorithmId,

        /// <remarks></remarks>
        SoftwareId,

        /// <remarks></remarks>
        StandardId,
    }

    /// <remarks> A ListSummaryStatsValuesType defines a list of the statistical
    /// values to be used in a summary and optionally defines the software,
    /// standard or specification, or algorithm to be used to evaluate the values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListSummaryStatsValuesType : StatsWithReferenceBaseType
    {
        /// <remarks> The Stats element is a list of one or more statistical values to be accumulated.</remarks>
        public ListSummaryStatsValuesListType? Stats { get; set; }
    }

    /// <remarks> The SubgroupIntegersType defines a list of SubgroupIntegerType and
    /// optionally defines the software, standard or specification, or algorithm to be used to determine the list of integers.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupIntegersType : StatsWithReferenceBaseType
    {
        /// <remarks> The Values element is the array of integer values associated with subgroup ids.</remarks>
        public SubgroupIntegerArrayType? Values { get; set; }
    }

    /// <remarks> A SubgroupIntegerArrayType defines a list of xs:positiveInteger
    /// types associated with particular subgroup ids.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupIntegerArrayType : ArrayBaseType<SubgroupIntegerType>
    {
        /// <remarks> Each SubgroupInteger element in the list defines an integer value associated with a subgroup id.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SubgroupInteger")]
        public SubgroupIntegerType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> A SubgroupIntegerType defines an xs:positiveInteger type associated with a particular subgroup id.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class SubgroupIntegerType : NonNegativeIntegerType
    {
        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; } = new QIFApplications.QIFIdType();

        /// <remarks> The required subgroupId attribute references the id of the subgroup with which this decimal value is associated.</remarks>
        [System.Xml.Serialization.XmlAttribute("subgroupId")]
        public uint SubgroupId { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks> The StatsNonNegativeIntegerType defines a non negative integer
    /// statistical result and optionally defines the software, standard
    /// or specification, or algorithm to be used to determine the non
    /// negative integer statistical result.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsNonNegativeIntegerWithReferencesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsNonNegativeIntegerType : StatsWithReferenceBaseType
    {
        /// <remarks> The Value element is the non negative integer statistical result.</remarks>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint Value { get; set; }
    }

    /// <remarks> The StatsNonNegativeIntegerWithReferencesType defines a non
    /// negative integer statistical result and optionally defines a list
    /// of references to QIF ids associated with this value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsNonNegativeIntegerWithReferencesType : StatsNonNegativeIntegerType
    {
        /// <remarks> The optional Ids element is the array of QIF id references.</remarks>
        public ArrayReferenceType? Ids { get; set; }
    }

    /// <remarks> The SubgroupDecimalsType defines a list of SubgroupDecimalType and
    /// optionally defines the software, standard or specification, or
    /// algorithm to be used to determine the array of measured values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupDecimalsType : StatsWithReferenceBaseType
    {
        /// <remarks> The Values element is the array of measured values associated with subgroup ids.</remarks>
        public SubgroupDecimalArrayType? Values { get; set; }
    }

    /// <remarks> A SubgroupDecimalArrayType defines a list of SubgroupDecimalType.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupDecimalArrayType : ArrayBaseType<SubgroupDecimalType>
    {
        /// <remarks> Each SubgroupDecimal element in the list defines a decimal value associated with a subgroup id.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SubgroupDecimal")]
        public SubgroupDecimalType[]? Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The StatsMeasuredDecimalType defines a numeric statistical result
    /// and optionally defines the software, standard or specification, or
    /// algorithm used to evaluate the value.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsMeasuredDecimalWithReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsMeasuredDecimalType : StatsWithReferenceBaseType
    {
        /// <remarks> The Value element is the numeric statistical result.</remarks>
        public MeasuredDecimalType? Value { get; set; }
    }

    /// <remarks> The StatsMeasuredDecimalWithReferenceType defines a numeric
    /// statistical result with an optional QIF id reference.For example,
    /// a maximum value may optionally reference the characteristic with the maximum value.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsMeasuredDecimalWithReferenceType : StatsMeasuredDecimalType
    {
        /// <remarks> The optional Id element is a reference to a QIF id associated with this statistical result.</remarks>
        public QIFReferenceType? Id { get; set; }
    }

    /// <remarks> A ListSubgroupStatsValuesType defines a list of the statistical
    /// values to be accumulated on a per-subgroup basis and optionally
    /// defines the software, standard or specification, or algorithm to be
    /// used to evaluate the values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListSubgroupStatsValuesType : StatsWithReferenceBaseType
    {
        /// <remarks> The Stats element is a list of one or more statistical values to be accumulated.</remarks>
        public ListSubgroupStatsValuesListType? Stats { get; set; }
    }

    /// <remarks> A ListAccumulatedStatsValuesType defines a list of the statistical
    /// values to be accumulated and optionally defines the software,
    /// standard or specification, or algorithm to be used to evaluate the values.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListAccumulatedStatsValuesType : StatsWithReferenceBaseType
    {
        /// <remarks> The Stats element is a list of one or more statistical values to be accumulated.</remarks>
        public ListAccumulatedStatsValuesListType? Stats { get; set; }
    }
}
