/*! \file ToleranceType.cs
    \brief defines tolerance types

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.IntermediatesPMI
{
    /// <remarks The NonToleranceEnumType enumerates values that describe a
    /// dimension characteristic that is not toleranced but which
    /// nevertheless needs to be tracked and/or reported./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum NonToleranceEnumType
    {
        /// <remarks 
        /// The MEASURED enumeration defines a characteristic as being a
        /// basic dimension which can be measured and therefore a valid
        /// measured value may exist./>
        MEASURED,

        /// <remarks
        /// The SET enumeration defines a characteristic as being a
        /// dimension which cannot be measured and therefore no valid
        /// measured value exists and the measured value is set to the
        /// nominal value for reporting purposes./>
        SET,
    }

    /// <remarks The LinearToleranceType defines a tolerance on a quantity measured in length units./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class LinearToleranceType
    {
        /// <remarks
        /// The choice is among:
        /// (1) MaxValue with optional MaxDualValue
        /// (2) MinValue with optional MinDualValue
        /// (3) both 1 and 2 (with MaxValue coming first; this choice structure is the normal XML schema language structure for 'one or both')
        /// (4) a reference to a linear tolerance definition./>
        [System.Xml.Serialization.XmlElementAttribute("DefinitionId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxDualValue", typeof(Units.LinearDualValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinDualValue", typeof(Units.LinearDualValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.LinearValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public LinearToleranceTypeValueChoiceEnum[] ItemsElementName { get; set; }

        /// <remarks The DefinedAsLimit element signifies whether the MaxValue and
        /// MinValue represent actual values('true') or the upper and
        /// lower tolerances, respectively ('false'). Also when
        /// DefinedAsLimit is set to 'false', the MaxValue and MinValue may be negative./>
        public bool DefinedAsLimit { get; set; }

        /// <remarks The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        public Primitives.AttributesType Attributes { get; set; }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum LinearToleranceTypeValueChoiceEnum
    {
        /// <remarks/>
        DefinitionId,

        /// <remarks/>
        MaxDualValue,

        /// <remarks/>
        MaxValue,

        /// <remarks/>
        MinDualValue,

        /// <remarks/>
        MinValue,
    }

    /// <remarks The AngularToleranceType defines a tolerance on an angle./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class AngularToleranceType
    {
        /// <remarks
        /// The choice is among (1) MaxValue, (2) MinValue, (3) both
        /// (with MaxValue coming first; this choice structure is the
        /// normal XML schema language structure for 'one or both'), or
        /// (4) a reference to a tolerance definition./>
        [System.Xml.Serialization.XmlElementAttribute("DefinitionId", typeof(Primitives.QIFReferenceFullType))]
        [System.Xml.Serialization.XmlElementAttribute("MaxValue", typeof(Units.AngularValueType))]
        [System.Xml.Serialization.XmlElementAttribute("MinValue", typeof(Units.AngularValueType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public AngularToleranceValueChoiceEnum[] ItemsElementName { get; set; }

        /// <remarks
        /// The DefinedAsLimit element signifies whether the MaxValue and
        /// MinValue represent actual values('true') or the upper and
        /// lower tolerances, respectively ('false'). Also when
        /// DefinedAsLimit is set to 'false', the MaxValue and MinValue may be negative./>
        public bool DefinedAsLimit { get; set; }

        /// <remarks The optional Attributes element contains user defined attributes(typified, binary array, or XML structured)./>
        public Primitives.AttributesType Attributes { get; set; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3", IncludeInSchema = false)]
    public enum AngularToleranceValueChoiceEnum
    {
        /// <remarks/>
        DefinitionId,

        /// <remarks/>
        MaxValue,

        /// <remarks/>
        MinValue,
    }

    /// <remarks
    /// The DimensionModifierEnumType enumerates values that signify that a
    /// dimension is a basic or theoretically exact dimension, an
    /// un-measurable dimension that is set to its nominal value, or a
    /// reference or auxiliary dimension.ISO theoretically exact
    /// dimensions(TED) and ASME basic dimensions are analogous concepts
    /// both of which are signified with the BASIC_OR_TED enumeration.ISO
    /// auxiliary dimensions and ASME reference dimensions are analogous
    /// concepts both of which are signified with the
    /// REFERENCE_OR_AUXILIARY enumeration./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DimensionModifierEnumType
    {
        /// <remarks/>
        BASIC_OR_TED,

        /// <remarks/>
        SET,

        /// <remarks/>
        REFERENCE_OR_AUXILIARY,
    }

    /// <remarks The DimensionDeterminationEnumType enumerates values that signify
    /// the method by which a measured dimension will be determined.The
    /// method may signify a measurement technique, an association
    /// criterion, or a calculation method./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum DimensionDeterminationEnumType
    {
        LP, ///< two-point size
        LS, ///< local size defined by a sphere
        GG, ///< least-squares association criterion
        GX, ///< maximum inscribed association criterion
        GN, ///< minimum circumscribed association criterion
        GC, ///< minimax (Chebyshev) association criterion
        CC, ///< circumference diameter (calculated size)
        CA, ///< area diameter (calculated size)
        CV, ///< volume diameter (calculated size)
    }

    /// <remarks The SignificantDimensionEnumType enumerates values that signify
    /// which aspect of a measured dimension is significant to a tolerance evaluation./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum SignificantDimensionEnumType
    {
        SX, ///< maximum size
        SN, ///< minimum size
        SA, ///< average size
        SM, ///< median size
        SD, ///< mid-range size
        SR, ///< range of sizes
        SQ, ///< standard deviation of sizes
    }

    /// <remarks (ISO specific) The DimensionModifiersType provides containers for dimension modifiers./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DimensionModifiersType
    {
        /// <remarks The optional DeterminationModifier element modifies the
        /// dimension by specifying how the dimension measured value will be determined./>
        public DimensionDeterminationEnumType DeterminationModifier { get; set; }

        /// <remarks The optional SignificanceModifier element modifies the
        /// dimension by specifying which aspect of a measured dimension is
        /// significant to a tolerance evaluation./>
        public SignificantDimensionEnumType SignificanceModifier { get; set; }

        /// <remarks The optional SectionModifier element modifies the dimension
        /// by specifying feature cross-section modifier./>
        public SectionModifierEnumType SectionModifier { get; set; }
    }

    /// <remarks The LimitsAndFitsSpecificationType defines a limits and fits specification./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class LimitsAndFitsSpecificationType
    {
        /// <remarks The FormVariance element defines the form variance portion of the limits and fits specification./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string FormVariance { get; set; }

        /// <remarks The Grade element defines the grade portion of the limits and fits specification./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string Grade { get; set; }

        /// <remarks The required zoneVariance attribute is the zone variance type for the limits and fits specification./>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LimitsAndFitsZoneVarianceType zoneVariance { get; set; }
    }

    /// <remarks The LimitsAndFitsZoneVarianceType enumerates values that describe the zone variance portion of a limits and fits specification./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum LimitsAndFitsZoneVarianceType
    {
        HOLE,
        SHAFT,
    }

    /// <remarks The ToleranceZonePerUnitAngleType defines a per-unit-angle tolerance./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ToleranceZonePerUnitAngleType
    {
        /// <remarks The ToleranceValuePerUnit element is a tolerance value in
        /// linear units to be applied on a per unit angle basis./>
        public Units.LinearValueType ToleranceValuePerUnit { get; set; }

        /// <remarks The UnitAngle element is the angle in angular units over which
        /// the per-unit-angle tolerance is applied./>
        public Units.AngularValueType UnitAngle { get; set; }
    }

    /// <remarks The ToleranceZonePerUnitLengthType defines a per-unit-length tolerance.
    /// ASME Y14.5 - 2009 Section 5.4.1.3, Figure 5-4, Figure 5-5/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ToleranceZonePerUnitLengthType
    {
        /// <remarks The ToleranceValuePerUnit element is a tolerance value in
        /// linear units to be applied on a per unit length basis./>
        public Units.LinearValueType ToleranceValuePerUnit { get; set; }

        /// <remarks The UnitLength element is the length in linear units over which
        /// the per-unit-length tolerance is applied./>
        public Units.LinearValueType UnitLength { get; set; }
    }

    /// <remarks The ToleranceZonePerUnitPolarAreaType defines a per-unit-polar-area
    /// tolerance.An angle and a length together define a cylindrical
    /// segment shaped zone over which the tolerance value applies./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ToleranceZonePerUnitPolarAreaType
    {
        /// <remarks The ToleranceValuePerUnit element is a tolerance value in linear units to be applied on a per-unit-polar-area basis./>
        public Units.LinearValueType ToleranceValuePerUnit { get; set; }

        /// <remarks The UnitAngle element is the angle in angular units over which the per-unit-polar-area tolerance is applied./>
        public Units.AngularValueType UnitAngle { get; set; }

        /// <remarks The UnitLength element is the length in linear units over which the per-unit-polar-area is applied./>
        public Units.LinearValueType UnitLength { get; set; }
    }

    /// <remarks The ToleranceZonePerUnitAreaType defines a per-unit-area tolerance. This may be used for flatness tolerance.
    /// ASME Y14.5 - 2009 Section 5.4.2.2 DMIS 5.2 Section 6.199/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class ToleranceZonePerUnitAreaType
    {
        /// <remarks The ToleranceValuePerUnit element is the tolerance value in
        /// linear units to be applied on a per unit area basis./>
        public Units.LinearValueType ToleranceValuePerUnit { get; set; }

        /// <remarks 
        /// The RectangularUnitArea element gives the length and width of the rectangular region over which the per-unit-area tolerance is applied./>
        /// <remarks 
        /// The CircularUnitArea element gives the diameter of the circular region over which the per-unit-area tolerance is applied./>
        [System.Xml.Serialization.XmlElementAttribute("CircularUnitArea", typeof(PrimitivesPMI.CircularUnitAreaType))]
        [System.Xml.Serialization.XmlElementAttribute("RectangularUnitArea", typeof(PrimitivesPMI.RectangularUnitAreaType))]
        public object Item { get; set; }
    }
}
