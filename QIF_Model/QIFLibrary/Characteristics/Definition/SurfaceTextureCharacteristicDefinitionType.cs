/*! \file SurfaceTextureCharacteristicDefinitionType.cs
    \brief The SurfaceTextureCharacteristicDefinitionType defines information
        that can be common to more than one surface texture characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The SurfaceTextureCharacteristicDefinitionType defines information that can be common to more than one surface texture characteristic.
    /// </summary>
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class SurfaceTextureCharacteristicDefinitionType : CharacteristicDefinitionBaseType
    {
        /// <remarks The RoughnessAverage element is the ASME Y14.36 - 1978 Roughness Average(Ra) value of the surface texture./>
        public Units.LinearValueType RoughnessAverage { get; set; }
    }
}
