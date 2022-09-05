/*! \file DimensionalCharacteristicItemBaseType.cs
    \brief abstract base type that defines a dimensional characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <summary>
    /// The DimensionalCharacteristicItemBaseType is the abstract base type that defines a dimensional characteristic item.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LinearCharacteristicItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularCharacteristicItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoordinateCharacteristicItemBaseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class DimensionalCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }
}
