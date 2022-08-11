﻿/*! \file MaterialsType.cs
	\brief Defines a list of materials.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

using QIF_Model.QIFLibrary.Primitives;

namespace QIF_Model.QIFLibrary.PrimitivesPMI
{
    /// <remarks The MaterialsType defines a list of materials./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MaterialsType : ArrayBaseType<MaterialType>
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Material")]
        public MaterialType[] Items { get => base.itemsField; set => base.itemsField = value; }
    }

    /// <remarks The MaterialType defines properties of a material./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class MaterialType
    {
        /// <remarks The optional Attributes element contains user defined
        /// attributes(typified, binary array, or XML structured)./>
        public AttributesType Attributes { get; set; }

        /// <remarks
        /// The MaterialClassEnum element describes an often-used material type.
        /// The OtherMaterialClass element describes an often-used material type in natural language./>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassEnum", typeof(MaterialClassEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherMaterialClass", typeof(string))]
        public object Item { get; set; }

        /// <remarks The optional Description element is a description of the material./>
        public string Description { get; set; }

        /// <remarks The optional MassDensity element is the material mass density parameter in the model units./>
        public double MassDensity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MassDensitySpecified { get; set; }

        /// <remarks The optional PoissonsRatio element is the material Poisson's ratio parameter in the model units./>
        public double PoissonsRatio { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PoissonsRatioSpecified { get; set; }

        /// <remarks The optional YoungsModulus element is the material Young's modulus parameter in the model units./>
        public double YoungsModulus { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YoungsModulusSpecified { get; set; }

        /// <remarks The optional UltimateTensileStress element is the material ultimate tensile stress parameter in the model units./>
        public double UltimateTensileStress { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UltimateTensileStressSpecified { get; set; }

        /// <remarks The optional CompressiveYieldStress element is the material compressive yield stress parameter in the model units./>
        public double CompressiveYieldStress { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompressiveYieldStressSpecified { get; set; }

        /// <remarks The optional TensileYieldStress element is the material tensile yield stress parameter in the model units./>
        public double TensileYieldStress { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TensileYieldStressSpecified { get; set; }

        /// <remarks The optional ThermalExpansion element is the material thermal expansion parameter in the model units./>
        public double ThermalExpansion { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThermalExpansionSpecified { get; set; }

        /// <remarks The optional SpecificHeatCapacity element is the material specific heat capacity parameter in the model units./>
        public double SpecificHeatCapacity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpecificHeatCapacitySpecified { get; set; }

        /// <remarks The optional ThermalConductivity element is the material thermal conductivity parameter in the model units./>
        public double ThermalConductivity { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThermalConductivitySpecified { get; set; }

        /// <remarks The required Index attribute is a unique material index in the material library./>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Index { get; set; }

        /// <remarks The required MaterialName attribute is the name of the material./>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string MaterialName { get; set; }
    }

    /// <remarks The MaterialClassEnumType enumerates often-used material types./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum MaterialClassEnumType
    {

        /// <remarks/>
        PLASTIC,

        /// <remarks/>
        METAL,

        /// <remarks/>
        WOOD,

        /// <remarks/>
        STONE,

        /// <remarks/>
        RUBBER,

        /// <remarks/>
        COMPOSITE,

        /// <remarks/>
        FOAM,

        /// <remarks/>
        CERAMIC,

        /// <remarks/>
        GLASS,
    }
}
