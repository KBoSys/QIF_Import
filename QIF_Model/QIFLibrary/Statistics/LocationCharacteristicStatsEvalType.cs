/*! \file LocationCharacteristicStatsEvalType.cs
    \brief base type that defines the results of a statistical evaluation of measured location characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The LocationCharacteristicStatsEvalType is the base type that
    /// defines the results of a statistical evaluation of measured location
    /// characteristics. The type itself can be used to accumulate summary
    /// statistics over different types of location characteristics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SymmetryCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcentricityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoaxialityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LocationCharacteristicStatsEvalType : GeometricCharacteristicStatsEvalType
    {
        /// <remarks The optional DatumsOkStats element is the result of a statistical evaluation of DatumsOk flags./>
        public StatsPassFailType DatumsOkStats { get; set; }
    }

    /// <remarks The SymmetryCharacteristicStatsEvalType defines the results of a
    /// statistical evaluation of measured symmetry characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SymmetryCharacteristicStatsEvalType : LocationCharacteristicStatsEvalType
    {
        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance./>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }

        /// <remarks The optional CompositeSegmentsStats element is the results of a statistical evaluation of measured composite segments./>
        public CompositeSegmentsSymmetryStatsEvalType CompositeSegmentsStats { get; set; }
    }

    /// <remarks The ConcentricityCharacteristicStatsEvalType defines the results of a statistical evaluation of measured concentricity characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConcentricityCharacteristicStatsEvalType : LocationCharacteristicStatsEvalType
    {
        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance./>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }
    }

    /// <remarks The CoaxialityCharacteristicStatsEvalType defines the results of
    /// a statistical evaluation of measured coaxiality characteristics
    /// (ISO specific characteristic type)./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CoaxialityCharacteristicStatsEvalType : LocationCharacteristicStatsEvalType
    {
        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance./>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }
    }

    /// <remarks The PositionCharacteristicStatsEvalType defines the results of a
    /// statistical evaluation of measured position characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PositionCharacteristicStatsEvalType : LocationCharacteristicStatsEvalType
    {
        /// <remarks The optional BonusStats element is the result of a
        /// statistical evaluation of the applied bonus./>
        public StatsLinearType BonusStats { get; set; }

        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this position tolerance zone./>
        public PositionCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }

        /// <remarks The optional CompositeSegmentsStats element is the results
        /// of a statistical evaluation of measured composite segments./>
        public CompositeSegmentsPositionStatsEvalType CompositeSegmentsStats { get; set; }
    }

    /// <remarks The PositionCapabilityCalculationEnumType enumerates values that
    /// describe methods of calculating capability for position tolerances./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum PositionCapabilityCalculationEnumType
    {
        /// <remarks/>
        THREE_SIGMA,

        /// <remarks/>
        SIX_SIGMA,

        /// <remarks/>
        BIVARIATE,

        /// <remarks/>
        TRIVARIATE,
    }

    /// <remarks The CompositeSegmentsPositionStatsEvalType defines a list that
    /// contains information about position composite segment statistical evaluations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentsPositionStatsEvalType
    {
        /// <remarks The SecondCompositeSegmentPositionStats element gives
        /// information about the results of a statistical evaluation of
        /// the second segment of a composite frame position characteristic./>
        public CompositeSegmentPositionStatsEvalType SecondCompositeSegmentPositionStats { get; set; }

        /// <remarks The optional ThirdCompositeSegmentPositionStats element gives
        /// information about the results of a statistical evaluation of
        /// the third segment of a composite frame position characteristic./>
        public CompositeSegmentPositionStatsEvalType ThirdCompositeSegmentPositionStats { get; set; }

        /// <remarks The optional FourthCompositeSegmentPositionStats element gives
        /// information about the results of a statistical evaluation of
        /// the third segment of a composite frame position characteristic.
        /// This element may be used only if the ThirdCompositeSegmentPositionStats element is used./>
        public CompositeSegmentPositionStatsEvalType FourthCompositeSegmentPositionStats { get; set; }
    }

    /// <remarks The CompositeSegmentsSymmetryStatsEvalType element defines a list
    /// that contains information about symmetry composite segment statistical evaluations./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CompositeSegmentsSymmetryStatsEvalType
    {
        /// <remarks The SecondCompositeSegmentSymmetryStats element gives
        /// information about the results of a statistical evaluation of
        /// the second segment of a composite frame symmetry characteristic./>
        public CompositeSegmentSymmetryStatsEvalType SecondCompositeSegmentSymmetryStats { get; set; }

        /// <remarks The optional ThirdCompositeSegmentSymmetryStats element gives
        /// information about the results of a statistical evaluation of
        /// the third segment of a composite frame symmetry characteristic./>
        public CompositeSegmentSymmetryStatsEvalType ThirdCompositeSegmentSymmetryStats { get; set; }
    }
}
