/*! \file StatisticalStudyPlanBaseType.cs
    \brief abstract base type that defines information common to all statistical study plans.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Traceability;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks> The StatisticalStudyPlanBaseType is the abstract base type that defines information common to all statistical study plans.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GageRandRStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleProductInstanceStudyPlanBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductionStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilityStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiasStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProcessDifferenceStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirstArticleStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StabilityStudyPlanType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearityStudyPlanType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class StatisticalStudyPlanBaseType
    {
        /// <remarks> The optional Version element gives version information about the statistical study.</remarks>
        public VersionType Version { get; set; }

        /// <remarks> The optional Attributes element contains user defined attributes(typified, binary array, or XML structured).</remarks>
        public AttributesType Attributes { get; set; }

        /// <remarks> The FeatureItemIds element is the list of feature items to be included in this statistical study.</remarks>
        public ArrayReferenceType FeatureItemIds { get; set; }

        /// <remarks> The optional CalculateAverageFeatures element when
        /// present and set true signifies that average features are
        /// to be calculated in this statistical study.</remarks>
        public bool CalculateAverageFeatures { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalculateAverageFeaturesSpecified { get; set; }

        /// <remarks> The CharacteristicItemIds element is the list of
        /// characteristic items to be included in this statistical study.</remarks>
        public ArrayReferenceType CharacteristicItemIds { get; set; }

        /// <remarks> Each optional StatsValuesPerChar element identifies the
        /// various statistical values to be accumulated on a
        /// per-characteristic basis in this statistical study plan.For
        /// example, the Cpk of each characteristic might be accumulated.
        /// Each optional StatsValuesPerChar element also optionally
        /// identifies the statistical software to use for the evaluation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("StatsValuesPerChar")]
        public ListAccumulatedStatsValuesType[] StatsValuesPerChar { get; set; }

        /// <remarks> Each optional StatsValuesPerSubgroup element identifies
        /// the various statistical values to be accumulated on a
        /// per-subgroup basis for this statistical study plan.For
        /// example, the average value of each characteristic might
        /// be accumulated for each subgroup.Each optional
        /// StatsValuesPerSubgroup element also optionally identifies the
        /// statistical software to use for the evaluation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("StatsValuesPerSubgroup")]
        public ListSubgroupStatsValuesType[] StatsValuesPerSubgroup { get; set; }

        /// <remarks> Each optional StatsValuesSummarys element identifies a list of
        /// statistical values to be summarized over all characteristics in
        /// this statistical study plan.For example, the Cpk value over
        /// all characteristics might be summarized.Each optional
        /// StatsValuesSummarys element also optionally identifies the
        /// statistical software to use for the evaluation.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("StatsValuesSummarys")]
        public SummaryStatsValuesListType[] StatsValuesSummarys { get; set; }

        /// <remarks> The optional PreInspectionTraceability element gives
        /// traceability information that applies to the statistical study.</remarks>
        public PreInspectionTraceabilityType PreInspectionTraceability { get; set; }

        /// <remarks> The optional Name element is the name identifying the statistical study.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name { get; set; }

        /// <remarks> The optional Description element is a description of the statistical study.</remarks>
        public string Description { get; set; }

        /// <remarks> The optional PlanId element is the QIF id of the associated measurement plan.</remarks>
        public QIFReferenceType PlanId { get; set; }

        /// <remarks> This optional compositor provides a choice between software, or a standard of specification.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("SoftwareId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("StandardId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public QIFReferenceType Item { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftwareOrStandardEnum ItemElementName { get; set; }

        /// <remarks> The optional CorrectiveActionPlanId element is the QIF id of a corrective action plan.</remarks>
        public QIFReferenceType CorrectiveActionPlanId { get; set; }

        /// <remarks> The QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks> The id attribute is the QIF id of the feature, used for referencing.</remarks>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum SoftwareOrStandardEnum
    {
        /// <remarks></remarks>
        SoftwareId,

        /// <remarks></remarks>
        StandardId,
    }
}
