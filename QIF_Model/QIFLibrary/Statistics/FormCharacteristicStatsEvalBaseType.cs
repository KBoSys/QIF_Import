/*! \file FormCharacteristicStatsEvalBaseType.cs
    \brief abstract base type that defines the results of a statistical evaluation of measured form characteristics.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Statistics
{
    /// <remarks The FormCharacteristicStatsEvalBaseType is the abstract base type
    /// that defines the results of a statistical evaluation of measured form characteristics./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherFormCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidicityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StraightnessCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatnessCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicityCharacteristicStatsEvalType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularityCharacteristicStatsEvalType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FormCharacteristicStatsEvalBaseType : GeometricCharacteristicStatsEvalType
    {
        /// <remarks The optional CapabilityCalculationMethod element is the
        /// method used to calculate process capability for this one-sided tolerance./>
        public OneSidedCapabilityCalculationEnumType CapabilityCalculationMethod { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CapabilityCalculationMethodSpecified { get; set; }
    }

    /// <remarks The OtherFormCharacteristicStatsEvalType defines the results of a statistical evaluation of measured form characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherFormCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks The ToroidicityCharacteristicStatsEvalType defines the results of a
    /// statistical evaluation of measured toroidicity characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidicityCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks The StraightnessCharacteristicStatsEvalType defines the results of a statistical evaluation of measured straightness characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StraightnessCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
        /// <remarks The optional BonusStats element is the result of a statistical evaluation of the applied bonus./>
        public StatsLinearType BonusStats { get; set; }

        /// <remarks The optional MaxStraightnessStats element is result of a
        /// statistical evaluation of the measured overall feature
        /// straightness when a per-unit-length characteristic is used./>
        public StatsLinearType MaxStraightnessStats { get; set; }
    }

    /// <remarks The SphericityCharacteristicStatsEvalType defines the results of a statistical evaluation of measured sphericity characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericityCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks The FlatnessCharacteristicStatsEvalType defines the results of a
    /// statistical evaluation of measured flatness characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FlatnessCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
        /// <remarks The optional BonusStats element is the result of a statistical evaluation of the applied bonus./>
        public StatsLinearType BonusStats { get; set; }

        /// <remarks The optional MaxFlatnessStats element is result of a
        /// statistical evaluation of the measured overall feature
        /// flatness when a per-unit-area characteristic is used./>
        public StatsLinearType MaxFlatnessStats { get; set; }
    }

    /// <remarks The EllipticityCharacteristicStatsEvalType defines the results of a    statistical evaluation of measured ellipticity characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticityCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks The CylindricityCharacteristicStatsEvalType defines the results of a statistical evaluation of measured cylindricity characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricityCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
        /// <remarks/>
        public StatsLinearType MaxCylindricityStats { get; set; }
    }

    /// <remarks The ConicityCharacteristicStatsEvalType defines the results of a statistical evaluation of measured conicity characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicityCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
    }

    /// <remarks The CircularityCharacteristicStatsEvalType defines the results of a
    /// statistical evaluation of measured circularity or roundness characteristics./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularityCharacteristicStatsEvalType : FormCharacteristicStatsEvalBaseType
    {
        /// <remarks The optional MaxCircularityStats element is result of a
        /// statistical evaluation of the measured overall feature
        /// circularity or roundness when a per-unit-angle characteristic is used./>
        public StatsLinearType MaxCircularityStats { get; set; }
    }
}
