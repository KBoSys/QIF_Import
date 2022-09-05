/*! \file AngularCharacteristicDefinitionBaseType.cs
    \brief The AngularCharacteristicDefinitionBaseType is the abstract base
        type that defines an angular characteristic.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Definition
{
    /// <summary>
    /// The AngularCharacteristicDefinitionBaseType is the abstract base type that defines an angular characteristic.
    /// </summary>
    /// 
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract class AngularCharacteristicDefinitionBaseType : DimensionalCharacteristicDefinitionBaseType
    {
        /// <remarks> This compositor provides a choice between a toleranced
        /// characteristic and a non-toleranced characteristic that still needs to be tracked and/or reported.</remarks>
        [System.Xml.Serialization.XmlElementAttribute("NonTolerance", typeof(IntermediatesPMI.NonToleranceEnumType))]
        [System.Xml.Serialization.XmlElementAttribute("Tolerance", typeof(IntermediatesPMI.AngularToleranceType))]
        public object? Item { get; set; }
    }

    /// <summary>
    /// The AngleBetweenCharacteristicDefinitionType defines information
    /// that can be common to more than one angle between characteristic.
    /// An angle between characteristic is an angle between two features.
    /// </summary>
    public class AngleBetweenCharacteristicDefinitionType : AngularCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The AngleCharacteristicDefinitionType defines information that can
    /// be common to more than one angle characteristic.An angle characteristic applies to a single feature.
    /// </summary>
    public class AngleCharacteristicDefinitionType : AngularCharacteristicDefinitionBaseType
    {
    }

    /// <summary>
    /// The AngleFromCharacteristicDefinitionType defines information that
    /// can be common to more than one angle-from characteristic.An
    /// angle-from characteristic is an angle with respect to an origin reference feature.
    /// </summary>
    public class AngleFromCharacteristicDefinitionType : AngularCharacteristicDefinitionBaseType
    {
    }
}
