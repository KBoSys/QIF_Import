/*! \file LinearCoordinateCharacteristicDefinitionType.cs
    \brief The LinearCoordinateCharacteristicDefinitionType defines
        information that can be common to more than one linear coordinate
        characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The LinearCoordinateCharacteristicDefinitionType defines
    /// information that can be common to more than one linear coordinate characteristic.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class LinearCoordinateCharacteristicDefinitionType : CoordinateCharacteristicDefinitionBaseType
    {
        /// <remarks> 
        /// This compositor provides a choice between a toleranced
        /// characteristic and a non-toleranced characteristic that still needs to be tracked and/or reported.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("NonTolerance", typeof(IntermediatesPMI.NonToleranceEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Tolerance", typeof(IntermediatesPMI.LinearToleranceType))]
        public object Item { get; set; }
    }
}
