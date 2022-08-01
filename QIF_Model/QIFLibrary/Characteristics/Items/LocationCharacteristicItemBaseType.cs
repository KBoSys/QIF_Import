/*! \file LocationCharacteristicItemBaseType.cs
    \brief abstract base type that defines a location characteristic item base type.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks The LocationCharacteristicItemBaseType is the abstract base type that defines a location characteristic item base type./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LocationCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks The SymmetryCharacteristicItemType defines a symmetry characteristic item./>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SymmetryCharacteristicItemType : LocationCharacteristicItemBaseType
    {
    }

    /// <remarks TODO/>
    public class ConcentricityCharacteristicItemType : LocationCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class CoaxialityCharacteristicItemType : LocationCharacteristicItemBaseType
    {

    }

    /// <remarks TODO/>
    public class PositionCharacteristicItemType : LocationCharacteristicItemBaseType
    {

    }

}
