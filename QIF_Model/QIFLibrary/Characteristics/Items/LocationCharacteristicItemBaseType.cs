/*! \file LocationCharacteristicItemBaseType.cs
    \brief abstract base type that defines a location characteristic item base type.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks> The LocationCharacteristicItemBaseType is the abstract base type that defines a location characteristic item base type.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SymmetryCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConcentricityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CoaxialityCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PositionCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class LocationCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks> The SymmetryCharacteristicItemType defines a symmetry characteristic item.</remarks>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public partial class SymmetryCharacteristicItemType : LocationCharacteristicItemBaseType
    {
    }

    /// <remarks> The ConcentricityCharacteristicItemType defines a concentricity characteristic item.</remarks>
    public class ConcentricityCharacteristicItemType : LocationCharacteristicItemBaseType
    {

    }

    /// <remarks> The CoaxialityCharacteristicItemType defines a coaxiality characteristic item(ISO specific characteristic type).</remarks>
    public class CoaxialityCharacteristicItemType : LocationCharacteristicItemBaseType
    {

    }

    /// <remarks> The PositionCharacteristicItemType defines a position characteristic item.</remarks>
    public class PositionCharacteristicItemType : LocationCharacteristicItemBaseType
    {

    }
}
