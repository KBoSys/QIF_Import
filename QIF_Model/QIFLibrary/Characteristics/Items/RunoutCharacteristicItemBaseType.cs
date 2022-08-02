/*! \file RunoutCharacteristicItemBaseType.cs
    \brief abstract base type that defines a runout characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks The RunoutCharacteristicItemBaseType is the abstract base type that defines a runout characteristic item./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TotalRunoutCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircularRunoutCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class RunoutCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks The TotalRunoutCharacteristicItemType defines a total runout characteristic item./>
    public class TotalRunoutCharacteristicItemType : RunoutCharacteristicItemBaseType
    {

    }

    /// <remarks The CircularRunoutCharacteristicItemType defines a circular runout characteristic item./>
    public class CircularRunoutCharacteristicItemType : RunoutCharacteristicItemBaseType
    {

    }
}
