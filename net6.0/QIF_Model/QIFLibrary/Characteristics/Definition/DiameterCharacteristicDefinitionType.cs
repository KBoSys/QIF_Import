/*! \file DiameterCharacteristicDefinitionType.cs
    \brief The DiameterCharacteristicDefinitionType defines information that
        can be common to more than one diameter characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The DiameterCharacteristicDefinitionType defines information that
    /// can be common to more than one diameter characteristic.
    /// </summary>
    /// <remarks></remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public class DiameterCharacteristicDefinitionType : DimensionalCharacteristicDefinitionBaseType
    {
        /// <remarks>
        /// This compositor provides a choice among a simple toleranced
        /// characteristic, a toleranced characteristic defined by a
        /// limits and fits specification, and a non-toleranced
        /// characteristic that still needs to be tracked and/or reported.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("LimitsAndFitsSpecification", typeof(IntermediatesPMI.LimitsAndFitsSpecificationType))]
        [System.Xml.Serialization.XmlElementAttribute("NonTolerance", typeof(IntermediatesPMI.NonToleranceEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Tolerance", typeof(IntermediatesPMI.LinearToleranceType))]
        public object? Item { get; set; }
    }
}
