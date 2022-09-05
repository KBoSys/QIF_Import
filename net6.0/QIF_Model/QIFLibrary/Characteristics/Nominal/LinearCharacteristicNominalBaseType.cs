/*! \file LinearCharacteristicNominalBaseType.cs
    \brief abstract base type that defines a unique linear characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <remarks> The LinearCharacteristicNominalBaseType is the abstract base type that defines a unique linear characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class LinearCharacteristicNominalBaseType : DimensionalCharacteristicNominalBaseType
    {
        /// <remarks> The optional TargetValue element is the nominal value of the linear characteristic.</remarks>
        public Units.LinearValueType? TargetValue { get; set; }

        /// <remarks> The optional TargetDualValue element is the dual nominal value of the linear characteristic.</remarks>
        public Units.LinearDualValueType? TargetDualValue { get; set; }
    }

    /// <remarks> The FlatTaperCharacteristicNominalType defines a unique flat taper
    /// characteristic nominal with a slope expressed as a difference in heights over a distance.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class FlatTaperCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
        /// <remarks> The Distance element is the distance over which
        /// the slope applies. The TargetValue element in the
        /// LinearCharacteristicNominalBaseType is the difference in heights over this distance.</remarks>
        public Units.LinearValueType? Distance { get; set; }
    }

    /// <remarks> The ConicalTaperCharacteristicNominalType defines a unique conical
    /// taper characteristic nominal with a taper expressed as a difference in diameters over a distance.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ConicalTaperCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
        /// <remarks> The Distance element is the distance over which
        /// the taper applies.The TargetValue element in the
        /// LinearCharacteristicNominalBaseType is the difference in diameters over this distance.</remarks>
        public Units.LinearValueType? Distance { get; set; }
    }

    /// <remarks> The ChordCharacteristicNominalType defines a unique chord characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ChordCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The SphericalRadiusCharacteristicNominalType defines a unique spherical radius characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SphericalRadiusCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The RadiusCharacteristicNominalType defines a unique radius characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class RadiusCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The DistanceBetweenCharacteristicNominalType defines a unique distance-between characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistanceBetweenCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
        /// <remarks> The FeatureNominalPairs element is a list of pairs of QIF
        /// ids of feature nominals.This element replaces the
        /// FeatureNominalIds element of CharacteristicNominalBaseType.
        /// The FeatureNominalIds element is not populated for distance between characteristics.</remarks>
        public Primitives.ArrayPairReferenceFullType? FeatureNominalPairs { get; set; }

        /// <remarks> The optional AnalysisVector element used by the
        /// AnalysisMode gives a vector defining the point-to-point
        /// direction, the direction along which, or the plane normal in which the distance-between characteristic is evaluated.</remarks>
        public Primitives.UnitVectorType? AnalysisVector { get; set; }

        /// <remarks> The AnalysisMode element indicates whether the
        /// distance-between characteristic is one dimensional, two dimensional or three dimensional.</remarks>
        public IntermediatesPMI.DistanceBetweenAnalysisModeEnumType AnalysisMode { get; set; }

        /// <remarks> The optional MeasurementDirective element indicates if the
        /// characteristic evaluation is the average, minimum or
        /// maximum distance between two features.</remarks>
        public IntermediatesPMI.MeasurementDirectiveType? MeasurementDirective { get; set; }

        /// <remarks> The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated.</remarks>
        public Primitives.QIFReferenceFullType? CoordinateSystemId { get; set; }
    }

    /// <remarks> The OriginReferenceType defines the origin or reference point for a tolerance between two features.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class OriginReferenceType
    {
        /// <remarks> This compositor provides a choice between an origin reference
        /// that is a nominal or measured feature and an origin reference that is a defined datum.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DatumDefinitionId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("FeatureNominalId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferencedComponent", typeof(IntermediatesPMI.ReferencedComponentEnumType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[]? Items { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public OriginReferenceChoiceType[]? ItemsElementName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum OriginReferenceChoiceType
    {
        DatumDefinitionId,
        FeatureNominalId,
        ReferencedComponent,
    }

    /// <remarks> The DistanceFromCharacteristicNominalType defines a unique distance-from characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DistanceFromCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
        /// <remarks> The optional OriginReference element indicates the reference feature for the distance-from characteristic.
        /// This is the first of two features involved in the distance-from characteristic. 
        /// The second feature(s) is defined in the FeatureNominalIds element of CharacteristicNominalBaseType.</remarks>
        public OriginReferenceType? OriginReference { get; set; }

        /// <remarks> The optional AnalysisVector element used by the
        /// AnalysisMode gives a vector defining the point-to-point
        /// direction, the direction along which, or the plane normal
        /// in which the distance-from characteristic is evaluated.</remarks>
        public Primitives.UnitVectorType? AnalysisVector { get; set; }

        /// <remarks> The AnalysisMode element indicates whether the
        /// distance-from characteristic is one dimensional, two dimensional or three dimensional.</remarks>
        public IntermediatesPMI.DistanceBetweenAnalysisModeEnumType AnalysisMode { get; set; }

        /// <remarks> The optional MeasurementDirective element indicates if the
        /// characteristic evaluation is the average, minimum or maximum distance between two features.</remarks>
        public IntermediatesPMI.MeasurementDirectiveType? MeasurementDirective { get; set; }

        /// <remarks> The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated.</remarks>
        public Primitives.QIFReferenceFullType? CoordinateSystemId { get; set; }
    }

    /// <remarks> The SquareCharacteristicNominalType defines a unique square characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SquareCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The ThicknessCharacteristicNominalType defines a unique thickness characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ThicknessCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The DepthCharacteristicNominalType defines a unique depth characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DepthCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The HeightCharacteristicNominalType defines a unique height characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class HeightCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The WidthCharacteristicNominalType defines a unique width characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class WidthCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The global LengthCharacteristicNominal element gives information about a length characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LengthCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The SphericalDiameterCharacteristicNominalType defines a unique spherical diameter characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SphericalDiameterCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The DiameterCharacteristicNominalType defines a unique diameter characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class DiameterCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks> The CurveLengthCharacteristicNominalType defines a unique curve length characteristic nominal.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class CurveLengthCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }

    /// <remarks>
    /// The UserDefinedLinearCharacteristicNominalType is a characteristic
    /// nominal specified by the user that is measured in linear units.
    /// This user defined type is not to be used where an appropriate type
    /// already exists. In particular it is not to be used for: angularity,
    /// chord, circularity, circular-runout, concentricity, conical taper,
    /// conicity, curve-length, cylindricity, depth, diameter, distance-
    /// between, distance-from, ellipticity, flatness, flat taper, height,
    /// length, linear-coordinate, line-profile, (other) form, parallelism,
    /// perpendicularity, point-profile, position, radius, sphericity,
    /// square, straightness, surface-profile, surface-texture, symmetry,
    /// thickness, toroidicity, total-runout or width.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class UserDefinedLinearCharacteristicNominalType : LinearCharacteristicNominalBaseType
    {
    }
}
