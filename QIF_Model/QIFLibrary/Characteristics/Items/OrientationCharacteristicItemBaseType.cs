/*! \file OrientationCharacteristicItemBaseType.cs
    \brief abstract base type that defines an orientation characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks The OrientationCharacteristicItemBaseType is the abstract base type that defines an orientation characteristic item./>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AngularityCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class OrientationCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks TODO/>
    public class ParallelismCharacteristicItemType : OrientationCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class PerpendicularityCharacteristicItemType : OrientationCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class AngularityCharacteristicItemType : OrientationCharacteristicItemBaseType
    {

    }

}
