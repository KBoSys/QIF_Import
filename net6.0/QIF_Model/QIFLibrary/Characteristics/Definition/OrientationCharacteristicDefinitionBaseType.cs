﻿/*! \file OrientationCharacteristicDefinitionBaseType.cs
    \brief The OrientationCharacteristicDefinitionBaseType is the abstract
        base type that defines information in an orientation characteristic
        feature control frame.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System.Xml.Serialization;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <remarks> The OrientationDiametricalZoneType defines the shape of a tolerance zone as diametrical.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OrientationDiametricalZoneType
    {
        /// <remarks> The optional ZoneOrientationVector element gives the orientation of the diametrical tolerance zone.</remarks>
        public Primitives.UnitVectorType? ZoneOrientationVector { get; set; }
    }

    /// <remarks> The OrientationPlanarZoneType defines the shape of a tolerance zone as planar.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OrientationPlanarZoneType
    {
        /// <remarks> The optional ZoneOrientationVector element gives the orientation of the tolerance zone.</remarks>
        public Primitives.UnitVectorType? ZoneOrientationVector { get; set; }
    }

    /// <remarks> The OrientationZoneShapeType defines the shape of a tolerance zone for an orientation characteristic.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OrientationZoneShapeType
    {
        /// <remarks> This compositor provides a choice between a diametrical tolerance zone shape and a non-diametrical tolerance zone shape.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("DiametricalZone", typeof(OrientationDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("PlanarZone", typeof(OrientationPlanarZoneType))]
        public object? Item { get; set; }
    }

    /// <summary>
    /// The OrientationCharacteristicDefinitionBaseType is the abstract
    /// base type that defines information in an orientation characteristic feature control frame.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class OrientationCharacteristicDefinitionBaseType : GeometricCharacteristicDefinitionBaseType
    {
        /// <remarks> The ToleranceValue element is the tolerance of the orientation characteristic.</remarks>
        [XmlElement]
        public Units.LinearValueType? ToleranceValue { get; set; }

        /// <remarks> The optional ToleranceDualValue element is the dual tolerance value of the orientation characteristic.</remarks>
        [XmlElement]
        public Units.LinearDualValueType? ToleranceDualValue { get; set; }

        /// <remarks> The optional DatumReferenceFrameId element is the QIF id of
        /// the datum reference frame for the orientation characteristic.</remarks>
        public Primitives.QIFReferenceFullType? DatumReferenceFrameId { get; set; }

        /// <remarks> The MaterialCondition element is the material condition
        /// modifier for the orientation characteristic tolerance.</remarks>
        public IntermediatesPMI.MaterialModifierEnumType MaterialCondition { get; set; }

        /// <remarks> The optional SizeCharacteristicDefinitionId element is the
        /// QIF id of the associated feature size characteristic used
        /// to derive bonus tolerance for maximum and least material conditions.</remarks>
        public Primitives.QIFReferenceType? SizeCharacteristicDefinitionId { get; set; }

        /// <remarks> The ZoneShape element describes the shape of the tolerance zone.</remarks>
        public OrientationZoneShapeType? ZoneShape { get; set; }

        /// <remarks> The optional TangentPlane element indicates whether the
        /// characteristic is evaluated with a tangent plane: "true"
        /// for tangent plane, "false" or not present for no tangent plane.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool TangentPlane { get; set; }

        /// <remarks> The optional MaximumToleranceValue element is the maximum tolerance value in cases where bonus is available.</remarks>
        public Units.LinearValueType? MaximumToleranceValue { get; set; }

        /// <remarks> The optional ProjectedToleranceZoneValue element is the length of a projected tolerance zone.</remarks>
        public Units.LinearValueType? ProjectedToleranceZoneValue { get; set; }

        /// <remarks> 
        /// This optional compositor provides a choice between:
        /// EachRadialElement zone modifier and 
        /// EachElement linear zone modifier as indicated by a EACH RADIAL ELEMENT or 
        /// EACH ELEMENT note respectively, 
        /// or by the ISO specific LE modifier in the latter case.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("EachElement", typeof(bool))]
        [System.Xml.Serialization.XmlElementAttribute("EachRadialElement", typeof(bool))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("EachElementName")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EachElement { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public EachElementNameChoiceEnum EachElementName { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum EachElementNameChoiceEnum
    {
        EachElement,
        EachRadialElement,
    }

    /// <summary>
    /// The AngularityCharacteristicDefinitionType defines information that can be common to more than one angularity characteristic.
    /// </summary>
    public class AngularityCharacteristicDefinitionType : OrientationCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The ParallelismCharacteristicDefinitionType defines information that can be common to more than one parallelism characteristic.
    /// </summary>
	public class ParallelismCharacteristicDefinitionType : OrientationCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The PerpendicularityCharacteristicDefinitionType defines
    /// information that can be common to more than one perpendicularity characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRoot]
    public class PerpendicularityCharacteristicDefinitionType : OrientationCharacteristicDefinitionBaseType
    {
    }
}
