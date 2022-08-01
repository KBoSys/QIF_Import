﻿/*! \file ProfileCharacteristicStatsEvalBaseType.cs
    \brief abstract base type that defines the results of a statistical evaluation of measured profile characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The OneSidedCapabilityCalculationEnumType enumerates values that
    /// describe methods of calculating capability for one-sided tolerances./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum OneSidedCapabilityCalculationEnumType
    {
        /// <remarks/>
        THREE_SIGMA,

        /// <remarks/>
        SIX_SIGMA,
    }

    /// <remarks The ProfileCharacteristicStatsEvalBaseType is the abstract base
    /// type that defines the results of a statistical evaluation of
    /// measured profile characteristics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileNonUniformCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointProfileCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ProfileCharacteristicStatsEvalBaseType : GeometricCharacteristicStatsEvalType
    {
        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance./>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }

        /// <remarks The optional WorstPositiveDeviationStats element is the
        /// result of a statistical evaluation of the worst positive deviation./>
        public StatsLinearType WorstPositiveDeviationStats { get; set; }

        /// <remarks The optional WorstNegativeDeviationStats element is the
        /// result of a statistical evaluation of the worst positive deviation./>
        public StatsLinearType WorstNegativeDeviationStats { get; set; }

        /// <remarks The optional PointDeviationsStats element is a list of the
        /// results of statistical evaluation of vector deviations of
        /// measurement points from nominal./>
        public PointDeviationsStatsEvalType PointDeviationsStats { get; set; }

        /// <remarks The optional DatumsOkStats element is the result of a
        /// statistical evaluation of DatumsOk flags./>
        public StatsPassFailType DatumsOkStats { get; set; }

        /// <remarks The optional CompositeSegmentsStats element is the results
        /// of a statistical evaluation of measured composite segments./>
        public CompositeSegmentsProfileStatsEvalType CompositeSegmentsStats { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceProfileNonUniformCharacteristicStatsEvalType : ProfileCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SurfaceProfileCharacteristicStatsEvalType : ProfileCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PointProfileCharacteristicStatsEvalType : ProfileCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LineProfileCharacteristicStatsEvalType : ProfileCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks The CompositeSegmentsProfileStatsEvalType defines a list that
    /// contains information about profile composite segment statistical evaluations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentsProfileStatsEvalType
    {
        /// <remarks The SecondCompositeSegmentProfileStats element gives
        /// information about the results of a statistical evaluation of
        /// the second segment of a composite frame profile characteristic./>
        public CompositeSegmentProfileStatsEvalType SecondCompositeSegmentProfileStats { get; set; }

        /// <remarks The optional ThirdCompositeSegmentProfileStats element gives
        /// information about the results of a statistical evaluation of
        /// the third segment of a composite frame profile characteristic./>
        public CompositeSegmentProfileStatsEvalType ThirdCompositeSegmentProfileStats { get; set; }

        /// <remarks The optional FourthCompositeSegmentProfileStats element gives
        /// information about the results of a statistical evaluation of
        /// the third segment of a composite frame profile characteristic.
        /// This element may be used only if the
        /// ThirdCompositeSegmentProfileStats element is used./>
        public CompositeSegmentProfileStatsEvalType FourthCompositeSegmentProfileStats { get; set; }
    }
}
