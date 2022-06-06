/*! \file AverageFeaturesType.cs
    \brief defines a list of average features.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.Features.FeatureMeasurement;
using QIF_Model.QIFLibrary.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The AverageFeaturesType defines a list of average features./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AverageFeaturesType
    {
        /// <remarks Each AverageFeature element gives information about an average feature./>
        [System.Xml.Serialization.XmlElementAttribute("AverageFeature")]
        public AverageFeatureType[] AverageFeatures { get; set; }

        /// <remarks The required n attribute is the number of average features in the list./>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.AverageFeatures.Length;
            set { }
        }
    }

    /// <remarks The AverageFeatureType defines a feature measurement which is the average representation of a list of feature measurements./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AverageFeatureType
    {
        /// <remarks The FeatureMeasurement element is the average feature./>
        public FeatureMeasurementBaseType FeatureMeasurement { get; set; }

        /// <remarks The MeasuredIds element contains a list of ids of the feature
        /// measurements used to calculate the average feature and an
        /// optional set of exclusions from the list./>
        public StatsArrayIdType MeasuredIds { get; set; }
    }

    /// <remarks The StatsArrayIdType defines the set of QIF ids of measurements used in a statistical evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StatsArrayIdType
    {
        /// <remarks The Ids element is an array of QIF ids of measurements./>
        public ArrayReferenceType Ids { get; set; }

        /// <remarks The optional Exclusions element defines a list of QIF ids in
        /// the Ids array that is to be excluded from a statistical evaluation with reasons./>
        public ExclusionsIdType Exclusions { get; set; }
    }

    /// <remarks The ExclusionsIdType defines a list of measurement id exlusions./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionsIdType
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Exclusion")]
        public ExclusionIdType[] Exclusions { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("n")]
        public uint Count
        {
            get => (uint)this.Exclusions.Length;
            set { }
        }
    }

    /// <remarks The ExclusionIdType defines the QIF id of a measurement to be
    /// excluded from a statistical evaluation and the reason for that exclusion./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionIdType
    {
        /// <remarks The Id element is the QIF id of the measurement to be excluded./>
        public QIFReferenceType Id { get; set; }

        /// <remarks Each Reason element gives the reason why this measurement is being excluded./>
        public ExclusionReasonType Reason { get; set; }
    }

    /// <remarks The ExclusionReasonType defines the reason for excluding a measurement from statistical evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ExclusionReasonType
    {
        /// <remarks
        /// The ExclusionReasonEnum element describes an often-used reason for exclusion.
        /// The OtherExclusionReason element describes the reason for exclusion in natural language./>
        [System.Xml.Serialization.XmlElementAttribute("ExclusionReasonEnum", typeof(ExclusionEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherExclusionReason", typeof(string))]
        public object Item { get; set; }
    }

    /// <remarks The ExclusionEnumType enumerates values that describe the reasons for exclusion from a statistical calculation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum ExclusionEnumType
    {
        /// <remarks/>
        FLIER,

        /// <remarks/>
        EQUIPERROR,

        /// <remarks/>
        REWORK,

        /// <remarks/>
        KNOWNCAUSE,
    }
}
