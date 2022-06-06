/*! \file OrientationCharacteristicStatsEvalType.cs
    \brief base type that defines the results of a statistical evaluation of measured orientation characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The OrientationCharacteristicStatsEvalType is the base type that
    /// defines the results of a statistical evaluation of measured
    /// orientation characteristics. The type itself can be used to
    /// accumulate summary statistics over different types of orientation characteristics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ParallelismCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerpendicularityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OrientationCharacteristicStatsEvalType : GeometricCharacteristicStatsEvalType
    {
        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance./>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks />
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }

        /// <remarks The optional DatumsOkStats element is the result of a statistical evaluation of DatumsOk flags./>
        public StatsPassFailType DatumsOkStats { get; set; }

        /// <remarks The optional BonusStats element is the result of a statistical evaluation of the applied bonus./>
        public StatsLinearType BonusStats { get; set; }

        /// <remarks The optional ReferenceLengthStats element is the result of
        /// a statistical evaluation of the measured length of the applied tolerance zone./>
        public StatsLinearType ReferenceLengthStats { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ParallelismCharacteristicStatsEvalType : OrientationCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PerpendicularityCharacteristicStatsEvalType : OrientationCharacteristicStatsEvalType
    {
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class AngularityCharacteristicStatsEvalType : OrientationCharacteristicStatsEvalType
    {
    }

}
