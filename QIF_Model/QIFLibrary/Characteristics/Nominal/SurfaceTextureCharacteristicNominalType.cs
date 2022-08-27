/*! \file SurfaceTextureCharacteristicNominalType.cs
    \brief defines a unique surface texture characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Nominal
{
    /// <summary>
    /// The SurfaceTextureCharacteristicNominalType defines a unique surface texture characteristic nominal.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SurfaceTextureCharacteristicNominalType : CharacteristicNominalBaseType
    {
        /// <remarks> The optional Obtention element defines an obtention.</remarks>
        [System.ComponentModel.DefaultValueAttribute(RoughnessObtentionEnumType.UNDEFINED)]
        public RoughnessObtentionEnumType Obtention { get; set; } = RoughnessObtentionEnumType.UNDEFINED;

        /// <remarks> The optional Applicability element defines an applicability.</remarks>
        [System.ComponentModel.DefaultValueAttribute(RoughnessApplicabilityEnumType.UNSUPPORTED)]
        public RoughnessApplicabilityEnumType Applicability { get; set; } = RoughnessApplicabilityEnumType.UNSUPPORTED;

        /// <remarks> The optional MinimumMaterialRemoval element defines a minimum material removal.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string MinimumMaterialRemoval { get; set; }

        /// <remarks> The optional ProductionMethod element defines a manufacturing method.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ProductionMethod { get; set; }

        /// <remarks> The optional Cutoff element defines a cutoff value.</remarks>
        public Units.LinearValueType Cutoff { get; set; }

        /// <remarks> The optional SecondaryRoughnessParameter element defines a secondary roughness parameter.</remarks>
        public Units.LinearValueType SecondaryRoughnessParameter { get; set; }

        /// <remarks> The optional DirectionOfLay element defines a direction of lay.</remarks>
        public RoughnessLayEnumType DirectionOfLay { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectionOfLaySpecified { get; set; }

        /// <remarks> The optional OtherSurfaceParameter element defines other surface finish parameters.</remarks>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string OtherSurfaceParameter { get; set; }
    }

    /// <remarks> The RoughnessObtentionEnumType enumerates values that describe obtention.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum RoughnessObtentionEnumType
    {
        /// <remarks></remarks>
        UNDEFINED,

        /// <remarks></remarks>
        UNSUPPORTED,

        /// <remarks></remarks>
        MACHINING_MANDATORY,

        /// <remarks></remarks>
        MACHINING_FORBIDDEN,
    }

    /// <remarks> The RoughnessApplicabilityEnumType enumerates values that describe applicability.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum RoughnessApplicabilityEnumType
    {
        /// <remarks></remarks>
        UNSUPPORTED,

        /// <remarks></remarks>
        SPECIFIED_SURFACE_ONLY,

        /// <remarks></remarks>
        ALL_PART_SURFACES,

        /// <remarks></remarks>
        BASIC_SURFACE,
    }

    /// <remarks> The RoughnessLayEnumType enumerates values that describe directions of lay.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum RoughnessLayEnumType
    {
        /// <remarks></remarks>
        PARALLEL,

        /// <remarks></remarks>
        PERPENDICULAR,

        /// <remarks></remarks>
        CROSS_HATCH,

        /// <remarks></remarks>
        MULTI_DIRECTIONAL,

        /// <remarks></remarks>
        CIRCULAR,

        /// <remarks></remarks>
        RADIAL,

        /// <remarks></remarks>
        PARTICULATE,
    }
}
