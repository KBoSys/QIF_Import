/*! \file CharacteristicDefinitionBaseType.cs
    \brief defines a list of characteristic definitions. 

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The CharacteristicDefinitionBaseType is the abstract base type that
    /// defines information that can be common to more than one	characteristic.
    /// </summary>
    public abstract class CharacteristicDefinitionBaseType : CharacteristicBaseType
    {
        /// <remarks> The optional Name element is the name identifying the characteristic.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string? Name { get; set; }

        /// <remarks>
        /// The optional CharacteristicDesignator element is the
        /// designator of a characteristic together with an optional
        /// level of criticality and optional UUID.The designator
        /// element of the CharacteristicDesignator will typically be
        /// at the most general level when used in this
        /// CharacteristicDefinitionBaseType. For example, an instance
        /// of CharacteristicDefinitionBaseType might have a
        /// CharacteristicDesignator element with the Designator K.
        /// Then there might be three instances of
        /// CharacteristicItemBaseType referencing the
        /// CharacteristicDefinitionBaseType instance and having
        /// CharacteristicDesignator elements using Designators K-1, K-2, and K-3.</remarks>
        public CharacteristicDesignatorType? CharacteristicDesignator { get; set; }

        /// <remarks> The optional FreeState element indicates whether the
        /// characteristic is applied to the product in free state or
        /// constrained: "true" for free state, "false" or not present for constrained.
        ///        
        /// ASME Y14.5-1994 - 3.3.19</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool FreeState { get; set; }

        /// <remarks>
        /// The optional StatisticalCharacteristic element indicates
        /// whether the characteristic is applied on a per-product
        /// basis or statistically over a set of products. The element
        /// is set to "true" for statistical, and is set to "false" or is not present for per-product.
        /// 
        /// ASME Y14.5-1994 - 3.3.10 - RE: SPC Control Limits</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool StatisticalCharacteristic { get; set; }

        /// <remarks>
        /// (ISO specific CZ) The optional CommonZone element indicates
        /// whether the characteristic is applied to two or more
        /// features using a common tolerance zone: "true" for common
        /// zone, "false" or not present for no common zone or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CommonZone { get; set; }

        /// <remarks> (ISO specific CT) The optional CommonTolerance element
        /// indicates whether the characteristic is applied to two or
        /// more features using a common tolerance: "true" for common
        /// tolerance, "false" or not present for no common tolerance or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CommonTolerance { get; set; }

        /// <remarks> (ISO specific (A)) The optional MedianFeature element
        /// indicates whether the characteristic is applied to the
        /// median feature(center-line, center-plane, etc.) :
        /// "true" for median feature, "false" or not present for no median feature or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool MedianFeature { get; set; }

        /// <remarks> (ISO specific (E)) The optional EnvelopeRequirement element
        /// indicates whether the characteristic is applied with the
        /// ISO envelope requirement: "true" for envelope requirement,
        /// "false" or not present for no envelope requirement or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnvelopeRequirement { get; set; }

        /// <remarks> (ISO specific (I)) The optional Independency element
        /// indicates whether the characteristic is applied with the
        /// ISO independency requirement: "true" for independency
        /// requirement, "false" or not present for no independency requirement or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Independency { get; set; }

        /// <remarks> (ISO specific UF, ASME specific CF) The optional
        /// UnitedOrContinuousFeature element indicates whether the
        /// characteristic is applied to two or more features as if the
        /// features were one, united or continuous feature: "true" for
        /// united or continuous feature, "false" or not present for no
        /// united or continuous feature or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UnitedOrContinuousFeature { get; set; }

        /// <remarks> (ISO specific SZ) The optional SeparateZone element
        /// indicates whether the characteristic is applied to two or
        /// more features using separate tolerance zones: "true" for
        /// separate zone, "false" or not present for no separate zone or not applicable.</remarks>
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SeparateZone { get; set; }
    }

    /// <summary>
    /// The DimensionalCharacteristicDefinitionBaseType is the abstract
    /// base type that defines dimensional information that can be common to more than one dimensional characteristic.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DiameterCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCharacteristicDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FlatTaperCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConicalTaperCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ChordCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalRadiusCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RadiusCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceBetweenCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistanceFromCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SquareCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThicknessCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DepthCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HeightCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WidthCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LengthCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphericalDiameterCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CurveLengthCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedLinearCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCharacteristicDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleBetweenCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleFromCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngleCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserDefinedAngularCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateCharacteristicDefinitionBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCoordinateCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCoordinateCharacteristicDefinitionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class DimensionalCharacteristicDefinitionBaseType : CharacteristicDefinitionBaseType
    {
        /// <remarks></remarks>
        public IntermediatesPMI.DimensionModifierEnumType DimensionType { get; set; }

        /// <remarks></remarks>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DimensionTypeSpecified { get; set; }

        /// <remarks></remarks>
        public IntermediatesPMI.DimensionModifiersType? DimensionModifiers { get; set; }
    }

    /// <remarks></remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCoordinateCharacteristicDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCoordinateCharacteristicDefinitionType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class CoordinateCharacteristicDefinitionBaseType : DimensionalCharacteristicDefinitionBaseType
    {
    }
}
