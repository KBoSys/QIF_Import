/*! \file RunoutCharacteristicItemBaseType.cs
    \brief abstract base type that defines a runout characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks The RunoutCharacteristicItemBaseType is the abstract base type that defines a runout characteristic item./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class RunoutCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks TODO/>
    public class TotalRunoutCharacteristicItemType : RunoutCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class CircularRunoutCharacteristicItemType : RunoutCharacteristicItemBaseType
    {

    }

}
