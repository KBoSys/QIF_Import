/*! \file FormCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured form characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks> The FormCharacteristicMeasurementBaseType is the abstract base type
    /// that defines the results of a measured form characteristic evaluation.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherFormCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ToroidicityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EllipticityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylindricityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularityCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatnessCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StraightnessCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class FormCharacteristicMeasurementBaseType : GeometricCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The OtherFormCharacteristicMeasurementType defines the results of a measured form characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OtherFormCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The ToroidicityCharacteristicMeasurementType defines the results of a measured toroidicity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidicityCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The SphericityCharacteristicMeasurementType defines the results of a measured sphericity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericityCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
        /// <remarks> The ZoneRadii element gives the inner and outer measured sizes of the evaluated sphericity tolerance zone.</remarks>
        public MeasuredZoneRadiiType ZoneRadii { get; set; }

        /// <remarks> The ZonePoint element is the measured point about which the evaluated sphericity tolerance zone is centered.</remarks>
        public PrimitivesPMI.MeasuredPointType ZonePoint { get; set; }
    }

    /// <remarks> The EllipticityCharacteristicMeasurementType defines the results of a measured ellipticity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class EllipticityCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The CylindricityCharacteristicMeasurementType defines the results of a measured cylindricity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CylindricityCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
        /// <remarks></remarks>
        public MeasuredLinearValueType? MaxCylindricity { get; set; }
        /// <remarks></remarks>
        public MeasuredZoneRadiiType ZoneRadii { get; set; }

        /// <remarks></remarks>
        public MeasuredZoneAxisType ZoneAxis { get; set; }
    }

    /// <remarks> The ConicityCharacteristicMeasurementType defines the results of a
    /// measured conicity characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicityCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
    }

    /// <remarks> The CircularityCharacteristicMeasurementType defines the results of
    /// a measured circularity or roundness characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CircularityCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
        /// <remarks> The optional MaxCircularity element is the measured overall
        /// feature circularity or roundness when a per-unit characteristic is used.</remarks>
        public MeasuredLinearValueType? MaxCircularity { get; set; }

        /// <remarks> The ZoneRadii element gives the inner and outer measured
        /// sizes of the evaluated circularity or roundness tolerance zone.</remarks>
        public MeasuredZoneRadiiType ZoneRadii { get; set; }

        /// <remarks> The ZonePlane element is the measured plane in which the
        /// evaluated circularity or roundness tolerance zone lies.</remarks>
        public MeasuredPlaneType ZonePlane { get; set; }
    }

    /// <remarks> The FlatnessCharacteristicMeasurementType defines the results of a
    /// measured flatness characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FlatnessCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
        /// <remarks> The optional Bonus element is the size of the applied bonus.</remarks>
        public MeasuredLinearValueType? Bonus { get; set; }

        /// <remarks> The optional MaxFlatness element is the measured overall
        /// feature flatness when a per-unit-area characteristic is used.</remarks>
        public MeasuredLinearValueType? MaxFlatness { get; set; }

        /// <remarks> The optional ZonePlane element is the measured mid-plane of the flatness tolerance zone.</remarks>
        public MeasuredPlaneType? ZonePlane { get; set; }
    }

    /// <remarks> The StraightnessCharacteristicMeasurementType defines the results
    /// of a measured straightness characteristic evaluation.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StraightnessCharacteristicMeasurementType : FormCharacteristicMeasurementBaseType
    {
        /// <remarks> The optional Bonus element is the size of the applied bonus.</remarks>
        public MeasuredLinearValueType? Bonus { get; set; }

        /// <remarks> The optional MaxStraightness element is the measured overall
        /// feature straightness when a per-unit-length characteristic is used.</remarks>
        public MeasuredLinearValueType? MaxStraightness { get; set; }

        /// <remarks> The optional ZoneOrientation element is the measured
        /// orientation of the plane(the plane normal) in which parallel-line shaped tolerance zone lies.</remarks>
        public PrimitivesPMI.MeasuredUnitVectorType? ZoneOrientation { get; set; }

        /// <remarks> The optional ZoneLine element is the measured mid-line of
        /// the parallel-line or cylinder shaped tolerance zone.</remarks>
        public MeasuredZoneAxisType? ZoneLine { get; set; }
    }
}
