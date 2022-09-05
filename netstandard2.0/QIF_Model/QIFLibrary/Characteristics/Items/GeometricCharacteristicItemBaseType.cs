/*! \file GeometricCharacteristicItemBaseType.cs
    \brief abstract base type that defines a geometric characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <summary>
    /// The GeometricCharacteristicItemBaseType is the abstract base type that defines a geometric characteristic item.
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ProfileCharacteristicItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RunoutCharacteristicItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LocationCharacteristicItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FormCharacteristicItemBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrientationCharacteristicItemBaseType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class GeometricCharacteristicItemBaseType : CharacteristicItemBaseType
    {
    }
}
