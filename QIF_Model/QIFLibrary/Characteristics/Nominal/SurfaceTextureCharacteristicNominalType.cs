/*! \file SurfaceTextureCharacteristicNominalType.cs
    \brief defines a unique surface texture characteristic nominal.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

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
        /// <remarks The optional Obtention element defines an obtention./>
        [System.ComponentModel.DefaultValueAttribute(RoughnessObtentionEnumType.UNDEFINED)]
        public RoughnessObtentionEnumType Obtention { get; set; } = RoughnessObtentionEnumType.UNDEFINED;

        /// <remarks The optional Applicability element defines an applicability./>
        [System.ComponentModel.DefaultValueAttribute(RoughnessApplicabilityEnumType.UNSUPPORTED)]
        public RoughnessApplicabilityEnumType Applicability { get; set; } = RoughnessApplicabilityEnumType.UNSUPPORTED;

        /// <remarks The optional MinimumMaterialRemoval element defines a minimum material removal./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string MinimumMaterialRemoval { get; set; }

        /// <remarks The optional ProductionMethod element defines a manufacturing method./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string ProductionMethod { get; set; }

        /// <remarks The optional Cutoff element defines a cutoff value./>
        public Units.LinearValueType Cutoff { get; set; }

        /// <remarks The optional SecondaryRoughnessParameter element defines a secondary roughness parameter./>
        public Units.LinearValueType SecondaryRoughnessParameter { get; set; }

        /// <remarks The optional DirectionOfLay element defines a direction of lay./>
        public RoughnessLayEnumType DirectionOfLay { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectionOfLaySpecified { get; set; }

        /// <remarks The optional OtherSurfaceParameter element defines other surface finish parameters./>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
        public string OtherSurfaceParameter { get; set; }
    }

    /// <remarks The RoughnessObtentionEnumType enumerates values that describe obtention./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum RoughnessObtentionEnumType
    {
        /// <remarks/>
        UNDEFINED,

        /// <remarks/>
        UNSUPPORTED,

        /// <remarks/>
        MACHINING_MANDATORY,

        /// <remarks/>
        MACHINING_FORBIDDEN,
    }

    /// <remarks The RoughnessApplicabilityEnumType enumerates values that describe applicability./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum RoughnessApplicabilityEnumType
    {
        /// <remarks/>
        UNSUPPORTED,

        /// <remarks/>
        SPECIFIED_SURFACE_ONLY,

        /// <remarks/>
        ALL_PART_SURFACES,

        /// <remarks/>
        BASIC_SURFACE,
    }

    /// <remarks The RoughnessLayEnumType enumerates values that describe directions of lay./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public enum RoughnessLayEnumType
    {
        /// <remarks/>
        PARALLEL,

        /// <remarks/>
        PERPENDICULAR,

        /// <remarks/>
        CROSS_HATCH,

        /// <remarks/>
        MULTI_DIRECTIONAL,

        /// <remarks/>
        CIRCULAR,

        /// <remarks/>
        RADIAL,

        /// <remarks/>
        PARTICULATE,
    }
}
