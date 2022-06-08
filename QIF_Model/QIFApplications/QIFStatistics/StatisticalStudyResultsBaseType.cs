/*! \file StatisticalStudyResultsBaseType.cs
    \brief abstract base type that defines information common to all statistical study results.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.IntermediatesPMI;
using QIF_Model.QIFLibrary.Primitives;
using QIF_Model.QIFLibrary.Statistics;
using QIF_Model.QIFLibrary.Traceability;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFApplications.QIFStatistics
{
    /// <remarks The StatisticalStudyResultsBaseType is the abstract base type that defines information common to all statistical study results./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GageRandRStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MultipleProductInstanceStudyResultsBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductionStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilityStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProcessDifferenceStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FirstArticleStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BiasStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StabilityStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearityStudyResultsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class StatisticalStudyResultsBaseType
    {
        /// <remarks The optional ThisStatisticalStudyResultsInstanceQPId element
        /// uniquely identifies the statistical study results.Different
        /// versions of the results must have different
        /// ThisStatisticalStudyResultsInstanceQPId elements./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public QPIdType ThisStatisticalStudyResultsInstanceQPId { get; set; }

        /// <remarks The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks The Status element is the overall status of the statistical study./>
        public StatsEvalStatusType Status { get; set; }

        /// <remarks
        /// - The SoftwareId element is the id of the software used to evaluate the statistical values in these results.
        ///   This value can be overridden by the value on any particular instance of CharacteristicsStats or on any individual statistical value.
        /// - The StandardId element is the id of the standard or specification used to evaluate the statistical values in
        ///   these results.This value can be overridden by the value on any particular instance of CharacteristicsStats or on any individual statistical value./>
        [System.Xml.Serialization.XmlElementAttribute("SoftwareId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("StandardId", typeof(QIFReferenceType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public QIFReferenceType Item { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SoftwareOrStandardEnum ItemElementName { get; set; }

        /// <remarks The optional StudyIssues element defines a list that provides details about any issues encountered in the study.  />
        public StudyIssuesType StudyIssues { get; set; }

        /// <remarks The optional InspectionTraceability element gives traceability information that applies to the statistical study results./>
        public InspectionTraceabilityType InspectionTraceability { get; set; }

        /// <remarks The optional Name element is the name identifying the statistical study results./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Name { get; set; }

        /// <remarks The optional Description element is a description of the statistical study results./>
        public string Description { get; set; }

        /// <remarks The optional StudyId element is the QIF id of the associated statistical study plan./>
        public QIFReferenceType StudyId { get; set; }

        /// <remarks This optional compositor provides a choice between QIF sources
        /// of measurement results(either internal or external) or other, external sources of measurement results./>
        [System.Xml.Serialization.XmlElementAttribute("ResultsFiles", typeof(ExternalFileReferencesType))]
        [System.Xml.Serialization.XmlElementAttribute("ResultsIds", typeof(ArrayReferenceType))]
        [System.Xml.Serialization.XmlElementAttribute("ResultsQPIds", typeof(ArrayQPIdFullReferenceType))]
        public object[] QIFSources { get; set; }

        /// <remarks The optional AverageFeatures element is a list of the results of average feature calculations./>
        public AverageFeaturesType AverageFeatures { get; set; }

        /// <remarks The optional CharacteristicsStats element contains a list of results of statistical analysis for one or more characteristics./>
        public CharacteristicsStatsType CharacteristicsStats { get; set; }

        /// <remarks The optional LinearStatsSummary element contains a list of the
        /// results of statistical summaries for characteristic statistics with linear units./>
        public SummariesStatisticsLinearType LinearStatsSummaries { get; set; }

        /// <remarks The optional AngularStatsSummaries element contains a list of
        /// the results of statistical summaries for characteristic statistics with angular units./>
        public SummariesStatisticsAngularType AngularStatsSummaries { get; set; }

        /// <remarks The optional AreaStatsSummaries element contains a list of the
        /// results of statistical summaries for characteristic statistics with area units./>
        public SummariesStatisticsAreaType AreaStatsSummaries { get; set; }

        /// <remarks The optional ForceStatsSummaries element contains a list of the
        /// results of statistical summaries for characteristic statistics with force units./>
        public SummariesStatisticsForceType ForceStatsSummaries { get; set; }

        /// <remarks The optional MassStatsSummaries element contains a list of the
        /// results of statistical summaries for characteristic statistics with mass units./>
        public SummariesStatisticsMassType MassStatsSummaries { get; set; }

        /// <remarks The optional PressureStatsSummaries element contains a list of
        /// the results of statistical summaries for characteristic statistics with pressure units./>
        public SummariesStatisticsPressureType PressureStatsSummaries { get; set; }

        /// <remarks The optional SpeedStatsSummaries element contains a list of the
        /// results of statistical summaries for characteristic statistics with speed units./>
        public SummariesStatisticsSpeedType SpeedStatsSummaries { get; set; }

        /// <remarks The optional TemperatureStatsSummaries element contains a list
        /// of the results of statistical summaries for characteristic statistics with temperature units./>
        public SummariesStatisticsTemperatureType TemperatureStatsSummaries { get; set; }

        /// <remarks The optional TimeStatsSummaries element contains a list of the
        /// results of statistical summaries for characteristic statistics with time units./>
        public SummariesStatisticsTimeType TimeStatsSummaries { get; set; }

        /// <remarks The optional UserDefinedUnitStatsSummaries element contains a
        /// list of the results of statistical summaries for characteristic
        /// statistics with user defined units.This element is not to be
        /// used to define summaries with units available in another
        /// element. In particular this element is not to be used to define
        /// summaries with linear units, angular units, or units of
        /// temperature, area, force, mass, pressure, speed, or time./>
        public SummariesStatisticsUserDefinedUnitType UserDefinedUnitStatsSummaries { get; set; }

        /// <remarks The optional StatsSummaries element contains a list of the
        /// results of statistical summaries for characteristic statistics with dimensionless units./>
        public SummariesStatisticsType StatsSummaries { get; set; }

        /// <remarks The QIF id of the feature, used for referencing./>
        [System.Xml.Serialization.XmlIgnore]
        public QIFApplications.QIFIdType QIFID { get; set; }

        /// <remarks The required id attribute is the QIF id of the statistical study results, used for referencing./>
        [System.Xml.Serialization.XmlAttribute("id")]
        public uint Id { get => this.QIFID; set => this.QIFID = value; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class GageRandRStudyResultsType : StatisticalStudyResultsBaseType
    {
        /// <remarks/>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfAppraisers { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfParts { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfTrials { get; set; }
    }

    /// <remarks The MultipleProductInstanceStudyResultsBaseType is the abstract
    /// base type that defines information common to the results of all
    /// statistical studies involving multiple part measurements./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProductionStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilityStudyResultsType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SimpleStudyResultsType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class MultipleProductInstanceStudyResultsBaseType : StatisticalStudyResultsBaseType
    {
        /// <remarks The NumberOfSamples element specifies the number of samples used in the statistical study./>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfSamples { get; set; }

        /// <remarks The optional SubgroupSize element is the size of each
        /// subgroup used in the statistical study./>
        [System.Xml.Serialization.XmlElementAttribute()]
        [System.ComponentModel.DefaultValueAttribute(0)]
        public uint SubgroupSize { get; set; } = 0;
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProductionStudyResultsType : MultipleProductInstanceStudyResultsBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlIssueDetailsList")]
        public ControlIssueDetailsListType[] ControlIssueDetailsList { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CapabilityStudyResultsType : MultipleProductInstanceStudyResultsBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SimpleStudyResultsType : MultipleProductInstanceStudyResultsBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ProcessDifferenceStudyResultsType : StatisticalStudyResultsBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint NumberOfSamples { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SubgroupSize { get; set; } = 2;

        /// <remarks/>
        public QIFReferenceType ManufacturingProcessId { get; set; }

        /// <remarks/>
        public AbsoluteMeasurementsByUnitType AbsoluteDifferences { get; set; }

        /// <remarks/>
        public MeasuredDecimalType RelativeDifference { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FirstArticleStudyResultsType : StatisticalStudyResultsBaseType
    {
        /// <remarks/>
        public decimal InSpecRatio { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InSpecRatioSpecified { get; set; }

        /// <remarks/>
        public AbsoluteMeasurementsByUnitType AbsoluteMaximums { get; set; }

        /// <remarks/>
        public MeasuredDecimalType RelativeMaximum { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class BiasStudyResultsType : StatisticalStudyResultsBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SampleSize { get; set; }

        /// <remarks/>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StabilityStudyResultsType : StatisticalStudyResultsBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SampleSize { get; set; }

        /// <remarks/>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearityStudyResultsType : StatisticalStudyResultsBaseType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute()]
        public uint SampleSize { get; set; }

        /// <remarks/>
        public ArrayReferenceType MeasurementDeviceIds { get; set; }

        /// <remarks/>
        public MeasuredDecimalType GoodnessOfFit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AngularAbsoluteLinearity", typeof(MeasuredAngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("AreaAbsoluteLinearity", typeof(MeasuredAreaValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ForceAbsoluteLinearity", typeof(MeasuredForceValueType))]
        [System.Xml.Serialization.XmlElementAttribute("LinearAbsoluteLinearity", typeof(MeasuredLinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MassAbsoluteLinearity", typeof(MeasuredMassValueType))]
        [System.Xml.Serialization.XmlElementAttribute("PressureAbsoluteLinearity", typeof(MeasuredPressureValueType))]
        [System.Xml.Serialization.XmlElementAttribute("SpeedAbsoluteLinearity", typeof(MeasuredSpeedValueType))]
        [System.Xml.Serialization.XmlElementAttribute("TemperatureAbsoluteLinearity", typeof(MeasuredTemperatureValueType))]
        [System.Xml.Serialization.XmlElementAttribute("TimeAbsoluteLinearity", typeof(MeasuredTimeValueType))]
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedUnitAbsoluteLinearity", typeof(MeasuredUserDefinedUnitValueType))]
        public MeasuredDecimalType Item1 { get; set; }

        /// <remarks/>
        public MeasuredDecimalType RelativeLinearity { get; set; }
    }
}
