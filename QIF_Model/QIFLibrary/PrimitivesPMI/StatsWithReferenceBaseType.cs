/*! \file StatsWithReferenceBaseType.cs
    \brief abstract base type for statistical types that include a reference to an algorithm, software or standard.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The StatsEnumType enumerates the various statistical values that can be accumulated./>
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

    /// <remarks The ListSummaryStatsValuesListType defines a list of the statistical values to be used in a summary./>
    public class ListSummaryStatsValuesListType : List<StatsValuesEnumType>
    {
    }

    /// <remarks The ListAccumulatedStatsValuesListType defines a list of the statistical values to be accumulated./>
    public class ListAccumulatedStatsValuesListType : List<StatsValuesEnumType>
    {
    }

    /// <remarks The SubgroupStatsValuesEnumType enumerates the various statistical values that can be accumulated on a per-subgroup basis./>
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

    /// <remarks The ListSubgroupStatsValuesListType defines a list of the statistical values to be accumulated on a per-subgroup basis./>
    public class ListSubgroupStatsValuesListType : List<StatsValuesEnumType>
    {
    }

    /// <remarks A StatsWithReferenceBaseType is the abstract base type for
    /// statistical types that include a reference to an algorithm, software or standard./>
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
        /// <remarks This optional compositor provides a choice between a reference to software, a particular algorithm, or a standard./>
        [System.Xml.Serialization.XmlElementAttribute("AlgorithmId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("SoftwareId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("StandardId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public QIFReferenceType ReferenceId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public StatsReferenceEnum ItemElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum StatsReferenceEnum
    {
        /// <remarks/>
        AlgorithmId,

        /// <remarks/>
        SoftwareId,

        /// <remarks/>
        StandardId,
    }

    /// <remarks A ListSummaryStatsValuesType defines a list of the statistical
    /// values to be used in a summary and optionally defines the software,
    /// standard or specification, or algorithm to be used to evaluate the values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListSummaryStatsValuesType : StatsWithReferenceBaseType
    {
        /// <remarks The Stats element is a list of one or more statistical values to be accumulated./>
        public ListSummaryStatsValuesListType Stats { get; set; }
    }

    /// <remarks The SubgroupIntegersType defines a list of SubgroupIntegerType and
    /// optionally defines the software, standard or specification, or algorithm to be used to determine the list of integers./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupIntegersType : StatsWithReferenceBaseType
    {
        /// <remarks The Values element is the array of integer values associated with subgroup ids./>
        public SubgroupIntegerArrayType Values { get; set; }
    }

    /// <remarks A SubgroupIntegerArrayType defines a list of xs:positiveInteger
    /// types associated with particular subgroup ids./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupIntegerArrayType
    {
        /// <remarks Each SubgroupInteger element in the list defines an integer value associated with a subgroup id./>
        [System.Xml.Serialization.XmlElementAttribute("SubgroupInteger")]
        public SubgroupIntegerType[] Items { get; set; }

        /// <remarks The required n attribute is the number of values in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks A SubgroupIntegerType defines an xs:positiveInteger type associated with a particular subgroup id./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot()]
    public partial class SubgroupIntegerType : NonNegativeIntegerType
    {
        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required subgroupId attribute references the id of the subgroup with which this decimal value is associated./>
        [System.Xml.Serialization.XmlAttribute("subgroupId")]
        public uint SubgroupId { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks The StatsNonNegativeIntegerType defines a non negative integer
    /// statistical result and optionally defines the software, standard
    /// or specification, or algorithm to be used to determine the non
    /// negative integer statistical result./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsNonNegativeIntegerWithReferencesType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsNonNegativeIntegerType : StatsWithReferenceBaseType
    {
        /// <remarks The Value element is the non negative integer statistical result./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public NonNegativeIntegerType Value { get; set; }
    }

    /// <remarks The StatsNonNegativeIntegerWithReferencesType defines a non
    /// negative integer statistical result and optionally defines a list
    /// of references to QIF ids associated with this value./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsNonNegativeIntegerWithReferencesType : StatsNonNegativeIntegerType
    {
        /// <remarks The optional Ids element is the array of QIF id references./>
        public ArrayReferenceType Ids { get; set; }
    }

    /// <remarks The SubgroupDecimalsType defines a list of SubgroupDecimalType and
    /// optionally defines the software, standard or specification, or
    /// algorithm to be used to determine the array of measured values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupDecimalsType : StatsWithReferenceBaseType
    {
        /// <remarks The Values element is the array of measured values associated with subgroup ids./>
        public SubgroupDecimalArrayType Values { get; set; }
    }

    /// <remarks A SubgroupDecimalArrayType defines a list of SubgroupDecimalType./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SubgroupDecimalArrayType
    {
        /// <remarks Each SubgroupDecimal element in the list defines a decimal value associated with a subgroup id./>
        [System.Xml.Serialization.XmlElementAttribute("SubgroupDecimal")]
        public SubgroupDecimalType[] Items { get; set; }

        /// <remarks The required n attribute is the number of values in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Items.Length;
            set { }
        }
    }

    /// <remarks The StatsMeasuredDecimalType defines a numeric statistical result
    /// and optionally defines the software, standard or specification, or
    /// algorithm used to evaluate the value./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatsMeasuredDecimalWithReferenceType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsMeasuredDecimalType : StatsWithReferenceBaseType
    {
        /// <remarks The Value element is the numeric statistical result./>
        public MeasuredDecimalType Value { get; set; }
    }

    /// <remarks The StatsMeasuredDecimalWithReferenceType defines a numeric
    /// statistical result with an optional QIF id reference.For example,
    /// a maximum value may optionally reference the characteristic with the maximum value./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsMeasuredDecimalWithReferenceType : StatsMeasuredDecimalType
    {
        /// <remarks The optional Id element is a reference to a QIF id associated with this statistical result./>
        public QIFReferenceType Id { get; set; }
    }

    /// <remarks A ListSubgroupStatsValuesType defines a list of the statistical
    /// values to be accumulated on a per-subgroup basis and optionally
    /// defines the software, standard or specification, or algorithm to be
    /// used to evaluate the values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListSubgroupStatsValuesType : StatsWithReferenceBaseType
    {
        /// <remarks The Stats element is a list of one or more statistical values to be accumulated./>
        public ListSubgroupStatsValuesListType Stats { get; set; }
    }

    /// <remarks A ListAccumulatedStatsValuesType defines a list of the statistical
    /// values to be accumulated and optionally defines the software,
    /// standard or specification, or algorithm to be used to evaluate the values./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ListAccumulatedStatsValuesType : StatsWithReferenceBaseType
    {
        /// <remarks The Stats element is a list of one or more statistical values to be accumulated./>
        public ListAccumulatedStatsValuesListType Stats { get; set; }
    }
}
