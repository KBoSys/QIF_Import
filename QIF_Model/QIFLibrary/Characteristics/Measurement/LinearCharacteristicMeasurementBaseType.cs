/*! \file LinearCharacteristicMeasurementBaseType.cs
    \brief abstract base type that defines the results of a measured linear characteristic evaluation.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using QIF_Model.QIFLibrary.PrimitivesPMI;
using QIF_Model.QIFLibrary.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Measurement
{
    /// <remarks The LinearCharacteristicMeasurementBaseType is the abstract base
    /// type that defines the results of a measured linear characteristic evaluation./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatTaperCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalTaperCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChordCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalRadiusCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RadiusCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBetweenCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceFromCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThicknessCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DepthCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HeightCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WidthCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalDiameterCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiameterCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveLengthCharacteristicMeasurementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedLinearCharacteristicMeasurementType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LinearCharacteristicMeasurementBaseType : DimensionalCharacteristicMeasurementBaseType<MeasuredLinearValueType>
    {
    }

    /// <remarks The FlatTaperCharacteristicMeasurementType defines the results of a measured flat taper characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FlatTaperCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
        /// <remarks The optional Distance element is the measured distance over which the slope applies./>
        public MeasuredLinearValueType Distance { get; set; }
    }

    /// <remarks The ConicalTaperCharacteristicMeasurementType defines the results of a measured conical taper characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalTaperCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
        /// <remarks The optional Distance element is the measured distance over which the taper applies./>
        public MeasuredLinearValueType Distance { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ChordCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The ChordCharacteristicMeasurementType defines the results of a measured chord characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalRadiusCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The RadiusCharacteristicMeasurementType defines the results of a measured radius characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class RadiusCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The DistanceBetweenCharacteristicMeasurementType defines the results of a measured distance-between characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistanceBetweenCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
        /// <remarks The optional AnalysisVector element used by the
        /// AnalysisMode defines the point-to-point direction, the
        /// direction along which, or the plane normal in which the
        /// distance-between characteristic was evaluated./>
        public MeasuredUnitVectorType AnalysisVector { get; set; }
    }

    /// <remarks The DistanceFromCharacteristicMeasurementType defines the results of a measured distance-from characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistanceFromCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
        /// <remarks The optional AnalysisVector element used by the
        /// AnalysisMode defines the point-to-point direction, the
        /// direction along which, or the plane normal in which the distance-from characteristic was evaluated./>
        public MeasuredUnitVectorType AnalysisVector { get; set; }
    }

    /// <remarks The SquareCharacteristicMeasurementType defines the results of a measured square characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SquareCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The ThicknessCharacteristicMeasurementType defines the results of a measured thickness characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThicknessCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The DepthCharacteristicMeasurementType defines the results of a measured depth characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DepthCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The HeightCharacteristicMeasurementType defines the results of a measured height characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HeightCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The WidthCharacteristicMeasurementType defines the results of a measured width characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WidthCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The LengthCharacteristicMeasurementType defines the results of a measured length characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LengthCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The SphericalDiameterCharacteristicMeasurementType defines the results of a measured spherical diameter characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalDiameterCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The DiameterCharacteristicMeasurementType defines the results of a measured diameter characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DiameterCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks The CurveLengthCharacteristicMeasurementType defines the results of a measured curve length characteristic evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CurveLengthCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }

    /// <remarks
    /// The UserDefinedLinearCharacteristicMeasurementType is a
    /// characteristic measurement specified by the user that is measured
    /// in linear units.This user defined type is not to be used where an
    /// appropriate type already exists. In particular it is not to be used
    /// for: angularity, chord, circularity, circular-runout,
    /// concentricity, conical taper, conicity, curve-length, cylindricity,
    /// depth, diameter, distance- between, distance-from, ellipticity,
    /// flatness, flat taper, height, length, linear-coordinate,
    /// line-profile, (other) form, parallelism, perpendicularity,
    /// point-profile, position, radius, sphericity, square, straightness,
    /// surface-profile, surface-texture, symmetry, thickness, toroidicity,
    /// total-runout or width./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedLinearCharacteristicMeasurementType : LinearCharacteristicMeasurementBaseType
    {
    }
}
