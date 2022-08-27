/*! \file PositionCharacteristicDefinitionType.cs
    \brief The PositionCharacteristicDefinitionType defines information that
        can be common to more than one position characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <remarks> The CompositeSegmentSymmetryDefinitionType defines information that
    /// can be common to more than one composite segment symmetry characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CompositeSegmentSymmetryDefinitionType : CompositeSegmentDefinitionBaseType
    {
    }

    /// <remarks> The SymmetryCharacteristicDefinitionType defines information that can be common to more than one symmetry characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SymmetryCharacteristicDefinitionType : LocationCharacteristicDefinitionBaseType
    {
        /// <remarks> The optional SecondCompositeSegmentSymmetryDefinition
        /// gives information about the second segment of a composite frame symmetry characteristic.</remarks>
        public CompositeSegmentSymmetryDefinitionType SecondCompositeSegmentSymmetryDefinition { get; set; }

        /// <remarks> The optional ThirdCompositeSegmentSymmetryDefinition
        /// gives information about the third segment of a composite frame symmetry characteristic.This element
        /// may be used only if the SecondCompositeSegmentSymmetryDefinition element is used.</remarks>
        public CompositeSegmentSymmetryDefinitionType ThirdCompositeSegmentSymmetryDefinition { get; set; }
    }

    /// <remarks> The CompositeSegmentPositionDefinitionType defines information that
    /// can be common to more than one composite segment position characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CompositeSegmentPositionDefinitionType : CompositeSegmentDefinitionBaseType
    {
        /// <remarks> The MaterialCondition element is the material condition modifier for the tolerance characteristic in the segment.</remarks>
        public IntermediatesPMI.MaterialModifierEnumType MaterialCondition { get; set; }

        /// <remarks> The ZoneShape element describes the shape of the tolerance zone in this segment.</remarks>
        public PositionZoneShapeType ZoneShape { get; set; }

        /// <remarks> The optional MaximumToleranceValue element is the maximum tolerance value in cases where bonus is available.</remarks>
        public Units.LinearValueType MaximumToleranceValue { get; set; }

        /// <remarks> The optional ProjectedToleranceZone element is the length of the projected tolerance zone.</remarks>
        public Units.LinearValueType ProjectedToleranceZone { get; set; }
    }

    /// <remarks> The PositionDiametricalZoneType defines the shape of a tolerance zone as diametrical.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PositionDiametricalZoneType
    {
        /// <remarks> The optional Dimensionality element for the diametrical
        /// tolerance zone differentiates between cylindrical(3D) and circular(2D) tolerance zones.</remarks>
        public PrimitivesPMI.DimensionCountEnumType Dimensionality { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalitySpecified { get; set; }

        /// <remarks> The optional ZoneOrientationVector element gives the
        /// orientation of the diametrical tolerance zone.</remarks>
        public Primitives.UnitVectorType ZoneOrientationVector { get; set; }

        /// <remarks> The optional ElongatedZone element (when present and set to
        /// "true") indicates the tolerance zone is elongated as applied to
        /// the round ends of a slot.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ElongatedZone { get; set; }
    }

    /// <remarks> The PositionNonDiametricalZoneType defines the shape of a tolerance
    /// zone as neither diametrical nor spherical, but as either
    /// parallel-planes, parallel-lines or a more complex, non-circular shape.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PositionNonDiametricalZoneType
    {
        /// <remarks> The optional Dimensionality element differentiates between
        /// three dimensional and two dimensional tolerance zones.</remarks>
        public PrimitivesPMI.DimensionCountEnumType Dimensionality { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalitySpecified { get; set; }

        /// <remarks> The optional ZoneOrientationVector element gives the orientation of the tolerance zone.</remarks>
        public Primitives.UnitVectorType ZoneOrientationVector { get; set; }

        /// <remarks> The optional BoundaryZone element (when present and set to
        /// "true") indicates the tolerance zone is applied to the boundary of an irregular shape.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BoundaryZone { get; set; }

        /// <remarks> The optional ZoneOrientationEnum element describes the position
        /// tolerance zone orientation with respect to a feature or coordinate system characteristic.</remarks>
        public PrimitivesPMI.ZoneOrientationEnumType ZoneOrientationEnum { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ZoneOrientationEnumSpecified { get; set; }

        /// <remarks> The optional CoordinateSystemId element is the QIF id of
        /// the coordinate system in which this characteristic is evaluated.</remarks>
        public Primitives.QIFReferenceFullType CoordinateSystemId { get; set; }
    }

    /// <remarks> The PositionSphericalZoneType defines the shape of a tolerance zone as spherical.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PositionSphericalZoneType
    {
        /// <remarks> The optional Dimensionality element for a spherical tolerance zone(if present) is always three dimensional.</remarks>
        public PrimitivesPMI.DimensionCountEnumType Dimensionality { get; set; } = PrimitivesPMI.DimensionCountEnumType.THREEDIMENSIONAL;

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionalitySpecified { get; set; }
    }

    /// <remarks> The PositionZoneShapeType defines the shape of the tolerance zone for a position characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class PositionZoneShapeType
    {
        /// <remarks> This compositor provides a choice among spherical diametrical, diametrical, and non-diametrical tolerance zone shapes.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DiametricalZone", typeof(PositionDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("NonDiametricalZone", typeof(PositionNonDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("SphericalZone", typeof(PositionSphericalZoneType))]
        public object Item { get; set; }
    }

    /// <summary>
    /// The PositionCharacteristicDefinitionType defines information that can be common to more than one position characteristic.
    /// </summary>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class PositionCharacteristicDefinitionType : LocationCharacteristicDefinitionBaseType
    {
        /// <remarks> The MaterialCondition element is the material condition modifier for the characteristic.</remarks>
        public IntermediatesPMI.MaterialModifierEnumType MaterialCondition { get; set; }

        /// <remarks> The optional SizeCharacteristicDefinitionId element is the
        /// QIF id of the associated feature size characteristic used
        /// to derive bonus tolerance for maximum and least material conditions.</remarks>
        public Primitives.QIFReferenceType SizeCharacteristicDefinitionId { get; set; }

        /// <remarks> The ZoneShape element describes the shape of the tolerance zone.</remarks>
        public PositionZoneShapeType ZoneShape { get; set; }

        /// <remarks> The optional MaximumToleranceValue element is the maximum tolerance value in cases where bonus is available.</remarks>
        public Units.LinearValueType MaximumToleranceValue { get; set; }

        /// <remarks> The optional ProjectedToleranceZoneValue element is the length of the projected tolerance zone.</remarks>
        public Units.LinearValueType ProjectedToleranceZoneValue { get; set; }

        /// <remarks> The optional SecondCompositeSegmentPositionDefinition
        /// gives information about the second segment of a composite frame position characteristic.</remarks>
        public CompositeSegmentPositionDefinitionType SecondCompositeSegmentPositionDefinition { get; set; }

        /// <remarks> The optional ThirdCompositeSegmentPositionDefinition
        /// gives information about the third segment of a
        /// composite frame position characteristic.This element may be used only if the
        /// SecondCompositeSegmentPositionDefinition element is used.</remarks>
        public CompositeSegmentPositionDefinitionType ThirdCompositeSegmentPositionDefinition { get; set; }

        /// <remarks> The optional FourthCompositeSegmentPositionDefinition
        /// gives information about the fourth segment of a
        /// composite frame position characteristic.This element
        /// may be used only if the ThirdCompositeSegmentPositionDefinition element is used.</remarks>
        public CompositeSegmentPositionDefinitionType FourthCompositeSegmentPositionDefinition { get; set; }

        /// <remarks> The optional ToPointToleranceValue element is the tolerance
        /// value which applies at the ToPoint in a linearly variable
        /// tolerance zone(for example, a conical diametrical
        /// tolerance zone). The ToleranceValue applies at the
        /// FromPoint.The tolerance zone varies linearly between the two points.</remarks>
        public Units.LinearValueType ToPointToleranceValue { get; set; }

        /// <remarks> (ISO specific greaterthan/lessthan) The optional
        /// OrientationOnly element when present and set to true
        /// signifies that the DRF associated with this position
        /// characteristic controls only orientation degrees of freedom.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool OrientationOnly { get; set; }
    }
}
