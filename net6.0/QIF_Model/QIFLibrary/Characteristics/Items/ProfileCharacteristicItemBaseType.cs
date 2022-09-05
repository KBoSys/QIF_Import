/*! \file ProfileCharacteristicItemBaseType.cs
    \brief abstract base type that defines a profile characteristic item.

    \copyright Copyright © 2022 KBO Systems Inc. All rights reserved.    
*/

namespace QIF_Model.QIFLibrary.Characteristics.Items
{
    /// <remarks> The ProfileCharacteristicItemBaseType is the abstract base type that defines a profile characteristic item.</remarks>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileNonUniformCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurfaceProfileCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointProfileCharacteristicItemType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineProfileCharacteristicItemType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://qifstandards.org/xsd/qif3")]
    public abstract partial class ProfileCharacteristicItemBaseType : GeometricCharacteristicItemBaseType
    {
    }

    /// <remarks> The SurfaceProfileNonUniformCharacteristicItemType defines a
    /// non-uniform surface profile characteristic item.This characteristic
    /// can be used in cases where the tolerance zone itself is uniform but
    /// the upper disposition or(ISO specific) unequally displaced zone
    /// varies over the extents of the tolerance zone in which case the
    /// tolerance value and to-point tolerance values will be equal.</remarks>
    public class SurfaceProfileNonUniformCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

    /// <remarks> The SurfaceProfileCharacteristicItemType defines a surface profile characteristic item.</remarks>
    public class SurfaceProfileCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

    /// <remarks> The PointProfileCharacteristicItemType defines a point profile characteristic item.</remarks>
    public class PointProfileCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }

    /// <remarks> The LineProfileCharacteristicItemType defines a profile of a line characteristic item.</remarks>
    public class LineProfileCharacteristicItemType : ProfileCharacteristicItemBaseType
    {

    }
}
