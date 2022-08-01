/*! \file FormCharacteristicDefinitionBaseType.cs
    \brief The FormCharacteristicDefinitionBaseType is the abstract base type that defines a form characteristic base class.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The FormCharacteristicDefinitionBaseType is the abstract base type that defines a form characteristic base class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class FormCharacteristicDefinitionBaseType : GeometricCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The CircularityCharacteristicDefinitionType defines information
    /// that can be common to more than one circularity or roundness characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CircularityCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks This compositor provides a choice between a simple
        /// circularity or roundness tolerance(with an optional second
        /// tier per-unit-angle tolerance) and a per-unit-angle tolerance./>
        [System.Xml.Serialization.XmlElementAttribute("ToleranceDualValue", typeof(Units.LinearDualValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitAngle", typeof(IntermediatesPMI.ToleranceZonePerUnitAngleType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitArcLength", typeof(IntermediatesPMI.ToleranceZonePerUnitLengthType))]
        public object[] Items { get; set; }
    }

    /// <summary>
    /// The OtherFormCharacteristicDefinitionType defines information that can be common to more than one form characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class OtherFormCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks The ToleranceValue element is the tolerance of the form characteristic./>
        public Units.LinearValueType ToleranceValue { get; set; }

        /// <remarks The optional ToleranceDualValue element is the dual tolerance value of the form characteristic./>
        public Units.LinearDualValueType ToleranceDualValue { get; set; }
    }

    /// <summary>
    /// The ToroidicityCharacteristicDefinitionType defines information that can be common to more than one toroidicity characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class ToroidicityCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks The ToleranceValue element is the tolerance of the toroidicity characteristic./>
        public Units.LinearValueType ToleranceValue { get; set; }

        /// <remarks The optional ToleranceDualValue element is the dual tolerance value of the toroidicity characteristic./>
        public Units.LinearDualValueType ToleranceDualValue { get; set; }
    }

    /// <summary>
    /// The SphericityCharacteristicDefinitionType defines information that can be common to more than one sphericity characteristic.
    /// </summary>
    public class SphericityCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks The ToleranceValue element is the tolerance of the toroidicity characteristic./>
        public Units.LinearValueType ToleranceValue { get; set; }

        /// <remarks The optional ToleranceDualValue element is the dual tolerance value of the toroidicity characteristic./>
        public Units.LinearDualValueType ToleranceDualValue { get; set; }
    }

    /// <summary>
    /// The EllipticityCharacteristicDefinitionType defines information that can be common to more than one ellipticity characteristic.
    /// </summary>
    public class EllipticityCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks The ToleranceValue element is the tolerance of the toroidicity characteristic./>
        public Units.LinearValueType ToleranceValue { get; set; }

        /// <remarks The optional ToleranceDualValue element is the dual tolerance value of the toroidicity characteristic./>
        public Units.LinearDualValueType ToleranceDualValue { get; set; }
    }

    /// <summary>
    /// The CylindricityCharacteristicDefinitionType defines information that can be common to more than one cylindricity characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class CylindricityCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks 
        /// This compositor provides a choice between a simple
        /// cylindricity tolerance(with an optional second tier
        /// per-unit-polar-area tolerance) and a per-unit-polar-area tolerance./>
        [System.Xml.Serialization.XmlElementAttribute("ToleranceDualValue", typeof(Units.LinearDualValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitAngle", typeof(IntermediatesPMI.ToleranceZonePerUnitAngleType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitArcLength", typeof(IntermediatesPMI.ToleranceZonePerUnitLengthType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitArea", typeof(IntermediatesPMI.ToleranceZonePerUnitAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitLength", typeof(IntermediatesPMI.ToleranceZonePerUnitLengthType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitPolarArea", typeof(IntermediatesPMI.ToleranceZonePerUnitPolarAreaType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public CylindricityItemsChoice[] ItemsElementName { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum CylindricityItemsChoice
    {
        ToleranceDualValue,
        ToleranceValue,
        ToleranceZonePerUnitAngle,
        ToleranceZonePerUnitArcLength,
        ToleranceZonePerUnitArea,
        ToleranceZonePerUnitLength,
        ToleranceZonePerUnitPolarArea,
    }

    /// <summary>
    /// The ConicityCharacteristicDefinitionType defines information that can be common to more than one conicity characteristic.
    /// </summary>
    public class ConicityCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks The ToleranceValue element is the tolerance of the toroidicity characteristic./>
        public Units.LinearValueType ToleranceValue { get; set; }

        /// <remarks The optional ToleranceDualValue element is the dual tolerance value of the toroidicity characteristic./>
        public Units.LinearDualValueType ToleranceDualValue { get; set; }
    }

    /// <summary>
    /// The FlatnessCharacteristicDefinitionType defines information that can be common to more than one flatness characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class FlatnessCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks
        /// This compositor provides a choice between a simple flatness
        /// tolerance(with an optional second tier per-unit-area
        /// tolerance) and a per-unit-area tolerance./>
        [System.Xml.Serialization.XmlElementAttribute("ToleranceDualValue", typeof(Units.LinearDualValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitArea", typeof(IntermediatesPMI.ToleranceZonePerUnitAreaType))]
        public object[] Items { get; set; }

        /// <remarks/>
        public IntermediatesPMI.MaterialModifierEnumType MaterialCondition { get; set; }

        /// <remarks The optional MaterialCondition element is the material
        /// condition modifier for a feature of size such as when
        /// applied to the center-plane of a parallel planes feature.
        /// ASME Y14.5-2009 - 5.4.2.1/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialConditionSpecified { get; set; }

        /// <remarks The optional SizeCharacteristicDefinitionId element is the
        /// QIF id of the associated feature size characteristic used
        /// to derive bonus tolerance for maximum and least material conditions./>
        public Primitives.QIFReferenceType SizeCharacteristicDefinitionId { get; set; }

        /// <remarks The optional MaximumToleranceValue element is the maximum tolerance value in cases where bonus is available./>
        public Units.LinearValueType MaximumToleranceValue { get; set; }

        /// <remarks (ISO specific NC) The optional NotConvex element when
        /// present and set to true indicates the feature must not be convex./>
        public bool NotConvex { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotConvexSpecified { get; set; }
    }

    /// <summary>
    /// The StraightnessCharacteristicDefinitionType defines information that can be common to more than one straightness characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StraightnessCharacteristicDefinitionType : FormCharacteristicDefinitionBaseType
    {
        /// <remarks
        /// This compositor provides a choice between a simple
        /// straightness tolerance(with an optional second tier
        /// per-unit-length tolerance) and a per-unit-length tolerance./>
        [System.Xml.Serialization.XmlElementAttribute("ToleranceDualValue", typeof(Units.LinearDualValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("ToleranceZonePerUnitLength", typeof(IntermediatesPMI.ToleranceZonePerUnitLengthType))]
        public object[] Items { get; set; }

        /// <remarks The optional MaterialCondition element is the material
        /// condition modifier for a feature of size such as when applied to the axis of a cylinder.
        /// ASME Y14.5-2009 - 5.4.1.2/>
        public IntermediatesPMI.MaterialModifierEnumType MaterialCondition { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaterialConditionSpecified { get; set; }

        /// <remarks The optional SizeCharacteristicDefinitionId element is the
        /// QIF id of the associated feature size characteristic used
        /// to derive bonus tolerance for maximum and least material conditions./>
        public Primitives.QIFReferenceType SizeCharacteristicDefinitionId { get; set; }

        /// <remarks The ZoneShape element describes the shape of the tolerance zone./>
        public StraightnessZoneShapeType ZoneShape { get; set; }

        /// <remarks The optional MaximumToleranceValue element is the maximum tolerance value in cases where bonus is available./>
        public Units.LinearValueType MaximumToleranceValue { get; set; }
    }

    /// <remarks The StraightnessZoneShapeType defines the shape of tolerance zone for a straightness characteristic./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StraightnessZoneShapeType
    {
        /// <remarks This compositor provides a choice between a diametrical tolerance
        /// zone shape and a non-diametrical tolerance zone shape./>
        [System.Xml.Serialization.XmlElementAttribute("DiametricalZone", typeof(StraightnessDiametricalZoneType))]
        [System.Xml.Serialization.XmlElementAttribute("NonDiametricalZone", typeof(StraightnessNonDiametricalZoneType))]
        public object Item { get; set; }
    }

    /// <remarks The StraightnessDiametricalZoneType defines the shape of a tolerance zone as diametrical./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class StraightnessDiametricalZoneType
    {
    }

    /// <remarks The StraightnessNonDiametricalZoneType defines the shape of a tolerance zone as parallel lines./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class StraightnessNonDiametricalZoneType
    {
        /// <remarks The optional ZoneOrientationVector element gives the orientation of the tolerance zone./>
        public Primitives.UnitVectorType ZoneOrientationVector { get; set; }
    }
}
