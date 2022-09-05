/*! \file AverageFeaturesType.cs
    \brief defines a list of average features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.FeatureMeasurement;
using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks> The AverageFeaturesType defines a list of average features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AverageFeaturesType : ArrayBaseType<AverageFeatureType>
    {
        /// <remarks> Each AverageFeature element gives information about an average feature.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("AverageFeature")]
        public AverageFeatureType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The AverageFeatureType defines a feature measurement which is the average representation of a list of feature measurements.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AverageFeatureType
    {
        /// <remarks> The FeatureMeasurement element is the average feature.</remarks>
        public FeatureMeasurementBaseType FeatureMeasurement { get; set; }

        /// <remarks> The MeasuredIds element contains a list of ids of the feature
        /// measurements used to calculate the average feature and an
        /// optional set of exclusions from the list.</remarks>
        public StatsArrayIdType MeasuredIds { get; set; }
    }

    /// <remarks> The StatsArrayIdType defines the set of QIF ids of measurements used in a statistical evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsArrayIdType
    {
        /// <remarks> The Ids element is an array of QIF ids of measurements.</remarks>
        public ArrayReferenceType? Ids { get; set; }

        /// <remarks> The optional Exclusions element defines a list of QIF ids in
        /// the Ids array that is to be excluded from a statistical evaluation with reasons.</remarks>
        public ExclusionsIdType Exclusions { get; set; }
    }

    /// <remarks> The ExclusionsIdType defines a list of measurement id exlusions.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionsIdType : ArrayBaseType<ExclusionIdType>
    {
        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("Exclusion")]
        public ExclusionIdType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks> The ExclusionIdType defines the QIF id of a measurement to be
    /// excluded from a statistical evaluation and the reason for that exclusion.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionIdType
    {
        /// <remarks> The Id element is the QIF id of the measurement to be excluded.</remarks>
        public QIFReferenceType? Id { get; set; }

        /// <remarks> Each Reason element gives the reason why this measurement is being excluded.</remarks>
        public ExclusionReasonType Reason { get; set; }
    }

    /// <remarks> The ExclusionReasonType defines the reason for excluding a measurement from statistical evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionReasonType
    {
        /// <remarks>
        /// The ExclusionReasonEnum element describes an often-used reason for exclusion.
        /// The OtherExclusionReason element describes the reason for exclusion in natural language.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("ExclusionReasonEnum", typeof(ExclusionEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherExclusionReason", typeof(string))]
        public object? Item { get; set; }
    }

    /// <remarks> The ExclusionEnumType enumerates values that describe the reasons for exclusion from a statistical calculation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ExclusionEnumType
    {
        /// <remarks></remarks>
        FLIER,

        /// <remarks></remarks>
        EQUIPERROR,

        /// <remarks></remarks>
        REWORK,

        /// <remarks></remarks>
        KNOWNCAUSE,
    }
}
