/*! \file CoordinateCharacteristicItemBaseType.cs
    \brief abstract base type that defines a coordinate characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <summary>
    /// The CoordinateCharacteristicItemBaseType is the abstract base type that defines a coordinate characteristic item.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class CoordinateCharacteristicItemBaseType : DimensionalCharacteristicItemBaseType
    {
    }

    /// <remarks TODO/>
    public class AngularCoordinateCharacteristicItemType : CoordinateCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class LinearCoordinateCharacteristicItemType : CoordinateCharacteristicItemBaseType
    {

    }

}
